using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Line_Production.Database;
using Line_Production.Entities;
using Microsoft.VisualBasic;
using Line_Production.Business;
namespace Line_Production
{
    public partial class Control : Form
    {
        private List<string> ModelSpeacials = new List<string>();
        private static PVSReference.PVSWebServiceSoapClient pvsservice = new PVSReference.PVSWebServiceSoapClient();
        private static USAPReference.USAPWebServiceSoapClient usapservice = new USAPReference.USAPWebServiceSoapClient();
        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);
        private LineProductWebServiceReference.LineProductRealtimeWebServiceSoapClient _lineproduct_service = new LineProductWebServiceReference.LineProductRealtimeWebServiceSoapClient();
        private LineProductWebServiceReference.tbl_Product_RealtimeEntity _entity = new LineProductWebServiceReference.tbl_Product_RealtimeEntity();
        private DateTime time_scanBarcode;
        private int bien_dem = 0;
        private bool useWip = true;
        private int _index = 0;
        private int _counter = 0;
        private bool IS_USING_FILE_LOG = false;
        public Control()
        {
            InitializeComponent();
            checkModelSpeacial();
            if (Common.GetValueRegistryKey(Constants.PathConfig, RegistryKeys.id) is null)
            {
                MessageBox.Show("Vào Config để điền đây đủ các mục setting!");
            }
        }


        int CountFileBeginDay = 0;
        int CountFileBeginNight = 0;
        int CountFileCurrentDay = 0;
        int CountFileCurrentNight = 0;
        public void ShiftDirectory(string targetDirectory)
        {
            if (!IS_USING_FILE_LOG) return;
            if (Directory.Exists(targetDirectory + @"\" + DateTime.Now.Date.ToString("yyyyMMdd")) == false)
            {
                Directory.CreateDirectory(targetDirectory + @"\" + DateTime.Now.Date.ToString("yyyyMMdd"));
            }

            if (Directory.Exists(targetDirectory + @"\" + DateTime.Now.Date.ToString("yyyyMMdd") + @"\" + ModelCurrent) == false)
            {
                Directory.CreateDirectory(targetDirectory + @"\" + DateTime.Now.Date.ToString("yyyyMMdd") + @"\" + ModelCurrent);
            }

            if (Directory.Exists(targetDirectory + @"\" + DateTime.Now.Date.ToString("yyyyMMdd") + @"\" + ModelCurrent + @"\CaNgay") == false)
            {
                Directory.CreateDirectory(targetDirectory + @"\" + DateTime.Now.Date.ToString("yyyyMMdd") + @"\" + ModelCurrent + @"\CaNgay");
            }

            if (Directory.Exists(targetDirectory + @"\" + DateTime.Now.Date.ToString("yyyyMMdd") + @"\" + ModelCurrent + @"\CaDem") == false)
            {
                Directory.CreateDirectory(targetDirectory + @"\" + DateTime.Now.Date.ToString("yyyyMMdd") + @"\" + ModelCurrent + @"\CaDem");
            }

            var fileEntries = Directory.GetFiles(targetDirectory + @"\" + DateTime.Now.Date.ToString("yyyyMMdd"));
            // Process the list of files found in the directory.
            string fileName;
            foreach (var currentFileName in fileEntries)
            {
                fileName = currentFileName;
                if (fileName.Contains(".txt") == true & fileName.Contains(ModelCurrent) == true)
                {
                    string filecut = Strings.Mid(fileName, Strings.InStrRev(fileName, @"\", -1, CompareMethod.Text) + 1, fileName.Length);
                    if (File.GetLastWriteTime(fileName).Hour >= 8 & File.GetLastWriteTime(fileName).Hour <= 19)
                    {
                        File.Move(fileName, targetDirectory + @"\" + DateTime.Now.Date.ToString("yyyyMMdd") + @"\" + ModelCurrent + @"\CaNgay\" + filecut);
                    }
                    else
                    {
                        File.Move(fileName, targetDirectory + @"\" + DateTime.Now.Date.ToString("yyyyMMdd") + @"\" + ModelCurrent + @"\CaDem" + filecut);
                    }
                }
            }

            var fileEntries2 = Directory.GetFiles(targetDirectory + @"\" + DateTime.Now.Date.ToString("yyyyMMdd") + @"\" + ModelCurrent + @"\CaNgay");
            foreach (var currentFileName1 in fileEntries2)
            {
                fileName = currentFileName1;
                if (fileName.Contains(".txt") == true)
                    CountFileBeginDay += 1;
            }

            var fileEntries3 = Directory.GetFiles(targetDirectory + @"\" + DateTime.Now.Date.ToString("yyyyMMdd") + @"\" + ModelCurrent + @"\CaDem");
            foreach (var currentFileName2 in fileEntries2)
            {
                fileName = currentFileName2;
                if (fileName.Contains(".txt") == true)
                    CountFileBeginNight += 1;
            }
        }

        public void ProcessDirectory(string targetDirectory)
        {
            try
            {
                if (!IS_USING_FILE_LOG) return;
                if (bool.Parse(Common.GetValueRegistryKey(Constants.PathConfig, RegistryKeys.LinkPathLog))
                   || bool.Parse(Common.GetValueRegistryKey(Constants.PathConfig, RegistryKeys.LinkWip)))
                {
                    targetDirectory = targetDirectory + @"\backup\" + DateTime.Now.Date.ToString("yyyyMMdd");
                }

                var fileEntries = Directory.GetFiles(targetDirectory);
                if (Directory.Exists(targetDirectory + @"\" + DateTime.Now.Date.ToString("yyyyMMdd")) == false)
                {
                    Directory.CreateDirectory(targetDirectory + @"\" + DateTime.Now.Date.ToString("yyyyMMdd"));
                }

                if (Directory.Exists(targetDirectory + @"\" + DateTime.Now.Date.ToString("yyyyMMdd") + @"\" + ModelCurrent) == false)
                {
                    Directory.CreateDirectory(targetDirectory + @"\" + DateTime.Now.Date.ToString("yyyyMMdd") + @"\" + ModelCurrent);
                }

                if (Directory.Exists(targetDirectory + @"\" + DateTime.Now.Date.ToString("yyyyMMdd") + @"\" + ModelCurrent + @"\CaNgay") == false)
                {
                    Directory.CreateDirectory(targetDirectory + @"\" + DateTime.Now.Date.ToString("yyyyMMdd") + @"\" + ModelCurrent + @"\CaNgay");
                }

                if (Directory.Exists(targetDirectory + @"\" + DateTime.Now.Date.ToString("yyyyMMdd") + @"\" + ModelCurrent + @"\CaDem") == false)
                {
                    Directory.CreateDirectory(targetDirectory + @"\" + DateTime.Now.Date.ToString("yyyyMMdd") + @"\" + ModelCurrent + @"\CaDem");
                    // Process the list of files found in the directory.
                }

                foreach (var fileName in fileEntries)
                {
                    if (fileName.Contains(".txt") == true & fileName.Contains(ModelCurrent.ToUpper()) == true)
                    {
                        string filecut = Strings.Mid(fileName, Strings.InStrRev(fileName, @"\", -1, CompareMethod.Text) + 1, fileName.Length);
                        if (File.GetLastWriteTime(fileName).Hour >= 8 & File.GetLastWriteTime(fileName).Hour <= 19)
                        {
                            File.Move(fileName, targetDirectory + @"\" + DateTime.Now.Date.ToString("yyyyMMdd") + @"\" + ModelCurrent + @"\CaNgay\" + filecut);
                            CountFileCurrentDay = CountFileBeginDay + 1;
                            IncreaseProduct();
                        }
                        else
                        {
                            File.Move(fileName, targetDirectory + @"\" + DateTime.Now.Date.ToString("yyyyMMdd") + @"\" + ModelCurrent + @"\CaDem\" + filecut);
                            CountFileCurrentNight = CountFileBeginNight + 1;
                            IncreaseProduct();
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                LogFileWritter.WriteLog(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UpdateRealtime error!", ex);
            }

        }

        private void checkModelSpeacial()
        {
            // Model nay thuoc khach hang CANON thang long. khi check mac co hoi lua chon mac thung repair hay khong
            var modelSpecial = Common.GetValueRegistryKey(Constants.PathConfig, RegistryKeys.MODEL_SPEACIAL);
            if (modelSpecial == null)
            {
                Common.WriteRegistry(Constants.PathConfig, RegistryKeys.MODEL_SPEACIAL, "QM7-1890-000SS01");
                ModelSpeacials.Add("QM7-1890-000SS01");
            }
            else
            {
                var list = modelSpecial.Split(',');
                foreach (var item in list)
                {
                    ModelSpeacials.Add(item);
                }
            }
        }

        public void FormatNgayCasx()
        {
            CheckCaSX();
            if (Shiftcheck == true)
            {
                Datecheck = DateAndTime.Now.Date.ToString("dd-MM-yyyy");
            }
            else if (DateAndTime.Now.Hour >= 0 & DateAndTime.Now.Hour <= 7)
            {
                if (DateAndTime.Now.Day > 1)
                {
                    Datecheck = (DateAndTime.Now.Day - 1).ToString().PadLeft(2, '0') + "-" + DateAndTime.Now.Month.ToString().PadLeft(2, '0') + "-" + DateAndTime.Now.Year;
                }
                else
                {
                    switch (DateAndTime.Now.Month - 1)
                    {
                        case 1:
                            {
                                Datecheck = DateAndTime.Now.Year - 1 + "1231";
                                break;
                            }

                        case 3:
                        case 5:
                        case 7:
                        case 8:
                        case 10:
                        case 12:
                            {
                                Datecheck = "31-" + (DateAndTime.Now.Month - 1).ToString().PadLeft(2, '0') + "-" + DateAndTime.Now.Year;
                                break;
                            }

                        case 4:
                        case 6:
                        case 9:
                        case 11:
                            {
                                Datecheck = "30-" + (DateAndTime.Now.Month - 1).ToString().PadLeft(2, '0') + "-" + DateAndTime.Now.Year;
                                break;
                            }

                        case 2:
                            {
                                if (DateAndTime.Now.Year % 4 == 0 & DateAndTime.Now.Year % 100 != 0 | DateAndTime.Now.Year % 400 == 0)
                                {
                                    Datecheck = "29-02" + DateAndTime.Now.Year;
                                }
                                else
                                {
                                    Datecheck = "28-02" + DateAndTime.Now.Year;
                                }

                                break;
                            }
                    }
                }
            }
            else
            {
                Datecheck = DateAndTime.Now.Date.ToString("dd-MM-yyyy");
            }

            txtDate.Text = Datecheck;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileShare.Connect(FileShare.PATH, new System.Net.NetworkCredential(FileShare.USER, FileShare.PASSWORD));

            if (CheckModelList() == true)
            {
                Init();
                SetupDisplay();
            }
            else
            {
                MessageBox.Show("Setup List Model Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }

        public void SetupDisplay()
        {
            Common.SendToComport("S0000000000000R", (result) =>
            {
                lblState.Text = result;
            });
            Common.SendToComport("C", (result) =>
            {
                lblState.Text = result;
            });


            cbbModel.Visible = true;
            cbbModel.Text = "";
            for (int index = 1; index <= 10; index++)
            {
                Table1.Controls.Find("TextTime" + index, true)[0].Text = "";
                Table1.Controls.Find("TextPlan" + index, true)[0].Text = "";
                Table1.Controls.Find("TextActual" + index, true)[0].Text = "";
                Table1.Controls.Find("TextBalance" + index, true)[0].Text = "";
                Table1.Controls.Find("TextComment" + index, true)[0].Text = "";
                notePerHour[index] = "";
            }

            lblComcontrol.Text = Common.GetValueRegistryKey(Constants.PathConfig, "COM");
            chkNG.Enabled = false;
            lblVersion.Text = GetRunningVersion();
            TextCycleTimeCurrent.Text = "0";
            TextCycleTimeModel.Text = "0";
            txtShift.Clear();
            txtDate.Clear();
            StatusLine = 0;
            CountProduct = 0;
            ProductPlan = 0;
            TimeCycleActual = 0;
            LabelPCBA.Text = "0";
            LabelSoThung.Text = "0";
            LabelPCS1BOX.Text = "0";
            IDCount = 0;
            IDCount_box = 0;
            MacCurrent = "";
            for (int index = 1; index <= 9; index++)
                CountProductPerHour[index] = 0;
            NoPeople = 0;
            NumberInModel = 0;
            ModelCurrent = "";
            Shape2.Visible = false;
            Shape1.Visible = false;
            Shape3.Visible = false;
            LabelShapeOnline.Visible = false;
            LabelShapeOffLine.Visible = false;
            LabelShapeError.Visible = false;
            Timer1.Enabled = true;
            TextMacBox.Text = "";
            txtSerial.Text = "";
            TextMacBox.Enabled = false;
            txtSerial.Enabled = false;
            TextCycleTimeCurrent.Text = "0";
            txtPeople.Text = "0";
            txtPlan.Text = "0";
            txtActual.Text = "0";
            TextBalance.Text = "0";
            CountProduct = 0;
            lblQuantity.Text = CountProduct.ToString();
            txtShift.Text = "";
            BtStart.Enabled = false;
            BtStop.Enabled = false;
            BtStart.Text = "Bắt đầu";
            BtStart.Image = Properties.Resources.play;
            try
            {
                useWip = bool.Parse(Common.GetValueRegistryKey(Constants.PathConfig, "useWip"));
            }
            catch { }
        }

        public void LoadProduction()
        {
            string line = Common.GetValueRegistryKey(Constants.PathConfig, RegistryKeys.id);
            string currentStation = Common.GetValueRegistryKey(Constants.PathConfig, RegistryKeys.station);
            var passRate = DataProvider.Instance.PassRates.GetPassRate(line, cbbModel.Text, Datecheck + "_" + Shiftcheck);
            if (passRate != null)
            {
                ProductPlanBegin = passRate.ProductPlan is int productPlan ? productPlan : 0;
                ProductPlan = passRate.ProductPlan is int productPlan1 ? productPlan1 : 0;
                CountProduct = passRate.Actual is int actual ? actual : 0;
                IDCount = 0;
                IDCount_box = passRate.IDCountBox is int countBox ? countBox : 0;
                Box_curent = "";
                TimeCycleActual = (int)passRate.TimeCycleActual;
                for (int index = 0; index < 10; index++)
                {
                    CountProductPerHour[index + 1] = int.Parse(passRate.TimeValues[index]);
                    notePerHour[index + 1] = "";
                }
            }
            else
            {
                for (int index = 1; index <= 10; index++)
                {
                    CountProductPerHour[index] = 0;
                    notePerHour[index] = "";
                }
                LINE_PASSRATE p = new LINE_PASSRATE();
                p.ProductionID = cbbModel.Text;
                p.Line = line;
                p.Time = Datecheck + "_" + Shiftcheck;
                p.ProductPlan = ProductPlan;
                p.Actual = CountProduct;
                p.IDCount = IDCount;
                p.IDCountBox = IDCount_box;
                p.BoxCurrent = Box_curent;
                p.TimeCycleActual = TimeCycleActual;
                p.TimeValues = new string[10];
                for (int index = 0; index < 10; index++)
                {
                    p.TimeValues[index] = "0";
                }
                p.TimeValue = string.Join(",", p.TimeValues);
                DataProvider.Instance.PassRates.Update(p);
            }

        }

        public void RecordProduction()
        {
            if (ModelCurrent != "")
            {
                string line = Common.GetValueRegistryKey(Constants.PathConfig, RegistryKeys.id);

                LINE_PASSRATE p = new LINE_PASSRATE();
                p.ProductionID = cbbModel.Text;
                p.Line = line;
                p.Time = Datecheck + "_" + Shiftcheck;
                p.ProductPlan = ProductPlan;
                p.Actual = CountProduct;
                p.IDCount = IDCount;
                p.IDCountBox = IDCount_box;
                p.BoxCurrent = Box_curent;
                p.TimeCycleActual = TimeCycleActual;
                p.TimeValues = new string[10];
                for (int index = 0; index < 10; index++)
                {
                    p.TimeValues[index] = "0";
                }
                p.TimeValue = string.Join(",", p.TimeValues);
                DataProvider.Instance.PassRates.Update(p);
            }
        }

        private void ComboModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbModel.Text != "")
            {
                Schedule schedule = new Schedule();
                schedule.ShowInTaskbar = false;
                schedule.updateTotal = new Action<string>(m =>
                {
                    lblTotal.Text = m;
                });
                schedule.ShowDialog();

                LabelPCBA.Text = "0";
                ModelCurrent = cbbModel.Text;
                Common.WriteRegistry(Constants.PathConfig, RegistryKeys.ModelCurrent, ModelCurrent);
                if (LoadModelCurrent(ModelCurrent))
                {
                    TextCycleTimeModel.Text = CycleTimeModel.ToString();
                    TextCycleTimeCurrent.Text = "";
                    txtPeople.Text = NoPeople.ToString();
                    lblHistoryNo.Text = "HIS:" + HistoryNo;
                    FormatNgayCasx();
                    BtStart.Enabled = true;
                    BtStop.Enabled = true;
                    LoadProduction();
                    txtPlan.Text = Math.Round(TimeCycleActual / CycleTimeModel, 0, MidpointRounding.AwayFromZero).ToString(); // ProductPlanBegin.ToString()
                    txtActual.Text = CountProduct.ToString();
                    TextBalance.Text = Math.Abs(CountProduct - ProductPlanBegin).ToString();
                    lblQuantity.Text = CountProduct.ToString();
                    LabelSoThung.Text = IDCount_box.ToString();
                    TextCycleTimeCurrent.Text = Math.Round((double)TimeCycleActual / CountProduct, 1, MidpointRounding.AwayFromZero).ToString();
                    if (CheckCaSX() == true)
                    {
                        txtShift.Text = "Ca Ngày";
                        for (int index = 1; index <= 10; index++)
                        {
                            Table1.Controls.Find("TextComment" + index, true)[0].Text = notePerHour[index];
                            Table1.Controls.Find("TextTime" + index, true)[0].Text = TimeLine[1 + 2 * (index - 1)].Hour + ":" + TimeLine[1 + 2 * (index - 1)].Minute + ":" + TimeLine[1 + 2 * (index - 1)].Second + ">" + TimeLine[2 + 2 * (index - 1)].Hour + ":" + TimeLine[2 + 2 * (index - 1)].Minute + ":" + TimeLine[2 + 2 * (index - 1)].Second;
                            Table1.Controls.Find("TextPlan" + index, true)[0].Text = Strings.Format(((TimeLine[2 + 2 * (index - 1)].Hour - TimeLine[1 + 2 * (index - 1)].Hour) * 3600 + (TimeLine[2 + 2 * (index - 1)].Minute - TimeLine[1 + 2 * (index - 1)].Minute) * 60 + (TimeLine[2 + 2 * (index - 1)].Second - TimeLine[1 + 2 * (index - 1)].Second)) / CycleTimeModel, "0");
                            if (CountProductPerHour[index] > 0)
                            {
                                Table1.Controls.Find("TextActual" + index, true)[0].Text = CountProductPerHour[index].ToString();
                                Table1.Controls.Find("TextBalance" + index, true)[0].Text = (int.Parse(Table1.Controls.Find("TextActual" + index, true)[0].Text) - int.Parse(Table1.Controls.Find("TextPlan" + index, true)[0].Text)).ToString();
                            }
                        }
                    }
                    else
                    {
                        txtShift.Text = "Ca Đêm";
                        for (int index = 1; index <= 10; index++)
                        {
                            Table1.Controls.Find("TextComment" + index, true)[0].Text = notePerHour[index];
                            Table1.Controls.Find("TextTime" + index, true)[0].Text = TimeLine[1 + 2 * (index - 1)].Hour + ":" + TimeLine[1 + 2 * (index - 1)].Minute + ":" + TimeLine[1 + 2 * (index - 1)].Second + ">" + TimeLine[2 + 2 * (index - 1)].Hour + ":" + TimeLine[2 + 2 * (index - 1)].Minute + ":" + TimeLine[2 + 2 * (index - 1)].Second;
                            Table1.Controls.Find("TextPlan" + index, true)[0].Text = Strings.Format(((TimeLine[2 + 2 * (index - 1)].Hour - TimeLine[1 + 2 * (index - 1)].Hour) * 3600 + (TimeLine[2 + 2 * (index - 1)].Minute - TimeLine[1 + 2 * (index - 1)].Minute) * 60 + (TimeLine[2 + 2 * (index - 1)].Second - TimeLine[1 + 2 * (index - 1)].Second)) / CycleTimeModel, "0");
                            if (CountProductPerHour[index] > 0)
                            {
                                Table1.Controls.Find("TextActual" + index, true)[0].Text = CountProductPerHour[index].ToString();
                                Table1.Controls.Find("TextBalance" + index, true)[0].Text = Strings.Format(((TimeLine[2 + 2 * (index - 1)].Hour - TimeLine[1 + 2 * (index - 1)].Hour) * 3600 + (TimeLine[2 + 2 * (index - 1)].Minute - TimeLine[1 + 2 * (index - 1)].Minute) * 60 + (TimeLine[2 + 2 * (index - 1)].Second - TimeLine[1 + 2 * (index - 1)].Second)) / CycleTimeModel, "0");
                            }
                        }
                    }

                }
            }
        }

        public void ShowStatus(int value, bool VisibleShow)
        {
            switch (value)
            {
                case 0:
                    {

                        // LabelStatus.Text = "Tình trạng Line:       "
                        LabelShapeOnline.Visible = false;
                        LabelShapeOffLine.Visible = false;
                        LabelShapeError.Visible = false;
                        Shape1.Visible = false;
                        Shape2.Visible = false;
                        Shape3.Visible = false;
                        break;
                    }

                case 1:
                    {
                        // LabelStatus.Text = "Tình trạng Line:Online"
                        LabelShapeOnline.Visible = VisibleShow;
                        LabelShapeOffLine.Visible = false;
                        LabelShapeError.Visible = false;
                        Shape1.Visible = VisibleShow;
                        if (VisibleShow == false)
                        {
                            Common.SendToComport("R", result =>
                             {
                                 lblState.Text = result;
                             });
                        }
                        else
                        {
                            Common.SendToComport("X", result =>
                            {
                                lblState.Text = result;
                            });
                        }
                        Shape2.Visible = false;
                        Shape3.Visible = false;
                        break;
                    }

                case 2:
                    {
                        // LabelStatus.Text = "Tình trạng Line: Bao Dong"
                        LabelShapeOnline.Visible = false;
                        LabelShapeOffLine.Visible = VisibleShow;
                        LabelShapeError.Visible = false;
                        Shape1.Visible = false;
                        Shape2.Visible = VisibleShow;
                        if (VisibleShow == false)
                        {
                            Common.SendToComport("R", result =>
                            {
                                lblState.Text = result;
                            });
                        }
                        else
                        {
                            Common.SendToComport("V", result =>
                            {
                                lblState.Text = result;
                            });
                        }

                        Shape3.Visible = false;
                        break;
                    }

                case 3:
                    {
                        // LabelStatus.Text = "Tình trạng Line: Bat Thuong"
                        LabelShapeOnline.Visible = false;
                        LabelShapeOffLine.Visible = false;
                        LabelShapeError.Visible = VisibleShow;
                        Shape1.Visible = false;
                        Shape2.Visible = false;
                        Shape3.Visible = VisibleShow;
                        if (VisibleShow == false)
                        {
                            Common.SendToComport("R", result => { lblState.Text = result; });

                        }
                        else
                        {
                            Common.SendToComport("D", result => { lblState.Text = result; });
                        }

                        break;
                    }

                default:
                    {
                        break;
                    }
            }
        }
        private void ShowNGForm(string message)
        {
            NG_FORM NG_FORM = new NG_FORM();
            NG_FORM.Show();
            NG_FORM.Lb_inform_NG.Text = message;
            NG_FORM.GroupBox3.Visible = false;
            NG_FORM.GroupBox3.Enabled = false;
            NG_FORM.ControlBox = true;
        }
        private void BtStart_Click(object sender, EventArgs e)
        {
            if (StateProduct != StateLine.RUNNING)
            {
                if (!cbbModel.Items.Contains(cbbModel.Text))
                {
                    ShowNGForm("Bạn vừa sửa model đã chọn");
                    return;
                }
                ModelCurrent = cbbModel.Text;
                LabelShapeOnline.Visible = true;
                LabelShapeOffLine.Visible = false;
                LabelShapeError.Visible = false;
                Shape1.Visible = false;
                Shape2.Visible = false;
                Shape3.Visible = false;
                cbbModel.Visible = false;
                lblModel.Visible = true;
                lblModel.Text = cbbModel.Text;
                chkNG.Enabled = true;
                StateProduct = StateLine.RUNNING;
                BtStart.Text = "Online";
                BtStart.Image = Properties.Resources.pause;
                Common.UpdateState(StateProduct);
                int sumtime = DateAndTime.Now.Hour * 100 + DateAndTime.Now.Minute;
                if (StatusLine == 0)
                {
                    StatusLine = 1;
                    ShowStatus(StatusLine, true);
                    CheckIsConfirm();
                    for (int index = 1; index <= 20; index++)
                    {

                        if (index % 2 != 0 & sumtime >= TimeLine[index].Hour * 100 + TimeLine[index].Minute & sumtime <= TimeLine[index + 1].Hour * 100 + TimeLine[index + 1].Minute)
                        {
                            time_scanBarcode = DateAndTime.Now;
                            txtActual.Text = CountProduct.ToString();
                            break;
                        }
                    }
                }
                else
                {
                    StateProduct = StateLine.RUNNING;
                    ShowStatus(StatusLine, true);
                    for (int index = 1; index <= 20; index++)
                    {
                        if (index % 2 != 0 & sumtime >= TimeLine[index].Hour * 100 + TimeLine[index].Minute & sumtime <= TimeLine[index + 1].Hour * 100 + TimeLine[index + 1].Minute)
                        {
                            Table1.Controls.Find("TextTime" + (index / 2 + 1), true)[0].Text = TimeLine[index].Hour + ":" + TimeLine[index].Minute + ":" + TimeLine[index].Second + ">" + TimeLine[index + 1].Hour + ":" + TimeLine[index + 1].Minute + ":" + TimeLine[index + 1].Second;
                            Table1.Controls.Find("TextPlan" + (index / 2 + 1), true)[0].Text = Strings.Format(((TimeLine[index + 1].Hour - TimeLine[index].Hour) * 3600 + (TimeLine[index + 1].Minute - TimeLine[index].Minute) * 60 + (TimeLine[index + 1].Second - TimeLine[index].Second)) / CycleTimeModel + CountProductPerHour[index / 2 + 1], "0");
                            break;
                        }
                    }

                    TimePauseLine = 0;
                }

                time_scanBarcode = DateAndTime.Now;
                ProductPlan = (int)Math.Round(TimeCycleActual / CycleTimeModel, 0, MidpointRounding.AwayFromZero);
                txtPlan.Text = ProductPlan.ToString();
                if (IS_USING_FILE_LOG || !IsUseBarcode)
                {
                    return;
                }
                if (NumberInModel == 0)
                {
                    TextMacBox.Enabled = true;
                    TextMacBox.Focus();
                }
                else if (NumberInModel > 0)
                {
                    // Trường hợp ở ichikoh có model không dùng mac thùng => tính toán số lượng thùng đã bắn
                    using (var db = new barcode_dbEntities())
                    {
                        var currentStation = Common.GetValueRegistryKey(Constants.PathConfig, RegistryKeys.station);
                        IDCount = db.HondaLocks.Where(m => m.ProductionID == ModelCurrent &&
                        string.IsNullOrEmpty(m.BoxID) &&
                        m.Station == currentStation).Count()
                        - IDCount_box * NumberInModel;
                    }

                    PCBBOX = NumberInModel;
                    if (PCBBOX < 0)
                    {
                        ShowNGForm("Số lượng thùng đang bị âm");
                        TextMacBox.SelectAll();
                        return;
                    }

                    LabelPCS1BOX.Text = PCBBOX.ToString();
                    TextMacBox.Enabled = false;
                    txtSerial.Enabled = true;
                    txtSerial.SelectAll();
                    txtSerial.Focus();
                    if (IDCount >= PCBBOX)
                    {
                        LabelPCBA.Text = "0";
                        IDCount = 0;
                    }
                    else
                    {
                        LabelPCBA.Text = IDCount.ToString();
                    }


                }
                else
                {
                    // Trường hợp ở YASKAWA không sử dụng mac
                    PCBBOX = int.MaxValue;
                    LabelPCBA.Text = "0";
                    lblExplain.Text = "PCS/WO";
                    groupSoThung.Visible = false;
                    TextMacBox.Enabled = false;
                    txtSerial.Enabled = true;
                    txtSerial.SelectAll();
                    txtSerial.Focus();
                }
            }
            else
            {
                try
                {
                    Common.UpdateState(StateLine.STOP);
                    ProductionSave(StateLine.STOP);
                    BtStart.Text = "Dừng";
                    BtStart.Image = Properties.Resources.play;
                    StateProduct = StateLine.PAUSE;
                    txtSerial.Enabled = false;
                }
                catch (Exception ex)
                {
                    LogFileWritter.WriteLog(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UpdateRealtime error!", ex);
                }
            }

        }

        private void CheckIsConfirm()
        {
            for (int index = 1; index <= 20; index++)
            {
                using (var db = new barcode_dbEntities())
                {
                    var line = Common.GetValueRegistryKey(Constants.PathConfig, RegistryKeys.id);
                    var i = index / 2 + 1;
                    if (i > 10) break;
                    var currentDate = DateTime.Now.Date;
                    var timeLine = Table1.Controls.Find("TextTime" + i, true)[0].Text;
                    var confirm = db.CONFIRM_FAULT_REASON.Where(m => m.Line == line
                    && m.Model == ModelCurrent && m.TimeLine == timeLine
                    && m.UpdateTime.CompareTo(currentDate) >= 0).FirstOrDefault();
                    if (confirm == null)
                    {
                        Table1.Controls.Find("btnConfirm" + i, true)[0].Visible = true;
                    }
                    else
                    {
                        Table1.Controls.Find("btnConfirm" + i, true)[0].Visible = false;
                    }
                }
            }

        }
        private void ProductionSave(string status)
        {
            try
            {
                var ett = new LineProductWebServiceReference.tbl_Product_RealtimeEntity()
                {
                    CUSTOMER = Common.GetValueRegistryKey(Constants.PathConfig, RegistryKeys.Customer),
                    LINE_NO = IdLine,
                    MODEL = cbbModel.Text,
                    QTY_PLAN = ProductPlan,
                    QTY_ACTUAL = CountProduct,
                    UPDATE_TIME = DateTime.Now.Date,
                    PEOPLE = NoPeople,
                    CYRCLETIME_PLAN = (decimal)CycleTimeModel,
                    CYRCLETIME_ACTUAL = (decimal)CycleTimeActual,
                    DIFF = BalanceProduction,
                    ALARM = StatusLine,
                    STATUS = status,
                    QTY_TOTAL = int.Parse(lblTotal.Text),
                    VERSION = GetRunningVersion()
                };
                _lineproduct_service.ProductionSave(ett);
            }
            catch (Exception)
            {

            }

        }
        private void BtStop_Click(object sender, EventArgs e)
        {
            try
            {
                Common.UpdateState(StateLine.STOP);
                ProductionSave(StateLine.STOP);
                cbbModel.Visible = true;
                lblModel.Visible = false;
                StateProduct = StateLine.STOP;
                SetupDisplay();
            }
            catch (Exception ex)
            {
                LogFileWritter.WriteLog(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UpdateRealtime error!", ex);
            }
        }


        public void IncreaseProduct()
        {
            if (StateProduct == StateLine.RUNNING)
            {
                for (int i = 1; i <= 10; i++)
                    notePerHour[i] = Table1.Controls.Find("TextComment" + i, true)[0].Text;
                int sumtime = DateAndTime.Now.Hour * 100 + DateAndTime.Now.Minute;
                for (int index = 1; index <= 20; index++)
                {
                    if (index % 2 != 0 & sumtime >= TimeLine[index].Hour * 100 + TimeLine[index].Minute & sumtime <= TimeLine[index + 1].Hour * 100 + TimeLine[index + 1].Minute)
                    {
                        bien_dem = bien_dem + 1;
                        CountProductPerHour[index / 2 + 1] = CountProductPerHour[index / 2 + 1] + 1;
                        Table1.Controls.Find("TextActual" + (index / 2 + 1), true)[0].Text = CountProductPerHour[index / 2 + 1].ToString();
                        Table1.Controls.Find("TextBalance" + (index / 2 + 1), true)[0].Text = (CountProductPerHour[index / 2 + 1] - int.Parse(Table1.Controls.Find("TextPlan" + (index / 2 + 1), true)[0].Text)).ToString();
                        _index = (int)((index + 1) / 2d);
                        break;
                    }
                    else
                    {
                        bien_dem = 0;
                    }
                }

                if (bien_dem != 0)
                {
                    CountProduct = CountProduct + 1;
                    if (CountProduct == 1)
                    {
                        CycleTimeActual = (DateAndTime.Now - time_scanBarcode).TotalSeconds; // CalTimeWork(time_scanBarcode, Now) 
                    }
                    else
                    {
                        TimeCycleActual = (int)(TimeCycleActual + (DateAndTime.Now - time_scanBarcode).TotalSeconds); // CalTimeWork(time_scanBarcode, Now)
                        CycleTimeActual = Math.Round((double)TimeCycleActual / CountProduct, 1, MidpointRounding.AwayFromZero);
                    }

                    time_scanBarcode = DateAndTime.Now;
                    TextCycleTimeCurrent.Text = CycleTimeActual.ToString();
                    lblQuantity.Text = CountProduct.ToString();
                    ProductPlan = (int)Math.Round((double)TimeCycleActual / CycleTimeModel, 0, MidpointRounding.AwayFromZero);
                    txtPlan.Text = ProductPlan.ToString();
                    time_scanBarcode = DateAndTime.Now;
                }

                RecordProduction();
            }
        }

        public void ReduceProduct()
        {
            if (StateProduct == StateLine.RUNNING && CountProduct > 0)
            {
                int sumtime = DateAndTime.Now.Hour * 100 + DateAndTime.Now.Minute;
                for (int index = 1; index <= 20; index++)
                {
                    if (index % 2 != 0 & sumtime >= TimeLine[index].Hour * 100 + TimeLine[index].Minute & sumtime <= TimeLine[index + 1].Hour * 100 + TimeLine[index + 1].Minute)
                    {
                        CountProduct = CountProduct - 1;
                        lblQuantity.Text = CountProduct.ToString();
                        CountProductPerHour[index / 2 + 1] = CountProductPerHour[index / 2 + 1] - 1;
                        Table1.Controls.Find("TextActual" + (index / 2 + 1), true)[0].Text = CountProductPerHour[index / 2 + 1].ToString();
                        Table1.Controls.Find("TextBalance" + (index / 2 + 1), true)[0].Text = (CountProductPerHour[index / 2 + 1] - int.Parse(Table1.Controls.Find("TextPlan" + (index / 2 + 1), true)[0].Text)).ToString();
                        break;
                    }
                }

                RecordProduction();
            }
        }
        private void CheckLinePause()
        {
            TimePauseLine = TimePauseLine + 1;
            if (TimePauseLine % 2 == 0)
            {
                ShowStatus(StatusLine, true);
                TimePauseLine = 0;
            }
            else
            {
                ShowStatus(StatusLine, false);
            }
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            try
            {

                LabelTimeDate.Text = DateAndTime.Now.ToString("HH:mm:ss  dd/MM/yyyy");
                _counter++;
                if (StateProduct == StateLine.RUNNING)
                {
                    CheckLinePause();
                    ProcessDirectory(Common.GetValueRegistryKey(Constants.PathConfig, RegistryKeys.pathWip));
                    int sumtime = DateAndTime.Now.Hour * 100 + DateAndTime.Now.Minute;
                    int indexCurrent = 0;
                    for (int index = 1; index <= 20; index++)
                    {
                        if (index % 2 != 0)
                        {
                            if (sumtime >= TimeLine[index].Hour * 100 + TimeLine[index].Minute & sumtime <= TimeLine[index + 1].Hour * 100 + TimeLine[index + 1].Minute)
                            {
                                bien_dem = bien_dem + 1;
                                indexCurrent = index / 2 + 1;
                                IsPauseByTime = false;
                                break;
                            }
                            else
                            {
                                bien_dem = 0;
                            }
                        }
                        else if (index == 20)
                        {
                            IsPauseByTime = true;
                        }
                    }

                    if (bien_dem == 0)
                    {
                        time_scanBarcode = DateAndTime.Now;

                    }


                    BalanceProduction = CountProduct - ProductPlan;

                    var perBalanceProduction = ProductPlan == 0 ? 0 : BalanceProduction * 100 / ProductPlan;
                    if (perBalanceProduction < BalanceErrorSetup)
                    {
                        StatusLine = 3;
                        ShowStatus(StatusLine, true);
                    }
                    else if (perBalanceProduction < BalanceAlarmSetup)
                    {
                        StatusLine = 2;
                        ShowStatus(StatusLine, true);
                    }
                    else
                    {
                        StatusLine = 1;
                        ShowStatus(StatusLine, true);
                    }

                    txtPlan.Text = ProductPlan.ToString();
                    txtActual.Text = CountProduct.ToString();
                    TextBalance.Text = BalanceProduction.ToString();
                    int total = 0;
                    try
                    {
                        total = int.Parse(lblTotal.Text);
                    }
                    catch { }
                    if (BalanceProduction < 0)
                    {
                        if (Math.Abs(BalanceProduction) >= 1000)
                        {
                            ArraySend = "S-" + Strings.Format(999, "000") + Strings.Format(CountProduct, "0000") + Strings.Format(total, "0000") + Strings.Format(NoPeople, "00") + "*";
                        }
                        else
                        {
                            ArraySend = "S" + Strings.Format(BalanceProduction, "000") + Strings.Format(CountProduct, "0000") + Strings.Format(total, "0000") + Strings.Format(NoPeople, "00") + "*";
                        }
                    }
                    else
                    {
                        ArraySend = "S+" + Strings.Format(BalanceProduction, "000") + Strings.Format(CountProduct, "0000") + Strings.Format(total, "0000") + Strings.Format(NoPeople, "00") + "*";
                    }

                    if (_counter >= 60)
                    {
                        string note = "";
                        if (Table1.Controls.Find("TextComment" + indexCurrent, true).Length > 0)
                        {
                            note = Table1.Controls.Find("TextComment" + indexCurrent, true)[0].Text;
                        }
                        ProductionSave("RUNNING");
                        _counter = 0;
                    }
                    Common.SendToComport(ArraySend, result => { lblState.Text = result; });

                }

            }
            catch (Exception ex)
            {

                //LogFileWritter.WriteLog(@"\\172.28.10.12\Share\18 IT\U34811(hoanht)\7.ERRORS\CANON\aa.txt", "UpdateRealtime error!", ex);
                LogFileWritter.WriteLog(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UpdateRealtime error!", ex);
                Console.Write(ex.ToString());
            }
        }

        private void BtIncrease_Click(object sender, EventArgs e)
        {
            IncreaseProduct();
        }

        private void BtReduce_Click(object sender, EventArgs e)
        {
            ReduceProduct();
        }

        private void Control_FormClosed(object sender, FormClosedEventArgs e)
        {
            RecordProduction();
            ProductionSave(StateLine.STOP);
            if (ComPressPort.IsOpen)
            {
                ComPressPort.Close();
            }
            SetupDisplay();
            Application.Exit();
        }

        private void lblConfig_Click(object sender, EventArgs e)
        {
            frmConfig frmConfig = new frmConfig();
            frmConfig.updateAfterSetting = () =>
            {
                Init();
            };
            frmConfig.ShowDialog();

        }

        private void chkNG_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNG.Checked)
            {
                chkOK.Checked = false;
                TextMacBox.Enabled = false;
                txtSerial.Enabled = true;
                txtSerial.SelectAll();
                txtSerial.Focus();
            }
        }

        private void CaculatorPlan()
        {
            if (StateProduct == StateLine.RUNNING)
            {
                int sumtime = DateAndTime.Now.Hour * 100 + DateAndTime.Now.Minute;
                for (int index = 1; index <= 20; index++)
                {
                    if (index % 2 != 0)
                    {
                        var time = TimeLine[index];
                        if (sumtime >= TimeLine[index].Hour * 100 + TimeLine[index].Minute & sumtime <= TimeLine[index + 1].Hour * 100 + TimeLine[index + 1].Minute)
                        {
                            bien_dem = bien_dem + 1;
                            break;
                        }
                        else
                        {
                            bien_dem = 0;
                        }
                    }
                    else
                    {
                    }
                }

                if (bien_dem == 0)
                {
                    time_scanBarcode = DateAndTime.Now;
                }
                else
                {
                    TimeCycleActual = (int)(TimeCycleActual + (DateAndTime.Now - time_scanBarcode).TotalSeconds);
                    time_scanBarcode = DateAndTime.Now;
                    ProductPlan = (int)Math.Round(TimeCycleActual / CycleTimeModel, 0, MidpointRounding.AwayFromZero);
                    txtPlan.Text = ProductPlan.ToString();
                }
            }
        }
        private void Timer3_Tick(object sender, EventArgs e)
        {
            CaculatorPlan();
        }
        private void CompressEvent()
        {
            try
            {
                if (ComPressPort.IsOpen)
                {
                    ComPressPort.Write("B");
                    if (ComPressPort.ReadExisting() == "B")
                        BitPress = true;
                    else if (ComPressPort.ReadExisting() != "B" & BitPress == true)
                    {
                        BitPress = false;
                        IncreaseProduct();
                    }
                }

            }
            catch (Exception)
            {
            }

        }
        private void chkOK_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOK.Checked)
            {
                chkNG.Checked = false;
                TextMacBox.Enabled = false;
                txtSerial.Enabled = true;
                txtSerial.SelectAll();
                txtSerial.Focus();
            }
        }
        private bool CheckWIPOK(List<string> listBarcode)
        {
            //Kiểm tra xem đã link hết wip chưa
            foreach (var barcode in listBarcode)
            {
                if (pvsservice.GetWorkOrderItem(barcode, STATION) == null)
                {
                    return false;
                }

            }
            return true;
        }

        private void txtSerial_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string serial = txtSerial.Text.Trim();
                    if (string.IsNullOrEmpty(serial)) return;
                    if (IsPauseByTime)
                    {
                        txtSerial.Enabled = true;
                        txtSerial.Focus();
                        txtSerial.SelectAll();
                        ShowNGForm("Đang thời gian nghỉ");
                        return;
                    }

                    txtSerial.Enabled = false;
                    var listBarcode = Common.CreateBarcode(txtSerial.Text.Trim(), Model.PCB,
                        Model.ContentIndex, Model.ContentLength, Model.CheckFirst);
                    if (IDCount + listBarcode.Count > PCBBOX)
                    {
                        txtSerial.Enabled = true;
                        txtSerial.Focus();
                        txtSerial.SelectAll();
                        ShowNGForm("Vượt quá số lượng bản mạch/thùng cho phép!");
                        return;
                    }

                    // Check hang NG
                    if (chkNG.Checked)
                    {

                        var contentWip = new StringBuilder();
                        string sTime = pvsservice.GetDateTime().ToString("yyMMddHHmmss");
                        contentWip.AppendLine(string.Join("|", cbbModel.Text, txtSerial.Text.Trim(), sTime, State.F.ToString(), STATION));
                        Common.WriteLog(Path.Combine(pathWip, $"{sTime}_{txtSerial.Text.Trim()}.txt"), contentWip);
                        Common.WriteLog(Path.Combine(pathBackup, "NG", $"{sTime}_{txtSerial.Text.Trim()}.txt"), contentWip);
                        txtSerial.Enabled = true;
                        txtSerial.Focus();
                        txtSerial.SelectAll();
                        return;

                    }
                    // Hàng sửa
                    if (lblRepair.Visible)
                    {
                        bool isRepair = false;
                        foreach (var barcode in listBarcode)
                        {
                            if (pvsservice.CheckRepair(barcode))
                            {
                                isRepair = true;
                                break;
                            }
                        }
                        if (!isRepair)
                        {
                            txtSerial.Enabled = true;
                            txtSerial.Focus();
                            txtSerial.SelectAll();
                            ShowNGForm("Không có bản mạch sửa!");
                            return;
                        }

                    }

                    // validate
                    var checkValidateSerial = ValidateCommon.ValidateSerial(listBarcode, ModelCurrent);
                    if (checkValidateSerial != "OK")
                    {
                        txtSerial.Enabled = true;
                        txtSerial.Focus();
                        txtSerial.SelectAll();
                        ShowNGForm(checkValidateSerial);

                        return;
                    }
                    var orderItem = pvsservice.GetWorkOrderItemByBoardNo(serial);
                    if (orderItem != null)
                    {
                        if(WO_MES != orderItem.ORDER_NO)
                        {
                            WO_MES = orderItem.ORDER_NO;

                            if (NumberInModel == -1)
                            {
                                var workOrder = pvsservice.GetWorkOrdersByOrderNo(orderItem.ORDER_NO);
                                LabelPCS1BOX.Text = workOrder.QUANTITY.ToString();
                            }
                        }
                        
                    }
                    if (bool.Parse(Common.GetValueRegistryKey(Constants.PathConfig, RegistryKeys.LinkPathLog)))
                    {
                        // sinh ra log
                        foreach (var barcode in listBarcode)
                        {
                            try
                            {
                                var contentWip = new StringBuilder();
                                string sTime = pvsservice.GetDateTime().ToString("yyMMddHHmmss");
                                contentWip.AppendLine(string.Join("|", cbbModel.Text, barcode, sTime,
                                    chkNG.Checked ? State.F.ToString() : State.P.ToString(), STATION));
                                Common.WriteLog(Path.Combine(pathWip, $"{sTime}_{barcode}.txt"), contentWip);
                                Common.WriteLog(Path.Combine(pathBackup, chkNG.Checked ? "NG" : "OK", $"{sTime}_{barcode}.txt"), contentWip);

                            }
                            catch (Exception ex)
                            {
                                //LogFileWritter.WriteLog(@"\\172.28.10.12\Share\18 IT\U34811(hoanht)\7.ERRORS\CANON\aa.txt", "Ghi log wip bị lỗi", ex);
                                LogFileWritter.WriteLog(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Ghi log wip bị lỗi", ex);
                                return;
                            }
                        }

                        if (listBarcode.Count > 1)
                        {
                            // Kiểm tra trên wip có dữ liệu chưa

                            lblWaiting.Text = $"Wait...";
                            bgwLinkWip.RunWorkerAsync(argument: listBarcode);
                        }
                        else
                        {
                            increaseInDb(listBarcode);
                        }
                    }
                    else if (bool.Parse(Common.GetValueRegistryKey(Constants.PathConfig, RegistryKeys.LinkWip)))
                    {
                        // Link wip
                        string nameSoft = Common.FindApplication(Common.GetValueRegistryKey(Constants.PathConfig, RegistryKeys.Process));
                        int wipHandle = 0;
                        wipHandle = NativeWin32.FindWindow(null, nameSoft);
                        bool temp = Common.IsRunning(nameSoft);
                        if (!temp)
                        {
                            txtSerial.Enabled = true;
                            txtSerial.Focus();
                            txtSerial.SelectAll();
                            ShowNGForm("Chương trình WIP chưa bật!");
                            return;
                        }

                        Common.ActiveProcess(nameSoft);
                        Console.Write(nameSoft);
                        Clipboard.SetText(txtSerial.Text.Trim());
                        SendKeys.Send("^V");
                        Thread.Sleep(170);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(170);
                        Common.ActiveProcess(this.Text);
                        Thread.Sleep(220);

                        if (!ListeningWip())
                        {
                            txtSerial.Enabled = true;
                            txtSerial.Focus();
                            txtSerial.SelectAll();
                            ShowNGForm("Link WIP NG vui lòng chạy lại!");
                            return;
                        }
                        increaseInDb(listBarcode);
                    }
                    else
                    {
                        increaseInDb(listBarcode);
                    }

                }
                catch (Exception ex)
                {
                    LogFileWritter.WriteLog(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "txtSerial_PreviewKeyDown", ex);
                    return;
                }

            }

        }
        private bool ListeningWip()
        {
            for (int i = 0; i < 10; i++)
            {
                if (pvsservice.GetWorkOrderItem(txtSerial.Text, Common.GetValueRegistryKey(Constants.PathConfig, RegistryKeys.station)) != null)
                {
                    return true;
                }
                Thread.Sleep(int.Parse(Common.GetValueRegistryKey(Constants.PathConfig, RegistryKeys.SleepTime)));
            }
            return false;
        }
        private void increaseInDb(List<string> listBarcode)
        {
            using (var db = new barcode_dbEntities())
            {

                var currentStation = Common.GetValueRegistryKey(Constants.PathConfig, RegistryKeys.station);
                using (DbContextTransaction transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        foreach (var barcode in listBarcode)
                        {

                            var existItem = db.HondaLocks.Where(m => m.BoardNo == barcode && m.Station == currentStation).FirstOrDefault();
                            if (existItem != null)
                            {
                                transaction.Rollback();
                                txtSerial.Enabled = true;
                                txtSerial.Focus();
                                txtSerial.SelectAll();
                                ShowNGForm("Đã tồn tại bản mạch " + barcode);
                                return;
                            }
                            var item = new HondaLock()
                            {
                                ProductionID = cbbModel.Text.ToString(),
                                BoxID = TextMacBox.Text,
                                BoardNo = barcode,
                                UpdateTime = pvsservice.GetDateTime(),
                                Status = chkOK.Checked ? "1" : "0",
                                Updator_Code = "",
                                Updator_Name = "",
                                Line = Common.GetValueRegistryKey(Constants.PathConfig, RegistryKeys.id),
                                Repair = lblRepair.Visible,
                                ShiftDate = Datecheck + "_" + Shiftcheck,
                                Station = currentStation,
                                Wo_Sap = WO_SAP,
                                Wo_Mes = WO_MES
                            };
                            string hostname = Environment.MachineName;
                            if (!string.IsNullOrEmpty(hostname))
                            {
                                item.NamePC = hostname;
                            }
                            db.HondaLocks.Add(item);
                            db.SaveChanges();
                        }
                        transaction.Commit();

                    }
                    catch (Exception ex)
                    {
                        //LogFileWritter.WriteLog(@"\\172.28.10.12\Share\18 IT\U34811(hoanht)\7.ERRORS\CANON\aa.txt", "Thêm vào db bị lỗi", ex);
                        LogFileWritter.WriteLog(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Thêm vào db bị lỗi", ex);
                        transaction.Rollback();
                        txtSerial.Enabled = true;
                        txtSerial.Focus();
                        txtSerial.SelectAll();
                        ShowNGForm("Thêm vào DB thất bại!");
                        return;
                    }

                }


                // wip ok thì thêm vào db
                if (NumberInModel == 0)
                {
                    IDCount = db.HondaLocks.Where(m => m.BoxID == TextMacBox.Text && m.ProductionID == ModelCurrent && m.Station == currentStation).Count();
                }
                else if (NumberInModel > 0)
                {
                    IDCount += listBarcode.Count();
                }
                else
                {
                    // Trường hợp ở YAS muốn đếm theo số WO theo line
                    var line = Common.GetValueRegistryKey(Constants.PathConfig, RegistryKeys.id);
                    IDCount = db.HondaLocks.Where(m => m.Wo_Mes == WO_MES
                    && m.ProductionID == ModelCurrent
                    && m.Station == currentStation
                    && m.Line == line).Count();
                }


                LabelPCBA.Text = IDCount.ToString();

                foreach (var barcode in listBarcode)
                {
                    IncreaseProduct();
                }
                if (IDCount >= PCBBOX)
                {
                    IDCount = 0;
                    IDCount_box += 1;
                    Box_curent = "";
                    LabelSoThung.Text = IDCount_box.ToString();
                    if (NumberInModel == 0)
                    {
                        TextMacBox.Enabled = true;
                        TextMacBox.Focus();
                        txtSerial.Enabled = false;
                        TextMacBox.Clear();
                    }
                    else
                    {
                        txtSerial.Enabled = true;
                        txtSerial.Clear();
                        txtSerial.Focus();

                    }

                }
                else
                {
                    txtSerial.Enabled = true;
                    txtSerial.Focus();
                    txtSerial.SelectAll();
                }
            }

        }
        private void lblListModel_Click(object sender, EventArgs e)
        {
            var login = new fmLogin();
            login.closeForm = () =>
            {
                CheckModelList();

            };
            login.ShowDialog();
        }

        private void lblSettingTime_Click(object sender, EventArgs e)
        {
            var timeLine = new TimeDetailForm();
            timeLine.ShowDialog();
        }

        private void txtSearch_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                var text = txtSearch.Text;
                if (!string.IsNullOrEmpty(text))
                {
                    new ResultForm(text, cbbFilter.Text).ShowDialog();
                }
            }

        }

        private void bgwLinkWip_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            List<string> listBarcode = (List<string>)e.Argument;
            bool isSuccess = false;
            for (int i = 0; i < 10; i++)
            {

                //Chờ lên wip 1s
                string sleepTime = Common.GetValueRegistryKey(Constants.PathConfig, RegistryKeys.SleepTime);
                Thread.Sleep(string.IsNullOrEmpty(sleepTime) ? 0 : int.Parse(sleepTime));
                if (CheckWIPOK(listBarcode))
                {
                    isSuccess = true;
                    break;
                }

            }
            e.Result = Tuple.Create(isSuccess, listBarcode);
        }

        private void bgwLinkWip_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            Tuple<bool, List<string>> result = (Tuple<bool, List<string>>)e.Result;
            lblWaiting.Text = $"";
            if (result.Item1)
            {
                increaseInDb(result.Item2);
            }
            else
            {
                txtSerial.Enabled = true;
                txtSerial.Focus();
                txtSerial.SelectAll();
                ShowNGForm("Link Wip NG! Vui lòng chạy lại!");
                return;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button)sender;
                var index = int.Parse(btn.Name.Substring(10, btn.Name.Length - 10));

                var confirmModel = new CONFIRM_FAULT_REASON()
                {
                    Line = IdLine,
                    Model = cbbModel.Text,
                    TimeLine = Table1.Controls.Find("TextTime" + index, true)[0].Text,
                    Expect = Table1.Controls.Find("TextPlan" + index, true)[0].Text,
                    Actual = Table1.Controls.Find("TextActual" + index, true)[0].Text,
                    Balance = Table1.Controls.Find("TextBalance" + index, true)[0].Text,
                };
                string hostname = Environment.MachineName;
                if (!string.IsNullOrEmpty(hostname))
                {
                    confirmModel.HostName = hostname;
                }
                else confirmModel.HostName = "";

                var fmConfirm = new fmConfirm(confirmModel, TimeLine[1 + 2 * (index - 1)], TimeLine[2 + 2 * (index - 1)]);
                fmConfirm.closeForm = () =>
                {
                    CheckIsConfirm();
                };
                fmConfirm.ShowDialog();
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        private void timerCompress_Tick(object sender, EventArgs e)
        {
            if (BtStart.Text != "Bắt đầu")
            {
                CompressEvent();
            }
        }

        private void TextMacBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                using (var db = new barcode_dbEntities())
                {
                    MacCurrent = TextMacBox.Text.Trim();
                    if (string.IsNullOrEmpty(MacCurrent)) return;
                    var validate = ValidateCommon.ValidateBox(MacCurrent, ModelCurrent);
                    if (validate != "OK")
                    {
                        ShowNGForm(validate);
                        TextMacBox.SelectAll();
                        return;
                    }
                    IDCount = db.HondaLocks.Where(m => m.BoxID == TextMacBox.Text && m.ProductionID == ModelCurrent && m.Station == STATION).Count();
                    BOX_INFO = USAPHelper.GetBoxInfo(MacCurrent);
                    if (BOX_INFO == null || BOX_INFO.OS_QTY <= 0)
                    {
                        ShowNGForm("Mã thùng không tồn tại!");
                        TextMacBox.SelectAll();
                        return;
                    }
                    PCBBOX = (int)BOX_INFO.OS_QTY;
                    if (IDCount >= PCBBOX)
                    {
                        ShowNGForm("Thùng đã kiểm tra xong!");
                        TextMacBox.SelectAll();
                        return;
                    }
                    LabelPCS1BOX.Text = PCBBOX.ToString();
                    LabelPCBA.Text = IDCount.ToString();
                    TextMacBox.Enabled = false;
                    txtSerial.Enabled = true;
                    txtSerial.SelectAll();
                    txtSerial.Focus();
                    if (ModelSpeacials.Contains(ModelCurrent))
                    {
                        if (IDCount == 0)
                        {
                            var selectRepair = new frmSelectRepair();
                            selectRepair.CloseForm = (check) =>
                            {
                                lblRepair.Visible = check;
                            };
                            selectRepair.ShowDialog();
                        }
                        else
                        {
                            int BoxIsRepair = DataProvider.Instance.HondaLocks.BoxIsRepair(MacCurrent, cbbModel.Text);
                            if (BoxIsRepair == -1)
                            {
                                MessageBox.Show("Có lỗi xảy ra!");
                            }
                            else
                            {
                                lblRepair.Visible = BoxIsRepair == 1 ? true : false;
                            }
                        }
                    }
                }
            }
        }
    }
}

