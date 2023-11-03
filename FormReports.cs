using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHD_ChallengeDesktop
{
    public partial class FormReports : Form
    {

        public FormReports()
        {
            InitializeComponent();

            // Get the projects from database;
            ShowProjects();

            // Get the project's info from database
            ShowProjectInfo(dbgvProjects.Rows[0].Cells[0].Value.ToString());
        }
        private void ShowProjects()
        {
            // Get the projects from database;
            SqlConnection conn = PurchaseOrder.DB_conn;
            try
            {
                conn.Open();
                string sql = " SELECT pr.projet AS Proj_Number, pj.ProjectDescription AS Project_Name," +
                        " ROUND(sum((pr.costPer*pr.quantity)),2) AS Project_Cost_Total" +
                        " FROM PurchaseRecord pr JOIN ProjectRecord pj ON pj.projectNumber = pr.projet" +
                        " GROUP BY pr.projet, pj.projectDescription";
                SqlCommand sqlCmd = new SqlCommand(sql, conn);
                SqlDataReader reader = sqlCmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                reader.Close();
                dbgvProjects.DataSource = dataTable;
                dbgvProjects.AllowUserToAddRows = false;
                dbgvProjects.AllowUserToDeleteRows = false;
                dbgvProjects.ReadOnly = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public void ShowProjectInfo(string projNumber)
        {
            // Get the project's info from database
            SqlConnection conn = PurchaseOrder.DB_conn;
            try
            {
                //Purchases
                conn.Open();
                string sql = " SELECT pj.projectNumber, pj.projectDescription AS Proj_Name, u.fullName AS Purchaser_Name," +
                        " pr.partNumber, mm.Description, pr.quantity, pr.costPer" +
                        " FROM ProjectRecord pj JOIN PurchaseRecord pr ON pr.projet = pj.projectNumber" +
                        " JOIN Users u ON u.userName = pr.purchaser" +
                        " JOIN MaterialMaster mm ON pr.partNumber = mm.PartNumber" +
                        " WHERE pj.projectNumber = @p_projectNumber;";
                SqlCommand sqlCmd = new SqlCommand(sql, conn);
                sqlCmd.Parameters.Add(new SqlParameter("@p_projectNumber", projNumber));
                SqlDataReader reader = sqlCmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                reader.Close();
                dbgvPurchases.DataSource = dataTable;
                dbgvPurchases.AllowUserToAddRows = false;
                dbgvPurchases.AllowUserToDeleteRows = false;
                dbgvPurchases.ReadOnly = true;

                // Users
                sql = " SELECT DISTINCT u.fullName AS Purchaser_Fullname, count(pr.partNumber) AS Number_of_Purchases" +
                        " FROM Users u JOIN PurchaseRecord pr ON u.userName = pr.purchaser" +
                        " WHERE pr.projet = @p_projectNumber " +
                        " GROUP BY u.fullName";
                sqlCmd = new SqlCommand(sql, conn);
                sqlCmd.Parameters.Add(new SqlParameter("@p_projectNumber", projNumber));
                reader = sqlCmd.ExecuteReader();
                dataTable = new DataTable();
                dataTable.Load(reader);
                reader.Close();
                dbgvUsers.DataSource = dataTable;
                dbgvUsers.AllowUserToAddRows = false;
                dbgvUsers.AllowUserToDeleteRows = false;
                dbgvUsers.ReadOnly = true;

                // Parts
                sql = " SELECT pr.partNumber, mm.Description, SUM(pr.quantity) AS Quantity_Total," +
                        " ROUND(SUM((pr.costPer*pr.quantity)),2) AS Cost_Total" +
                        " FROM PurchaseRecord pr JOIN MaterialMaster mm ON pr.partNumber = mm.PartNumber" +
                        " WHERE pr.projet = @p_projectNumber" +
                        " GROUP BY pr.partNumber, mm.Description" +
                        " ORDER BY pr.partNumber";
                sqlCmd = new SqlCommand(sql, conn);
                sqlCmd.Parameters.Add(new SqlParameter("@p_projectNumber", projNumber));
                reader = sqlCmd.ExecuteReader();
                dataTable = new DataTable();
                dataTable.Load(reader);
                reader.Close();
                dbgvParts.DataSource = dataTable;
                dbgvParts.AllowUserToAddRows = false;
                dbgvParts.AllowUserToDeleteRows = false;
                dbgvParts.ReadOnly = true;

                // Total Cost
                sql = " SELECT pr.projet AS Proj_Number, pj.ProjectDescription AS Project_Name," +
                        " ROUND(SUM((pr.costPer*pr.quantity)),2) AS Project_Cost_Total" +
                        " FROM PurchaseRecord pr JOIN ProjectRecord pj ON pj.projectNumber = pr.projet" +
                        " WHERE pr.projet = @p_projectNumber" +
                        " GROUP BY pr.projet, pj.projectDescription";
                sqlCmd = new SqlCommand(sql, conn);
                sqlCmd.Parameters.Add(new SqlParameter("@p_projectNumber", projNumber));
                reader = sqlCmd.ExecuteReader();
                dataTable = new DataTable();
                dataTable.Load(reader);
                reader.Close();
                dbgvTotal.DataSource = dataTable;
                dbgvTotal.AllowUserToAddRows = false;
                dbgvTotal.AllowUserToDeleteRows = false;
                dbgvTotal.ReadOnly = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            // Get the initial value to project name label 
            if (string.IsNullOrEmpty(lblProjectName.Text))
            {
                lblProjectName.Text = dbgvProjects.Rows[0].Cells[1].Value.ToString() + " - " + dbgvProjects.Rows[0].Cells[0].Value.ToString();
            }
        }
        private void dbgvProjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Update the project name label
            lblProjectName.Text = dbgvProjects.Rows[e.RowIndex].Cells[1].Value.ToString() + " - " + dbgvProjects.Rows[e.RowIndex].Cells[0].Value.ToString();
            ShowProjectInfo(dbgvProjects.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void FormReports_FormClosed(object sender, FormClosedEventArgs e)
        {
            // exit the application if close de Report Form
            Application.Exit();
        }
    }
}
