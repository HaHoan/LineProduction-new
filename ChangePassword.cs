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
    public partial class ChangePassword : Form
    {
        public Action closeForm;
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            var code = txbCode.Text.Trim();
            var oldPass = txbOldPass.Text.Trim();
            var newPass = txbNewPass.Text.Trim();
            if (newPass == "umcvn")
            {
                MessageBox.Show("Không được phép đặt password mặc định umcvn.");
                return;
            }
            using (var db = new barcode_dbEntities())
            {
                var user = db.USERs.Where(m => m.Code == code && m.Password == oldPass).FirstOrDefault();
                if (user == null)
                {
                    MessageBox.Show("Không tồn tại user " + code + " hoặc bị sai mật khẩu");
                    return;
                }
                user.Password = newPass;
                db.SaveChanges();
                this.Hide();
                var listForm = new ListModel();
                listForm.closeForm = () =>
               {
                   closeForm();
               };
                listForm.ShowDialog();
            }
        }

        private void txbCode_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txbOldPass.Focus();
            }
        }

        private void txbOldPass_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                txbNewPass.Focus();
            }
        }

        private void txbNewPass_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                btnSaveChanges.Focus();
            }
        }
    }
}
