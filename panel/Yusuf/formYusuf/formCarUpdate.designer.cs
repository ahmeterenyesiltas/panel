namespace panel
{
    partial class formCarUpdate
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
            this.tBHourRate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dTPFinish = new System.Windows.Forms.DateTimePicker();
            this.dTPStart = new System.Windows.Forms.DateTimePicker();
            this.nUDParkingNo = new System.Windows.Forms.NumericUpDown();
            this.labelMessage = new System.Windows.Forms.Label();
            this.label0 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBNumberPlate = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tBCarID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nUDParkingNo)).BeginInit();
            this.SuspendLayout();
            // 
            // tBHourRate
            // 
            this.tBHourRate.Location = new System.Drawing.Point(250, 197);
            this.tBHourRate.MaxLength = 40;
            this.tBHourRate.Name = "tBHourRate";
            this.tBHourRate.Size = new System.Drawing.Size(346, 20);
            this.tBHourRate.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(182, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Hour Rate :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(181, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Finish Time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(186, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Start Time:";
            // 
            // dTPFinish
            // 
            this.dTPFinish.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dTPFinish.Location = new System.Drawing.Point(250, 249);
            this.dTPFinish.Name = "dTPFinish";
            this.dTPFinish.Size = new System.Drawing.Size(200, 20);
            this.dTPFinish.TabIndex = 47;
            // 
            // dTPStart
            // 
            this.dTPStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dTPStart.Location = new System.Drawing.Point(250, 223);
            this.dTPStart.Name = "dTPStart";
            this.dTPStart.Size = new System.Drawing.Size(200, 20);
            this.dTPStart.TabIndex = 46;
            // 
            // nUDParkingNo
            // 
            this.nUDParkingNo.Location = new System.Drawing.Point(250, 148);
            this.nUDParkingNo.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nUDParkingNo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDParkingNo.Name = "nUDParkingNo";
            this.nUDParkingNo.Size = new System.Drawing.Size(120, 20);
            this.nUDParkingNo.TabIndex = 45;
            this.nUDParkingNo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.ForeColor = System.Drawing.Color.Black;
            this.labelMessage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelMessage.Location = new System.Drawing.Point(250, 106);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(0, 13);
            this.labelMessage.TabIndex = 43;
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Font = new System.Drawing.Font("Century", 28.2F, System.Drawing.FontStyle.Bold);
            this.label0.ForeColor = System.Drawing.Color.MediumBlue;
            this.label0.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label0.Location = new System.Drawing.Point(250, 60);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(236, 44);
            this.label0.TabIndex = 42;
            this.label0.Text = "Car Update";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(167, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Number Plate :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(178, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Parking No: ";
            // 
            // tBNumberPlate
            // 
            this.tBNumberPlate.Location = new System.Drawing.Point(250, 171);
            this.tBNumberPlate.MaxLength = 40;
            this.tBNumberPlate.Name = "tBNumberPlate";
            this.tBNumberPlate.Size = new System.Drawing.Size(346, 20);
            this.tBNumberPlate.TabIndex = 38;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.White;
            this.buttonClose.FlatAppearance.BorderSize = 2;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Image = global::panel.Properties.Resources.close_window_18px;
            this.buttonClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonClose.Location = new System.Drawing.Point(352, 275);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(96, 43);
            this.buttonClose.TabIndex = 44;
            this.buttonClose.Text = "     Close  ";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
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
            this.buttonAdd.Location = new System.Drawing.Point(250, 275);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(96, 43);
            this.buttonAdd.TabIndex = 39;
            this.buttonAdd.Text = "     Update";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(201, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Car ID :";
            // 
            // tBCarID
            // 
            this.tBCarID.Location = new System.Drawing.Point(250, 122);
            this.tBCarID.MaxLength = 40;
            this.tBCarID.Name = "tBCarID";
            this.tBCarID.Size = new System.Drawing.Size(346, 20);
            this.tBCarID.TabIndex = 53;
            // 
            // formCarUpdate
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.ControlBox = false;
            this.Controls.Add(this.tBCarID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBHourRate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dTPFinish);
            this.Controls.Add(this.dTPStart);
            this.Controls.Add(this.nUDParkingNo);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.tBNumberPlate);
            this.MaximumSize = new System.Drawing.Size(800, 400);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "formCarUpdate";
            this.Text = "Restaurant Managment System";
            ((System.ComponentModel.ISupportInitialize)(this.nUDParkingNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBHourRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dTPFinish;
        private System.Windows.Forms.DateTimePicker dTPStart;
        private System.Windows.Forms.NumericUpDown nUDParkingNo;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox tBNumberPlate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBCarID;
    }
}