namespace Weasel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btn_OK = new Button();
            btn_Cancel = new Button();
            label2 = new Label();
            label1 = new Label();
            btn_Registro = new Button();
            checkbxSenha = new CheckBox();
            txt_User = new TextBox();
            txt_Senha = new TextBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_OK
            // 
            btn_OK.BackColor = Color.FromArgb(32, 33, 40);
            btn_OK.FlatStyle = FlatStyle.Popup;
            btn_OK.ForeColor = Color.White;
            btn_OK.Location = new Point(12, 378);
            btn_OK.Name = "btn_OK";
            btn_OK.Size = new Size(334, 52);
            btn_OK.TabIndex = 0;
            btn_OK.Text = "Entrar";
            btn_OK.UseVisualStyleBackColor = false;
            btn_OK.Click += btn_OK_Click;
            // 
            // btn_Cancel
            // 
            btn_Cancel.BackColor = Color.Transparent;
            btn_Cancel.FlatStyle = FlatStyle.Flat;
            btn_Cancel.ForeColor = Color.White;
            btn_Cancel.Location = new Point(12, 454);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(334, 52);
            btn_Cancel.TabIndex = 1;
            btn_Cancel.Text = "Sair";
            btn_Cancel.UseVisualStyleBackColor = false;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(13, 248);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 6;
            label2.Text = "Senha:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(13, 155);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 5;
            label1.Text = "Usuário:";
            // 
            // btn_Registro
            // 
            btn_Registro.FlatAppearance.BorderSize = 0;
            btn_Registro.FlatStyle = FlatStyle.Flat;
            btn_Registro.ForeColor = Color.DodgerBlue;
            btn_Registro.Location = new Point(104, 573);
            btn_Registro.Name = "btn_Registro";
            btn_Registro.Size = new Size(135, 50);
            btn_Registro.TabIndex = 9;
            btn_Registro.Text = "Cadastre-se aqui";
            btn_Registro.UseVisualStyleBackColor = true;
            btn_Registro.Click += btn_Registro_Click;
            // 
            // checkbxSenha
            // 
            checkbxSenha.AutoSize = true;
            checkbxSenha.BackColor = Color.Transparent;
            checkbxSenha.ForeColor = Color.White;
            checkbxSenha.Location = new Point(13, 312);
            checkbxSenha.Name = "checkbxSenha";
            checkbxSenha.Size = new Size(144, 24);
            checkbxSenha.TabIndex = 10;
            checkbxSenha.Text = "Mostrar a senha";
            checkbxSenha.UseVisualStyleBackColor = false;
            checkbxSenha.CheckedChanged += checkbxSenha_CheckedChanged;
            // 
            // txt_User
            // 
            txt_User.BackColor = Color.White;
            txt_User.BorderStyle = BorderStyle.None;
            txt_User.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txt_User.ForeColor = Color.FromArgb(64, 64, 64);
            txt_User.Location = new Point(13, 178);
            txt_User.Margin = new Padding(4, 3, 4, 3);
            txt_User.Name = "txt_User";
            txt_User.Size = new Size(333, 35);
            txt_User.TabIndex = 11;
            // 
            // txt_Senha
            // 
            txt_Senha.BackColor = Color.White;
            txt_Senha.BorderStyle = BorderStyle.None;
            txt_Senha.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Senha.ForeColor = Color.FromArgb(64, 64, 64);
            txt_Senha.Location = new Point(13, 271);
            txt_Senha.Margin = new Padding(4, 3, 4, 3);
            txt_Senha.Name = "txt_Senha";
            txt_Senha.PasswordChar = '•';
            txt_Senha.Size = new Size(333, 35);
            txt_Senha.TabIndex = 12;
            txt_Senha.TextChanged += txt_Senha_TextChanged_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(80, 550);
            label4.Name = "label4";
            label4.Size = new Size(197, 20);
            label4.TabIndex = 14;
            label4.Text = "Ainda não tem uma conta?";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(80, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(197, 138);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 42, 57);
            ClientSize = new Size(358, 681);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(txt_Senha);
            Controls.Add(txt_User);
            Controls.Add(checkbxSenha);
            Controls.Add(btn_Registro);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_OK);
            Controls.Add(btn_Cancel);
            Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            TransparencyKey = Color.Black;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_OK;
        private Button btn_Cancel;
        private Label label2;
        private Label label1;
        private Button btn_Registro;
        private CheckBox checkbxSenha;
        private TextBox txt_User;
        private TextBox txt_Senha;
        private Label label4;
        private PictureBox pictureBox1;
    }
}