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
    public partial class novolivro : Form
    {
        public novolivro()
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
    }
}
