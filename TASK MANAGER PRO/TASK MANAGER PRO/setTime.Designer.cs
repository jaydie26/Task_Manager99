namespace TASK_MANAGER_PRO
{
    partial class setTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(setTime));
            this.nGio = new System.Windows.Forms.NumericUpDown();
            this.nPhut = new System.Windows.Forms.NumericUpDown();
            this.nGiay = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_shutdown = new System.Windows.Forms.Button();
            this.button_restart = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nGio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPhut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGiay)).BeginInit();
            this.SuspendLayout();
            // 
            // nGio
            // 
            this.nGio.Location = new System.Drawing.Point(27, 26);
            this.nGio.Name = "nGio";
            this.nGio.Size = new System.Drawing.Size(86, 22);
            this.nGio.TabIndex = 0;
            // 
            // nPhut
            // 
            this.nPhut.Location = new System.Drawing.Point(187, 27);
            this.nPhut.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nPhut.Name = "nPhut";
            this.nPhut.Size = new System.Drawing.Size(86, 22);
            this.nPhut.TabIndex = 1;
            this.nPhut.ValueChanged += new System.EventHandler(this.NPhut_ValueChanged);
            // 
            // nGiay
            // 
            this.nGiay.Location = new System.Drawing.Point(347, 26);
            this.nGiay.Name = "nGiay";
            this.nGiay.Size = new System.Drawing.Size(86, 22);
            this.nGiay.TabIndex = 2;
            this.nGiay.ValueChanged += new System.EventHandler(this.NGiay_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "hour";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "minute";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(439, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "second";
            // 
            // button_shutdown
            // 
            this.button_shutdown.Location = new System.Drawing.Point(27, 76);
            this.button_shutdown.Name = "button_shutdown";
            this.button_shutdown.Size = new System.Drawing.Size(86, 39);
            this.button_shutdown.TabIndex = 6;
            this.button_shutdown.Text = "Shutdown";
            this.button_shutdown.UseVisualStyleBackColor = true;
            this.button_shutdown.Click += new System.EventHandler(this.Button_shutdown_Click);
            // 
            // button_restart
            // 
            this.button_restart.Location = new System.Drawing.Point(187, 76);
            this.button_restart.Name = "button_restart";
            this.button_restart.Size = new System.Drawing.Size(86, 39);
            this.button_restart.TabIndex = 7;
            this.button_restart.Text = "Restart";
            this.button_restart.UseVisualStyleBackColor = true;
            this.button_restart.Click += new System.EventHandler(this.Button_restart_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(347, 76);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(86, 39);
            this.button_delete.TabIndex = 8;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.Button_delete_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // setTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 165);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_restart);
            this.Controls.Add(this.button_shutdown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nGiay);
            this.Controls.Add(this.nPhut);
            this.Controls.Add(this.nGio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "setTime";
            this.Text = "Set shutdown time";
            ((System.ComponentModel.ISupportInitialize)(this.nGio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPhut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGiay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nGio;
        private System.Windows.Forms.NumericUpDown nPhut;
        private System.Windows.Forms.NumericUpDown nGiay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_shutdown;
        private System.Windows.Forms.Button button_restart;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Timer timer1;
    }
}