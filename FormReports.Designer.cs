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
            ((System.ComponentModel.ISupportInitialize)(this.dbgvPurchases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbgvProjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbgvParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbgvTotal)).BeginInit();
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
            this.lblTitleProjectPurchases.Location = new System.Drawing.Point(569, 34);
            this.lblTitleProjectPurchases.Name = "lblTitleProjectPurchases";
            this.lblTitleProjectPurchases.Size = new System.Drawing.Size(161, 25);
            this.lblTitleProjectPurchases.TabIndex = 3;
            this.lblTitleProjectPurchases.Text = "Projects Purchases:";
            // 
            // lblTitleUsers
            // 
            this.lblTitleUsers.AutoSize = true;
            this.lblTitleUsers.Location = new System.Drawing.Point(567, 540);
            this.lblTitleUsers.Name = "lblTitleUsers";
            this.lblTitleUsers.Size = new System.Drawing.Size(271, 25);
            this.lblTitleUsers.TabIndex = 5;
            this.lblTitleUsers.Text = "Users that have made purchases:";
            // 
            // lblTitleParts
            // 
            this.lblTitleParts.AutoSize = true;
            this.lblTitleParts.Location = new System.Drawing.Point(953, 540);
            this.lblTitleParts.Name = "lblTitleParts";
            this.lblTitleParts.Size = new System.Drawing.Size(141, 25);
            this.lblTitleParts.TabIndex = 7;
            this.lblTitleParts.Text = "Parts purchased:";
            // 
            // lblTitleTotal
            // 
            this.lblTitleTotal.AutoSize = true;
            this.lblTitleTotal.Location = new System.Drawing.Point(12, 664);
            this.lblTitleTotal.Name = "lblTitleTotal";
            this.lblTitleTotal.Size = new System.Drawing.Size(225, 25);
            this.lblTitleTotal.TabIndex = 8;
            this.lblTitleTotal.Text = "Total cost off all purchases:";
            // 
            // dbgvPurchases
            // 
            this.dbgvPurchases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgvPurchases.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dbgvPurchases.Location = new System.Drawing.Point(567, 65);
            this.dbgvPurchases.Name = "dbgvPurchases";
            this.dbgvPurchases.RowHeadersWidth = 62;
            this.dbgvPurchases.RowTemplate.Height = 33;
            this.dbgvPurchases.Size = new System.Drawing.Size(1275, 472);
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
            this.dbgvProjects.Size = new System.Drawing.Size(524, 562);
            this.dbgvProjects.TabIndex = 11;
            this.dbgvProjects.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbgvProjects_CellClick);
            // 
            // dbgvUsers
            // 
            this.dbgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgvUsers.Location = new System.Drawing.Point(567, 568);
            this.dbgvUsers.Name = "dbgvUsers";
            this.dbgvUsers.RowHeadersWidth = 62;
            this.dbgvUsers.RowTemplate.Height = 33;
            this.dbgvUsers.Size = new System.Drawing.Size(380, 235);
            this.dbgvUsers.TabIndex = 12;
            // 
            // dbgvParts
            // 
            this.dbgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgvParts.Location = new System.Drawing.Point(953, 568);
            this.dbgvParts.Name = "dbgvParts";
            this.dbgvParts.RowHeadersWidth = 62;
            this.dbgvParts.RowTemplate.Height = 33;
            this.dbgvParts.Size = new System.Drawing.Size(889, 235);
            this.dbgvParts.TabIndex = 13;
            // 
            // dbgvTotal
            // 
            this.dbgvTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgvTotal.Location = new System.Drawing.Point(15, 692);
            this.dbgvTotal.Name = "dbgvTotal";
            this.dbgvTotal.RowHeadersWidth = 62;
            this.dbgvTotal.RowTemplate.Height = 33;
            this.dbgvTotal.Size = new System.Drawing.Size(524, 111);
            this.dbgvTotal.TabIndex = 14;
            // 
            // FormReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1865, 870);
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
    }
}