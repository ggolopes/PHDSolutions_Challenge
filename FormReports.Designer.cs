namespace PHD_ChallengeDesktop
{
    partial class FormReports
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
            this.lblTitleProjects = new System.Windows.Forms.Label();
            this.lblTitleProjectPurchases = new System.Windows.Forms.Label();
            this.lblTitleUsers = new System.Windows.Forms.Label();
            this.lblTitleParts = new System.Windows.Forms.Label();
            this.lblTitleTotal = new System.Windows.Forms.Label();
            this.dbgvPurchases = new System.Windows.Forms.DataGridView();
            this.dbgvProjects = new System.Windows.Forms.DataGridView();
            this.dbgvUsers = new System.Windows.Forms.DataGridView();
            this.dbgvParts = new System.Windows.Forms.DataGridView();
            this.dbgvTotal = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.lblTitleProjectName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbgvPurchases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbgvProjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbgvParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbgvTotal)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitleProjects
            // 
            this.lblTitleProjects.AutoSize = true;
            this.lblTitleProjects.Location = new System.Drawing.Point(12, 34);
            this.lblTitleProjects.Name = "lblTitleProjects";
            this.lblTitleProjects.Size = new System.Drawing.Size(78, 25);
            this.lblTitleProjects.TabIndex = 1;
            this.lblTitleProjects.Text = "Projects:";
            // 
            // lblTitleProjectPurchases
            // 
            this.lblTitleProjectPurchases.AutoSize = true;
            this.lblTitleProjectPurchases.Location = new System.Drawing.Point(568, 265);
            this.lblTitleProjectPurchases.Name = "lblTitleProjectPurchases";
            this.lblTitleProjectPurchases.Size = new System.Drawing.Size(161, 25);
            this.lblTitleProjectPurchases.TabIndex = 3;
            this.lblTitleProjectPurchases.Text = "Projects Purchases:";
            // 
            // lblTitleUsers
            // 
            this.lblTitleUsers.AutoSize = true;
            this.lblTitleUsers.Location = new System.Drawing.Point(555, 664);
            this.lblTitleUsers.Name = "lblTitleUsers";
            this.lblTitleUsers.Size = new System.Drawing.Size(271, 25);
            this.lblTitleUsers.TabIndex = 5;
            this.lblTitleUsers.Text = "Users that have made purchases:";
            // 
            // lblTitleParts
            // 
            this.lblTitleParts.AutoSize = true;
            this.lblTitleParts.Location = new System.Drawing.Point(1052, 664);
            this.lblTitleParts.Name = "lblTitleParts";
            this.lblTitleParts.Size = new System.Drawing.Size(141, 25);
            this.lblTitleParts.TabIndex = 7;
            this.lblTitleParts.Text = "Parts purchased:";
            // 
            // lblTitleTotal
            // 
            this.lblTitleTotal.AutoSize = true;
            this.lblTitleTotal.Location = new System.Drawing.Point(1200, 55);
            this.lblTitleTotal.Name = "lblTitleTotal";
            this.lblTitleTotal.Size = new System.Drawing.Size(225, 25);
            this.lblTitleTotal.TabIndex = 8;
            this.lblTitleTotal.Text = "Total cost off all purchases:";
            this.lblTitleTotal.Click += new System.EventHandler(this.lblTitleTotal_Click);
            // 
            // dbgvPurchases
            // 
            this.dbgvPurchases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgvPurchases.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dbgvPurchases.Location = new System.Drawing.Point(555, 296);
            this.dbgvPurchases.Name = "dbgvPurchases";
            this.dbgvPurchases.RowHeadersWidth = 62;
            this.dbgvPurchases.RowTemplate.Height = 33;
            this.dbgvPurchases.Size = new System.Drawing.Size(1275, 353);
            this.dbgvPurchases.TabIndex = 10;
            // 
            // dbgvProjects
            // 
            this.dbgvProjects.AllowUserToAddRows = false;
            this.dbgvProjects.AllowUserToDeleteRows = false;
            this.dbgvProjects.AllowUserToResizeColumns = false;
            this.dbgvProjects.AllowUserToResizeRows = false;
            this.dbgvProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgvProjects.Location = new System.Drawing.Point(15, 65);
            this.dbgvProjects.Name = "dbgvProjects";
            this.dbgvProjects.RowHeadersWidth = 62;
            this.dbgvProjects.RowTemplate.Height = 33;
            this.dbgvProjects.Size = new System.Drawing.Size(524, 863);
            this.dbgvProjects.TabIndex = 11;
            this.dbgvProjects.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbgvProjects_CellClick);
            this.dbgvProjects.CurrentCellChanged += new System.EventHandler(this.dbgvProjects_CurrentCellChanged);
            this.dbgvProjects.SelectionChanged += new System.EventHandler(this.dbgvProjects_SelectionChanged);
            // 
            // dbgvUsers
            // 
            this.dbgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgvUsers.Location = new System.Drawing.Point(555, 692);
            this.dbgvUsers.Name = "dbgvUsers";
            this.dbgvUsers.RowHeadersWidth = 62;
            this.dbgvUsers.RowTemplate.Height = 33;
            this.dbgvUsers.Size = new System.Drawing.Size(491, 235);
            this.dbgvUsers.TabIndex = 12;
            // 
            // dbgvParts
            // 
            this.dbgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgvParts.Location = new System.Drawing.Point(1052, 692);
            this.dbgvParts.Name = "dbgvParts";
            this.dbgvParts.RowHeadersWidth = 62;
            this.dbgvParts.RowTemplate.Height = 33;
            this.dbgvParts.Size = new System.Drawing.Size(778, 235);
            this.dbgvParts.TabIndex = 13;
            // 
            // dbgvTotal
            // 
            this.dbgvTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgvTotal.Location = new System.Drawing.Point(1200, 86);
            this.dbgvTotal.Name = "dbgvTotal";
            this.dbgvTotal.RowHeadersWidth = 62;
            this.dbgvTotal.RowTemplate.Height = 33;
            this.dbgvTotal.Size = new System.Drawing.Size(630, 152);
            this.dbgvTotal.TabIndex = 14;
            this.dbgvTotal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbgvTotal_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.lblProjectName);
            this.panel1.Controls.Add(this.lblTitleProjectName);
            this.panel1.Location = new System.Drawing.Point(555, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 173);
            this.panel1.TabIndex = 15;
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProjectName.ForeColor = System.Drawing.Color.Navy;
            this.lblProjectName.Location = new System.Drawing.Point(141, 5);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(0, 32);
            this.lblProjectName.TabIndex = 1;
            this.lblProjectName.Paint += new System.Windows.Forms.PaintEventHandler(this.lblProjectName_Paint);
            // 
            // lblTitleProjectName
            // 
            this.lblTitleProjectName.AutoSize = true;
            this.lblTitleProjectName.Location = new System.Drawing.Point(13, 12);
            this.lblTitleProjectName.Name = "lblTitleProjectName";
            this.lblTitleProjectName.Size = new System.Drawing.Size(122, 25);
            this.lblTitleProjectName.TabIndex = 0;
            this.lblTitleProjectName.Text = "Project Name:";
            // 
            // FormReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1865, 987);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dbgvTotal);
            this.Controls.Add(this.dbgvParts);
            this.Controls.Add(this.dbgvUsers);
            this.Controls.Add(this.dbgvProjects);
            this.Controls.Add(this.dbgvPurchases);
            this.Controls.Add(this.lblTitleTotal);
            this.Controls.Add(this.lblTitleParts);
            this.Controls.Add(this.lblTitleUsers);
            this.Controls.Add(this.lblTitleProjectPurchases);
            this.Controls.Add(this.lblTitleProjects);
            this.Name = "FormReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReports";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormReports_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dbgvPurchases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbgvProjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbgvParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbgvTotal)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblTitleProjects;
        private Label lblTitleProjectPurchases;
        private Label lblTitleUsers;
        private Label lblTitleParts;
        private Label lblTitleTotal;
        private DataGridView dbgvPurchases;
        private DataGridView dbgvProjects;
        private DataGridView dbgvUsers;
        private DataGridView dbgvParts;
        private DataGridView dbgvTotal;
        private Panel panel1;
        private Label lblProjectName;
        private Label lblTitleProjectName;
    }
}