namespace panel
{
    partial class formCarAdd
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dTPFinish = new System.Windows.Forms.DateTimePicker();
            this.dTPStart = new System.Windows.Forms.DateTimePicker();
            this.nUDParkingNo = new System.Windows.Forms.NumericUpDown();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.label0 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.tBNumberPlate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBHourRate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nUDParkingNo)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(179, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Finish Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(184, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Start Time:";
            // 
            // dTPFinish
            // 
            this.dTPFinish.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dTPFinish.Location = new System.Drawing.Point(248, 225);
            this.dTPFinish.Name = "dTPFinish";
            this.dTPFinish.Size = new System.Drawing.Size(200, 20);
            this.dTPFinish.TabIndex = 33;
            // 
            // dTPStart
            // 
            this.dTPStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dTPStart.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dTPStart.Location = new System.Drawing.Point(248, 199);
            this.dTPStart.Name = "dTPStart";
            this.dTPStart.Size = new System.Drawing.Size(200, 20);
            this.dTPStart.TabIndex = 32;
            // 
            // nUDParkingNo
            // 
            this.nUDParkingNo.Location = new System.Drawing.Point(248, 121);
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
            this.nUDParkingNo.TabIndex = 31;
            this.nUDParkingNo.Value = new decimal(new int[] {
            1,
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
            this.buttonClose.Location = new System.Drawing.Point(358, 251);
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
            this.labelMessage.Location = new System.Drawing.Point(248, 105);
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
            this.label0.Location = new System.Drawing.Point(248, 61);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(174, 44);
            this.label0.TabIndex = 28;
            this.label0.Text = "Car Add";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(165, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Number Plate :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(176, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Parking No: ";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.White;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonAdd.FlatAppearance.BorderSize = 2;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonAdd.Location = new System.Drawing.Point(248, 251);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(96, 43);
            this.buttonAdd.TabIndex = 25;
            this.buttonAdd.Text = "     Add ";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // tBNumberPlate
            // 
            this.tBNumberPlate.Location = new System.Drawing.Point(248, 147);
            this.tBNumberPlate.MaxLength = 40;
            this.tBNumberPlate.Name = "tBNumberPlate";
            this.tBNumberPlate.Size = new System.Drawing.Size(346, 20);
            this.tBNumberPlate.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(180, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Hour Rate :";
            // 
            // tBHourRate
            // 
            this.tBHourRate.Location = new System.Drawing.Point(248, 173);
            this.tBHourRate.MaxLength = 40;
            this.tBHourRate.Name = "tBHourRate";
            this.tBHourRate.Size = new System.Drawing.Size(346, 20);
            this.tBHourRate.TabIndex = 37;
            // 
            // formCarAdd
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.ControlBox = false;
            this.Controls.Add(this.tBHourRate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dTPFinish);
            this.Controls.Add(this.dTPStart);
            this.Controls.Add(this.nUDParkingNo);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.tBNumberPlate);
            this.Location = new System.Drawing.Point(800, 400);
            this.MaximumSize = new System.Drawing.Size(800, 400);
            this.Name = "formCarAdd";
            this.Text = "Restaurant Managment System";
            ((System.ComponentModel.ISupportInitialize)(this.nUDParkingNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dTPFinish;
        private System.Windows.Forms.DateTimePicker dTPStart;
        private System.Windows.Forms.NumericUpDown nUDParkingNo;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox tBNumberPlate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBHourRate;
    }
}