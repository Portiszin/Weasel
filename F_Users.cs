using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weasel
{
    public partial class F_Users : Form
    {
        public F_Users()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtUser.Text == "")
                MessageBox.Show("Porfavor insira os dados nos campos!");
            else
            {
                string connectionString = @"Data Source=DESKTOP-QQOLUS3\SQLEXPRESS; Integrated Security=True; Connect Timeout=30; Encrypt=False; TrustServerCertificate=False; ApplicationIntent=ReadWrite; MultiSubnetFailover=False; Initial Catalog=login;";

                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    string deleteQuery = "DELETE FROM log WHERE ID = @ID AND username = @username ";
                    using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, sqlCon))
                    {
                        deleteCmd.Parameters.AddWithValue("@ID", txtID.Text.Trim());
                        deleteCmd.Parameters.AddWithValue("@username", txtUser.Text.Trim());

                        int rowsAffected = deleteCmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Dados excluídos com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Nenhum dado correspondente encontrado para exclusão.");
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
