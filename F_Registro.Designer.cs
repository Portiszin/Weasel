namespace Weasel
{
    partial class F_Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Registro));
            label1 = new Label();
            txtSenha = new TextBox();
            button1 = new Button();
            btn_Voltar = new Button();
            txtConfirma = new TextBox();
            checkbxSenha = new CheckBox();
            label4 = new Label();
            txtUser = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            txtEmail = new TextBox();
            txtEndereço = new TextBox();
            txtMatricula = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtTelefone = new TextBox();
            label10 = new Label();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.FromArgb(230, 231, 233);
            label1.Location = new Point(19, 120);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(146, 23);
            label1.TabIndex = 0;
            label1.Text = "Nome de usuário";
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.White;
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenha.Location = new Point(19, 312);
            txtSenha.Margin = new Padding(4, 3, 4, 3);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '•';
            txtSenha.Size = new Size(301, 35);
            txtSenha.TabIndex = 4;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(32, 33, 40);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(398, 372);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(301, 53);
            button1.TabIndex = 6;
            button1.Text = "REGISTRAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btn_Voltar
            // 
            btn_Voltar.BackColor = Color.Transparent;
            btn_Voltar.FlatAppearance.BorderSize = 0;
            btn_Voltar.FlatStyle = FlatStyle.Flat;
            btn_Voltar.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Voltar.ForeColor = Color.DodgerBlue;
            btn_Voltar.Location = new Point(273, 545);
            btn_Voltar.Margin = new Padding(4, 3, 4, 3);
            btn_Voltar.Name = "btn_Voltar";
            btn_Voltar.Size = new Size(178, 38);
            btn_Voltar.TabIndex = 7;
            btn_Voltar.Text = "Voltar para o Login";
            btn_Voltar.UseVisualStyleBackColor = false;
            btn_Voltar.Click += btn_Voltar_Click;
            // 
            // txtConfirma
            // 
            txtConfirma.BackColor = Color.White;
            txtConfirma.BorderStyle = BorderStyle.None;
            txtConfirma.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfirma.Location = new Point(19, 388);
            txtConfirma.Margin = new Padding(4, 3, 4, 3);
            txtConfirma.Name = "txtConfirma";
            txtConfirma.PasswordChar = '•';
            txtConfirma.Size = new Size(301, 35);
            txtConfirma.TabIndex = 9;
            txtConfirma.TextChanged += txtConfirma_TextChanged;
            // 
            // checkbxSenha
            // 
            checkbxSenha.AutoSize = true;
            checkbxSenha.BackColor = Color.Transparent;
            checkbxSenha.Cursor = Cursors.Hand;
            checkbxSenha.FlatStyle = FlatStyle.Flat;
            checkbxSenha.ForeColor = Color.FromArgb(230, 231, 233);
            checkbxSenha.Location = new Point(20, 442);
            checkbxSenha.Margin = new Padding(4, 3, 4, 3);
            checkbxSenha.Name = "checkbxSenha";
            checkbxSenha.Size = new Size(155, 27);
            checkbxSenha.TabIndex = 11;
            checkbxSenha.Text = "Mostrar a senha";
            checkbxSenha.UseVisualStyleBackColor = false;
            checkbxSenha.CheckedChanged += checkbxSenha_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MS PGothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(290, 22);
            label4.Name = "label4";
            label4.Size = new Size(141, 34);
            label4.TabIndex = 12;
            label4.Text = "Registro";
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.White;
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtUser.Location = new Point(19, 146);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(301, 35);
            txtUser.TabIndex = 13;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.FromArgb(230, 231, 233);
            label2.Location = new Point(19, 286);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(58, 23);
            label2.TabIndex = 14;
            label2.Text = "Senha";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.FromArgb(230, 231, 233);
            label3.Location = new Point(16, 362);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(149, 23);
            label3.TabIndex = 15;
            label3.Text = "Confirme a senha";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = Color.White;
            label5.Location = new Point(273, 519);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(178, 23);
            label5.TabIndex = 16;
            label5.Text = "Já possui uma conta?";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Click += label5_Click;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(19, 229);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(301, 35);
            txtEmail.TabIndex = 19;
            // 
            // txtEndereço
            // 
            txtEndereço.BackColor = Color.White;
            txtEndereço.BorderStyle = BorderStyle.None;
            txtEndereço.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtEndereço.Location = new Point(398, 229);
            txtEndereço.Margin = new Padding(4, 3, 4, 3);
            txtEndereço.Name = "txtEndereço";
            txtEndereço.Size = new Size(301, 35);
            txtEndereço.TabIndex = 20;
            // 
            // txtMatricula
            // 
            txtMatricula.BackColor = Color.White;
            txtMatricula.BorderStyle = BorderStyle.None;
            txtMatricula.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtMatricula.Location = new Point(398, 312);
            txtMatricula.Margin = new Padding(4, 3, 4, 3);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(301, 35);
            txtMatricula.TabIndex = 21;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.ForeColor = Color.FromArgb(230, 231, 233);
            label7.Location = new Point(23, 203);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(54, 23);
            label7.TabIndex = 22;
            label7.Text = "Email";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.ForeColor = Color.FromArgb(230, 231, 233);
            label8.Location = new Point(398, 203);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(83, 23);
            label8.TabIndex = 23;
            label8.Text = "Endereço";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.ForeColor = Color.FromArgb(230, 231, 233);
            label9.Location = new Point(398, 286);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(86, 23);
            label9.TabIndex = 24;
            label9.Text = "Matrícula";
            // 
            // txtTelefone
            // 
            txtTelefone.BackColor = Color.White;
            txtTelefone.BorderStyle = BorderStyle.None;
            txtTelefone.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefone.Location = new Point(398, 146);
            txtTelefone.Margin = new Padding(4, 3, 4, 3);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(301, 35);
            txtTelefone.TabIndex = 25;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.ForeColor = Color.FromArgb(230, 231, 233);
            label10.Location = new Point(397, 120);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(77, 23);
            label10.TabIndex = 26;
            label10.Text = "Telefone";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-3, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(168, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(32, 33, 40);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(614, 12);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(116, 31);
            button2.TabIndex = 28;
            button2.Text = "SAIR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // F_Registro
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 42, 57);
            ClientSize = new Size(743, 635);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(label10);
            Controls.Add(txtTelefone);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtMatricula);
            Controls.Add(txtEndereço);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtUser);
            Controls.Add(label4);
            Controls.Add(checkbxSenha);
            Controls.Add(txtConfirma);
            Controls.Add(btn_Voltar);
            Controls.Add(button1);
            Controls.Add(txtSenha);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "F_Registro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro";
            Load += F_Registro_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSenha;
        private Button button1;
        private Button btn_Voltar;
        private TextBox txtConfirma;
        private CheckBox checkbxSenha;
        private Label label4;
        private TextBox txtUser;
        private Label label2;
        private Label label3;
        private Label label5;
        private TextBox txtEmail;
        private TextBox txtEndereço;
        private TextBox txtMatricula;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtTelefone;
        private Label label10;
        private PictureBox pictureBox1;
        private Button button2;
    }
}