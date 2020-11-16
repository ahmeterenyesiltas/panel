namespace info
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.websitemiz = new System.Windows.Forms.LinkLabel();
            this.info = new System.Windows.Forms.Button();
            this.yemeksepeti = new System.Windows.Forms.Button();
            this.kampanya = new System.Windows.Forms.Button();
            this.googlemaps = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // websitemiz
            // 
            this.websitemiz.AutoSize = true;
            this.websitemiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.websitemiz.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.websitemiz.Location = new System.Drawing.Point(1111, 9);
            this.websitemiz.Name = "websitemiz";
            this.websitemiz.Size = new System.Drawing.Size(343, 33);
            this.websitemiz.TabIndex = 1;
            this.websitemiz.TabStop = true;
            this.websitemiz.Text = "web sitemiz için tıklayınız";
            // 
            // info
            // 
            this.info.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.info.ForeColor = System.Drawing.Color.Red;
            this.info.Image = global::info.Properties.Resources.info;
            this.info.Location = new System.Drawing.Point(1051, 335);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(207, 205);
            this.info.TabIndex = 5;
            this.info.Text = "Hakkımızda";
            this.info.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.info.UseVisualStyleBackColor = true;
            // 
            // yemeksepeti
            // 
            this.yemeksepeti.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yemeksepeti.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.yemeksepeti.Image = global::info.Properties.Resources.yemeksepeti;
            this.yemeksepeti.Location = new System.Drawing.Point(688, 0);
            this.yemeksepeti.Name = "yemeksepeti";
            this.yemeksepeti.Size = new System.Drawing.Size(230, 221);
            this.yemeksepeti.TabIndex = 4;
            this.yemeksepeti.Text = "Tek Tık Sipariş";
            this.yemeksepeti.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.yemeksepeti.UseVisualStyleBackColor = true;
            // 
            // kampanya
            // 
            this.kampanya.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kampanya.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kampanya.Image = global::info.Properties.Resources.kampanya;
            this.kampanya.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.kampanya.Location = new System.Drawing.Point(303, 335);
            this.kampanya.Name = "kampanya";
            this.kampanya.Size = new System.Drawing.Size(207, 198);
            this.kampanya.TabIndex = 2;
            this.kampanya.Text = "Kampanyalar";
            this.kampanya.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.kampanya.UseVisualStyleBackColor = true;
            // 
            // googlemaps
            // 
            this.googlemaps.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.googlemaps.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.googlemaps.Image = global::info.Properties.Resources.Googleharitalar;
            this.googlemaps.Location = new System.Drawing.Point(12, 1);
            this.googlemaps.Name = "googlemaps";
            this.googlemaps.Size = new System.Drawing.Size(204, 221);
            this.googlemaps.TabIndex = 0;
            this.googlemaps.Text = "Neredeyiz?";
            this.googlemaps.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.googlemaps.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 552);
            this.Controls.Add(this.info);
            this.Controls.Add(this.yemeksepeti);
            this.Controls.Add(this.kampanya);
            this.Controls.Add(this.websitemiz);
            this.Controls.Add(this.googlemaps);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button googlemaps;
        private System.Windows.Forms.LinkLabel websitemiz;
        private System.Windows.Forms.Button kampanya;
        private System.Windows.Forms.Button yemeksepeti;
        private System.Windows.Forms.Button info;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

