using System.Data.SqlClient;
using System.Xml;
using System.Xml.Serialization;

namespace PHD_ChallengeDesktop
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        
        // Import XML files content into database
        private void btnImportPO_Click(object sender, EventArgs e)
        {
            string curDir = Path.GetDirectoryName(txtFolder.Text);
            int poOrdersConter = 0;
            PurchaseOrder purchaseOrder;
            
            XmlSerializer serializer = new XmlSerializer(typeof(PurchaseOrder));

            lbPurchaseOrders.Items.Clear();
            for (int k = 0; k < lbPOFiles.Items.Count; k++)
            {
                string xmlFileName = curDir + "\\" + lbPOFiles.Items[k];

                // get Purchase Order Number from the XML filename
                string poNumber = lbPOFiles.Items[k].ToString().Substring(0, lbPOFiles.Items[k].ToString().Length - 4);

                // call the class method to deserialize a XML file into a PurchaseOrder Object
                purchaseOrder = PurchaseOrder.DeserializeFromXml(xmlFileName);

                // add the Purchase Order into the ListView
                lbPurchaseOrders.Items.Add("Purchase Order #" + poNumber);
                if ((purchaseOrder.purchaseItem != null) && (purchaseOrder.purchaseItem.Length > 0)) // The purchaseOrder has purchaseItems
                {
                    // Iterate from PurchaseOrder object properties to build the ListView
                    for (int i = 0; i < purchaseOrder.purchaseItem.Length; i++)
                    {
                        lbPurchaseOrders.Items.Add("Purchase Item Part Number# " + purchaseOrder.purchaseItem[i].partNumber);
                        lbPurchaseOrders.Items.Add("\tQuantity: " + purchaseOrder.purchaseItem[i].quantity);
                        lbPurchaseOrders.Items.Add("\tCost: " + purchaseOrder.purchaseItem[i].costPer);
                        lbPurchaseOrders.Items.Add("\tPurchaser: " + purchaseOrder.purchaseItem[i].purchaser);
                        lbPurchaseOrders.Items.Add("\tProject: " + purchaseOrder.purchaseItem[i].project + "\n");

                        // Call the Class method SavePurchaseOrder to save the Purchase Order to Database
                        if (purchaseOrder.SavePurchaseOrder(poNumber, purchaseOrder))
                        {
                            poOrdersConter++;
                        }
                    }
                }
                else // The PurchaseOrder doesn't have purchaseItems
                {
                    lbPurchaseOrders.Items.Add("\tNo purchase items found.\n");
                }

                lbPurchaseOrders.Items.Add("\n\n");

            }
            lbPurchaseOrders.Items.Add("\n" + poOrdersConter.ToString() + " Purchase Orders were inserted into database.");
            lbPurchaseOrders.SetSelected(lbPurchaseOrders.Items.Count - 1, true);

        }


        // Instanciate and show The Report Form
        FormReports formReports;
        private void btnReports_Click(object sender, EventArgs e)
        {
            if (formReports == null)
            {
                formReports = new FormReports();
                formReports.Show();
            } else
            {
                formReports.Activate();
            }
        }

        // Method to change and update the folder of XML files to be imported
        private void btnChangeFolder_Click(object sender, EventArgs e)
        {
            var folder = new FolderBrowserDialog();
            if (string.IsNullOrEmpty(txtFolder.Text))
            {
                folder.SelectedPath = @"C:\Files\C#_Codes\phdChallenge\PO_DATA\";
            }
            else
            {
                folder.SelectedPath = txtFolder.Text;
            }
            if (folder.ShowDialog() == DialogResult.OK){

                // Read the folder filenames
                txtFolder.Text = folder.SelectedPath + "\\";
                DirectoryInfo dir = new DirectoryInfo(txtFolder.Text);
                FileInfo[] files = dir.GetFiles("*.xml");

                // build the file list into ListBox
                lbPOFiles.Items.Clear();
                if (files.Length > 0) // there is at least one XML file
                {
                    lblTitleFiles.Text = "Files:";
                    btnImportPO.Enabled = true;
                    foreach (FileInfo file in files)
                    {
                        lbPOFiles.Items.Add(file.Name);
                    }
                }
                else // there is no XML file
                {
                    lblTitleFiles.Text = "Files:  NO XML FILE FOUND.";
                    btnImportPO.Enabled = false;
                }
            }
        }
        
        // Method to clear the PurchaseRecord Database.
        private void btnClearDataBase_Click(object sender, EventArgs e)
        {
            PurchaseOrder.DeletePO_FromDB();
        }
    }
}