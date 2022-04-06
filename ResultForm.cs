using Line_Production.Database;
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
    public partial class ResultForm : Form
    {
        public ResultForm(string text,string filter)
        {
            InitializeComponent();
            SetUpData(text,filter);
        }

        private void SetUpData(string text,string filter)
        {
            using(var db = new barcode_dbEntities())
            {
                var currentStation = Common.GetValueRegistryKey(Control.PathConfig, RegistryKeys.station);
                var list = new List<HondaLock>();
                if (filter == Constants.SERIAL)
                {
                    list = db.HondaLocks.Where(m => m.BoardNo == text && m.Station == currentStation).ToList();
                }
                else if (filter == Constants.BOXID)
                {
                    list = db.HondaLocks.Where(m => m.BoxID == text && m.Station == currentStation).ToList();
                }

                dgrvSearch.DataSource = list;

            }
          
        }
    }
}
