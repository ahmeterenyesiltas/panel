namespace panel
{
    partial class formAccountUpdate
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
            this.cBEntryMainType = new System.Windows.Forms.ComboBox();
            this.tBEntryAmount = new System.Windows.Forms.TextBox();
            this.tBEntryType = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.label0 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.tBEntryName = new System.Windows.Forms.TextBox();
            this.tBEntryID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cBEntryMainType
            // 
            this.cBEntryMainType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBEntryMainType.FormattingEnabled = true;
            this.cBEntryMainType.Items.AddRange(new object[] {
            "Gelir",
            "Gider"});
            this.cBEntryMainType.Location = new System.Drawing.Point(259, 162);
            this.cBEntryMainType.Name = "cBEntryMainType";
            this.cBEntryMainType.Size = new System.Drawing.Size(121, 21);
            this.cBEntryMainType.TabIndex = 68;
            // 
            // tBEntryAmount
            // 
            this.tBEntryAmount.Location = new System.Drawing.Point(259, 215);
            this.tBEntryAmount.MaxLength = 40;
            this.tBEntryAmount.Name = "tBEntryAmount";
            this.tBEntryAmount.Size = new System.Drawing.Size(346, 20);
            this.tBEntryAmount.TabIndex = 67;
            // 
            // tBEntryType
            // 
            this.tBEntryType.Location = new System.Drawing.Point(259, 189);
            this.tBEntryType.MaxLength = 40;
            this.tBEntryType.Name = "tBEntryType";
            this.tBEntryType.Size = new System.Drawing.Size(346, 20);
            this.tBEntryType.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(177, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 65;
            this.label5.Text = "Entry Amount :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(189, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "Entry Type :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(163, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "Entry Main Type :";
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.White;
            this.buttonClose.FlatAppearance.BorderSize = 2;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Image = global::panel.Properties.Resources.close_window_18px;
            this.buttonClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonClose.Location = new System.Drawing.Point(361, 241);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(96, 43);
            this.buttonClose.TabIndex = 62;
            this.buttonClose.Text = "     Close  ";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.ForeColor = System.Drawing.Color.Black;
            this.labelMessage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelMessage.Location = new System.Drawing.Point(259, 98);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(0, 13);
            this.labelMessage.TabIndex = 61;
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Font = new System.Drawing.Font("Century", 28.2F, System.Drawing.FontStyle.Bold);
            this.label0.ForeColor = System.Drawing.Color.MediumBlue;
            this.label0.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label0.Location = new System.Drawing.Point(259, 54);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(316, 44);
            this.label0.TabIndex = 60;
            this.label0.Text = "Account Update";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(185, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "Enrty Name :";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.White;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonAdd.FlatAppearance.BorderSize = 2;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Image = global::panel.Properties.Resources.save_18px;
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonAdd.Location = new System.Drawing.Point(259, 241);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(96, 43);
            this.buttonAdd.TabIndex = 58;
            this.buttonAdd.Text = "     Update ";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // tBEntryName
            // 
            this.tBEntryName.Location = new System.Drawing.Point(259, 137);
            this.tBEntryName.MaxLength = 40;
            this.tBEntryName.Name = "tBEntryName";
            this.tBEntryName.Size = new System.Drawing.Size(346, 20);
            this.tBEntryName.TabIndex = 57;
            // 
            // tBEntryID
            // 
            this.tBEntryID.Location = new System.Drawing.Point(259, 114);
            this.tBEntryID.MaxLength = 40;
            this.tBEntryID.Name = "tBEntryID";
            this.tBEntryID.Size = new System.Drawing.Size(346, 20);
            this.tBEntryID.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(205, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 70;
            this.label1.Text = "EnrtyID :";
            // 
            // formAccountUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBEntryID);
            this.Controls.Add(this.cBEntryMainType);
            this.Controls.Add(this.tBEntryAmount);
            this.Controls.Add(this.tBEntryType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.tBEntryName);
            this.MaximumSize = new System.Drawing.Size(800, 400);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "formAccountUpdate";
            this.Text = "formAccountUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBEntryMainType;
        private System.Windows.Forms.TextBox tBEntryAmount;
        private System.Windows.Forms.TextBox tBEntryType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox tBEntryName;
        private System.Windows.Forms.TextBox tBEntryID;
        private System.Windows.Forms.Label label1;
    }
}