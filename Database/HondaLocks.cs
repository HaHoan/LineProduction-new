﻿using Line_Production.Entities;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Production.Database
{

    public class HondaLocks
    {
        public const string TABLE = "HondaLock";
        public object Insert(object o)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("insert into " + TABLE + "(ProductionID,BoxID,BoardNo,UpdateTime,Status,Updator_Code,Updator_Name,Line,Repair) values(@ProductionID,@BoxID,@BoardNo,@UpdateTime,@Status,@Updator_Code,@Updator_Name,@Line,@Repair);SELECT CAST(scope_identity() AS int)", DataProvider.Instance.DB))
                {

                    cmd.Parameters.AddWithValue("@ProductionID", (o as HondaLock).ProductionID);
                    cmd.Parameters.AddWithValue("@BoxID", (o as HondaLock).BoxID);
                    cmd.Parameters.AddWithValue("@BoardNo", (o as HondaLock).BoardNo);
                    cmd.Parameters.AddWithValue("@UpdateTime", (o as HondaLock).UpdateTime);
                    cmd.Parameters.AddWithValue("@Status", (o as HondaLock).Status ?? "");
                    cmd.Parameters.AddWithValue("@Updator_Code", (o as HondaLock).Update_Code ?? "");
                    cmd.Parameters.AddWithValue("@Updator_Name", (o as HondaLock).Update_Name ?? "");
                    cmd.Parameters.AddWithValue("@Line", (o as HondaLock).Line ?? "");
                    cmd.Parameters.AddWithValue("@Repair", (o as HondaLock).Repair ? 1 : 0);
                    (o as HondaLock).ID = (int)cmd.ExecuteScalar();

                    return o;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
                return null;
            }
        }
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
