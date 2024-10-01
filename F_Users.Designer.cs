namespace Weasel
{
    partial class F_Users
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            label2 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            lblTitulo = new Label();
            txtUser = new TextBox();
            txtID = new TextBox();
            btnExcluir = new Button();
            button3 = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(32, 33, 57);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(782, 55);
            panel2.TabIndex = 49;
            panel2.Paint += panel2_Paint;
            // 
            // label2
            // 
            label2.Font = new Font("Nirmala UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(-1, 0);
            label2.Name = "label2";
            label2.Size = new Size(133, 47);
            label2.TabIndex = 0;
            label2.Text = "Weasel";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(32, 33, 57);
            panel1.Location = new Point(0, 354);
            panel1.Name = "panel1";
            panel1.Size = new Size(782, 47);
            panel1.TabIndex = 48;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(423, 72);
            label5.Name = "label5";
            label5.Size = new Size(154, 23);
            label5.TabIndex = 53;
            label5.Text = "Nome do Usuário:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(44, 72);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(107, 23);
            lblTitulo.TabIndex = 52;
            lblTitulo.Text = "ID da conta:";
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.White;
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtUser.Location = new Point(423, 98);
            txtUser.Margin = new Padding(4, 3, 4, 3);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(301, 35);
            txtUser.TabIndex = 51;
            // 
            // txtID
            // 
            txtID.BackColor = Color.White;
            txtID.BorderStyle = BorderStyle.None;
            txtID.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtID.Location = new Point(44, 98);
            txtID.Name = "txtID";
            txtID.Size = new Size(301, 35);
            txtID.TabIndex = 50;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(32, 33, 57);
            btnExcluir.Cursor = Cursors.Hand;
            btnExcluir.FlatAppearance.BorderSize = 0;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnExcluir.ForeColor = Color.White;
            btnExcluir.Location = new Point(227, 219);
            btnExcluir.Margin = new Padding(4, 3, 4, 3);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(301, 47);
            btnExcluir.TabIndex = 54;
            btnExcluir.Text = "Excluir Conta";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(247, 286);
            button3.Name = "button3";
            button3.Size = new Size(259, 43);
            button3.TabIndex = 55;
            button3.Text = "Voltar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // F_Users
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 42, 57);
            ClientSize = new Size(782, 401);
            ControlBox = false;
            Controls.Add(button3);
            Controls.Add(btnExcluir);
            Controls.Add(label5);
            Controls.Add(lblTitulo);
            Controls.Add(txtUser);
            Controls.Add(txtID);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "F_Users";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "F_Users";
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label2;
        private Panel panel1;
        private Label label5;
        private Label lblTitulo;
        private TextBox txtUser;
        private TextBox txtID;
        private Button btnExcluir;
        private Button button3;
    }
}