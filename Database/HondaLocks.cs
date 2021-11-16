using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;


namespace Line_Production.Database
{

    public class HondaLocks
    {
        public const string TABLE = "HondaLock";
      
        public bool KiemTraBanMachDaBan(string mathung, string banmach)
        {
            var list = new List<int>();
            try
            {
                string sql = "select * from " + TABLE + " where BoardNo = '" + banmach + "';";
                SqlCommand command = new SqlCommand(sql, DataProvider.Instance.DB);

                using (DbDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message.ToString());
                return false;
            }
            return false;
        }

        public int SoLuongBanMachDaDem(string mathung, string Model)
        {
            try
            {
                string sql = "select count(BoxID) from " + TABLE + " where ProductionID = '" + Model + "' and BoxID = '" + mathung + "'";
                SqlCommand command = new SqlCommand(sql, DataProvider.Instance.DB);
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count;
            }
            catch (Exception e)
            {
                Console.Write(e.Message.ToString());
                return 0;
            }
        }
        public int BoxIsRepair(string mathung, string Model)
        {
            try
            {
                string sql = "select TOP 1 Repair from " + TABLE + " where ProductionID = '" + Model + "' and BoxID = '" + mathung + "'";
                SqlCommand command = new SqlCommand(sql, DataProvider.Instance.DB);
                int Repair = Convert.ToInt32(command.ExecuteScalar());
                return Repair;
            }
            catch (Exception e)
            {
                Console.Write(e.Message.ToString());
                return -1;
            }
        }
        public int SoLuongBanMachDaDem(string Model)
        {
            try
            {
                string sql = "select count(BoxID) from " + TABLE + " where ProductionID = '" + Model +"' and Line = '" + Common.GetValueRegistryKey(Control.PathConfig, RegistryKeys.id) + "'" ;
                SqlCommand command = new SqlCommand(sql, DataProvider.Instance.DB);
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count;
            }
            catch (Exception e)
            {
                Console.Write(e.Message.ToString());
                return 0;
            }
        }

        public int SoLuongThungDaDem(string Model)
        {
            try
            {
                string sql = "select count(BoxID) from (select BoxID,count(*) sothung from " + TABLE + " where ProductionID = '" + Model + "' group by BoxID) as thungdadem";
                SqlCommand command = new SqlCommand(sql, DataProvider.Instance.DB);
                Int32 count = Convert.ToInt32(command.ExecuteScalar());
                return count;
            }
            catch (Exception e)
            {
                Console.Write(e.Message.ToString());
                return 0;
            }


        }

        public List<Tuple<string, string, string>> SearchSerial(string serial)
        {
            var list = new List<Tuple<string, string,string>>();
            try
            {
                string sql = "select BoxID, BoardNo,Repair from " + TABLE + " where BoardNo = '" + serial + "';";
                SqlCommand command = new SqlCommand(sql, DataProvider.Instance.DB);
                using (DbDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {

                        while (reader.Read())
                        {
                            string BoxID = reader[reader.GetOrdinal("BoxID")] as string;
                            string BoardNo = reader[reader.GetOrdinal("BoardNo")] as string;

                            bool repair = false;
                            int columnIndex = reader.GetOrdinal("Repair");
                            if (!reader.IsDBNull(columnIndex))
                            {
                                repair = reader.GetBoolean(reader.GetOrdinal("Repair"));
                            }

                            var hondaLock = Tuple.Create(BoxID, BoardNo, repair == true ? "Có" : "");
                            list.Add(hondaLock);
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
        public List<Tuple<string, string,string>> SearchBoxID(string boxID)
        {
            var list = new List<Tuple<string, string, string>>();
            try
            {
                string sql = "select BoxID, BoardNo,Repair from " + TABLE + " where BoxID = '" + boxID + "';";
                SqlCommand command = new SqlCommand(sql, DataProvider.Instance.DB);
                using (DbDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {

                        while (reader.Read())
                        {
                            string BoxID = reader[reader.GetOrdinal("BoxID")] as string;
                            string BoardNo = reader[reader.GetOrdinal("BoardNo")] as string;
                            int columnIndex = reader.GetOrdinal("Repair");
                            bool repair = false;
                            if (!reader.IsDBNull(columnIndex))
                            {
                                repair = reader.GetBoolean(reader.GetOrdinal("Repair"));
                            }
                            
                            var hondaLock = Tuple.Create(BoxID, BoardNo, repair == true ? "Có" : "");
                            list.Add(hondaLock);
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
    }
}
