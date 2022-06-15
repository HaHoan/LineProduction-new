using Line_Production.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Production.Database
{
    public class PassRates
    {
        public LINE_PASSRATE GetPassRate(string line, string modelId, string time)
        {
            try
            {
                using (var db = new barcode_dbEntities())
                {
                    var passRate = db.LINE_PASSRATE.Where(m => m.ProductionID == modelId && m.Line == line && m.Time == time).FirstOrDefault();
                    if (passRate != null && !string.IsNullOrEmpty(passRate.TimeValue))
                    {
                        passRate.TimeValues = passRate.TimeValue.Split(',');
                    }
                    else
                    {
                        passRate.TimeValues = new string[11];
                    }
                    return passRate;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return null;
        }

        internal void Update(LINE_PASSRATE pass)
        {
            try
            {
                using (var db = new barcode_dbEntities())
                {
                    var passRate = db.LINE_PASSRATE.Where(m => m.ProductionID == pass.ProductionID && m.Line == pass.Line && m.Time == pass.Time).FirstOrDefault();
                    if (passRate != null)
                    {
                        passRate.ProductPlan = pass.ProductPlan;
                        passRate.Actual = pass.Actual;
                        passRate.IDCount = pass.IDCount;
                        passRate.IDCountBox = pass.IDCountBox;
                        passRate.BoxCurrent = pass.BoxCurrent;
                        passRate.TimeCycleActual = pass.TimeCycleActual;
                        passRate.TimeValue = pass.TimeValue;

                    }
                    else
                    {
                        db.LINE_PASSRATE.Add(pass);
                    }
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw;
            }
           
        }
    }


}
