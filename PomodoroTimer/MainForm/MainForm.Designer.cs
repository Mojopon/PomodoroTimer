namespace PomodoroTimer
{
    partial class MainForm
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
            this.labelMinute = new System.Windows.Forms.Label();
            this.separationLabel = new System.Windows.Forms.Label();
            this.labelSecond = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.buttonStart = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMinute
            // 
            this.labelMinute.AutoSize = true;
            this.labelMinute.BackColor = System.Drawing.Color.White;
            this.labelMinute.Font = new System.Drawing.Font("MS UI Gothic", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelMinute.Location = new System.Drawing.Point(21, 34);
            this.labelMinute.Name = "labelMinute";
            this.labelMinute.Size = new System.Drawing.Size(77, 53);
            this.labelMinute.TabIndex = 0;
            this.labelMinute.Text = "00";
            // 
            // separationLabel
            // 
            this.separationLabel.AutoSize = true;
            this.separationLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.separationLabel.Font = new System.Drawing.Font("MS UI Gothic", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.separationLabel.Location = new System.Drawing.Point(86, 34);
            this.separationLabel.Name = "separationLabel";
            this.separationLabel.Size = new System.Drawing.Size(34, 53);
            this.separationLabel.TabIndex = 1;
            this.separationLabel.Text = ":";
            // 
            // labelSecond
            // 
            this.labelSecond.AutoSize = true;
            this.labelSecond.BackColor = System.Drawing.Color.White;
            this.labelSecond.Font = new System.Drawing.Font("MS UI Gothic", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelSecond.Location = new System.Drawing.Point(104, 34);
            this.labelSecond.Name = "labelSecond";
            this.labelSecond.Size = new System.Drawing.Size(77, 53);
            this.labelSecond.TabIndex = 2;
            this.labelSecond.Text = "00";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.tick);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(62, 100);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuConfig});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(197, 26);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuConfig
            // 
            this.toolStripMenuConfig.Name = "toolStripMenuConfig";
            this.toolStripMenuConfig.Size = new System.Drawing.Size(56, 22);
            this.toolStripMenuConfig.Text = "Config";
            this.toolStripMenuConfig.Click += new System.EventHandler(this.ConfigMenuClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 137);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelSecond);
            this.Controls.Add(this.separationLabel);
            this.Controls.Add(this.labelMinute);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMinute;
        private System.Windows.Forms.Label separationLabel;
        private System.Windows.Forms.Label labelSecond;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuConfig;
    }
}

