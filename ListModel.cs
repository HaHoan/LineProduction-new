﻿using Line_Production.Database;
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
    public partial class ListModel : Form
    {
        private List<LINE_MODEL> list = new List<LINE_MODEL>();
        public Action closeForm;
        public ListModel()
        {
            InitializeComponent();
           // SetDrgvListModel();

        }

        private void SetDataForListModel()
        {
            try
            {
                dgrvListModel.DataSource = list;
                dgrvListModel.Refresh();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }


        }


        private void ListModel_Load(object sender, EventArgs e)
        {
            using(var db = new barcode_dbEntities())
            {
                list = db.LINE_MODEL.ToList();
                SetDataForListModel();
            }
          
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addModelForm = new AddModelForm();
            addModelForm.close = () =>
            {
                using (var db = new barcode_dbEntities())
                {
                    list = db.LINE_MODEL.ToList();
                    SetDataForListModel();
                }
              
            };
            addModelForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow r in dgrvListModel.SelectedRows)
                {
                    string ModelID = r.Cells["Id"].Value.ToString();
                    int result = DataProvider.Instance.ModelQuantities.Delete(ModelID);
                    if (result == 0)
                    {
                        MessageBox.Show("Có lỗi xảy ra!");
                        return;
                    }
                    using (var db = new barcode_dbEntities())
                    {
                        list = db.LINE_MODEL.ToList();
                        SetDataForListModel();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if(dgrvListModel.SelectedRows.Count > 0)
                {
                    DataGridViewRow r = dgrvListModel.SelectedRows[0];
                    int ID = int.Parse(r.Cells[1].Value.ToString());
                    var addModelForm = new AddModelForm(ID);
                    addModelForm.close = () =>
                    {
                        using (var db = new barcode_dbEntities())
                        {
                            list = db.LINE_MODEL.ToList();
                            SetDataForListModel();
                        }
                    };
                    addModelForm.ShowDialog();                    
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void txbSearchModel_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                string txtSearch = txbSearchModel.Text.Trim();
                if (!string.IsNullOrEmpty(txtSearch))
                {
                    var listFilter = list.Where(m => m.Model.ToUpper().Contains(txtSearch.ToUpper())).ToList();
                    if (listFilter != null)
                    {
                        dgrvListModel.DataSource = listFilter;
                        dgrvListModel.Refresh();
                    }
                    else
                    {
                        dgrvListModel.DataSource = new List<Model>();
                        dgrvListModel.Refresh();
                    }
                }
                else
                {
                    dgrvListModel.DataSource = list;
                    dgrvListModel.Refresh();
                }
               
                             
            }
        }

        private void ListModel_FormClosed(object sender, FormClosedEventArgs e)
        {
            closeForm();
        }
    }
}
