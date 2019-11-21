using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GetProcess();
        }

        Process[] process; // luu lai danh sach process
        void GetProcess()//ham lay danh sach process
        {
            listView1.Items.Clear();
            process = Process.GetProcesses(); // lay tat ca danh sach process luu vao mang process
            foreach(Process item in process)
            {
                ListViewItem newItem = new ListViewItem()//tao ra 1 cai listView
                {
                    Text = item.ProcessName
                };
                newItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = item.Id.ToString() });// lay id cua cac tien trinh dang chay
                newItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = BytesToReadableValue(item.PrivateMemorySize64)});//lấy thông tin dung lượng bộ nhớ đang dùng của chỉ tiến trình đó
                newItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = BytesToReadableValue(item.VirtualMemorySize64) });//lấy thông tin bộ nhớ của tiến trình đó và các tiến trình liên quan đến nó.
                newItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = item.Responding.ToString() });//lấy thông số phản hồi từ tiến trình
                newItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = item.Threads.Count.ToString() });//lấy thông số các luồng của từng tiến trình
                listView1.Items.Add(newItem);
            }
        }
        //ham quy doi cac don vi cua memory

        public string BytesToReadableValue(long number)
        {
            List<string> s = new List<string> { " B", " KB", " MB", " GB", " TB", " PB" };
            for(int i = 0; i < s.Count; i++)
            {
                long temp = number / (int)Math.Pow(1024, i + 1);
                if (temp == 0) return (number / (int)Math.Pow(1024, i)) + s[i];
            }
            return number.ToString();
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.endTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runNewTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.performanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setShutdownTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temperatureCPUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 481);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Get Tasklist";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(690, 481);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "End Task";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.endTaskToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(135, 28);
            // 
            // endTaskToolStripMenuItem
            // 
            this.endTaskToolStripMenuItem.Name = "endTaskToolStripMenuItem";
            this.endTaskToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.endTaskToolStripMenuItem.Text = "End Task";
            this.endTaskToolStripMenuItem.Click += new System.EventHandler(this.endTaskToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runNewTaskToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // runNewTaskToolStripMenuItem
            // 
            this.runNewTaskToolStripMenuItem.Name = "runNewTaskToolStripMenuItem";
            this.runNewTaskToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.runNewTaskToolStripMenuItem.Text = "Run new task";
            this.runNewTaskToolStripMenuItem.Click += new System.EventHandler(this.runNewTaskToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.performanceToolStripMenuItem,
            this.setShutdownTimeToolStripMenuItem,
            this.temperatureCPUToolStripMenuItem});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // performanceToolStripMenuItem
            // 
            this.performanceToolStripMenuItem.Name = "performanceToolStripMenuItem";
            this.performanceToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.performanceToolStripMenuItem.Text = "Performance";
            this.performanceToolStripMenuItem.Click += new System.EventHandler(this.performanceToolStripMenuItem_Click);
            // 
            // setShutdownTimeToolStripMenuItem
            // 
            this.setShutdownTimeToolStripMenuItem.Name = "setShutdownTimeToolStripMenuItem";
            this.setShutdownTimeToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.setShutdownTimeToolStripMenuItem.Text = "Set shutdown time";
            this.setShutdownTimeToolStripMenuItem.Click += new System.EventHandler(this.SetShutdownTimeToolStripMenuItem_Click);
            // 
            // temperatureCPUToolStripMenuItem
            // 
            this.temperatureCPUToolStripMenuItem.Name = "temperatureCPUToolStripMenuItem";
            this.temperatureCPUToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.temperatureCPUToolStripMenuItem.Text = "Temperature CPU";
            this.temperatureCPUToolStripMenuItem.Click += new System.EventHandler(this.TemperatureCPUToolStripMenuItem_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Process Name";
            this.columnHeader1.Width = 160;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "PID";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Private Memory";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Virtual Memory";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 152;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(0, 31);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(804, 429);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Responding";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 126;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Threads";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 152;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(804, 531);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Task Manager";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private Timer timer1;
        private IContainer components;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(process.Length != Process.GetProcesses().Length)
            {
                GetProcess();// tu dong get tasklist khi co process moi
            }
        }

        private Button button1;

        private void button1_Click(object sender, EventArgs e)
        {
            GetProcess();//xu ly button get Tasklist
        }

        private Button button2;

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)              // xu ly button end Task
                process[listView1.SelectedIndices[0]].Kill();
        }

        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem endTaskToolStripMenuItem;

        private void endTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            process[listView1.SelectedIndices[0]].Kill();//lenh end task dang ung dung dang chay
        }

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem runNewTaskToolStripMenuItem;

        private void runNewTaskToolStripMenuItem_Click(object sender, EventArgs e)//xu ly menu file
        {
            using (FormRunNewTask f = new FormRunNewTask())
            {
                if (f.ShowDialog() == DialogResult.OK)
                    GetProcess();
            }
        }
        private ToolStripMenuItem exitToolStripMenuItem;

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();//thoat chuong trinh
        }

        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ListView listView1;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ToolStripMenuItem optionToolStripMenuItem;
        private ToolStripMenuItem performanceToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip2;

        private void performanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Performance p = new Performance())
            {
                if (p.ShowDialog() == DialogResult.OK)
                    GetProcess();
            }
        }

        private ToolStripMenuItem setShutdownTimeToolStripMenuItem;

        private void SetShutdownTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setTime st = new setTime();
            st.Visible = true;
        }

        private ToolStripMenuItem temperatureCPUToolStripMenuItem;

        private void TemperatureCPUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process process = new Process();
                process.StartInfo.FileName = "C:\\Users\\Admin\\Downloads\\TASK MANAGER PRO\\TempCPU\\TempCPU\\bin\\Debug\\TempCPU.exe";
                process.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }   
}

