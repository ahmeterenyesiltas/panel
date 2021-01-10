namespace panel
{
    partial class formCarHome
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelLeftMenu = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.panelMainMenu = new System.Windows.Forms.Panel();
            this.panelDGV = new System.Windows.Forms.Panel();
            this.dataGridViewDATA = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonView = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.panelLeftMenu.SuspendLayout();
            this.panelMainMenu.SuspendLayout();
            this.panelDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDATA)).BeginInit();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1404, 40);
            this.panel1.TabIndex = 0;
            // 
            // panelLeftMenu
            // 
            this.panelLeftMenu.BackColor = System.Drawing.Color.DarkRed;
            this.panelLeftMenu.Controls.Add(this.label3);
            this.panelLeftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftMenu.Location = new System.Drawing.Point(0, 40);
            this.panelLeftMenu.Name = "panelLeftMenu";
            this.panelLeftMenu.Size = new System.Drawing.Size(235, 574);
            this.panelLeftMenu.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkRed;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(235, 110);
            this.label3.TabIndex = 0;
            this.label3.Text = "Car Managment System";
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.DarkRed;
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(235, 564);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1169, 50);
            this.panelFooter.TabIndex = 2;
            // 
            // panelMainMenu
            // 
            this.panelMainMenu.BackColor = System.Drawing.Color.White;
            this.panelMainMenu.Controls.Add(this.panelDGV);
            this.panelMainMenu.Controls.Add(this.panel2);
            this.panelMainMenu.Controls.Add(this.flowLayoutPanel1);
            this.panelMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainMenu.Location = new System.Drawing.Point(235, 40);
            this.panelMainMenu.Name = "panelMainMenu";
            this.panelMainMenu.Size = new System.Drawing.Size(1169, 524);
            this.panelMainMenu.TabIndex = 3;
            // 
            // panelDGV
            // 
            this.panelDGV.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelDGV.Controls.Add(this.dataGridViewDATA);
            this.panelDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDGV.Location = new System.Drawing.Point(0, 252);
            this.panelDGV.Name = "panelDGV";
            this.panelDGV.Size = new System.Drawing.Size(1169, 272);
            this.panelDGV.TabIndex = 2;
            // 
            // dataGridViewDATA
            // 
            this.dataGridViewDATA.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDATA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDATA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDATA.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDATA.Name = "dataGridViewDATA";
            this.dataGridViewDATA.RowHeadersWidth = 51;
            this.dataGridViewDATA.Size = new System.Drawing.Size(1169, 272);
            this.dataGridViewDATA.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkRed;
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 202);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1169, 50);
            this.panel2.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(310, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 16);
            this.lblTitle.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonView);
            this.flowLayoutPanel1.Controls.Add(this.buttonAdd);
            this.flowLayoutPanel1.Controls.Add(this.buttonUpdate);
            this.flowLayoutPanel1.Controls.Add(this.buttonDelete);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1169, 202);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // buttonDelete
            // 
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonDelete.FlatAppearance.BorderSize = 5;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDelete.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonDelete.Image = global::panel.Properties.Resources.delete_100px;
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonDelete.Location = new System.Drawing.Point(611, 23);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(23);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.buttonDelete.Size = new System.Drawing.Size(150, 150);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.button10_Click);
            // 
            // buttonView
            // 
            this.buttonView.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonView.FlatAppearance.BorderSize = 5;
            this.buttonView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonView.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonView.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonView.Image = global::panel.Properties.Resources.view_100px;
            this.buttonView.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonView.Location = new System.Drawing.Point(23, 23);
            this.buttonView.Margin = new System.Windows.Forms.Padding(23);
            this.buttonView.Name = "buttonView";
            this.buttonView.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.buttonView.Size = new System.Drawing.Size(150, 150);
            this.buttonView.TabIndex = 0;
            this.buttonView.Text = "View";
            this.buttonView.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.button7_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonAdd.FlatAppearance.BorderSize = 5;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAdd.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonAdd.Image = global::panel.Properties.Resources.add_new_100px;
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAdd.Location = new System.Drawing.Point(219, 23);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(23);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.buttonAdd.Size = new System.Drawing.Size(150, 150);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.button8_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonUpdate.FlatAppearance.BorderSize = 5;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonUpdate.Image = global::panel.Properties.Resources.update_100px;
            this.buttonUpdate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonUpdate.Location = new System.Drawing.Point(415, 23);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(23);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.buttonUpdate.Size = new System.Drawing.Size(150, 150);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.button9_Click);
            // 
            // formCarHome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1404, 614);
            this.Controls.Add(this.panelMainMenu);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelLeftMenu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formCarHome";
            this.Text = "Restaurant Managment System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formCarHome_Load);
            this.panelLeftMenu.ResumeLayout(false);
            this.panelMainMenu.ResumeLayout(false);
            this.panelDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDATA)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelLeftMenu;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelMainMenu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelDGV;
        private System.Windows.Forms.DataGridView dataGridViewDATA;
        private System.Windows.Forms.Button buttonDelete;
    }
}