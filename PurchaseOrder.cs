using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;


namespace PHD_ChallengeDesktop
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class PurchaseOrder
    {
        // static String Connection
        public static SqlConnection DB_conn = new SqlConnection(@"Server=NBASUSGUIGA;Database=phdChallenge_DB;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true");


        private PurchaseOrderPurchaseItem[] purchaseItemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("purchaseItem")]
        public PurchaseOrderPurchaseItem[] purchaseItem
        {
            get
            {
                return this.purchaseItemField;
            }
            set
            {
                this.purchaseItemField = value;
            }
        }


        // Static Method to Delete Purchase Orders from database
        public static void DeletePO_FromDB()
        {
            string sql = "DELETE FROM PurchaseRecord";
            SqlCommand sqlCmd = new SqlCommand(sql, DB_conn);
            try
            {
                DB_conn.Open();
                sqlCmd.ExecuteNonQuery();
                sqlCmd = null;
                MessageBox.Show("All Purchase Orders were deleted from databsase.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                DB_conn.Close();
            }
        }

        // static method to Deserialize XML file into PurchaseOrder objects
        public static PurchaseOrder DeserializeFromXml(string xmlFileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(PurchaseOrder));

            TextReader textReader = (TextReader)new StreamReader(xmlFileName);
            XmlTextReader reader = new XmlTextReader(textReader);
            reader.Read();
            // Deserialize the stream into PurchaseOrder objects
            PurchaseOrder purchaseOrder = (PurchaseOrder)serializer.Deserialize(reader);
            reader.Close();

            return purchaseOrder;
        }


        // method to Save a purchase order into Database
        public Boolean SavePurchaseOrder(string poNumber, PurchaseOrder purchaseOrder)
        {

            // Mount the SQL commando to insert the Purchase Item to the PurchaseRecord table
            string sql = "INSERT INTO PurchaseRecord (PONumber, partNumber, quantity, costPer, purchaser, projet) " +
                         "VALUES (@p_PONumber, @p_partNumber, @p_quantity, @p_costPer, @p_purchaser, @p_project)";

            if ((purchaseOrder.purchaseItem != null) && (purchaseOrder.purchaseItem.Length > 0)) // The purchaseOrder has purchaseItems
            {
                // Iterate from PurchaseOrder object properties to build the ListView
                for (int i = 0; i < purchaseOrder.purchaseItem.Length; i++)
                {

                    // Add the PurchaseItem data to SQL parameters
                    SqlCommand sqlCmd = new SqlCommand(sql, DB_conn);
                    sqlCmd.Parameters.Add(new SqlParameter("@p_PONumber", poNumber));
                    sqlCmd.Parameters.Add(new SqlParameter("@p_partNumber", purchaseOrder.purchaseItem[i].partNumber));
                    sqlCmd.Parameters.Add(new SqlParameter("@p_quantity", float.Parse(purchaseOrder.purchaseItem[i].quantity.ToString())));
                    sqlCmd.Parameters.Add(new SqlParameter("@p_costPer", float.Parse(purchaseOrder.purchaseItem[i].costPer.ToString())));
                    sqlCmd.Parameters.Add(new SqlParameter("@p_purchaser", purchaseOrder.purchaseItem[i].purchaser));
                    sqlCmd.Parameters.Add(new SqlParameter("@p_project", purchaseOrder.purchaseItem[i].project));
                    try
                    {
                        // Open the connection, execute the SQL command, update the counter and clear the sqlCmd.
                        DB_conn.Open();
                        sqlCmd.ExecuteNonQuery();
                        sqlCmd = null;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        DB_conn.Close();
                    }
                }
            }
            return true;
        }
    }
}
