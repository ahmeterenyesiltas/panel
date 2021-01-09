namespace panel
{
    partial class formAnnouncementUpdate
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
            this.rTBText = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.label0 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.tBName = new System.Windows.Forms.TextBox();
            this.tBID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rTBText
            // 
            this.rTBText.Location = new System.Drawing.Point(250, 174);
            this.rTBText.Name = "rTBText";
            this.rTBText.Size = new System.Drawing.Size(344, 96);
            this.rTBText.TabIndex = 41;
            this.rTBText.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(210, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Text: ";
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.White;
            this.buttonClose.FlatAppearance.BorderSize = 2;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonClose.Location = new System.Drawing.Point(360, 276);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(96, 43);
            this.buttonClose.TabIndex = 39;
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
            this.labelMessage.TabIndex = 38;
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Font = new System.Drawing.Font("Century", 28.2F, System.Drawing.FontStyle.Bold);
            this.label0.ForeColor = System.Drawing.Color.MediumBlue;
            this.label0.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label0.Location = new System.Drawing.Point(250, 60);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(445, 44);
            this.label0.TabIndex = 37;
            this.label0.Text = "Announcement Update";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(203, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Name: ";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.White;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonAdd.FlatAppearance.BorderSize = 2;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonAdd.Location = new System.Drawing.Point(250, 276);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(96, 43);
            this.buttonAdd.TabIndex = 35;
            this.buttonAdd.Text = "     Update";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // tBName
            // 
            this.tBName.Location = new System.Drawing.Point(250, 148);
            this.tBName.MaxLength = 40;
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(346, 20);
            this.tBName.TabIndex = 34;
            // 
            // tBID
            // 
            this.tBID.Location = new System.Drawing.Point(250, 122);
            this.tBID.MaxLength = 40;
            this.tBID.Name = "tBID";
            this.tBID.Size = new System.Drawing.Size(346, 20);
            this.tBID.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(145, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Announcement ID: ";
            // 
            // formAnnouncementUpdate
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBID);
            this.Controls.Add(this.rTBText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.tBName);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "formAnnouncementUpdate";
            this.Text = "Restaurant Managment System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rTBText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.TextBox tBID;
        private System.Windows.Forms.Label label1;
    }
}