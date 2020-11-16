namespace katlarson
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
            this.zeminkat = new System.Windows.Forms.Button();
            this.giriskat = new System.Windows.Forms.Button();
            this.teraskat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // zeminkat
            // 
            this.zeminkat.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.zeminkat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.zeminkat.Image = global::katlarson.Properties.Resources.bodrumkat;
            this.zeminkat.Location = new System.Drawing.Point(1064, 354);
            this.zeminkat.Name = "zeminkat";
            this.zeminkat.Size = new System.Drawing.Size(253, 164);
            this.zeminkat.TabIndex = 2;
            this.zeminkat.Text = "Zemin Kat";
            this.zeminkat.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.zeminkat.UseVisualStyleBackColor = true;
            // 
            // giriskat
            // 
            this.giriskat.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giriskat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.giriskat.Image = global::katlarson.Properties.Resources.giris;
            this.giriskat.Location = new System.Drawing.Point(535, 183);
            this.giriskat.Name = "giriskat";
            this.giriskat.Size = new System.Drawing.Size(259, 149);
            this.giriskat.TabIndex = 1;
            this.giriskat.Text = "Giriş Kat";
            this.giriskat.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.giriskat.UseVisualStyleBackColor = true;
            // 
            // teraskat
            // 
            this.teraskat.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teraskat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.teraskat.Image = global::katlarson.Properties.Resources.teraskat;
            this.teraskat.Location = new System.Drawing.Point(-1, -1);
            this.teraskat.Name = "teraskat";
            this.teraskat.Size = new System.Drawing.Size(255, 163);
            this.teraskat.TabIndex = 0;
            this.teraskat.Text = "Teras Kat";
            this.teraskat.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.teraskat.UseVisualStyleBackColor = true;
            this.teraskat.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 530);
            this.Controls.Add(this.zeminkat);
            this.Controls.Add(this.giriskat);
            this.Controls.Add(this.teraskat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button teraskat;
        private System.Windows.Forms.Button giriskat;
        private System.Windows.Forms.Button zeminkat;
    }
}

