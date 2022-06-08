using Line_Production.Database;
using Line_Production.Entities;
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
    public partial class AddModelForm : Form
    {
        public Action close;
        private int ID;
        public AddModelForm(int ID = 0)
        {
            InitializeComponent();
            this.ID = ID;
            using (var db = new barcode_dbEntities())
            {
                cbbCustomer.DataSource = db.CUSTOMERs.ToList();
            }

        }
        private bool isValidate()
        {
            if (string.IsNullOrEmpty(txbModelID.Text) || string.IsNullOrEmpty(txbPersonInLine.Text)
                || string.IsNullOrEmpty(txbCycle.Text) || string.IsNullOrEmpty(txbWarmQuatity.Text)
                || string.IsNullOrEmpty(txbMnQuantity.Text)
                || string.IsNullOrEmpty(cbbCustomer.Text))

            {
                MessageBox.Show("Chưa điền đầy đủ thông tin!");
                return false;
            }
            return true;
        }
        private void btnSaveChanged_Click(object sender, EventArgs e)
        {
            if (!isValidate()) return;
            try
            {
                using (var db = new barcode_dbEntities())
                {
                    var modelInDb = db.LINE_MODEL.Where(m => m.Model == txbModelID.Text.ToString().Trim()).FirstOrDefault();
                    if (ID == 0)
                    {
                        if (modelInDb != null)
                        {
                            MessageBox.Show("Đã tồn tại model này rồi!");
                        }
                        else
                        {
                            var model = new LINE_MODEL()
                            {
                                Id = ID,
                                Model = txbModelID.Text.ToString().Trim(),
                                PersonPerLine = int.Parse(txbPersonInLine.Text.ToString()),
                                CycleTime = float.Parse(txbCycle.Text.ToString()),
                                WarnQuantity = float.Parse(txbWarmQuatity.Text.ToString()),
                                MinQuantity = float.Parse(txbMnQuantity.Text.ToString()),
                                CharModel = "",
                                UseBarcode = ckbUseBarcode.Checked ? 1 : 0,
                                NumberInModel = int.Parse(txbNumberInModel.Text.Trim()),
                                PCB = int.Parse(txbPCB.Text.Trim()),
                                Customer = cbbCustomer.Text.Trim(),
                                ContentIndex = int.Parse(txbContentIndex.Text.Trim()),
                                ContentLength = int.Parse(txbContentLength.Text.Trim()),
                                CheckFirst = cbCheckFirst.Checked,
                                HistoryNo = txbHistoryNo.Text.Trim(),
                                Modifier = Common.GetValueRegistryKey(Constants.PathConfig, RegistryKeys.CurrentUser),
                                ModifyDate = DateTime.Now,
                                ReadFileLog = cbReadLog.Checked
                            };
                            db.LINE_MODEL.Add(model);
                            db.SaveChanges();
                            close();
                            Close();
                        }

                    }
                    else
                    {
                        modelInDb.Id = ID;
                        modelInDb.Model = txbModelID.Text.ToString().Trim();
                        modelInDb.PersonPerLine = int.Parse(txbPersonInLine.Text.ToString());
                        modelInDb.CycleTime = float.Parse(txbCycle.Text.ToString());
                        modelInDb.WarnQuantity = float.Parse(txbWarmQuatity.Text.ToString());
                        modelInDb.MinQuantity = float.Parse(txbMnQuantity.Text.ToString());
                        modelInDb.CharModel = "";
                        modelInDb.UseBarcode = ckbUseBarcode.Checked ? 1 : 0;
                        modelInDb.NumberInModel = int.Parse(txbNumberInModel.Text.Trim());
                        modelInDb.PCB = int.Parse(txbPCB.Text.Trim());
                        modelInDb.Customer = cbbCustomer.Text.Trim();
                        modelInDb.ContentIndex = int.Parse(txbContentIndex.Text.Trim());
                        modelInDb.ContentLength = int.Parse(txbContentLength.Text.Trim());
                        modelInDb.CheckFirst = cbCheckFirst.Checked;
                        modelInDb.HistoryNo = txbHistoryNo.Text.Trim();
                        modelInDb.Modifier = Common.GetValueRegistryKey(Constants.PathConfig, RegistryKeys.CurrentUser);
                        modelInDb.ModifyDate = DateTime.Now;
                        modelInDb.ReadFileLog = cbReadLog.Checked;
                        db.SaveChanges();
                        close();
                        Close();
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }

        }

        private void AddModelForm_Shown(object sender, EventArgs e)
        {
            try
            {
                using (var db = new barcode_dbEntities())
                {
                    if (ID == 0)
                    {
                        return;
                    }
                    var model = db.LINE_MODEL.Where(m => m.Id == ID).FirstOrDefault();
                    if (model != null)
                    {
                        ID = model.Id;
                        txbModelID.Text = model.Model;
                        txbModelID.Enabled = false;
                        txbPersonInLine.Text = model.PersonPerLine.ToString();
                        txbCycle.Text = model.CycleTime.ToString();
                        txbWarmQuatity.Text = model.WarnQuantity.ToString();
                        txbMnQuantity.Text = model.MinQuantity.ToString();
                        ckbUseBarcode.Checked = model.UseBarcode == 1 ? true : false;
                        txbNumberInModel.Text = model.NumberInModel.ToString();
                        txbPCB.Text = model.PCB.ToString();
                        cbbCustomer.Text = model.Customer.ToString();
                        txbContentIndex.Text = model.ContentIndex.ToString();
                        txbContentLength.Text = model.ContentLength.ToString();
                        if (model.CheckFirst is bool checkFirst)
                        {
                            cbCheckFirst.Checked = checkFirst;
                        }
                        txbHistoryNo.Text = model.HistoryNo;
                        if (model.ReadFileLog is bool readFileLog)
                        {
                            cbReadLog.Checked = readFileLog;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy model này");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

        }

        private void txbModelID_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                using (var db = new barcode_dbEntities())
                {
                    string modelID = txbModelID.Text.Trim();
                    if (ID == 0)
                    {
                        var model = db.LINE_MODEL.Where(m => m.Model == modelID).FirstOrDefault();
                        if (model != null)
                        {
                            ID = model.Id;
                            txbModelID.Text = model.Model;
                            txbPersonInLine.Text = model.PersonPerLine.ToString();
                            txbCycle.Text = model.CycleTime.ToString();
                            txbWarmQuatity.Text = model.WarnQuantity.ToString();
                            txbMnQuantity.Text = model.MinQuantity.ToString();
                            ckbUseBarcode.Checked = model.UseBarcode == 1 ? true : false;
                            txbNumberInModel.Text = model.NumberInModel.ToString();
                            txbPCB.Text = model.PCB.ToString();
                            cbbCustomer.Text = model.Customer.ToString();
                            txbHistoryNo.Text = model.HistoryNo;
                            cbCheckFirst.Checked = model.CheckFirst is bool checkFirst;
                            cbReadLog.Checked = model.CheckFirst is bool readLog;
                        }
                    }
                }

            }

        }
    }
}
