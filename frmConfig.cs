using Line_Production.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Line_Production
{
    public partial class frmConfig : Form
    {
        public Action updateAfterSetting;
        private PVSReference.PVSWebServiceSoapClient pvsservice;

        public frmConfig()
        {
            InitializeComponent();
            cbbCOM.DataSource = SerialPort.GetPortNames();
            cbbComPress.DataSource = SerialPort.GetPortNames();
            GetTaskWindows();
            pvsservice = new PVSReference.PVSWebServiceSoapClient();
           
           
        }
        private void GetTaskWindows()
        {
            // Get the desktopwindow handle
            int nDeshWndHandle = NativeWin32.GetDesktopWindow();
            // Get the first child window
            int nChildHandle = NativeWin32.GetWindow(nDeshWndHandle, NativeWin32.GW_CHILD);
            while (nChildHandle != 0)
            {
                //If the child window is this (SendKeys) application then ignore it.
                if (nChildHandle == this.Handle.ToInt32())
                {
                    nChildHandle = NativeWin32.GetWindow(nChildHandle, NativeWin32.GW_HWNDNEXT);
                }

                // Get only visible windows
                if (NativeWin32.IsWindowVisible(nChildHandle) != 0)
                {
                    StringBuilder sbTitle = new StringBuilder(1024);
                    // Read the Title bar text on the windows to put in combobox
                    NativeWin32.GetWindowText(nChildHandle, sbTitle, sbTitle.Capacity);
                    string sWinTitle = sbTitle.ToString();
                    {
                        if (sWinTitle.Length > 0)
                        {
                            cbbProcess.Items.Add(sWinTitle);
                            //cbbsubprocess.Items.Add(sWinTitle);
                        }
                    }
                }
                // Look for the next child.
                nChildHandle = NativeWin32.GetWindow(nChildHandle, NativeWin32.GW_HWNDNEXT);
            }
        }
        private void btnSaveChanged_Click(object sender, EventArgs e)
        {
            Common.WriteRegistry(Control.PathConfig, RegistryKeys.id, txtId.Text);
            if (!string.IsNullOrEmpty(txtId.Text))
                DataProvider.Instance.TimeLines.InsertLine(txtId.Text);
            else
            {
                MessageBox.Show("Cần nhập tên Line");
                return;
            }
            Common.WriteRegistry(Control.PathConfig, RegistryKeys.pathWip, txtLog.Text);
            Common.WriteRegistry(Control.PathConfig, RegistryKeys.station, txtStation.Text.Trim());
            Common.WriteRegistry(Control.PathConfig, RegistryKeys.COM, cbbCOM.Text.Trim());
            Common.WriteRegistry(Control.PathConfig, RegistryKeys.COM_PRESS, cbbComPress.Text.Trim());
            Common.WriteRegistry(Control.PathConfig, RegistryKeys.Process, cbbProcess.Text.Trim());
            Common.WriteRegistry(Control.PathConfig, RegistryKeys.Customer, cbbCustomer.Text.Trim());
            Common.WriteRegistry(Control.PathConfig, RegistryKeys.LinkPathLog, cbLinkPathLog.Checked.ToString());
            Common.WriteRegistry(Control.PathConfig, RegistryKeys.SleepTime, txbSleepTime.Text.Trim());
            Common.WriteRegistry(Control.PathConfig, RegistryKeys.LinkWip, cbLinkWip.Checked.ToString());
            var confirm = MessageBox.Show("Save success!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (confirm == DialogResult.OK)
            {
                updateAfterSetting();
                Close();
            }
        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
           
            try
            {
                var mac = NetworkHelper.GetMacAddress("http://172.28.10.8:8084");
                var item = pvsservice.GetStationByHostName(mac);
                if (item != null)
                {
                    txtId.Text = item.LINE_ID;
                    txtStation.Text = item.STATION_NO;
                }
                else
                {
                    txtStation.Text = Constants.LINE_NO_WIP;
                    cbLinkPathLog.Checked = false;
                    cbLinkWip.Checked = false;
                }
                bool chkWipValue = bool.Parse(Common.GetValueRegistryKey(Control.PathConfig, RegistryKeys.LinkPathLog));
                cbLinkPathLog.Checked = chkWipValue;
                bool linkWip = bool.Parse(Common.GetValueRegistryKey(Control.PathConfig, RegistryKeys.LinkWip));
                cbLinkWip.Checked = linkWip;

            }
            catch { }

            txtLog.Text = Common.GetValueRegistryKey(Control.PathConfig, RegistryKeys.pathWip);
            cbbCOM.Text = Common.GetValueRegistryKey(Control.PathConfig, RegistryKeys.COM);
            cbbComPress.Text = Common.GetValueRegistryKey(Control.PathConfig, RegistryKeys.COM_PRESS);
            cbbProcess.Text = Common.GetValueRegistryKey(Control.PathConfig, RegistryKeys.Process);
            cbbCustomer.Text = Common.GetValueRegistryKey(Control.PathConfig, RegistryKeys.Customer);
            txbSleepTime.Text = Common.GetValueRegistryKey(Control.PathConfig, RegistryKeys.SleepTime);
        }

        private void btnBrower_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog choofdlog = new FolderBrowserDialog();

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                txtLog.Text = choofdlog.SelectedPath;
            }
        }

        private void btnTestCOM_Click(object sender, EventArgs e)
        {
            try
            {
                SerialPort com = new SerialPort() { PortName = cbbCOM.Text };
                if (!com.IsOpen) com.Open();
                if (com.IsOpen == true)
                {
                    com.Write("S+0000000012001*");
                }
                com.Close();
            }
            catch (Exception ex)
            {
               
            }
        }

        private void txbSleepTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void cbLinkWip_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLinkWip.Checked)
            {
                cbLinkPathLog.Checked = false;
            }
        }

        private void cbLinkPathLog_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLinkPathLog.Checked)
            {
                cbLinkWip.Checked = false;
            }
          
        }

        private void btnTestComPress_Click(object sender, EventArgs e)
        {
            Common.SendToComport("test", result => { MessageBox.Show("Test COM connection : " + result); },Common.GetValueRegistryKey(Control.PathConfig,RegistryKeys.COM_PRESS));
        }
    }
}
