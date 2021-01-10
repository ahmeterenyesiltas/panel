using System;

namespace panel
{
    partial class info
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
            this.websitemiz = new System.Windows.Forms.LinkLabel();
            this.bilgilendirme = new System.Windows.Forms.Button();
            this.hakkimizda = new System.Windows.Forms.Button();
            this.kampanya = new System.Windows.Forms.Button();
            this.yemeksepeti = new System.Windows.Forms.Button();
            this.adres = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // websitemiz
            // 
            this.websitemiz.AutoSize = true;
            this.websitemiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.websitemiz.Location = new System.Drawing.Point(1205, 622);
            this.websitemiz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.websitemiz.Name = "websitemiz";
            this.websitemiz.Size = new System.Drawing.Size(314, 25);
            this.websitemiz.TabIndex = 0;
            this.websitemiz.TabStop = true;
            this.websitemiz.Text = "web sitemize ulaşmak için tıklayınız";
            this.websitemiz.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.websitemiz_LinkClicked);
            // 
            // bilgilendirme
            // 
            this.bilgilendirme.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bilgilendirme.ForeColor = System.Drawing.Color.Red;
            this.bilgilendirme.Image = global::panel.Properties.Resources.info;
            this.bilgilendirme.Location = new System.Drawing.Point(869, 362);
            this.bilgilendirme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bilgilendirme.Name = "bilgilendirme";
            this.bilgilendirme.Size = new System.Drawing.Size(263, 235);
            this.bilgilendirme.TabIndex = 5;
            this.bilgilendirme.Text = "Bilgilendirme";
            this.bilgilendirme.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bilgilendirme.UseVisualStyleBackColor = true;
            this.bilgilendirme.Click += new System.EventHandler(this.bilgilendirme_Click);
            // 
            // hakkimizda
            // 
            this.hakkimizda.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hakkimizda.ForeColor = System.Drawing.Color.Red;
            this.hakkimizda.Image = global::panel.Properties.Resources.about_us;
            this.hakkimizda.Location = new System.Drawing.Point(1268, 4);
            this.hakkimizda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hakkimizda.Name = "hakkimizda";
            this.hakkimizda.Size = new System.Drawing.Size(276, 265);
            this.hakkimizda.TabIndex = 4;
            this.hakkimizda.Text = "Hakkımızda";
            this.hakkimizda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hakkimizda.UseVisualStyleBackColor = true;
            this.hakkimizda.Click += new System.EventHandler(this.hakkimizda_Click);
            // 
            // kampanya
            // 
            this.kampanya.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kampanya.ForeColor = System.Drawing.Color.Maroon;
            this.kampanya.Image = global::panel.Properties.Resources.indir1;
            this.kampanya.Location = new System.Drawing.Point(583, 15);
            this.kampanya.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kampanya.Name = "kampanya";
            this.kampanya.Size = new System.Drawing.Size(269, 239);
            this.kampanya.TabIndex = 3;
            this.kampanya.Text = "Kampanyalar";
            this.kampanya.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.kampanya.UseVisualStyleBackColor = true;
            this.kampanya.Click += new System.EventHandler(this.kampanya_Click);
            // 
            // yemeksepeti
            // 
            this.yemeksepeti.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yemeksepeti.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.yemeksepeti.Image = global::panel.Properties.Resources.yemeksepeti1;
            this.yemeksepeti.Location = new System.Drawing.Point(261, 370);
            this.yemeksepeti.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yemeksepeti.Name = "yemeksepeti";
            this.yemeksepeti.Size = new System.Drawing.Size(312, 226);
            this.yemeksepeti.TabIndex = 2;
            this.yemeksepeti.Text = "Tek Tık Sipariş";
            this.yemeksepeti.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.yemeksepeti.UseVisualStyleBackColor = true;
            this.yemeksepeti.Click += new System.EventHandler(this.yemeksepeti_Click);
            // 
            // adres
            // 
            this.adres.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adres.ForeColor = System.Drawing.Color.Red;
            this.adres.Image = global::panel.Properties.Resources.Googleharitalar;
            this.adres.Location = new System.Drawing.Point(3, 4);
            this.adres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(265, 250);
            this.adres.TabIndex = 1;
            this.adres.Text = "Neredeyiz?";
            this.adres.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.adres.UseVisualStyleBackColor = true;
            this.adres.Click += new System.EventHandler(this.adres_Click);
            this.adres.Enter += new System.EventHandler(this.adres_Click);
            // 
            // info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1557, 657);
            this.Controls.Add(this.bilgilendirme);
            this.Controls.Add(this.hakkimizda);
            this.Controls.Add(this.kampanya);
            this.Controls.Add(this.yemeksepeti);
            this.Controls.Add(this.adres);
            this.Controls.Add(this.websitemiz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "info";
            this.Text = "info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.LinkLabel websitemiz;
        private System.Windows.Forms.Button adres;
        private System.Windows.Forms.Button yemeksepeti;
        private System.Windows.Forms.Button kampanya;
        private System.Windows.Forms.Button hakkimizda;
        private System.Windows.Forms.Button bilgilendirme;
    }
}