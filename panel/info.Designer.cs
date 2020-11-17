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
            this.websitemiz.Location = new System.Drawing.Point(904, 505);
            this.websitemiz.Name = "websitemiz";
            this.websitemiz.Size = new System.Drawing.Size(252, 20);
            this.websitemiz.TabIndex = 0;
            this.websitemiz.TabStop = true;
            this.websitemiz.Text = "web sitemize ulaşmak için tıklayınız";
            // 
            // bilgilendirme
            // 
            this.bilgilendirme.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bilgilendirme.ForeColor = System.Drawing.Color.Red;
            this.bilgilendirme.Image = global::panel.Properties.Resources.info;
            this.bilgilendirme.Location = new System.Drawing.Point(652, 294);
            this.bilgilendirme.Name = "bilgilendirme";
            this.bilgilendirme.Size = new System.Drawing.Size(197, 191);
            this.bilgilendirme.TabIndex = 5;
            this.bilgilendirme.Text = "Bilgilendirme";
            this.bilgilendirme.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bilgilendirme.UseVisualStyleBackColor = true;
            // 
            // hakkimizda
            // 
            this.hakkimizda.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hakkimizda.ForeColor = System.Drawing.Color.Red;
            this.hakkimizda.Image = global::panel.Properties.Resources.about_us;
            this.hakkimizda.Location = new System.Drawing.Point(846, 3);
            this.hakkimizda.Name = "hakkimizda";
            this.hakkimizda.Size = new System.Drawing.Size(207, 215);
            this.hakkimizda.TabIndex = 4;
            this.hakkimizda.Text = "Hakkımızda";
            this.hakkimizda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hakkimizda.UseVisualStyleBackColor = true;
            // 
            // kampanya
            // 
            this.kampanya.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kampanya.ForeColor = System.Drawing.Color.Red;
            this.kampanya.Image = global::panel.Properties.Resources.kampanya;
            this.kampanya.ImageKey = "(yok)";
            this.kampanya.Location = new System.Drawing.Point(437, 12);
            this.kampanya.Name = "kampanya";
            this.kampanya.Size = new System.Drawing.Size(202, 194);
            this.kampanya.TabIndex = 3;
            this.kampanya.Text = "Kampanyalar";
            this.kampanya.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.kampanya.UseVisualStyleBackColor = true;
            // 
            // yemeksepeti
            // 
            this.yemeksepeti.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yemeksepeti.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.yemeksepeti.Image = global::panel.Properties.Resources.yemeksepeti1;
            this.yemeksepeti.Location = new System.Drawing.Point(196, 301);
            this.yemeksepeti.Name = "yemeksepeti";
            this.yemeksepeti.Size = new System.Drawing.Size(234, 184);
            this.yemeksepeti.TabIndex = 2;
            this.yemeksepeti.Text = "Tek Tık Sipariş";
            this.yemeksepeti.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.yemeksepeti.UseVisualStyleBackColor = true;
            // 
            // adres
            // 
            this.adres.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adres.ForeColor = System.Drawing.Color.Red;
            this.adres.Image = global::panel.Properties.Resources.Googleharitalar;
            this.adres.Location = new System.Drawing.Point(2, 3);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(199, 203);
            this.adres.TabIndex = 1;
            this.adres.Text = "Neredeyiz?";
            this.adres.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.adres.UseVisualStyleBackColor = true;
            // 
            // info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 534);
            this.Controls.Add(this.bilgilendirme);
            this.Controls.Add(this.hakkimizda);
            this.Controls.Add(this.kampanya);
            this.Controls.Add(this.yemeksepeti);
            this.Controls.Add(this.adres);
            this.Controls.Add(this.websitemiz);
            this.Name = "info";
            this.Text = "Form2";
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