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
    public partial class frmSelectRepair : Form
    {
        public Action<bool> CloseForm;
        public frmSelectRepair()
        {
            InitializeComponent();
            
        }

        private void cbYes_CheckedChanged(object sender, EventArgs e)
        {
            CloseForm(cbYes.Checked);
            Close();
        }

        private void cbNO_CheckedChanged(object sender, EventArgs e)
        {
            CloseForm(cbYes.Checked);
            Close();
        }
    }
}
