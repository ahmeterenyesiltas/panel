namespace panel
{
    partial class formCampaignAdd
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.label0 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.tBName = new System.Windows.Forms.TextBox();
            this.nUDDiscount = new System.Windows.Forms.NumericUpDown();
            this.dTPStart = new System.Windows.Forms.DateTimePicker();
            this.dTPFinish = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nUDDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.White;
            this.buttonClose.FlatAppearance.BorderSize = 2;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Image = global::panel.Properties.Resources.close_window_18px;
            this.buttonClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonClose.Location = new System.Drawing.Point(352, 227);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(96, 43);
            this.buttonClose.TabIndex = 18;
            this.buttonClose.Text = "     Close  ";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.ForeColor = System.Drawing.Color.Black;
            this.labelMessage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelMessage.Location = new System.Drawing.Point(251, 102);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(0, 13);
            this.labelMessage.TabIndex = 16;
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Font = new System.Drawing.Font("Century", 28.2F, System.Drawing.FontStyle.Bold);
            this.label0.ForeColor = System.Drawing.Color.MediumBlue;
            this.label0.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label0.Location = new System.Drawing.Point(250, 65);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(294, 44);
            this.label0.TabIndex = 14;
            this.label0.Text = "Campaign Add";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(161, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Discount Rate :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(201, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name: ";
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
            this.buttonAdd.Location = new System.Drawing.Point(250, 227);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(96, 43);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "     Add ";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // tBName
            // 
            this.tBName.Location = new System.Drawing.Point(250, 123);
            this.tBName.MaxLength = 40;
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(346, 20);
            this.tBName.TabIndex = 10;
            // 
            // nUDDiscount
            // 
            this.nUDDiscount.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUDDiscount.Location = new System.Drawing.Point(250, 149);
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
            this.nUDDiscount.TabIndex = 19;
            this.nUDDiscount.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // dTPStart
            // 
            this.dTPStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPStart.Location = new System.Drawing.Point(250, 175);
            this.dTPStart.Name = "dTPStart";
            this.dTPStart.Size = new System.Drawing.Size(200, 20);
            this.dTPStart.TabIndex = 20;
            // 
            // dTPFinish
            // 
            this.dTPFinish.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPFinish.Location = new System.Drawing.Point(250, 201);
            this.dTPFinish.Name = "dTPFinish";
            this.dTPFinish.Size = new System.Drawing.Size(200, 20);
            this.dTPFinish.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(184, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Start Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(179, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Finish Date:";
            // 
            // formCampaignAdd
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dTPFinish);
            this.Controls.Add(this.dTPStart);
            this.Controls.Add(this.nUDDiscount);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.tBName);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "formCampaignAdd";
            this.Text = "Restaurant Managment System";
            ((System.ComponentModel.ISupportInitialize)(this.nUDDiscount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.NumericUpDown nUDDiscount;
        private System.Windows.Forms.DateTimePicker dTPStart;
        private System.Windows.Forms.DateTimePicker dTPFinish;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}