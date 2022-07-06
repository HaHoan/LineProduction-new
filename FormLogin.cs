using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Line_Production
{
    public partial class FormLogin : Form
    {
        private PVSReference.PVSWebServiceSoapClient pvsservice = new PVSReference.PVSWebServiceSoapClient();
        public Action closeForm;
        public FormLogin()
        {
            InitializeComponent();
            txbUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (var db = new barcode_dbEntities())
            {
                var username = txbUsername.Text.Trim();
                var password = txbPassword.Text.Trim();
                if (string.IsNullOrEmpty(username))
                {
                    txbUsername.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(password))
                {
                    txbPassword.Focus();
                    return;
                }
                try
                {
                    var UserEntity = pvsservice.CheckUserLogin(username, password);
                    if (UserEntity == null)
                    {
                        MessageBox.Show("Account does not exist");
                        return;
                    }
                    var user = db.USERs.Where(m => m.Code == username).FirstOrDefault();
                    if (user != null)
                    {
                        Common.WriteRegistry(Constants.PathConfig, RegistryKeys.CurrentUser, user.Code);
                        var listForm = new ListModel();
                        listForm.closeForm = () =>
                        {
                            closeForm();
                        };
                        listForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Bạn không có quyền sửa model!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }

        }


       
        private void txtUsername_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txbPassword.Focus();
        }

        private void txtPassword_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin.Focus();
        }

        private void fmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            closeForm();
        }

        private void lblChangePassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ChangePassword().ShowDialog();
        }
    }
}
