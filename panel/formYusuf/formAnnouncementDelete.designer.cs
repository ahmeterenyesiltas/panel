namespace panel
{
    partial class formAnnouncementDelete
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.tBAnnouncementID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.White;
            this.buttonClose.FlatAppearance.BorderSize = 2;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonClose.Location = new System.Drawing.Point(352, 148);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(96, 43);
            this.buttonClose.TabIndex = 45;
            this.buttonClose.Text = "     Close  ";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.ForeColor = System.Drawing.Color.Black;
            this.labelMessage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelMessage.Location = new System.Drawing.Point(250, 106);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(0, 13);
            this.labelMessage.TabIndex = 44;
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Font = new System.Drawing.Font("Century", 28.2F, System.Drawing.FontStyle.Bold);
            this.label0.ForeColor = System.Drawing.Color.MediumBlue;
            this.label0.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label0.Location = new System.Drawing.Point(250, 60);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(429, 44);
            this.label0.TabIndex = 43;
            this.label0.Text = "Announcement Delete";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(145, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Announcement ID: ";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.White;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonAdd.FlatAppearance.BorderSize = 2;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonAdd.Location = new System.Drawing.Point(250, 148);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(96, 43);
            this.buttonAdd.TabIndex = 41;
            this.buttonAdd.Text = "     Delete";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // tBAnnouncementID
            // 
            this.tBAnnouncementID.Location = new System.Drawing.Point(250, 122);
            this.tBAnnouncementID.MaxLength = 40;
            this.tBAnnouncementID.Name = "tBAnnouncementID";
            this.tBAnnouncementID.Size = new System.Drawing.Size(346, 20);
            this.tBAnnouncementID.TabIndex = 40;
            // 
            // formAnnouncementDelete
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.tBAnnouncementID);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "formAnnouncementDelete";
            this.Text = "Restaurant Managment System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox tBAnnouncementID;
    }
}