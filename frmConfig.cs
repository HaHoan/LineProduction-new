using Line_Production.Business;
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
        private CommPort com;
        public frmConfig()
        {
            InitializeComponent();
            cbbCOM.DataSource = SerialPort.GetPortNames();
            using(var db = new barcode_dbEntities())
            {
                cbbCustomer.DataSource = db.CUSTOMERs.ToList();
            }
            
            GetTaskWindows();
            pvsservice = new PVSReference.PVSWebServiceSoapClient();
            com = CommPort.Instance;
            com.StatusChanged += OnStatusChanged;
        }

        private void OnStatusChanged(string param)
        {
            lblStatus.Text = param;
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
                            //cbbProcess.Items.Add(sWinTitle);
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
            Common.WriteRegistry(Constants.PathConfig, RegistryKeys.id, txtId.Text);
            if (!string.IsNullOrEmpty(txtId.Text))
                DataProvider.Instance.TimeLines.InsertLine(txtId.Text);
            else
            {
                MessageBox.Show("Cần nhập tên Line");
                return;
            }
            Common.WriteRegistry(Constants.PathConfig, RegistryKeys.pathWip, txtLog.Text);
            Common.WriteRegistry(Constants.PathConfig, RegistryKeys.station, txtStation.Text.Trim());
            Common.WriteRegistry(Constants.PathConfig, RegistryKeys.COM, cbbCOM.Text.Trim());
            Common.WriteRegistry(Constants.PathConfig, RegistryKeys.Customer, cbbCustomer.Text.Trim());
            Common.WriteRegistry(Constants.PathConfig, RegistryKeys.SleepTime, txbSleepTime.Text.Trim());
            if(com != null)
            {
                com.Open();
            }
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
                }

            }
            catch { }

            txtId.Text = Common.GetValueRegistryKey(Constants.PathConfig, RegistryKeys.id);
            txtLog.Text = Common.GetValueRegistryKey(Constants.PathConfig, RegistryKeys.pathWip);
            cbbCOM.Text = Common.GetValueRegistryKey(Constants.PathConfig, RegistryKeys.COM);
            cbbCustomer.Text = Common.GetValueRegistryKey(Constants.PathConfig, RegistryKeys.Customer);
            txbSleepTime.Text = Common.GetValueRegistryKey(Constants.PathConfig, RegistryKeys.SleepTime);
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
                Common.WriteRegistry(Constants.PathConfig, RegistryKeys.COM, cbbCOM.Text);
                com.Open();
                com.Send("S+0000000012001*");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không kết nối được với cổng " + cbbCOM.Text + ". Liên hệ LCA để xử lý!");
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

    }
}
