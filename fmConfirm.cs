using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Line_Production
{
    public partial class fmConfirm : Form
    {
        private CONFIRM_FAULT_REASON confirm = new CONFIRM_FAULT_REASON();
        private DateTime from;
        private DateTime to;
        private List<LINE_FAULT_REASON> listFaults = new List<LINE_FAULT_REASON>();
        public Action closeForm;
        public fmConfirm(CONFIRM_FAULT_REASON confirm, DateTime from, DateTime to)
        {
            InitializeComponent();
            this.confirm = confirm;
            this.from = from;
            this.to = to;
            dtStart.Value = DateTime.Now;
            dtEnd.Value = DateTime.Now;
            using (var db = new barcode_dbEntities())
            {
                listFaults = db.LINE_FAULT_REASON.ToList();
                cbbErrorByMachine.DataSource = listFaults.Where(m => m.Type == 1).ToList();
                cbbErrorByStaff.DataSource = listFaults.Where(m => m.Type == 2).ToList();
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            using (var db = new barcode_dbEntities())
            {
                using (DbContextTransaction transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        if(!cbErrorByMachine.Checked && !cbErrorByStaff.Checked)
                        {
                            MessageBox.Show("Phải chọn lỗi do người dùng hoặc do nhân sự!");
                            return;
                        }
                        if (cbErrorByMachine.Checked)
                        {
                            if (dtStart.Value >= from && dtEnd.Value <= to && dtStart.Value < dtEnd.Value)
                            {
                                confirm.ConfirmId = int.Parse(cbbErrorByMachine.SelectedValue.ToString());
                                confirm.Remark = txbRemark.Text;
                                confirm.TimeFrom = dtStart.Value;
                                confirm.TimeTo = dtEnd.Value;
                                confirm.UpdateTime = DateTime.Now;
                                db.CONFIRM_FAULT_REASON.Add(confirm);
                                db.SaveChanges();
                            }
                            else
                            {
                                MessageBox.Show("Thời gian phải bắt đầu từ " + from.ToShortTimeString() + " đến " + to.ToShortTimeString());
                                return;
                            }
                        }
                        if (cbErrorByStaff.Checked)
                        {
                            confirm.ConfirmId = int.Parse(cbbErrorByStaff.SelectedValue.ToString());
                            confirm.UpdateTime = DateTime.Now;
                            confirm.TimeFrom = null;
                            confirm.TimeTo = null;
                            confirm.Remark = "";
                            db.CONFIRM_FAULT_REASON.Add(confirm);
                            db.SaveChanges();
                        }
                        DialogResult result = MessageBox.Show("Bạn có muốn lưu không?", "", MessageBoxButtons.OKCancel);
                        if (result == DialogResult.OK)
                        {
                            transaction.Commit();
                            closeForm();
                            this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw;
                    }
                    
                }
            }

        }


    }
}
