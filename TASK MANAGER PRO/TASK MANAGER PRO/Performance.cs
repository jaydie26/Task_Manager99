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
using System.Management;
using System.Dynamic;

namespace TASK_MANAGER_PRO
{
    public partial class Performance : MetroFramework.Forms.MetroForm
    {
        public Performance()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
           

            float fcpu = pCPU.NextValue();
            float fram = pRAM.NextValue();
            float finternet = pINTERNET.NextValue();

            progressBarCpu.Value = (int)fcpu;
            progressBarRam.Value = (int)fram;
            progressBarInternet.Value = (int)finternet;

            labelCpu.Text = string.Format("{0:0.00}%", fcpu);
            labelRam.Text = string.Format("{0:0.00}%", fram);
            labelInternet.Text = string.Format("{0:0.00}%", finternet);
            chart1.Series["CPU"].Points.AddY(fcpu);
            chart1.Series["RAM"].Points.AddY(fram);
            chart1.Series["INTERNET"].Points.AddY(finternet);
            labelProcess.Text = string.Format("{0}", Process.GetProcesses().Length);

            Process[] processList = Process.GetProcesses();
            int threadCount = 0;
            foreach (Process proc in processList)
            {
                threadCount = threadCount + proc.Threads.Count;
            }
            labelThread.Text = string.Format("{0}", threadCount);
        }

        private void Performance_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}
