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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Weasel
{


    public partial class F_Aluno : Form
    {
        string connectionStringLog = @"Data Source=DESKTOP-QQOLUS3\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Initial Catalog=login;";
        string connectionString = @"Data Source=DESKTOP-QQOLUS3\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Initial Catalog=bibliotecas;";

        private int UserID;

        public F_Aluno(int UserID)
        {
            InitializeComponent();
            this.UserID = UserID;

            CarregarDadosDoBD(UserID);
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


        private void F_Aluno_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source = DESKTOP-QQOLUS3\SQLEXPRESS; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False; Initial Catalog = bibliotecas; "))
            {
                conn.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT titulo, autor, editora, publicacao, categoria, estado FROM livrs", conn);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgv4.DataSource = dtbl;
            }


            CarregarDadosHist(UserID);

            ExibirDadosReserva(UserID);

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


        //BOTOES DE RESERVA







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

        private void atualiza_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }


        //ABAS


        private void hist_Click(object sender, EventArgs e)
        {



        }

        private void historico_Click(object sender, EventArgs e)
        {


        }








        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void perfil_MouseHover(object sender, EventArgs e)
        {

        }

        private void perfil_MouseLeave(object sender, EventArgs e)
        {

        }

        private void acervo_MouseHover(object sender, EventArgs e)
        {


        }

        private void acervo_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

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


        //Reserva de livros

        private void button2_Click_1(object sender, EventArgs e)
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

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

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
                    string query = "SELECT titulo, autor, editora, publicacao, categoria, estado FROM livrs WHERE titulo LIKE '%' + @titulo + '%' OR '%' + @autor + '%' OR '%' + @categoria + '%'";
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


        //Excluir conta

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            certeza Certeza = new certeza(UserID);
            Certeza.Show();
        }


        //sair

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
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
                                        label2.Text = tituloLivro;


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




        private void btnDevolve_Click(object sender, EventArgs e)
        {
            int userID = UserID;

            string connectionString = @"Data Source=DESKTOP-QQOLUS3\SQLEXPRESS; Integrated Security=True; Connect Timeout=30; Encrypt=False; TrustServerCertificate=False; ApplicationIntent=ReadWrite; MultiSubnetFailover=False; Initial Catalog=login;";

            string segundaConnectionString = @"Data Source=DESKTOP-QQOLUS3\SQLEXPRESS; Integrated Security=True; Connect Timeout=30; Encrypt=False; TrustServerCertificate=False; ApplicationIntent=ReadWrite; MultiSubnetFailover=False; Initial Catalog=bibliotecas;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlConnection conn2 = new SqlConnection(segundaConnectionString))
            {
                conn.Open();
                conn2.Open();

                string nomelivro = label2.Text;
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

                        label2.Text = "---";
                    }
                }
            }
        }





        private void lbl1_Click(object sender, EventArgs e)
        {


        }

        private void ExibirDadosReserva(int userID)
        {
            string connectionString = @"Data Source=DESKTOP-QQOLUS3\SQLEXPRESS; Integrated Security=True; Connect Timeout=30; Encrypt=False; TrustServerCertificate=False; ApplicationIntent=ReadWrite; MultiSubnetFailover=False; Initial Catalog=login;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Consulta para obter os dados da coluna "Reserva" do usuário
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

        private void button1_Click(object sender, EventArgs e)
        {
            CarregarDadosHist(UserID);
            ExibirDadosReserva(UserID);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
            System.Diagnostics.Process.Start(Application.ExecutablePath);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
            System.Diagnostics.Process.Start(Application.ExecutablePath);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
            System.Diagnostics.Process.Start(Application.ExecutablePath);
        }
    }
}
