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
    public partial class certeza : Form
    {
        public certeza()
        {
            InitializeComponent();
        }

        private int UserID;

        public certeza(int UserID)
        {
            InitializeComponent();
            this.UserID = UserID;


        }

        string connectionString = (@"Data Source=DESKTOP-QQOLUS3\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Initial Catalog=login");


        private void ExcluirConta(int UserID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "DELETE FROM log WHERE ID = @UserID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userID", UserID);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Conta excluída com sucesso!");
                }
                else
                {
                    MessageBox.Show("Nenhuma conta encontrada com o ID informado.");
                }



            }
        }








        private void btnNao_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            ExcluirConta(UserID);

            F_Aluno formAluno = Application.OpenForms["F_Aluno"] as F_Aluno;
            if (formAluno != null)
            {
                formAluno.Hide();
            }

            this.Hide();

            Form1 formLogin = new Form1();
            formLogin.ShowDialog();
        }
    }
}
