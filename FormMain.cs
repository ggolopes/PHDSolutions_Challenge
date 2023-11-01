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
        SqlConnection DB_conn = new SqlConnection(@"Server=NBASUSGUIGA;Database=phdChallenge_DB;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true");
    


        private void btnGetPOFiles_Click(object sender, EventArgs e)
        {
            string curDir = Path.GetDirectoryName(txtFolder.Text);
            DirectoryInfo dir = new DirectoryInfo(curDir);
            FileInfo[] files = dir.GetFiles("*.xml");

            lbPOFiles.Items.Clear();
            foreach (FileInfo file in files)
            {
                lbPOFiles.Items.Add(file.Name);
            }
        }

        private void btnImportPO_Click(object sender, EventArgs e)
        {
            string curDir = Path.GetDirectoryName(txtFolder.Text);
            PurchaseOrder purchaseOrder;
            XmlSerializer serializer = new XmlSerializer(typeof(PurchaseOrder));

            DB_conn.Open();

            lbPurchaseOrders.Items.Clear();
            for (int k = 0; k < lbPOFiles.Items.Count; k++)
            {
                string poNumber = lbPOFiles.Items[k].ToString().Substring(0, lbPOFiles.Items[k].ToString().Length - 4);
                string sql = "INSERT INTO PurchaseRecord (PONumber, partNumber, quantity, costPer, purchaser, projet) " +
                             "VALUES (@p_PONumber, @p_partNumber, @p_quantity, @p_costPer, @p_purchaser, @p_project)";
                using (TextReader textReader = (TextReader)new StreamReader(curDir + "\\" + lbPOFiles.Items[k]))
                {
                    XmlTextReader reader = new XmlTextReader(textReader);
                    reader.Read();
                    purchaseOrder = (PurchaseOrder)serializer.Deserialize(reader);
                    reader.Close();
                }

                lbPurchaseOrders.Items.Add("Purchase Order #" + poNumber);
                if ((purchaseOrder.purchaseItem != null) && (purchaseOrder.purchaseItem.Length > 0)) // The purchaseOrder has purchaseItems
                {
                    for (int i = 0; i < purchaseOrder.purchaseItem.Length; i++)
                    {
                        lbPurchaseOrders.Items.Add("Purchase Item Part Number# " + purchaseOrder.purchaseItem[i].partNumber);
                        lbPurchaseOrders.Items.Add("\tQuantity: " + purchaseOrder.purchaseItem[i].quantity);
                        lbPurchaseOrders.Items.Add("\tCost: " + purchaseOrder.purchaseItem[i].costPer);
                        lbPurchaseOrders.Items.Add("\tPurchaser: " + purchaseOrder.purchaseItem[i].purchaser);
                        lbPurchaseOrders.Items.Add("\tProject: " + purchaseOrder.purchaseItem[i].project + "\n");

                        SqlCommand sqlCmd = new SqlCommand(sql, DB_conn);
                        sqlCmd.Parameters.Add(new SqlParameter("@p_PONumber", poNumber));
                        sqlCmd.Parameters.Add(new SqlParameter("@p_partNumber", purchaseOrder.purchaseItem[i].partNumber));
                        sqlCmd.Parameters.Add(new SqlParameter("@p_quantity", float.Parse(purchaseOrder.purchaseItem[i].quantity.ToString())));
                        sqlCmd.Parameters.Add(new SqlParameter("@p_costPer", float.Parse(purchaseOrder.purchaseItem[i].costPer.ToString())));
                        sqlCmd.Parameters.Add(new SqlParameter("@p_purchaser", purchaseOrder.purchaseItem[i].purchaser));
                        sqlCmd.Parameters.Add(new SqlParameter("@p_project", purchaseOrder.purchaseItem[i].project));
                        sqlCmd.ExecuteNonQuery();
                        sqlCmd = null;
                    }
                }
                else // The PurchaseOrder doesn't have purchaseItems
                {
                    lbPurchaseOrders.Items.Add("\tNo purchase items found.\n");
                }

                lbPurchaseOrders.Items.Add("\n\n");

            }
            DB_conn.Close();
        }
    }
}