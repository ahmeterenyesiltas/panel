﻿namespace panel
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button12 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.button13);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 707);
            this.panel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(43, 105);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 31);
            this.button3.TabIndex = 2;
            this.button3.Text = "Main Menu";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(43, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "İkinci Form";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Birinci Form";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(197, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1378, 105);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button12);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1178, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 105);
            this.panel4.TabIndex = 1;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Maroon;
            this.button12.Location = new System.Drawing.Point(79, 19);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(92, 47);
            this.button12.TabIndex = 3;
            this.button12.Text = "ÇIKIŞ";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Maroon;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.panel3.Location = new System.Drawing.Point(197, 105);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1378, 602);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(92, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(775, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "RMS TEST GITHUB TEST ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(265, 185);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(359, 185);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(457, 185);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(551, 185);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(265, 228);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 8;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(359, 228);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 9;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(457, 228);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 10;
            this.button10.Text = "button10";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(551, 228);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 11;
            this.button11.Text = "button11";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(43, 228);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(112, 34);
            this.button13.TabIndex = 3;
            this.button13.Text = "Medya ";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1575, 707);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button13;
    }
}

