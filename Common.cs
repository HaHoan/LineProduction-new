using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using Newtonsoft.Json;

public enum State
{
    P,
    F
}

namespace Line_Production
{
    public partial class Common
    {
        public static List<string> CreateBarcode(string boardNo, int pcb, int contentIndex, int contentLength, bool checkFirst = false)
        {

            List<string> lst = new List<string>();
            if(pcb == 1)
            {
                lst.Add(boardNo);
                return lst;
            }
            var boardHeader = boardNo.Substring(0, contentIndex);
            var start = Convert.ToInt32(boardNo.Substring(contentIndex, contentLength));
            if (checkFirst)
            {
                while (start % pcb != 1)
                {
                    Console.WriteLine("------> " + start);
                    start--;
                }
            }
            for (int i = 0; i < pcb; i++)
            {
                var boardMid = (i + start).ToString($"D{contentLength}");
                var right = boardNo.Length - boardHeader.Length - boardMid.Length;
                var boarZen = right == 0
                    ? $"{boardHeader}{boardMid}"
                    : $"{boardHeader}{boardMid}{boardNo.Substring(boardNo.Length - right, right)}";
                lst.Add(boarZen);
            }
            return lst;
        }
        public static void ActiveProcess(string title)
        {
            Process[] processes = Process.GetProcesses();
            int windowHandle = 0;
            foreach (Process p in processes)
            {
                if (p.MainWindowTitle.Contains(title))
                {
                    windowHandle = (int)p.MainWindowHandle;
                    break;
                }

            }
            NativeWin32.SetForegroundWindow(windowHandle);
        }
        public static void WriteRegistry(string path, string keyName, string content)
        {
            var key = Registry.CurrentUser.CreateSubKey(path);
            if (!string.IsNullOrEmpty(keyName) && !string.IsNullOrEmpty(content))
            {
                key.SetValue(keyName, content);
                key.Close();
            }
        }

        public static string GetValueRegistryKey(string path, string keyName)
        {
            try
            {
                var key = Registry.CurrentUser.CreateSubKey(path);
                string value = null;
                if (key is object)
                {
                    if (key.GetValue(keyName) is object)
                    {
                        value = key.GetValue(keyName).ToString();
                        key.Close();
                        return value;
                    }
                }

                return null;
            }
            catch (Exception )
            {

                return null;
            }
          
        }

        public static bool Validate_qty(string qty)
        {
            var objRegExp = new System.Text.RegularExpressions.Regex(@"^\d+$");
            return objRegExp.Match(qty).Success;
        }

        public static string FindApplication(string NameSoft)
        {
            string astring = null;
            foreach (Process p in Process.GetProcesses())
            {
                string h = p.MainWindowTitle.ToString();
                if (h.Length > 0)
                {
                    if (h.Contains(NameSoft))
                    {
                        astring = h;
                    }
                }
            }

            return astring;
        }

        public static bool IsRunning(string nameSoft)
        {
            if (nameSoft is null)
            {
                return false;
            }

            Process[] p;
            p = Process.GetProcesses();
            foreach (var pro in p)
            {
                if (pro.MainWindowTitle.Contains(nameSoft))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Ghi log
        /// </summary>
        /// <param name="path">Đường dẫn</param>
        /// <param name="content">Nội dung cần ghi log</param>
        public static void WriteLog(string path, StringBuilder content)
        {
            using (var writer = new StreamWriter(path, true))
            {
                writer.Write(content.ToString());
            }
        }
        public static bool SendToComport(string data, Action<string> result)
        {
            try
            {
                SerialPort com = new SerialPort() { PortName = GetValueRegistryKey(Control.PathConfig, "COM") };
                if (!com.IsOpen) com.Open();
                if (com.IsOpen == true)
                {
                    com.Write(data);
                }
                com.Close();
                result(ConstantsText.OK);
                return true;
            }
            catch
            {
                result(ConstantsText.NG);
                return false;
            }

        }
    }

    public static class FileShare
    {
        public static string PASSWORD = "umcvn";
        public static string USER = @"VN\Scanner";
        public static string PATH = @"\\172.28.10.12";

        [DllImport("mpr.dll")]
        private static extern int WNetAddConnection2(NetResource netResource,
        string password, string username, int flags);

        [StructLayout(LayoutKind.Sequential)]
        public class NetResource
        {
            public ResourceScope Scope;
            public ResourceType ResourceType;
            public ResourceDisplaytype DisplayType;
            public int Usage;
            public string LocalName;
            public string RemoteName;
            public string Comment;
            public string Provider;
        }

        public enum ResourceScope : int
        {
            Connected = 1,
            GlobalNetwork,
            Remembered,
            Recent,
            Context
        };

        public enum ResourceType : int
        {
            Any = 0,
            Disk = 1,
            Print = 2,
            Reserved = 8,
        }

        public enum ResourceDisplaytype : int
        {
            Generic = 0x0,
            Domain = 0x01,
            Server = 0x02,
            Share = 0x03,
            File = 0x04,
            Group = 0x05,
            Network = 0x06,
            Root = 0x07,
            Shareadmin = 0x08,
            Directory = 0x09,
            Tree = 0x0a,
            Ndscontainer = 0x0b
        }
        public static bool Connect(string networkName, NetworkCredential credentials)
        {
            try
            {
                var netResource = new NetResource
                {
                    Scope = ResourceScope.GlobalNetwork,
                    ResourceType = ResourceType.Disk,
                    DisplayType = ResourceDisplaytype.Share,
                    RemoteName = networkName
                };

                var userName = string.IsNullOrEmpty(credentials.Domain)
                    ? credentials.UserName
                    : string.Format(@"{0}\{1}", credentials.Domain, credentials.UserName);

                var result = WNetAddConnection2(
                    netResource,
                    credentials.Password,
                    userName,
                    0);

                return result == 0;
            }
            catch (Exception e)
            {
                Console.Write(e.ToString());
                return false;
            }
        }
    }
    public class CheckExist
    {
        public static bool CheckFileExist(string strFileName)
        {
            return File.Exists(strFileName);
        }

        public static bool CheckFolderExist(string strFolderName)
        {
            return Directory.Exists(strFolderName);
        }
    }
    public class LogFileWritter
    {
        public static int WriteLog(string filePath, string message, object objData = null)
        {
            int result;
            try
            {
                string FolderName = Path.GetDirectoryName(filePath);
                bool flag = !File.Exists(filePath);
                if (flag)
                {
                    bool flag2 = !Directory.Exists(FolderName);
                    if (flag2)
                    {
                        Directory.CreateDirectory(FolderName);
                    }
                    File.Create(filePath).Close();
                }
                string writeContent = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss") + "\r\n Message: " + message + "\r\n";
                bool flag3 = objData != null;
                if (flag3)
                {
                    string objContent = JsonConvert.SerializeObject(objData, new JsonSerializerSettings
                    {
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                    });
                    writeContent = writeContent + " Data: " + objContent + "\r\n";
                }
                WriteFiles.WriteToFile(filePath, writeContent);
                long folderSize = ReadFiles.GetFileSizeSumFromDirectory(FolderName);
                bool flag4 = folderSize > 1000000L;
                if (flag4)
                {
                    LogFileWritter.CleanOldLogging(FolderName);
                }
                result = 0;
            }
            catch (Exception ex)
            {
                string test = ex.Message;
                result = -1;
            }
            return result;
        }

        public static void CleanOldLogging(string strFolderPath)
        {
            bool flag = !CheckExist.CheckFolderExist(strFolderPath);
            if (!flag)
            {
                IEnumerable<string> files = Directory.EnumerateFiles(strFolderPath);
                foreach (string file in files)
                {
                    try
                    {
                        string fileName = Path.GetFileNameWithoutExtension(file);
                        string strDateCreate = fileName.Substring(0, 8);
                        DateTime dateCreate = DateTime.ParseExact(strDateCreate, "ddMMyyyy", CultureInfo.InvariantCulture);
                        bool flag2 = DateTime.Now - dateCreate > TimeSpan.FromDays(180.0);
                        if (flag2)
                        {
                            File.Delete(file);
                        }
                    }
                    catch
                    {
                    }
                }
            }
        }
    }
    public class WriteFiles
    {
        private static Mutex mut
        {
            get;
            set;
        }

        public static void WriteToFile(string strFileFullName, string strContent)
        {
            try
            {
                if (!CheckExist.CheckFileExist(strFileFullName))
                {
                    if (!CheckExist.CheckFolderExist(Path.GetDirectoryName(strFileFullName)))
                    {
                        Directory.CreateDirectory(Path.GetDirectoryName(strFileFullName));
                    }
                    File.Create(strFileFullName).Close();
                }
            }
            catch (Exception)
            {
                return;
            }
            bool flag = false;
            string str = "";
            int tickCount = ApiFunc.GetTickCount();
            while (!flag)
            {
                try
                {
                    WriteFiles.mut = new Mutex();
                    WriteFiles.mut.WaitOne();
                    StreamWriter streamWriter = File.AppendText(strFileFullName);
                    streamWriter.WriteLine(strContent);
                    streamWriter.Close();
                    WriteFiles.mut.ReleaseMutex();
                    flag = true;
                }
                catch (Exception ex)
                {
                    WriteFiles.mut.ReleaseMutex();
                    str = ex.Message;
                }
                if (ApiFunc.GetTickCount() - tickCount > 5000)
                {
                    break;
                }
            }
            if (!flag)
            {
                MessageBox.Show("Cannot Saving Data. Error Message:\r\n" + str, "AppendCsvFile()");
            }
        }
    }
    public class ReadFiles
    {
        public static long GetFileSizeSumFromDirectory(string searchDirectory)
        {
            long result = 0L;
            if (!CheckExist.CheckFolderExist(searchDirectory))
            {
                result = -1L;
            }
            else
            {
                IEnumerable<string> enumerable = Directory.EnumerateFiles(searchDirectory);

                foreach (var item in enumerable)
                {
                    result += new FileInfo(item).Length;
                }
            }
            return result;
        }
    }
    public class ApiFunc
    {
        public static int GetTickCount()
        {
            return ApiDeclaration.GetTickCount();
        }
    }


    public class ApiDeclaration
    {
        [DllImport("kernel32.dll")]
        public static extern int GetTickCount();

        [DllImport("kernel32.dll")]
        public static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        [DllImport("kernel32.dll")]
        public static extern long WritePrivateProfileString(string lpApplicationName, string lpKeyName, string lpString, string lpFileName);
    }
}