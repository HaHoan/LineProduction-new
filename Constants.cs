using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Line_Production
{
    public static class Constants
    {
        public static string BaudRate = "9600";
        public static string DataBits = "8";
        public static string Parity = "None";
        public static string StopBits = "1";
        public static string SERIAL = "SERIAL";
        public static string BOXID = "BOXID";
        //public static string MODEL_SPECIAL = "QM7-1890-000SS01";
        public static string LINE_NO_WIP = "STATION-DEFAULT";
        public static string PathApplication = Application.StartupPath;
        public static string PathPassrate = PathApplication + @"\Passrate";
        public static string PathConfig = @"SOFTWARE\LINEPRODUCTION\Configs";
        public static string pathConfirm = PathApplication + @"\Confirm";

    }
    public static class ConstantsText
    {
        public static string NG = "NG";
        public static string OK = "OK";
    }

    public static class StateLine
    {
        public static string RUNNING = "RUNNING";
        public static string PAUSE = "PAUSE";
        public static string STOP = "STOP";
    }
    public static class RegistryKeys
    {
        public static string id = "id";
        public static string pathWip = "pathWip";
        public static string station = "station";
        public static string COM = "COM";
        public static string COM_PRESS = "COM_PRESS";
        public static string Customer = "Customer";
        public static string Process = "Process";
        public static string LinkPathLog = "LinkPathLog";
        public static string IsRepair = "IsRepair";
        public static string SleepTime = "SleepTime";
        public static string MODEL_SPEACIAL = "MODEL_SPEACIAL";
        public static string LinkWip = "LinkWip";
        public static string CurrentUser = "CurrentUser";
        public static string ModelCurrent = "ModelCurrent";
        public static string Customer_ID = "Customer_ID";
    }
    public static class CaSX
    {
        public static int DAY = 0;
        public static int NIGHT = 1;
    }
    public static class USEWip
    {
        public static string UsePathLog = "UsePathLog";
        public static string UseLinkWip = "UseLinkWip";
        public static string NoWip = "NoWip";
    }
   
}
