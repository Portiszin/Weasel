using Microsoft.Data.SqlClient;
using System.Data;

namespace Weasel
{
    public partial class Form1 : Form
    {

        string connectionString = @"Data Source=DESKTOP-QQOLUS3\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Initial Catalog=login;";


        public enum TipoUsuario
        {
            Aluno,
            Professor,
            Bibliotecario
        }

        public static Form1 instance;

        public Form1()
        {
            InitializeComponent();
            instance = this;

        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QQOLUS3\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Initial Catalog=login");


        private void btn_OK_Click(object sender, EventArgs e)
        {



            string NomeUser = txt_User.Text;
            String username, user_password;

            username = txt_User.Text;
            user_password = txt_Senha.Text;


            try
            {
                String querry = "SELECT * FROM log WHERE username = '" + txt_User.Text + "' AND senha = '" + txt_Senha.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = txt_User.Text;
                    user_password = txt_Senha.Text;
                    string tipo = dtable.Rows[0]["tipo"].ToString();

                    switch (tipo)
                    {
                        case "aluno.com":
                            int UserID = Convert.ToInt32(dtable.Rows[0]["ID"]);
                            F_Aluno f_Aluno = new F_Aluno(UserID);
                            f_Aluno.Show();
                            this.Hide();
                            break;
                        case "professor.com":
                            int UID = Convert.ToInt32(dtable.Rows[0]["ID"]);
                            F_Professor f_Professor = new F_Professor(UID);
                            f_Professor.Show();
                            this.Hide();
                            break;
                        case "biblio.com":
                            int ID = Convert.ToInt32(dtable.Rows[0]["ID"]);
                            F_Bibliotecario f_Bibliotecario = new F_Bibliotecario(ID);
                            f_Bibliotecario.Show();
                            this.Hide();
                            break;
                        default:
                            MessageBox.Show("Tipo de usuário inválido");
                            break;
                    }

                }
                else
                {
                    MessageBox.Show("Usuário ou Senha inválido",
                        "Desculpe",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    txt_User.Focus();
                    txt_Senha.Text = "";



                }
            }


            catch (Exception ex)
            {
                MessageBox.Show("Desculpe",
                                ex.Message,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

            }
            finally
            {
                conn.Close();

            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Registro_Click(object sender, EventArgs e)
        {
            F_Registro f_Registro = new F_Registro();
            f_Registro.Show();
            this.Hide();
        }

        private void txt_User_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkbxSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxSenha.Checked)
            {
                txt_Senha.PasswordChar = '\0';
            }
            else
            {
                txt_Senha.PasswordChar = '•';
            }
        }

        private void txt_Senha_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}