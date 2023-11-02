namespace PHD_ChallengeDesktop
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbPOFiles = new System.Windows.Forms.ListBox();
            this.btnGetPOFiles = new System.Windows.Forms.Button();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.lblFolder = new System.Windows.Forms.Label();
            this.btnImportPO = new System.Windows.Forms.Button();
            this.lbPurchaseOrders = new System.Windows.Forms.ListBox();
            this.btnReports = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbPOFiles
            // 
            this.lbPOFiles.FormattingEnabled = true;
            this.lbPOFiles.ItemHeight = 25;
            this.lbPOFiles.Location = new System.Drawing.Point(24, 84);
            this.lbPOFiles.Name = "lbPOFiles";
            this.lbPOFiles.Size = new System.Drawing.Size(228, 304);
            this.lbPOFiles.TabIndex = 0;
            // 
            // btnGetPOFiles
            // 
            this.btnGetPOFiles.Location = new System.Drawing.Point(24, 407);
            this.btnGetPOFiles.Name = "btnGetPOFiles";
            this.btnGetPOFiles.Size = new System.Drawing.Size(228, 34);
            this.btnGetPOFiles.TabIndex = 1;
            this.btnGetPOFiles.Text = "Get PO Files";
            this.btnGetPOFiles.UseVisualStyleBackColor = true;
            this.btnGetPOFiles.Click += new System.EventHandler(this.btnGetPOFiles_Click);
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(96, 47);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(361, 31);
            this.txtFolder.TabIndex = 2;
            this.txtFolder.Text = "C:\\Files\\C#_Codes\\phdChallenge\\PO_DATA\\";
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Location = new System.Drawing.Point(24, 53);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(66, 25);
            this.lblFolder.TabIndex = 3;
            this.lblFolder.Text = "Folder:";
            // 
            // btnImportPO
            // 
            this.btnImportPO.Location = new System.Drawing.Point(24, 479);
            this.btnImportPO.Name = "btnImportPO";
            this.btnImportPO.Size = new System.Drawing.Size(228, 34);
            this.btnImportPO.TabIndex = 4;
            this.btnImportPO.Text = "Import PO from XML";
            this.btnImportPO.UseVisualStyleBackColor = true;
            this.btnImportPO.Click += new System.EventHandler(this.btnImportPO_Click);
            // 
            // lbPurchaseOrders
            // 
            this.lbPurchaseOrders.FormattingEnabled = true;
            this.lbPurchaseOrders.ItemHeight = 25;
            this.lbPurchaseOrders.Location = new System.Drawing.Point(258, 84);
            this.lbPurchaseOrders.Name = "lbPurchaseOrders";
            this.lbPurchaseOrders.Size = new System.Drawing.Size(953, 429);
            this.lbPurchaseOrders.TabIndex = 5;
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(24, 546);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(228, 34);
            this.btnReports.TabIndex = 6;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 696);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.lbPurchaseOrders);
            this.Controls.Add(this.btnImportPO);
            this.Controls.Add(this.lblFolder);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.btnGetPOFiles);
            this.Controls.Add(this.lbPOFiles);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lbPOFiles;
        private Button btnGetPOFiles;
        private TextBox txtFolder;
        private Label lblFolder;
        private Button btnImportPO;
        private ListBox lbPurchaseOrders;
        private Button btnReports;
    }
}