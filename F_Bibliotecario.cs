using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Weasel
{


    public partial class F_Bibliotecario : Form
    {
        string connectionStringLog = @"Data Source=DESKTOP-QQOLUS3\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Initial Catalog=login;";
        string connectionString = @"Data Source=DESKTOP-QQOLUS3\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Initial Catalog=bibliotecas;";

        private int UserID;

        public F_Bibliotecario(int UserID)
        {
            InitializeComponent();
            this.UserID = UserID;

            CarregarDadosDoBD(UserID);
            CarregarDadosHist(UserID);
            ExibirDadosReserva(UserID);

        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }



        //Carrega dados da tela de perfil

        private void CarregarDadosDoBD(int userID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source = DESKTOP-QQOLUS3\SQLEXPRESS; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False; Initial Catalog = login; "))
                {
                    conn.Open();
                    string query = "SELECT username, senha, matricula, endereco, email, telefone FROM log WHERE ID = @userID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userID", userID);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {

                            string nome = reader.GetString(reader.GetOrdinal("username"));
                            string senha = reader.GetString(reader.GetOrdinal("senha"));
                            string matricula = reader.GetString(reader.GetOrdinal("matricula"));
                            string endereco = reader.GetString(reader.GetOrdinal("endereco"));
                            string email = reader.GetString(reader.GetOrdinal("email"));
                            string telefone = reader.GetString(reader.GetOrdinal("telefone"));


                            lblUser.Text = nome;
                            lblName.Text = nome;
                            lblPass.Text = senha;
                            lblMatricula.Text = matricula;
                            lblAddress.Text = endereco;
                            lblMail.Text = email;
                            lblPhone.Text = telefone;


                        }
                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar os dados do BD: " + ex.Message);
            }
        }



        //EXIBIR OS LIVROS NO ACERVO (ASSIM QUE O FORM CARREGA)


        private void F_Bibliotecario_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source = DESKTOP-QQOLUS3\SQLEXPRESS; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False; Initial Catalog = bibliotecas; "))
            {
                conn.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT titulo, autor, editora, publicacao, categoria, estado FROM livrs", conn);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgv4.DataSource = dtbl;
            }

            using (SqlConnection conn = new SqlConnection(@"Data Source = DESKTOP-QQOLUS3\SQLEXPRESS; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False; Initial Catalog = login; "))
            {
                conn.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT ID, username, matricula, endereco, email, telefone, tipo FROM log", conn);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgv5.DataSource = dtbl;
            }

            //autorizar cadastro
            using (SqlConnection conn = new SqlConnection(@"Data Source = DESKTOP-QQOLUS3\SQLEXPRESS; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False; Initial Catalog = login; "))
            {
                conn.Open();
                SqlCommand sqlCmd = new SqlCommand("SELECT username, senha, matricula, endereco, email, telefone, tipo FROM autorizar", conn);

                SqlDataReader reader = sqlCmd.ExecuteReader();

                int rowIndex = 1;
                while (rowIndex <= 7 && reader.Read())
                {
                    if (rowIndex == 1)
                    {
                        u1.Text = reader.GetString(reader.GetOrdinal("username"));
                        s1.Text = reader.GetString(reader.GetOrdinal("senha"));
                        m1.Text = reader.GetString(reader.GetOrdinal("matricula"));
                        en1.Text = reader.GetString(reader.GetOrdinal("endereco"));
                        e1.Text = reader.GetString(reader.GetOrdinal("email"));
                        te1.Text = reader.GetString(reader.GetOrdinal("telefone"));
                        t1.Text = reader.GetString(reader.GetOrdinal("tipo"));
                    }
                    else if (rowIndex == 2)
                    {
                        u2.Text = reader.GetString(reader.GetOrdinal("username"));
                        s2.Text = reader.GetString(reader.GetOrdinal("senha"));
                        m2.Text = reader.GetString(reader.GetOrdinal("matricula"));
                        en2.Text = reader.GetString(reader.GetOrdinal("endereco"));
                        e2.Text = reader.GetString(reader.GetOrdinal("email"));
                        te2.Text = reader.GetString(reader.GetOrdinal("telefone"));
                        t2.Text = reader.GetString(reader.GetOrdinal("tipo"));
                    }
                    else if (rowIndex == 3)
                    {
                        u3.Text = reader.GetString(reader.GetOrdinal("username"));
                        s3.Text = reader.GetString(reader.GetOrdinal("senha"));
                        m3.Text = reader.GetString(reader.GetOrdinal("matricula"));
                        en3.Text = reader.GetString(reader.GetOrdinal("endereco"));
                        e3.Text = reader.GetString(reader.GetOrdinal("email"));
                        te3.Text = reader.GetString(reader.GetOrdinal("telefone"));
                        t3.Text = reader.GetString(reader.GetOrdinal("tipo"));
                    }
                    else if (rowIndex == 4)
                    {
                        u4.Text = reader.GetString(reader.GetOrdinal("username"));
                        s4.Text = reader.GetString(reader.GetOrdinal("senha"));
                        m4.Text = reader.GetString(reader.GetOrdinal("matricula"));
                        en4.Text = reader.GetString(reader.GetOrdinal("endereco"));
                        e4.Text = reader.GetString(reader.GetOrdinal("email"));
                        te4.Text = reader.GetString(reader.GetOrdinal("telefone"));
                        t4.Text = reader.GetString(reader.GetOrdinal("tipo"));
                    }
                    else if (rowIndex == 5)
                    {
                        u5.Text = reader.GetString(reader.GetOrdinal("username"));
                        s5.Text = reader.GetString(reader.GetOrdinal("senha"));
                        m5.Text = reader.GetString(reader.GetOrdinal("matricula"));
                        en5.Text = reader.GetString(reader.GetOrdinal("endereco"));
                        e5.Text = reader.GetString(reader.GetOrdinal("email"));
                        te5.Text = reader.GetString(reader.GetOrdinal("telefone"));
                        t5.Text = reader.GetString(reader.GetOrdinal("tipo"));
                    }
                    else if (rowIndex == 6)
                    {
                        u6.Text = reader.GetString(reader.GetOrdinal("username"));
                        s6.Text = reader.GetString(reader.GetOrdinal("senha"));
                        m6.Text = reader.GetString(reader.GetOrdinal("matricula"));
                        en6.Text = reader.GetString(reader.GetOrdinal("endereco"));
                        e6.Text = reader.GetString(reader.GetOrdinal("email"));
                        te6.Text = reader.GetString(reader.GetOrdinal("telefone"));
                        t6.Text = reader.GetString(reader.GetOrdinal("tipo"));
                    }
                    else if (rowIndex == 7)
                    {
                        u7.Text = reader.GetString(reader.GetOrdinal("username"));
                        s7.Text = reader.GetString(reader.GetOrdinal("senha"));
                        m7.Text = reader.GetString(reader.GetOrdinal("matricula"));
                        en7.Text = reader.GetString(reader.GetOrdinal("endereco"));
                        e7.Text = reader.GetString(reader.GetOrdinal("email"));
                        te7.Text = reader.GetString(reader.GetOrdinal("telefone"));
                        t7.Text = reader.GetString(reader.GetOrdinal("tipo"));
                    }

                    rowIndex++;
                }

                reader.Close();
            }


        }






        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblUserId_Click(object sender, EventArgs e)
        {

        }

        private void ID_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }










        //ATUALIZA O ACERVO
        private void CarregarDados()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source = DESKTOP-QQOLUS3\SQLEXPRESS; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False; Initial Catalog = bibliotecas; "))
                {
                    conn.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT titulo, autor, editora, publicacao, categoria, estado FROM livrs", conn);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);
                    dgv4.DataSource = dtbl;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar os dados: " + ex.Message);
            }
        }

        private void CarregarDados2()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source = DESKTOP-QQOLUS3\SQLEXPRESS; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False; Initial Catalog = login; "))
                {
                    conn.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT ID, username, matricula, endereco, email, telefone, tipo FROM log", conn);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);
                    dgv5.DataSource = dtbl;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar os dados" + ex.Message);
            }
        }

        private void atualiza_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void atualizar_Click(object sender, EventArgs e)
        {
            CarregarDados2();
        }













        private void pnlPerfil_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                pnlSenha.Visible = false;
            }
            else
            {
                pnlSenha.Visible = true;
            }
        }




        private void label10_Click(object sender, EventArgs e)
        {

        }


        //Reseerva de livros



        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void atualiza_Click_1(object sender, EventArgs e)
        {
            CarregarDados();
        }


        //Sistema de Busca


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string textoBusca = txtBusca.Text.Trim();

            if (!string.IsNullOrEmpty(textoBusca))
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QQOLUS3\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Initial Catalog=bibliotecas;"))
                {
                    conn.Open();
                    string query = "SELECT titulo, autor, editora, publicacao, categoria, estado FROM livrs WHERE titulo LIKE '%' + @titulo + '%'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@titulo", textoBusca);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgv4.DataSource = dt;

                    if (dgv4.Rows.Count == 0)
                    {
                        MessageBox.Show("Não há livros correspondentes à busca.");
                    }
                }
            }
            else
            {
                CarregarDados();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        //excluir conta



        private void btnExcluir_Click(object sender, EventArgs e)
        {
            certeza Certeza = new certeza(UserID);
            Certeza.Show();
        }



        //AUTORIZAR CONTAS



        private void btnA1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionStringLog))
            {
                string gambb = ".";
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("registro", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@username", u1.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@senha", s1.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@email", e1.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@endereco", en1.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@matricula", m1.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@telefone", te1.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@tipo", t1.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@reserva", gambb);
                sqlCmd.Parameters.AddWithValue("@hist", gambb);
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Login autorizado!");


                SqlCommand deleteCmd = new SqlCommand("DELETE FROM autorizar WHERE username = @username", sqlCon);
                deleteCmd.Parameters.AddWithValue("@username", u1.Text.Trim());
                deleteCmd.ExecuteNonQuery();


                u1.Text = "---";
                s1.Text = "---";
                e1.Text = "---";
                en1.Text = "---";
                m1.Text = "---";
                te1.Text = "---";
                t1.Text = "---";
            }
        }

        private void btnA2_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionStringLog))
            {
                string gambb = ".";
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("registro", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@username", u2.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@senha", s2.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@email", e2.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@endereco", en2.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@matricula", m2.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@telefone", te2.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@tipo", t2.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@reserva", gambb);
                sqlCmd.Parameters.AddWithValue("@hist", gambb);
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Login autorizado!");


                SqlCommand deleteCmd = new SqlCommand("DELETE FROM autorizar WHERE username = @username", sqlCon);
                deleteCmd.Parameters.AddWithValue("@username", u2.Text.Trim());
                deleteCmd.ExecuteNonQuery();

                u2.Text = "---";
                s2.Text = "---";
                e2.Text = "---";
                en2.Text = "---";
                m2.Text = "---";
                te2.Text = "---";
                t2.Text = "---";
            }
        }


        private void btnA3_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionStringLog))
            {
                string gambb = ".";
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("registro", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@username", u3.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@senha", s3.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@email", e3.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@endereco", en3.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@matricula", m3.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@telefone", te3.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@tipo", t3.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@reserva", gambb);
                sqlCmd.Parameters.AddWithValue("@hist", gambb);
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Login autorizado!");


                SqlCommand deleteCmd = new SqlCommand("DELETE FROM autorizar WHERE username = @username", sqlCon);
                deleteCmd.Parameters.AddWithValue("@username", u3.Text.Trim());
                deleteCmd.ExecuteNonQuery();


                u3.Text = "---";
                s3.Text = "---";
                e3.Text = "---";
                en3.Text = "---";
                m3.Text = "---";
                te3.Text = "---";
                t3.Text = "---";
            }
        }

        private void btnA4_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionStringLog))
            {
                string gambb = ".";
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("registro", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@username", u4.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@senha", s4.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@email", e4.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@endereco", en4.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@matricula", m4.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@telefone", te4.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@tipo", t4.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@reserva", gambb);
                sqlCmd.Parameters.AddWithValue("@hist", gambb);
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Login autorizado!");


                SqlCommand deleteCmd = new SqlCommand("DELETE FROM autorizar WHERE username = @username", sqlCon);
                deleteCmd.Parameters.AddWithValue("@username", u4.Text.Trim());
                deleteCmd.ExecuteNonQuery();


                u4.Text = "---";
                s4.Text = "---";
                e4.Text = "---";
                en4.Text = "---";
                m4.Text = "---";
                te4.Text = "---";
                t4.Text = "---";
            }
        }

        private void btnA5_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionStringLog))
            {
                string gambb = ".";
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("registro", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@username", u5.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@senha", s5.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@email", e5.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@endereco", en5.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@matricula", m5.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@telefone", te5.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@tipo", t5.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@reserva", gambb);
                sqlCmd.Parameters.AddWithValue("@hist", gambb);
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Login autorizado!");


                SqlCommand deleteCmd = new SqlCommand("DELETE FROM autorizar WHERE username = @username", sqlCon);
                deleteCmd.Parameters.AddWithValue("@username", u5.Text.Trim());
                deleteCmd.ExecuteNonQuery();


                u5.Text = "---";
                s5.Text = "---";
                e5.Text = "---";
                en5.Text = "---";
                m5.Text = "---";
                te5.Text = "---";
                t5.Text = "---";
            }
        }

        private void btnA6_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionStringLog))
            {
                string gambb = ".";
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("registro", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@username", u6.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@senha", s6.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@email", e6.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@endereco", en6.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@matricula", m6.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@telefone", te6.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@tipo", t6.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@reserva", gambb);
                sqlCmd.Parameters.AddWithValue("@hist", gambb);
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Login autorizado!");


                SqlCommand deleteCmd = new SqlCommand("DELETE FROM autorizar WHERE username = @username", sqlCon);
                deleteCmd.Parameters.AddWithValue("@username", u6.Text.Trim());
                deleteCmd.ExecuteNonQuery();


                u6.Text = "---";
                s6.Text = "---";
                e6.Text = "---";
                en6.Text = "---";
                m6.Text = "---";
                te6.Text = "---";
                t6.Text = "---";
            }
        }

        private void btnA7_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionStringLog))
            {
                string gambb = ".";
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("registro", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@username", u7.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@senha", s7.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@email", e7.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@endereco", en7.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@matricula", m7.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@telefone", te7.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@tipo", t7.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@reserva", gambb);
                sqlCmd.Parameters.AddWithValue("@hist", gambb);
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Login autorizado!");


                SqlCommand deleteCmd = new SqlCommand("DELETE FROM autorizar WHERE username = @username", sqlCon);
                deleteCmd.Parameters.AddWithValue("@username", u7.Text.Trim());
                deleteCmd.ExecuteNonQuery();


                u7.Text = "---";
                s7.Text = "---";
                e7.Text = "---";
                en7.Text = "---";
                m7.Text = "---";
                te7.Text = "---";
                t7.Text = "---";
            }
        }


        private void dgv5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        //busca LIVROS


        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            string textoBusca = txtBusca.Text.Trim();

            if (!string.IsNullOrEmpty(textoBusca))
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QQOLUS3\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Initial Catalog=bibliotecas;"))
                {
                    conn.Open();
                    string query = "SELECT titulo, autor, editora, publicacao, categoria, estado FROM livrs WHERE titulo LIKE '%' + @titulo + '%' OR autor LIKE '%' + @autor + '%' OR categoria LIKE '%' + @categoria + '%'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@titulo", textoBusca);
                    cmd.Parameters.AddWithValue("@autor", textoBusca);
                    cmd.Parameters.AddWithValue("@categoria", textoBusca);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgv4.DataSource = dt;

                    if (dgv4.Rows.Count == 0)
                    {
                        MessageBox.Show("Não há livros correspondentes à busca.");
                    }
                }
            }
            else
            {
                CarregarDados();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }


        //Busca USUARIO


        private void btnSearch_Click(object sender, EventArgs e)
        {
            string textoBusca = txtSearch.Text.Trim();

            if (!string.IsNullOrEmpty(textoBusca))
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QQOLUS3\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Initial Catalog=login;"))
                {
                    conn.Open();
                    string query = "SELECT username, matricula, endereco, email, telefone, tipo FROM log WHERE username LIKE '%' + @username + '%' OR matricula LIKE '%' + @matricula + '%'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", textoBusca);
                    cmd.Parameters.AddWithValue("@ID", textoBusca);
                    cmd.Parameters.AddWithValue("@matricula", textoBusca);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgv5.DataSource = dt;

                    if (dgv5.Rows.Count == 0)
                    {
                        MessageBox.Show("Não há livros correspondentes à busca.");
                    }
                }
            }
            else
            {
                CarregarDados2();
            }
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click_2(object sender, EventArgs e)
        {
            string nomeLivro = txtNome.Text.Trim();

            if (string.IsNullOrEmpty(nomeLivro))
            {
                MessageBox.Show("Por favor, insira o nome do livro.");
                return;
            }

            int userID = UserID;
            int livroID = 0;

            using (SqlConnection connBiblioteca = new SqlConnection(@"Data Source=DESKTOP-QQOLUS3\SQLEXPRESS; Integrated Security=True; Connect Timeout=30; Encrypt=False; TrustServerCertificate=False; ApplicationIntent=ReadWrite; MultiSubnetFailover=False; Initial Catalog=bibliotecas; "))
            {
                connBiblioteca.Open();


                string selectEstadoQuery = "SELECT estado FROM livrs WHERE titulo = @titulo";
                SqlCommand selectEstadoCmd = new SqlCommand(selectEstadoQuery, connBiblioteca);
                selectEstadoCmd.Parameters.AddWithValue("@titulo", nomeLivro);
                string estadoLivro = selectEstadoCmd.ExecuteScalar()?.ToString();

                if (estadoLivro == "Indisponível")
                {
                    MessageBox.Show("O livro selecionado está indisponível para reserva.");
                    return;
                }


                string updateEstadoQuery = "UPDATE livrs SET estado = @estado WHERE titulo = @titulo";
                SqlCommand updateEstadoCmd = new SqlCommand(updateEstadoQuery, connBiblioteca);
                updateEstadoCmd.Parameters.AddWithValue("@estado", "Indisponível");
                updateEstadoCmd.Parameters.AddWithValue("@titulo", nomeLivro);
                updateEstadoCmd.ExecuteNonQuery();


                string selectLivroIDQuery = "SELECT ID FROM livrs WHERE titulo = @titulo";
                SqlCommand selectLivroIDCmd = new SqlCommand(selectLivroIDQuery, connBiblioteca);
                selectLivroIDCmd.Parameters.AddWithValue("@titulo", nomeLivro);
                livroID = (int?)selectLivroIDCmd.ExecuteScalar() ?? 0;

                if (livroID == 0)
                {
                    MessageBox.Show("O livro não foi encontrado.");
                    return;
                }
            }

            using (SqlConnection connLogin = new SqlConnection(@"Data Source=DESKTOP-QQOLUS3\SQLEXPRESS; Integrated Security=True; Connect Timeout=30; Encrypt=False; TrustServerCertificate=False; ApplicationIntent=ReadWrite; MultiSubnetFailover=False; Initial Catalog=login; "))
            {
                connLogin.Open();


                string insertHistoricoQuery = "INSERT INTO historico (ID_user, ID_livro) VALUES (@ID_user, @ID_livro)";
                SqlCommand insertHistoricoCmd = new SqlCommand(insertHistoricoQuery, connLogin);
                insertHistoricoCmd.Parameters.AddWithValue("@ID_user", userID);
                insertHistoricoCmd.Parameters.AddWithValue("@ID_livro", livroID);
                insertHistoricoCmd.ExecuteNonQuery();

                MessageBox.Show("Livro reservado com sucesso!");

                txtNome.Text = string.Empty;
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnAtCad_Click(object sender, EventArgs e)
        {

        }

        //HISTORICO


        private void CarregarDadosHist(int userID)
        {
            string connectionStringHistorico = @"Data Source=DESKTOP-QQOLUS3\SQLEXPRESS; Integrated Security=True; Connect Timeout=30; Encrypt=False; TrustServerCertificate=False; ApplicationIntent=ReadWrite; MultiSubnetFailover=False; Initial Catalog=login;";
            string connectionStringLivros = @"Data Source=DESKTOP-QQOLUS3\SQLEXPRESS; Integrated Security=True; Connect Timeout=30; Encrypt=False; TrustServerCertificate=False; ApplicationIntent=ReadWrite; MultiSubnetFailover=False; Initial Catalog=bibliotecas;";

            using (SqlConnection connHistorico = new SqlConnection(connectionStringHistorico))
            using (SqlConnection connLivros = new SqlConnection(connectionStringLivros))
            {
                connHistorico.Open();
                connLivros.Open();

                string sqlQuery = "SELECT ID_livro FROM historico WHERE ID_user = @UserID";

                using (SqlCommand cmdHistorico = new SqlCommand(sqlQuery, connHistorico))
                {
                    cmdHistorico.Parameters.AddWithValue("@UserID", userID);

                    using (SqlDataReader readerHistorico = cmdHistorico.ExecuteReader())
                    {
                        if (readerHistorico.Read())
                        {
                            int idLivro = readerHistorico.GetInt32(readerHistorico.GetOrdinal("ID_livro"));

                            string sqlQueryLivros = "SELECT titulo FROM livrs WHERE ID = @id";

                            using (SqlCommand cmdLivros = new SqlCommand(sqlQueryLivros, connLivros))
                            {
                                cmdLivros.Parameters.AddWithValue("@id", idLivro);

                                using (SqlDataReader readerlivros = cmdLivros.ExecuteReader())
                                {
                                    if (readerlivros.Read())
                                    {
                                        string tituloLivro = readerlivros.GetString(readerlivros.GetOrdinal("titulo"));
                                        label10.Text = tituloLivro;


                                        string updateQueryLog = "UPDATE log SET hist = @titulo WHERE ID = @userID";

                                        using (SqlConnection connLog = new SqlConnection(connectionStringHistorico))
                                        {
                                            connLog.Open();


                                            using (SqlCommand updateCmdLog = new SqlCommand(updateQueryLog, connLog))
                                            {
                                                updateCmdLog.Parameters.AddWithValue("@titulo", tituloLivro);
                                                updateCmdLog.Parameters.AddWithValue("@userID", userID);

                                                updateCmdLog.ExecuteNonQuery();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }



        }




        private void btnDevolve_Click_1(object sender, EventArgs e)
        {
            int userID = UserID;

            string connectionString = @"Data Source=DESKTOP-QQOLUS3\SQLEXPRESS; Integrated Security=True; Connect Timeout=30; Encrypt=False; TrustServerCertificate=False; ApplicationIntent=ReadWrite; MultiSubnetFailover=False; Initial Catalog=login;";

            string segundaConnectionString = @"Data Source=DESKTOP-QQOLUS3\SQLEXPRESS; Integrated Security=True; Connect Timeout=30; Encrypt=False; TrustServerCertificate=False; ApplicationIntent=ReadWrite; MultiSubnetFailover=False; Initial Catalog=bibliotecas;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlConnection conn2 = new SqlConnection(segundaConnectionString))
            {
                conn.Open();
                conn2.Open();

                string nomelivro = label10.Text;
                string updateEstadoQuery = "UPDATE livrs SET estado = @estado WHERE titulo = @titulo";
                SqlCommand updateEstadoCmd = new SqlCommand(updateEstadoQuery, conn2);
                updateEstadoCmd.Parameters.AddWithValue("@estado", "Disponível");
                updateEstadoCmd.Parameters.AddWithValue("@titulo", nomelivro);
                updateEstadoCmd.ExecuteNonQuery();

                string selectQuery = "SELECT hist FROM log WHERE ID = @userID";

                using (SqlCommand selectCmd = new SqlCommand(selectQuery, conn))
                {
                    selectCmd.Parameters.AddWithValue("@userID", userID);
                    string histValue = selectCmd.ExecuteScalar()?.ToString();

                    if (!string.IsNullOrEmpty(histValue))
                    {
                        using (SqlConnection connBiblioteca = new SqlConnection(segundaConnectionString))
                        {
                            connBiblioteca.Open();


                            string updateQuery = "UPDATE log SET reserva = CONCAT(reserva, ', ', @histValue) WHERE ID = @userID";

                            using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                            {
                                updateCmd.Parameters.AddWithValue("@histValue", histValue);
                                updateCmd.Parameters.AddWithValue("@userID", userID);
                                updateCmd.ExecuteNonQuery();
                            }


                            string clearQuery = "UPDATE log SET hist = NULL WHERE ID = @userID";

                            using (SqlCommand clearCmd = new SqlCommand(clearQuery, conn))
                            {
                                clearCmd.Parameters.AddWithValue("@userID", userID);
                                clearCmd.ExecuteNonQuery();
                            }
                        }

                        using (SqlConnection connHistorico = new SqlConnection(connectionString))
                        {
                            connHistorico.Open();

                            string deleteQuery = "DELETE FROM historico WHERE ID_user = @userID";

                            using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, connHistorico))
                            {
                                deleteCmd.Parameters.AddWithValue("@userID", userID);
                                deleteCmd.ExecuteNonQuery();
                            }
                        }

                        label10.Text = "---";
                    }
                }
            }
        }

        private void ExibirDadosReserva(int userID)
        {
            string connectionString = @"Data Source=DESKTOP-QQOLUS3\SQLEXPRESS; Integrated Security=True; Connect Timeout=30; Encrypt=False; TrustServerCertificate=False; ApplicationIntent=ReadWrite; MultiSubnetFailover=False; Initial Catalog=login;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();


                string selectQuery = "SELECT reserva FROM log WHERE ID = @userID";

                using (SqlCommand selectCmd = new SqlCommand(selectQuery, conn))
                {
                    selectCmd.Parameters.AddWithValue("@userID", userID);
                    object reservaValue = selectCmd.ExecuteScalar();

                    if (reservaValue != null)
                    {
                        string reserva = reservaValue.ToString();
                        lbl1.Text = reserva;
                    }
                    else
                    {
                        lbl1.Text = "Nenhum dado de reserva encontrado.";
                    }
                }
            }

        }

        //refresh do histórico
        private void button3_Click(object sender, EventArgs e)
        {
            CarregarDadosHist(UserID);
            ExibirDadosReserva(UserID);



        }

        //add livros

        private void button1_Click(object sender, EventArgs e)
        {
            novolivro2 f_livro = new novolivro2();
            f_livro.Show();
        }

        //Tela de exclusao de usuário

        private void button4_Click(object sender, EventArgs e)
        {
            F_Users f_Users = new F_Users();
            f_Users.Show();
        }

        private void btnDevolve_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();


            System.Diagnostics.Process.Start(Application.ExecutablePath);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
            System.Diagnostics.Process.Start(Application.ExecutablePath);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
            System.Diagnostics.Process.Start(Application.ExecutablePath);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
            System.Diagnostics.Process.Start(Application.ExecutablePath);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
            System.Diagnostics.Process.Start(Application.ExecutablePath);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
            System.Diagnostics.Process.Start(Application.ExecutablePath);
        }
    }
}




