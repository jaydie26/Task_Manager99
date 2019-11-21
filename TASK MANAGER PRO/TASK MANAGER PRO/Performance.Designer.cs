namespace TASK_MANAGER_PRO
{
    partial class Performance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pCPU = new System.Diagnostics.PerformanceCounter();
            this.pRAM = new System.Diagnostics.PerformanceCounter();
            this.pINTERNET = new System.Diagnostics.PerformanceCounter();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.progressBarCpu = new System.Windows.Forms.ProgressBar();
            this.progressBarRam = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBarInternet = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCpu = new System.Windows.Forms.Label();
            this.labelRam = new System.Windows.Forms.Label();
            this.labelInternet = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelProcess = new System.Windows.Forms.Label();
            this.labelThread = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pINTERNET)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // pCPU
            // 
            this.pCPU.CategoryName = "Processor";
            this.pCPU.CounterName = "% Processor Time";
            this.pCPU.InstanceName = "_Total";
            // 
            // pRAM
            // 
            this.pRAM.CategoryName = "Memory";
            this.pRAM.CounterName = "% Committed Bytes In Use";
            // 
            // pINTERNET
            // 
            this.pINTERNET.CategoryName = "IPv4";
            this.pINTERNET.CounterName = "Datagrams Received/sec";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPU";
            // 
            // progressBarCpu
            // 
            this.progressBarCpu.Location = new System.Drawing.Point(154, 94);
            this.progressBarCpu.Name = "progressBarCpu";
            this.progressBarCpu.Size = new System.Drawing.Size(185, 31);
            this.progressBarCpu.TabIndex = 1;
            // 
            // progressBarRam
            // 
            this.progressBarRam.Location = new System.Drawing.Point(154, 142);
            this.progressBarRam.Name = "progressBarRam";
            this.progressBarRam.Size = new System.Drawing.Size(185, 31);
            this.progressBarRam.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "RAM";
            // 
            // progressBarInternet
            // 
            this.progressBarInternet.Location = new System.Drawing.Point(154, 192);
            this.progressBarInternet.Name = "progressBarInternet";
            this.progressBarInternet.Size = new System.Drawing.Size(185, 31);
            this.progressBarInternet.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "INTERNET";
            // 
            // labelCpu
            // 
            this.labelCpu.AutoSize = true;
            this.labelCpu.Location = new System.Drawing.Point(367, 108);
            this.labelCpu.Name = "labelCpu";
            this.labelCpu.Size = new System.Drawing.Size(28, 17);
            this.labelCpu.TabIndex = 6;
            this.labelCpu.Text = "0%";
            // 
            // labelRam
            // 
            this.labelRam.AutoSize = true;
            this.labelRam.Location = new System.Drawing.Point(367, 156);
            this.labelRam.Name = "labelRam";
            this.labelRam.Size = new System.Drawing.Size(28, 17);
            this.labelRam.TabIndex = 7;
            this.labelRam.Text = "0%";
            // 
            // labelInternet
            // 
            this.labelInternet.AutoSize = true;
            this.labelInternet.Location = new System.Drawing.Point(367, 206);
            this.labelInternet.Name = "labelInternet";
            this.labelInternet.Size = new System.Drawing.Size(28, 17);
            this.labelInternet.TabIndex = 8;
            this.labelInternet.Text = "0%";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(84, 229);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "CPU";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "RAM";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "INTERNET";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(534, 247);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(423, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Process:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(423, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Thread:";
            // 
            // labelProcess
            // 
            this.labelProcess.AutoSize = true;
            this.labelProcess.Location = new System.Drawing.Point(533, 108);
            this.labelProcess.Name = "labelProcess";
            this.labelProcess.Size = new System.Drawing.Size(16, 17);
            this.labelProcess.TabIndex = 12;
            this.labelProcess.Text = "0";
            // 
            // labelThread
            // 
            this.labelThread.AutoSize = true;
            this.labelThread.Location = new System.Drawing.Point(533, 156);
            this.labelThread.Name = "labelThread";
            this.labelThread.Size = new System.Drawing.Size(16, 17);
            this.labelThread.TabIndex = 13;
            this.labelThread.Text = "0";
            // 
            // Performance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 475);
            this.Controls.Add(this.labelThread);
            this.Controls.Add(this.labelProcess);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.labelInternet);
            this.Controls.Add(this.labelRam);
            this.Controls.Add(this.labelCpu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBarInternet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBarRam);
            this.Controls.Add(this.progressBarCpu);
            this.Controls.Add(this.label1);
            this.Name = "Performance";
            this.Text = "Performance";
            this.Load += new System.EventHandler(this.Performance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pINTERNET)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Diagnostics.PerformanceCounter pCPU;
        private System.Diagnostics.PerformanceCounter pRAM;
        private System.Diagnostics.PerformanceCounter pINTERNET;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBarCpu;
        private System.Windows.Forms.ProgressBar progressBarRam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBarInternet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCpu;
        private System.Windows.Forms.Label labelRam;
        private System.Windows.Forms.Label labelInternet;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelProcess;
        private System.Windows.Forms.Label labelThread;
    }
}