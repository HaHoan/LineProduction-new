using Line_Production.Entities;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Production.Database
{
    public class TimeLines
    {
        public const string TIME = "LINE_TIME";
        public const string TIMELINE = "LINE_TIMELINE";

        public bool Insert(TimeLine o)
        {
            try
            {
                using (var db = new barcode_dbEntities())
                {
                    var timeLine = db.LINE_TIMELINE.Where(m => m.IdTimeLine == o.IdTimeLine && m.TimeIndex == o.TimeIndex).FirstOrDefault();
                    if (timeLine != null)
                    {
                        timeLine.TimeFrom = o.TimeFrom;
                        timeLine.TimeTo = o.TimeTo;
                    }
                    else
                    {
                        timeLine = new LINE_TIMELINE()
                        {
                            IdTimeLine = o.IdTimeLine,
                            TimeIndex = o.TimeIndex,
                            TimeFrom = o.TimeFrom,
                            TimeTo = o.TimeTo
                        };
                        db.LINE_TIMELINE.Add(timeLine);
                    }
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
                return false;
            }
        }
        public bool InsertLine(string line)
        {
            try
            {
                int rsDay = 0, rsNight = 0;
                if (SelectIdLine(CaSX.DAY, line) == 0)
                {
                    using (SqlCommand cmd = new SqlCommand("insert into " + TIME + "(Line,Type) values(@Line,@Type);SELECT CAST(scope_identity() AS int)", DataProvider.Instance.DB))
                    {
                        cmd.Parameters.AddWithValue("@Line", line);
                        cmd.Parameters.AddWithValue("@Type", CaSX.DAY);
                        rsDay = (int)cmd.ExecuteScalar();
                    }
                }
                else rsDay = 1;
                if (SelectIdLine(CaSX.NIGHT, line) == 0)
                {
                    using (SqlCommand cmd = new SqlCommand("insert into " + TIME + "(Line,Type) values(@Line,@Type);SELECT CAST(scope_identity() AS int)", DataProvider.Instance.DB))
                    {
                        cmd.Parameters.AddWithValue("@Line", line);
                        cmd.Parameters.AddWithValue("@Type", CaSX.NIGHT);
                        rsNight = (int)cmd.ExecuteScalar();
                    }
                }
                else rsNight = 1;
                return (rsDay > 0 && rsNight > 0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
                return false;
            }
        }
        public int SelectIdLine(int caSX, string line)
        {
            try
            {
                using(var db = new barcode_dbEntities())
                {
                    var lineDB = db.LINE_TIME.Where(m => m.Line.ToLower() == line.ToLower() && m.Type == caSX).FirstOrDefault();
                    return lineDB != null ? lineDB.Id : 0;
                }
                
            }
            catch (Exception e)
            {
                Console.Write(e.Message.ToString());
            }
            return 0;
        }
        public int IsExist(int IdTimeLine, int TimeIndex)
        {
            try
            {
                string sql = "select count(IdTimeLine) total from " + TIMELINE + " where IdTimeLine = " + IdTimeLine + " and TimeIndex = " + TimeIndex;
                SqlCommand command = new SqlCommand(sql, DataProvider.Instance.DB);

                using (DbDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {

                        while (reader.Read())
                        {
                            int count = reader.GetInt32(reader.GetOrdinal(TimeLineString.total));
                            return count;
                        }

                    }

                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message.ToString());
            }
            return 0;
        }
        public List<string> SelectLine(int type)
        {
            var list = new List<string>();
            try
            {
                string sql = "select * from " + TIME + " where Type = '" + type + "'";
                SqlCommand command = new SqlCommand(sql, DataProvider.Instance.DB);

                using (DbDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {

                        while (reader.Read())
                        {
                            string line = reader[reader.GetOrdinal(TimeLineString.Line)] as string;
                            list.Add(line.ToUpper());
                        }

                    }

                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message.ToString());
                return null;
            }
            return list;
        }
        public List<LINE_TIMELINE> Select(string line, int type)
        {
            var list = new List<TimeLine>();
            try
            {
                using(var db = new barcode_dbEntities())
                {
                    var idTimeLine = db.LINE_TIME.Where(m => m.Line.ToLower() == line.ToLower() && m.Type == type).FirstOrDefault();
                    if(idTimeLine != null)
                    {
                        var listTimeLine = db.LINE_TIMELINE.Where(m => m.IdTimeLine == idTimeLine.Id).ToList();
                        return listTimeLine;
                    }
                   
                }
                return null;
            }
            catch (Exception e)
            {
                Console.Write(e.Message.ToString());
                return null;
            }
        }
    }
}
