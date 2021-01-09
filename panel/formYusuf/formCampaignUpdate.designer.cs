namespace panel
{
    partial class formCampaignUpdate
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
            this.nUDDiscount = new System.Windows.Forms.NumericUpDown();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.label0 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.tBName = new System.Windows.Forms.TextBox();
            this.tBID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nUDDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // nUDDiscount
            // 
            this.nUDDiscount.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUDDiscount.Location = new System.Drawing.Point(250, 174);
            this.nUDDiscount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nUDDiscount.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nUDDiscount.Name = "nUDDiscount";
            this.nUDDiscount.Size = new System.Drawing.Size(120, 20);
            this.nUDDiscount.TabIndex = 31;
            this.nUDDiscount.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.White;
            this.buttonClose.FlatAppearance.BorderSize = 2;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonClose.Location = new System.Drawing.Point(352, 200);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(96, 43);
            this.buttonClose.TabIndex = 30;
            this.buttonClose.Text = "     Close  ";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.ForeColor = System.Drawing.Color.Black;
            this.labelMessage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelMessage.Location = new System.Drawing.Point(250, 104);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(0, 13);
            this.labelMessage.TabIndex = 29;
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Font = new System.Drawing.Font("Century", 28.2F, System.Drawing.FontStyle.Bold);
            this.label0.ForeColor = System.Drawing.Color.MediumBlue;
            this.label0.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label0.Location = new System.Drawing.Point(250, 60);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(356, 44);
            this.label0.TabIndex = 28;
            this.label0.Text = "Campaign Update";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(163, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Discount Rate :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(153, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Campaign Name: ";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.White;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonAdd.FlatAppearance.BorderSize = 2;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonAdd.Location = new System.Drawing.Point(250, 200);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(96, 43);
            this.buttonAdd.TabIndex = 25;
            this.buttonAdd.Text = "     Update ";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // tBName
            // 
            this.tBName.Location = new System.Drawing.Point(250, 148);
            this.tBName.MaxLength = 40;
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(346, 20);
            this.tBName.TabIndex = 24;
            // 
            // tBID
            // 
            this.tBID.Location = new System.Drawing.Point(250, 122);
            this.tBID.MaxLength = 40;
            this.tBID.Name = "tBID";
            this.tBID.Size = new System.Drawing.Size(346, 20);
            this.tBID.TabIndex = 36;
            this.tBID.TextChanged += new System.EventHandler(this.tBID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(170, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Campaign ID: ";
            // 
            // formCampaignUpdate
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBID);
            this.Controls.Add(this.nUDDiscount);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.tBName);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "formCampaignUpdate";
            this.Text = "Restaurant Managment System";
            ((System.ComponentModel.ISupportInitialize)(this.nUDDiscount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown nUDDiscount;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.TextBox tBID;
        private System.Windows.Forms.Label label1;
    }
}