using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Globalization;
using System.Threading;
using System.IO;
using System.Text.RegularExpressions;

namespace GHL_LinkGrabber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bgwMemProbe.DoWork += startProbe;
            bgwMemProbe.ProgressChanged += updateProbe;
        }
        public class ReadMemory
        {
            const int PROCESS_WM_READ = 0x0010;

            [DllImport("kernel32.dll")]
            public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);
            [DllImport("kernel32.dll")]
            public static extern bool ReadProcessMemory(int hProcess, long lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);

            public static string GetString(long memAddress, string procName, int chunkSize)
            {
                Process process = Process.GetProcessesByName(procName).FirstOrDefault();
                if (process == null)
                {
                    return "Program Not Found.";
                }
                else
                {
                    IntPtr processHandle = OpenProcess(PROCESS_WM_READ, false, process.Id);
                    int bytesRead = 0;
                    //List<byte> memOutput = new List<byte>();
                    byte[] memChunk = new byte[chunkSize];

                    ReadProcessMemory((int)processHandle, (long)memAddress, memChunk, chunkSize, ref bytesRead);

                    string stringOutput = Encoding.UTF8.GetString(memChunk);
                    return stringOutput;
                }
            }
        }

        private void grabLink(object sender, EventArgs e)
        {
            bgwMemProbe.RunWorkerAsync();
        }

        private void cancelProbe(object sender, EventArgs e)
        {
            bgwMemProbe.CancelAsync();
        }

        private void startProbe(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (bgwMemProbe.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    Thread.Sleep(Convert.ToInt32(numPollRate.Value));

                    long memAddress = long.Parse(txtMemAddr.Text, NumberStyles.HexNumber);
                    string memValue;
                    memValue = ReadMemory.GetString(memAddress, txtProcName.Text, Convert.ToInt32(numChunkSize.Value));

                    bgwMemProbe.ReportProgress(0, memValue);
                }
            }
        }

        private void updateProbe(object sender, ProgressChangedEventArgs e)
        {
            if (!lbLog.Items.Contains(e.UserState))
            {
                lbLog.Items.Insert(0, e.UserState);
            }
        }

        private void exportText(object sender, EventArgs e)
        {
            if (lbLog.Items.Count != 0)
            {
                sfdExport.Filter = "Text File|*.txt";
                sfdExport.ShowDialog();

                if (sfdExport.FileName != "")
                {

                    StringBuilder sb = new StringBuilder();
                    foreach (string item in lbLog.Items)
                    {
                        string deJunked;
                        deJunked = Regex.Replace(item, @"[^\u0020-\u007E]+", string.Empty); ;
                        sb.Append(deJunked + Environment.NewLine);
                    }

                    using (StreamWriter exportFile = new StreamWriter(sfdExport.FileName))
                    {
                        exportFile.Write(sb.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("Empty List!");
            }
        }
    }
}
