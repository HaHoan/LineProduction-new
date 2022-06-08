using System;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;
using Line_Production.Database;
using Line_Production.Entities;
using Line_Production.USAPReference;
using Microsoft.VisualBasic; // Install-Package Microsoft.VisualBasic

namespace Line_Production
{
    public partial class Control
    {
        // bien quy dinh duong dan file
        public static bool waitWipConfirm = true;
        public static string pathBackup = string.Empty;
        public static string pathWip = string.Empty;
        public static bool unlock = false;
        // cac bien cai dat den line san xuat---------------------------------------------------------------
        public static LINE_MODEL Model;
        public static string IdLine = "";
        public static int NumberInModel = 0; // bien lua gia tri model có sử dụng macbox hay không 
        public static int NoPeople = 0; // bien lua gia tri model có sử dụng macbox hay không 
        public static bool BarcodeEnable = false; // bien cho phep model co su dung chuc nang barcode hay khong
        public static double CycleTimeModel = 30.6d;
        public static double CycleTimeActual = 0.0d;
        public static bool Shiftcheck = true; // true la ca dem, False la ca dem
        public static string Datecheck = "";
        public static string StateProduct = StateLine.STOP;
        public static bool IsPauseByTime = false;
        public static DateTime[] TimeLine = new DateTime[22]; // bien quy dinh khung gio 
        public static int TimePauseLine; // bien ghi gio tam dung line
        public static int CountProduct = 0; // dem san luong cua line model
        public static int[] CountProductPerHour = new int[22]; // dem san luong cua tung gio
        public static string[] notePerHour = new string[11];
        public static int ProductPlan = 0; // dem san luong tu dong theo cycle time cua model
        public static int ProductPlanBegin = 0; // dem san luong tu dong theo cycle time cua model
        public static int BalanceProduction = 0; // chenh lech san luong thuc te
        public static int BalanceAlarmSetup; // gia tri dat bat dau canh bao san luong
        public static int BalanceErrorSetup; // gia tri dat bat dau canh bao san luong
        public static bool BitPress = false; // bien xac nhan chong nhieu cho nut an tang qu cong com
        public static int TimeCountPlan = 0; // bien dem thoi gian cua cycle time theo line
        public static int TimeCycleActual = 0; // bien dem thoi gian cycle time thuc te ma line dang chay
        public static bool[] TimeUse = new bool[10]; // moc thoi gian ma line da chay va su dung
        public static int StatusLine = 0; // bien luu trang thai line, 0: chua hoat dong, 1: bat dau hoat dong, 2: Bao dong san luong  3:Bat thuong
        public static int TimeCycleActual2 = 0;
        public static string FilePassrate; // ten file passrate
        public static bool CheckServer = false;
        public static int PCBBOX = 10;
        public static string MacCurrent = "";
        public static string WO_SAP = "";
        public static string WO_MES = "";
        public static BCLBFLMEntity BOX_INFO = null;
        public static int IDCount = 0;
        public static int IDCount_box = 0;
        public static string HistoryNo = "";
        public static bool IsUseBarcode = true;
        // Public MacLe As Boolean = False
        // QuyetPham add 26.11
        public static string STATION = "";
        public static string STATION_BEFORE = "";
        // ///////////////////////////////////////////////////////////////////////
        public static string Box_curent = "";
        // //////////////////////////////////////////////////////////////////////////////////
        // cac bien lien quan den may chuc nang--------------------------------------------------------------
        public static string PathModelCurrent = ""; // duong dan file cai dat model hien tai
                                                    // Public PathLogMachine As String = "" ' duong dan ma log may chuc nang sinh ra khi can su dung 
                                                    // Public PathLogWip As String = "" ' duong dan sinh file log cho WIP
                                                    // Public NoLinePass As Integer = 3 ' dong co ki tu pass khi may chuc nang sinh log
                                                    // Public KiHieuPass As String = "P" ' ki tu thong bao la pass trong log
                                                    // Public SetProcess As String = "ICT_MUR" ' cong doan tren WIP
                                                    // Public setfilenamereport As String ' cai dat ten lien quan den file name của file report may chuc nang
        public static int CountLabel;
        public static int ModelRevPosition = 1;
        public static string ModelCurrent = "";
        public static string Idcode = "";
        public static short IdCodeLenght = 0;
        public static bool confirmCode_emp = false;

        // cac bien lien quan den com port
        public static string ComControl = "COM7";
        public static int SetBaudRateComControl = 9600;
        public static int SetDataBitsComControl = 8;
        public static int SetStopBitsComControl = 1;
        public static string SetParityComControl = "None";
        public static string ComPress = "COM6";
        public static int SetBaudRateComPress = 9600;
        public static int SetDataBitsComPress = 8;
        public static int SetStopBitsComPress = 1;
        public static string SetParityComPress = "None";
        public static string ArraySend = "S00000000000000B";

        public bool Init()
        {
            try
            {
                var mac = NetworkHelper.GetMacAddress("http://172.28.10.8:8084");
                var item = pvsservice.GetStationByHostName(mac);
                if (item != null)
                {
                    Common.WriteRegistry(Constants.PathConfig, RegistryKeys.id, item.LINE_ID);
                    DataProvider.Instance.TimeLines.InsertLine(item.LINE_ID);
                    Common.WriteRegistry(Constants.PathConfig, RegistryKeys.station, item.STATION_NO);
                }
                var path = Common.GetValueRegistryKey(Constants.PathConfig, RegistryKeys.pathWip);
                if (!string.IsNullOrEmpty(path))
                {
                    pathBackup = Path.Combine(path, "backup", DateTime.Now.ToString("yyyyMMdd"));
                    if (!Directory.Exists(pathBackup))
                        Directory.CreateDirectory(pathBackup);
                    if (!Directory.Exists(Path.Combine(pathBackup, "OK")))
                        Directory.CreateDirectory(Path.Combine(pathBackup, "OK"));
                    if (!Directory.Exists(Path.Combine(pathBackup, "NG")))
                        Directory.CreateDirectory(Path.Combine(pathBackup, "NG"));
                }
                pathWip = Common.GetValueRegistryKey(Constants.PathConfig, RegistryKeys.pathWip);
                IdLine = Common.GetValueRegistryKey(Constants.PathConfig, RegistryKeys.id);
                STATION = Common.GetValueRegistryKey(Constants.PathConfig, RegistryKeys.station);
                pathWip = Common.GetValueRegistryKey(Constants.PathConfig, RegistryKeys.pathWip);
                lblComcontrol.Text = Common.GetValueRegistryKey(Constants.PathConfig, RegistryKeys.COM);
                txtLine.Text = Common.GetValueRegistryKey(Constants.PathConfig, RegistryKeys.id);
                CheckComPressPort();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool CheckComPressPort()
        {
            try
            {
                ComPressPort.PortName = Common.GetValueRegistryKey(Constants.PathConfig, RegistryKeys.COM_PRESS);
                if (!ComPressPort.IsOpen)
                {
                    ComPressPort.Open();
                }

            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool CheckModelList()
        {
            try
            {

                using (var db = new barcode_dbEntities())
                {
                    var customer = Common.GetValueRegistryKey(Constants.PathConfig, RegistryKeys.Customer);
                    var list = db.LINE_MODEL.Where(m => m.Customer == customer).ToList();
                    if (list == null) return false;
                    foreach (var model in list)
                    {
                        cbbModel.Items.Add(model.Model);
                    }

                    return true;
                }


            }
            catch (Exception e)
            {

                return false;
            }


        }

        public bool LoadModelCurrent(string ModelLoad)
        {
            string Strcheck = ModelLoad;
            PathModelCurrent = "";
            if (Strcheck.Length != 0)
            {
                using (var db = new barcode_dbEntities())
                {
                    try
                    {
                        Model = db.LINE_MODEL.Where(m => m.Model.ToLower() == Strcheck.ToLower()).FirstOrDefault();
                        NoPeople = Model.PersonPerLine;
                        CycleTimeModel = Model.CycleTime;
                        BarcodeEnable = Model.UseBarcode is int useBarcode;
                        BalanceAlarmSetup = (int)Model.WarnQuantity;
                        BalanceErrorSetup = (int)Model.MinQuantity;
                        if (Model.NumberInModel is int numberInModel)
                        {
                            NumberInModel = numberInModel;
                        }
                        HistoryNo = Model.HistoryNo;
                        if (Model.UseBarcode == null || (Model.UseBarcode is int usebarcode && usebarcode == 0))
                        {
                            IsUseBarcode = false;
                            timerCompress.Enabled = true;
                        }
                        else
                        {
                            IsUseBarcode = true;
                            timerCompress.Enabled = false;
                        }
                        if (Model.ReadFileLog is bool readFileLog && readFileLog == true)
                        {
                            IS_USING_FILE_LOG = true;
                        }
                        else
                        {
                            IS_USING_FILE_LOG = false;
                        }
                        var customer = Common.GetValueRegistryKey(Constants.PathConfig, RegistryKeys.Customer); 
                        if(customer != Model.Customer)
                        {
                            Common.WriteRegistry(Constants.PathConfig, RegistryKeys.Customer, Model.Customer);
                        }
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }

                    return true;
                }


            }
            else
            {
                return false;
            }
        }

        public static bool CheckCaSX()
        {
            int caSX = 0;
            if (DateAndTime.Now.Hour >= 8 & DateAndTime.Now.Hour <= 19)
            {
                Shiftcheck = true;
                caSX = CaSX.DAY;
            }
            else
            {
                Shiftcheck = false;
                caSX = CaSX.NIGHT;
            }
            var list = DataProvider.Instance.TimeLines.Select(Common.GetValueRegistryKey(Constants.PathConfig, RegistryKeys.id), caSX);
            if (list == null || list.Count == 0)
            {
                MessageBox.Show("Không lấy được timeLine! Vui lòng kiểm tra lại!");
                return false;
            }
            foreach (var time in list)
            {
                var timeIndex = time.TimeIndex is int index ? index : 0;
                TimeLine[2 * timeIndex - 1] = Convert.ToDateTime(time.TimeFrom);
                TimeLine[2 * timeIndex] = Convert.ToDateTime(time.TimeTo);
            }
            return Shiftcheck;
        }

        public static double CalTimeWork(DateTime t1, DateTime t2)
        {
            double kq;
            var span = t2.Subtract(t1);
            kq = span.Hours * 3600 + span.Minutes * 60 + span.Seconds;
            return kq;
        }
    }
}


