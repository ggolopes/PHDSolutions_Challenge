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
            this.lblProjects = new System.Windows.Forms.Label();
            this.lblProjectPurchases = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            // lblProjects
            // 
            this.lblProjects.AutoSize = true;
            this.lblProjects.Location = new System.Drawing.Point(12, 34);
            this.lblProjects.Name = "lblProjects";
            this.lblProjects.Size = new System.Drawing.Size(78, 25);
            this.lblProjects.TabIndex = 1;
            this.lblProjects.Text = "Projects:";
            // 
            // lblProjectPurchases
            // 
            this.lblProjectPurchases.AutoSize = true;
            this.lblProjectPurchases.Location = new System.Drawing.Point(545, 37);
            this.lblProjectPurchases.Name = "lblProjectPurchases";
            this.lblProjectPurchases.Size = new System.Drawing.Size(161, 25);
            this.lblProjectPurchases.TabIndex = 3;
            this.lblProjectPurchases.Text = "Projects Purchases:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(545, 540);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Users that have made purchases:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(953, 540);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Parts purchased:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 664);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total cost off all purchases:";
            // 
            // dbgvPurchases
            // 
            this.dbgvPurchases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgvPurchases.Location = new System.Drawing.Point(545, 65);
            this.dbgvPurchases.Name = "dbgvPurchases";
            this.dbgvPurchases.RowHeadersWidth = 62;
            this.dbgvPurchases.RowTemplate.Height = 33;
            this.dbgvPurchases.Size = new System.Drawing.Size(1297, 472);
            this.dbgvPurchases.TabIndex = 10;
            // 
            // dbgvProjects
            // 
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
            this.dbgvUsers.Location = new System.Drawing.Point(545, 568);
            this.dbgvUsers.Name = "dbgvUsers";
            this.dbgvUsers.RowHeadersWidth = 62;
            this.dbgvUsers.RowTemplate.Height = 33;
            this.dbgvUsers.Size = new System.Drawing.Size(402, 235);
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
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProjectPurchases);
            this.Controls.Add(this.lblProjects);
            this.Name = "FormReports";
            this.Text = "FormReports";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private Label lblProjects;
        private Label lblProjectPurchases;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dbgvPurchases;
        private DataGridView dbgvProjects;
        private DataGridView dbgvUsers;
        private DataGridView dbgvParts;
        private DataGridView dbgvTotal;
    }
}