namespace PomodoroTimer
{
    partial class ConfigForm
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
            this.textBoxTaskTime = new System.Windows.Forms.TextBox();
            this.textBoxBreakTime = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.textBoxRepeatTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLongBreakTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxTaskTime
            // 
            this.textBoxTaskTime.Location = new System.Drawing.Point(160, 12);
            this.textBoxTaskTime.Name = "textBoxTaskTime";
            this.textBoxTaskTime.Size = new System.Drawing.Size(32, 19);
            this.textBoxTaskTime.TabIndex = 0;
            this.textBoxTaskTime.Text = "5";
            // 
            // textBoxBreakTime
            // 
            this.textBoxBreakTime.Location = new System.Drawing.Point(160, 48);
            this.textBoxBreakTime.Name = "textBoxBreakTime";
            this.textBoxBreakTime.Size = new System.Drawing.Size(32, 19);
            this.textBoxBreakTime.TabIndex = 1;
            this.textBoxBreakTime.Text = "1";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(65, 164);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // textBoxRepeatTime
            // 
            this.textBoxRepeatTime.Location = new System.Drawing.Point(160, 85);
            this.textBoxRepeatTime.Name = "textBoxRepeatTime";
            this.textBoxRepeatTime.Size = new System.Drawing.Size(32, 19);
            this.textBoxRepeatTime.TabIndex = 3;
            this.textBoxRepeatTime.Text = "2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "タスク";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "休憩";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "セット数";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "小休止";
            // 
            // textBoxLongBreakTime
            // 
            this.textBoxLongBreakTime.Location = new System.Drawing.Point(160, 120);
            this.textBoxLongBreakTime.Name = "textBoxLongBreakTime";
            this.textBoxLongBreakTime.Size = new System.Drawing.Size(32, 19);
            this.textBoxLongBreakTime.TabIndex = 8;
            this.textBoxLongBreakTime.Text = "3";
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 199);
            this.Controls.Add(this.textBoxLongBreakTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRepeatTime);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxBreakTime);
            this.Controls.Add(this.textBoxTaskTime);
            this.Name = "ConfigForm";
            this.Text = "ConfigForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfigForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTaskTime;
        private System.Windows.Forms.TextBox textBoxBreakTime;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox textBoxRepeatTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxLongBreakTime;
    }
}