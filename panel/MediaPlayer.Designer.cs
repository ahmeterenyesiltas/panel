﻿namespace panel
{
    partial class MediaPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaPlayer));
            this.pnlMedia1 = new System.Windows.Forms.Panel();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.btnMediaDelete = new System.Windows.Forms.Button();
            this.btnVolumeUp = new System.Windows.Forms.Button();
            this.btnVolumeDown = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnMediaDown = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnMediaUp = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnMediaAdd = new System.Windows.Forms.Button();
            this.listMedia = new System.Windows.Forms.ListBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.pnlMedia2 = new System.Windows.Forms.Panel();
            this.lblMedia = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pnlMedia1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.pnlMedia2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMedia1
            // 
            this.pnlMedia1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlMedia1.Controls.Add(this.trackBar2);
            this.pnlMedia1.Controls.Add(this.btnMediaDelete);
            this.pnlMedia1.Controls.Add(this.btnVolumeUp);
            this.pnlMedia1.Controls.Add(this.btnVolumeDown);
            this.pnlMedia1.Controls.Add(this.btnStart);
            this.pnlMedia1.Controls.Add(this.btnForward);
            this.pnlMedia1.Controls.Add(this.btnPause);
            this.pnlMedia1.Controls.Add(this.btnMediaDown);
            this.pnlMedia1.Controls.Add(this.btnRestart);
            this.pnlMedia1.Controls.Add(this.btnMediaUp);
            this.pnlMedia1.Controls.Add(this.btnReverse);
            this.pnlMedia1.Controls.Add(this.btnMediaAdd);
            this.pnlMedia1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMedia1.Location = new System.Drawing.Point(0, 559);
            this.pnlMedia1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlMedia1.Name = "pnlMedia1";
            this.pnlMedia1.Size = new System.Drawing.Size(1246, 85);
            this.pnlMedia1.TabIndex = 0;
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(9, 30);
            this.trackBar2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(78, 45);
            this.trackBar2.TabIndex = 11;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // btnMediaDelete
            // 
            this.btnMediaDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMediaDelete.BackgroundImage")));
            this.btnMediaDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMediaDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMediaDelete.Location = new System.Drawing.Point(1108, 15);
            this.btnMediaDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMediaDelete.Name = "btnMediaDelete";
            this.btnMediaDelete.Size = new System.Drawing.Size(56, 61);
            this.btnMediaDelete.TabIndex = 10;
            this.btnMediaDelete.UseVisualStyleBackColor = true;
            this.btnMediaDelete.Click += new System.EventHandler(this.btnMediaDelete_Click);
            // 
            // btnVolumeUp
            // 
            this.btnVolumeUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVolumeUp.BackgroundImage")));
            this.btnVolumeUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVolumeUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolumeUp.Location = new System.Drawing.Point(937, 15);
            this.btnVolumeUp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVolumeUp.Name = "btnVolumeUp";
            this.btnVolumeUp.Size = new System.Drawing.Size(56, 61);
            this.btnVolumeUp.TabIndex = 9;
            this.btnVolumeUp.UseVisualStyleBackColor = true;
            this.btnVolumeUp.Click += new System.EventHandler(this.btnVolumeUp_Click);
            // 
            // btnVolumeDown
            // 
            this.btnVolumeDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVolumeDown.BackgroundImage")));
            this.btnVolumeDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVolumeDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolumeDown.Location = new System.Drawing.Point(1005, 15);
            this.btnVolumeDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVolumeDown.Name = "btnVolumeDown";
            this.btnVolumeDown.Size = new System.Drawing.Size(56, 61);
            this.btnVolumeDown.TabIndex = 8;
            this.btnVolumeDown.UseVisualStyleBackColor = true;
            this.btnVolumeDown.Click += new System.EventHandler(this.btnVolumeDown_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStart.BackgroundImage")));
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Location = new System.Drawing.Point(608, 17);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(56, 61);
            this.btnStart.TabIndex = 7;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnForward
            // 
            this.btnForward.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnForward.BackgroundImage")));
            this.btnForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForward.Location = new System.Drawing.Point(755, 17);
            this.btnForward.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(56, 61);
            this.btnForward.TabIndex = 6;
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPause.BackgroundImage")));
            this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Location = new System.Drawing.Point(681, 17);
            this.btnPause.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(56, 61);
            this.btnPause.TabIndex = 5;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click_1);
            // 
            // btnMediaDown
            // 
            this.btnMediaDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMediaDown.BackgroundImage")));
            this.btnMediaDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMediaDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMediaDown.Location = new System.Drawing.Point(263, 15);
            this.btnMediaDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMediaDown.Name = "btnMediaDown";
            this.btnMediaDown.Size = new System.Drawing.Size(56, 61);
            this.btnMediaDown.TabIndex = 4;
            this.btnMediaDown.UseVisualStyleBackColor = true;
            this.btnMediaDown.Click += new System.EventHandler(this.btnMediaDown_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRestart.BackgroundImage")));
            this.btnRestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Location = new System.Drawing.Point(370, 15);
            this.btnRestart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(56, 61);
            this.btnRestart.TabIndex = 3;
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnMediaUp
            // 
            this.btnMediaUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMediaUp.BackgroundImage")));
            this.btnMediaUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMediaUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMediaUp.Location = new System.Drawing.Point(202, 15);
            this.btnMediaUp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMediaUp.Name = "btnMediaUp";
            this.btnMediaUp.Size = new System.Drawing.Size(56, 61);
            this.btnMediaUp.TabIndex = 2;
            this.btnMediaUp.UseVisualStyleBackColor = true;
            this.btnMediaUp.Click += new System.EventHandler(this.btnMediaUp_Click);
            // 
            // btnReverse
            // 
            this.btnReverse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReverse.BackgroundImage")));
            this.btnReverse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReverse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReverse.Location = new System.Drawing.Point(531, 17);
            this.btnReverse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(56, 61);
            this.btnReverse.TabIndex = 1;
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // btnMediaAdd
            // 
            this.btnMediaAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMediaAdd.BackgroundImage")));
            this.btnMediaAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMediaAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMediaAdd.Location = new System.Drawing.Point(113, 15);
            this.btnMediaAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMediaAdd.Name = "btnMediaAdd";
            this.btnMediaAdd.Size = new System.Drawing.Size(56, 61);
            this.btnMediaAdd.TabIndex = 0;
            this.btnMediaAdd.UseVisualStyleBackColor = true;
            this.btnMediaAdd.Click += new System.EventHandler(this.btnMediaAdd_Click);
            // 
            // listMedia
            // 
            this.listMedia.FormattingEnabled = true;
            this.listMedia.Location = new System.Drawing.Point(898, 93);
            this.listMedia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listMedia.Name = "listMedia";
            this.listMedia.Size = new System.Drawing.Size(300, 407);
            this.listMedia.TabIndex = 1;
            this.listMedia.DoubleClick += new System.EventHandler(this.listMedia_DoubleClick);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(151, 93);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(694, 470);
            this.axWindowsMediaPlayer1.TabIndex = 2;
            // 
            // pnlMedia2
            // 
            this.pnlMedia2.Controls.Add(this.lblMedia);
            this.pnlMedia2.Location = new System.Drawing.Point(82, 499);
            this.pnlMedia2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlMedia2.Name = "pnlMedia2";
            this.pnlMedia2.Size = new System.Drawing.Size(772, 93);
            this.pnlMedia2.TabIndex = 3;
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMedia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMedia.Location = new System.Drawing.Point(81, 33);
            this.lblMedia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(335, 31);
            this.lblMedia.TabIndex = 0;
            this.lblMedia.Text = "Henüz Medya Seçilmedi.";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MediaPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1246, 644);
            this.Controls.Add(this.pnlMedia1);
            this.Controls.Add(this.pnlMedia2);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.listMedia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MediaPlayer";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.MediaPlayer_Load);
            this.pnlMedia1.ResumeLayout(false);
            this.pnlMedia1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.pnlMedia2.ResumeLayout(false);
            this.pnlMedia2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMedia1;
        private System.Windows.Forms.Button btnMediaAdd;
        private System.Windows.Forms.Button btnMediaDelete;
        private System.Windows.Forms.Button btnVolumeUp;
        private System.Windows.Forms.Button btnVolumeDown;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnMediaDown;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnMediaUp;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.ListBox listMedia;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Panel pnlMedia2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.TrackBar trackBar2;
    }
}