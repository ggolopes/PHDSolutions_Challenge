﻿using System;
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
        private SqlConnection DB_conn = new SqlConnection(@"Server=NBASUSGUIGA;Database=phdChallenge_DB;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true");
        SqlCommand sqlCmd;
        SqlDataAdapter sqlDataAdapter;
        DataTable dataTable;
        string sql;

        public FormReports()
        {
            InitializeComponent();

            ShowProjects();
            ShowPurchaseOrdersByProject(dbgvProjects.Rows[0].Cells[0].Value.ToString());
        }

        private void ShowProjects()
        {
            using (SqlConnection conn = DB_conn)
            {
                try
                {
                    conn.Open();
                    //sql = "SELECT projectNumber AS Proj_Num, projectDescription AS Proj_Name FROM ProjectRecord";
                    sql = " SELECT pr.projet AS Proj_Number, pj.ProjectDescription AS Project_Name," +
                          " ROUND(sum((pr.costPer*pr.quantity)),2) AS Project_Cost_Total" +
                          " FROM PurchaseRecord pr JOIN ProjectRecord pj ON pj.projectNumber = pr.projet" + 
                          " GROUP BY pr.projet, pj.projectDescription";
                    sqlCmd = new SqlCommand(sql, conn);
                    SqlDataReader reader = sqlCmd.ExecuteReader();
                    dataTable = new DataTable();
                    dataTable.Load(reader);
                    reader.Close();
                    dbgvProjects.DataSource = dataTable;
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
        }

        public void ShowPurchaseOrdersByProject(string projNumber)
        {
            using (SqlConnection conn = DB_conn)
            {
                try
                {
                    conn.Open();
                    sql = " SELECT pj.projectNumber, pj.projectDescription AS Proj_Name, u.fullName AS Purchaser_Name," +
                          " pr.partNumber, mm.Description, pr.quantity, pr.costPer" +
                          " FROM ProjectRecord pj JOIN PurchaseRecord pr ON pr.projet = pj.projectNumber" +
                          " JOIN Users u ON u.userName = pr.purchaser" +
                          " JOIN MaterialMaster mm ON pr.partNumber = mm.PartNumber" +
                          " WHERE pj.projectNumber = @p_projectNumber;";
                    sqlCmd = new SqlCommand(sql, conn);
                    sqlCmd.Parameters.Add(new SqlParameter("@p_projectNumber", projNumber));
                    SqlDataReader reader = sqlCmd.ExecuteReader();
                    dataTable = new DataTable();
                    dataTable.Load(reader);
                    reader.Close();
                    dbgvPurchases.DataSource = dataTable;
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
        }


        private void dbgvProjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("Clicado " + dbgvProjects.Rows[e.RowIndex].Cells[0].Value.ToString());
            ShowPurchaseOrdersByProject(dbgvProjects.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void FormReports_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}