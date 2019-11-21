using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TASK_MANAGER_PRO
{
    public partial class setTime : Form
    {
        public setTime()
        {
            InitializeComponent();
            loadStatusbar();
        }
        StatusBarPanel downTimePanel = new StatusBarPanel();
        StatusBarPanel barPanel = new StatusBarPanel();
        decimal downTime = 0;
        void loadStatusbar()
        {
            StatusBar bar = new StatusBar();
            bar.ShowPanels = true;
            bar.Panels.Add(barPanel);
            bar.Panels.Add(downTimePanel);
            downTimePanel.Text = "";
            barPanel.Text = "Waiting...";
            this.Controls.Add(bar);
        }
        private void Button_shutdown_Click(object sender, EventArgs e)
        {
            calculate();
            shutDown("-s -t" + downTime.ToString());
            barPanel.Text = "Shutting down...";
            timer1.Start();
        }

        private void NPhut_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown box = sender as NumericUpDown;
            if (box.Value >= 60)
            {
                nGio.Value++;
                box.Value = 0;
            }
        }

        private void NGiay_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown box = sender as NumericUpDown;
            if (box.Value >= 60)
            {
                nPhut.Value++;
                box.Value = 0;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            downTime--;
            downTimePanel.Text = downTime.ToString();
        }

        private void Button_restart_Click(object sender, EventArgs e)
        {
            calculate();
            shutDown("-r -t" + downTime.ToString());
            barPanel.Text = "Restarting...";
            timer1.Start();
        }

        private void Button_delete_Click(object sender, EventArgs e)
        {
            shutDown("-a");
            barPanel.Text = "Waitting...";
            downTimePanel.Text = "";
            timer1.Stop();
        }
        void calculate()
        {
            downTime = nGiay.Value + nPhut.Value * 60 + nGio.Value * 60 * 60;
        }
        void shutDown(string cmd)
        {
            System.Diagnostics.Process.Start("shutdown", cmd);
        }
    }
}
