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
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.btnImportPO = new System.Windows.Forms.Button();
            this.lbPurchaseOrders = new System.Windows.Forms.ListBox();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnChangeFolder = new System.Windows.Forms.Button();
            this.lblTitleFiles = new System.Windows.Forms.Label();
            this.lblTitlePath = new System.Windows.Forms.Label();
            this.btnClearDataBase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbPOFiles
            // 
            this.lbPOFiles.FormattingEnabled = true;
            this.lbPOFiles.ItemHeight = 25;
            this.lbPOFiles.Location = new System.Drawing.Point(250, 165);
            this.lbPOFiles.Name = "lbPOFiles";
            this.lbPOFiles.Size = new System.Drawing.Size(228, 304);
            this.lbPOFiles.TabIndex = 0;
            // 
            // txtFolder
            // 
            this.txtFolder.Enabled = false;
            this.txtFolder.Location = new System.Drawing.Point(250, 81);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(361, 31);
            this.txtFolder.TabIndex = 2;
            // 
            // btnImportPO
            // 
            this.btnImportPO.Enabled = false;
            this.btnImportPO.Location = new System.Drawing.Point(12, 255);
            this.btnImportPO.Name = "btnImportPO";
            this.btnImportPO.Size = new System.Drawing.Size(206, 59);
            this.btnImportPO.TabIndex = 4;
            this.btnImportPO.Text = "Import PO from XML";
            this.btnImportPO.UseVisualStyleBackColor = true;
            this.btnImportPO.Click += new System.EventHandler(this.btnImportPO_Click);
            // 
            // lbPurchaseOrders
            // 
            this.lbPurchaseOrders.FormattingEnabled = true;
            this.lbPurchaseOrders.ItemHeight = 25;
            this.lbPurchaseOrders.Location = new System.Drawing.Point(484, 165);
            this.lbPurchaseOrders.Name = "lbPurchaseOrders";
            this.lbPurchaseOrders.Size = new System.Drawing.Size(757, 429);
            this.lbPurchaseOrders.TabIndex = 5;
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(12, 410);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(206, 59);
            this.btnReports.TabIndex = 6;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnChangeFolder
            // 
            this.btnChangeFolder.Location = new System.Drawing.Point(12, 53);
            this.btnChangeFolder.Name = "btnChangeFolder";
            this.btnChangeFolder.Size = new System.Drawing.Size(206, 59);
            this.btnChangeFolder.TabIndex = 7;
            this.btnChangeFolder.Text = "Change Folder:";
            this.btnChangeFolder.UseVisualStyleBackColor = true;
            this.btnChangeFolder.Click += new System.EventHandler(this.btnChangeFolder_Click);
            // 
            // lblTitleFiles
            // 
            this.lblTitleFiles.AutoSize = true;
            this.lblTitleFiles.Location = new System.Drawing.Point(250, 137);
            this.lblTitleFiles.Name = "lblTitleFiles";
            this.lblTitleFiles.Size = new System.Drawing.Size(50, 25);
            this.lblTitleFiles.TabIndex = 8;
            this.lblTitleFiles.Text = "Files:";
            // 
            // lblTitlePath
            // 
            this.lblTitlePath.AutoSize = true;
            this.lblTitlePath.Location = new System.Drawing.Point(250, 48);
            this.lblTitlePath.Name = "lblTitlePath";
            this.lblTitlePath.Size = new System.Drawing.Size(66, 25);
            this.lblTitlePath.TabIndex = 9;
            this.lblTitlePath.Text = "Folder:";
            // 
            // btnClearDataBase
            // 
            this.btnClearDataBase.Location = new System.Drawing.Point(12, 330);
            this.btnClearDataBase.Name = "btnClearDataBase";
            this.btnClearDataBase.Size = new System.Drawing.Size(206, 59);
            this.btnClearDataBase.TabIndex = 10;
            this.btnClearDataBase.Text = "Clear Database";
            this.btnClearDataBase.UseVisualStyleBackColor = true;
            this.btnClearDataBase.Click += new System.EventHandler(this.btnClearDataBase_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 696);
            this.Controls.Add(this.btnClearDataBase);
            this.Controls.Add(this.lblTitlePath);
            this.Controls.Add(this.lblTitleFiles);
            this.Controls.Add(this.btnChangeFolder);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.lbPurchaseOrders);
            this.Controls.Add(this.btnImportPO);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.lbPOFiles);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lbPOFiles;
        private TextBox txtFolder;
        private Button btnImportPO;
        private ListBox lbPurchaseOrders;
        private Button btnReports;
        private Button btnChangeFolder;
        private Label lblTitleFiles;
        private Label lblTitlePath;
        private Button btnClearDataBase;
    }
}