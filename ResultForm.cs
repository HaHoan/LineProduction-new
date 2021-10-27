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
            var list = new List<Tuple<string, string,string>>();
            if(filter == Constants.SERIAL)
            {
                list = DataProvider.Instance.HondaLocks.SearchSerial(text);
            }else if(filter == Constants.BOXID)
            {
                list = DataProvider.Instance.HondaLocks.SearchBoxID(text);
            }
           
            dgrvSearch.DataSource = list;
        }
    }
}
