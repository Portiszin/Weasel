using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;



namespace Weasel
{
    public partial class F_Registro : Form
    {
        public F_Registro()
        {
            InitializeComponent();
        }


        string connectionString = (@"Data Source=DESKTOP-QQOLUS3\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Initial Catalog=login");


        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }


        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || txtSenha.Text == "" || txtEmail.Text == "" || txtTelefone.Text == "" || txtEndereço.Text == "")
                MessageBox.Show("Porfavor insira os dados nos campos!");
            else if (txtSenha.Text != txtConfirma.Text)
                MessageBox.Show("A senhas não são idênticas");



            else
            {
                string email = txtEmail.Text;

                string[] partes = email.Split('@');

                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    if (partes.Length == 2)
                    {
                        string tipos = partes[1];
                        string gamb = "Livros:";

                        sqlCon.Open();
                        SqlCommand sqlCmd = new SqlCommand("pendente", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@username", txtUser.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@senha", txtSenha.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@endereco", txtEndereço.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@matricula", txtMatricula.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@telefone", txtTelefone.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@tipo", tipos);

                        sqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Aguarde seu cadastro ser autorizado!");
                    }
                }
            }
        }

        private void txtConfirma_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkbxSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxSenha.Checked)
            {
                txtSenha.PasswordChar = '\0';
                txtConfirma.PasswordChar = '\0';
            }
            else
            {
                txtSenha.PasswordChar = '•';
                txtConfirma.PasswordChar = '•';
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void F_Registro_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
