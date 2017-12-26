namespace SecurityApp.Forms
{
    partial class frmSecurityApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSecurityCode = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lsbAccessLog = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Security Code";
            // 
            // txtSecurityCode
            // 
            this.txtSecurityCode.Location = new System.Drawing.Point(115, 13);
            this.txtSecurityCode.Name = "txtSecurityCode";
            this.txtSecurityCode.Size = new System.Drawing.Size(195, 22);
            this.txtSecurityCode.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(121, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(171, 52);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(44, 45);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Olive;
            this.button4.Location = new System.Drawing.Point(221, 52);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(44, 45);
            this.button4.TabIndex = 2;
            this.button4.Text = "C";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(71, 103);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(44, 45);
            this.button5.TabIndex = 2;
            this.button5.Text = "4";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(121, 103);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(44, 45);
            this.button6.TabIndex = 2;
            this.button6.Text = "5";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(171, 103);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(44, 45);
            this.button7.TabIndex = 2;
            this.button7.Text = "6";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button8.Location = new System.Drawing.Point(221, 103);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(44, 45);
            this.button8.TabIndex = 2;
            this.button8.Text = "#";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.btnAccess_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(71, 154);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(44, 45);
            this.button9.TabIndex = 2;
            this.button9.Text = "7";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(121, 154);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(44, 45);
            this.button10.TabIndex = 2;
            this.button10.Text = "8";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(171, 154);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(44, 45);
            this.button11.TabIndex = 2;
            this.button11.Text = "9";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(221, 154);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(44, 45);
            this.button12.TabIndex = 2;
            this.button12.Text = "0";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Acess Log:";
            // 
            // lsbAccessLog
            // 
            this.lsbAccessLog.FormattingEnabled = true;
            this.lsbAccessLog.ItemHeight = 16;
            this.lsbAccessLog.Location = new System.Drawing.Point(16, 250);
            this.lsbAccessLog.Name = "lsbAccessLog";
            this.lsbAccessLog.Size = new System.Drawing.Size(336, 164);
            this.lsbAccessLog.TabIndex = 3;
            // 
            // frmSecurityApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 419);
            this.Controls.Add(this.lsbAccessLog);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSecurityCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSecurityApp";
            this.Text = "frmSecurityApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSecurityCode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lsbAccessLog;
    }
}