namespace panel
{
    partial class floors
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
            this.catikati = new System.Windows.Forms.Button();
            this.giriskat = new System.Windows.Forms.Button();
            this.altkat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // catikati
            // 
            this.catikati.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.catikati.ForeColor = System.Drawing.Color.Red;
            this.catikati.Image = global::panel.Properties.Resources.indir;
            this.catikati.Location = new System.Drawing.Point(130, 12);
            this.catikati.Name = "catikati";
            this.catikati.Size = new System.Drawing.Size(218, 200);
            this.catikati.TabIndex = 0;
            this.catikati.Text = "Çatı Katı";
            this.catikati.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.catikati.UseVisualStyleBackColor = true;
            // 
            // giriskat
            // 
            this.giriskat.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giriskat.ForeColor = System.Drawing.Color.Red;
            this.giriskat.Image = global::panel.Properties.Resources.indir;
            this.giriskat.Location = new System.Drawing.Point(481, 151);
            this.giriskat.Name = "giriskat";
            this.giriskat.Size = new System.Drawing.Size(218, 200);
            this.giriskat.TabIndex = 1;
            this.giriskat.Text = "Giriş Katı";
            this.giriskat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.giriskat.UseVisualStyleBackColor = true;
            // 
            // altkat
            // 
            this.altkat.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.altkat.ForeColor = System.Drawing.Color.Red;
            this.altkat.Image = global::panel.Properties.Resources.indir;
            this.altkat.Location = new System.Drawing.Point(815, 306);
            this.altkat.Name = "altkat";
            this.altkat.Size = new System.Drawing.Size(218, 200);
            this.altkat.TabIndex = 2;
            this.altkat.Text = "Alt Kat";
            this.altkat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.altkat.UseVisualStyleBackColor = true;
            this.altkat.Click += new System.EventHandler(this.button3_Click);
            // 
            // floors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 534);
            this.Controls.Add(this.altkat);
            this.Controls.Add(this.giriskat);
            this.Controls.Add(this.catikati);
            this.Name = "floors";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button catikati;
        private System.Windows.Forms.Button giriskat;
        private System.Windows.Forms.Button altkat;
    }
}