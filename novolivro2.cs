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
    public partial class novolivro2 : Form
    {
        public novolivro2()
        {
            InitializeComponent();
        }

        string connectionString = (@"Data Source=DESKTOP-QQOLUS3\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Initial Catalog=bibliotecas");

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtAutor.Text == "" || txtAutor.Text == "" || txtEditora.Text == "" || txtGen.Text == "")
                MessageBox.Show("Porfavor insira os dados nos campos!");
            else
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("livros", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@titulo", txtTitulo.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@autor", txtAutor.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@editora", txtEditora.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@publicacao", txtPubli.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@categoria", txtGen.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@estado", "Disponível".Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Registrado com sucesso!!!");
                }
            }

        }

        private void novolivro_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txtAutor_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (txtTitulo.Text == "" || txtAutor.Text == "" || txtEditora.Text == "" || txtGen.Text == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos!");
                return;
            }

            string connectionString = @"Data Source=DESKTOP-QQOLUS3\SQLEXPRESS; Integrated Security=True; Connect Timeout=30; Encrypt=False; TrustServerCertificate=False; ApplicationIntent=ReadWrite; MultiSubnetFailover=False; Initial Catalog=bibliotecas;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string deleteQuery = "DELETE FROM livrs WHERE titulo = @titulo AND autor = @autor AND editora = @editora AND categoria = @categoria";
                using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn))
                {
                    deleteCmd.Parameters.AddWithValue("@titulo", txtTitulo.Text.Trim());
                    deleteCmd.Parameters.AddWithValue("@autor", txtAutor.Text.Trim());
                    deleteCmd.Parameters.AddWithValue("@editora", txtEditora.Text.Trim());
                    deleteCmd.Parameters.AddWithValue("@categoria", txtGen.Text.Trim());
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

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtAutor.Text == "" || txtAutor.Text == "" || txtEditora.Text == "" || txtGen.Text == "")
                MessageBox.Show("Porfavor insira os dados nos campos!");
            else
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("livros", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@titulo", txtTitulo.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@autor", txtAutor.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@editora", txtEditora.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@publicacao", txtPubli.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@categoria", txtGen.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@estado", "Disponível".Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Registrado com sucesso!!!");
                }
            }
        }
    }
}
