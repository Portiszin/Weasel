﻿namespace Weasel
{
    partial class novolivro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(novolivro));
            label1 = new Label();
            lblTitulo = new Label();
            label5 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            txtEditora = new TextBox();
            button1 = new Button();
            txtTitulo = new TextBox();
            txtAutor = new TextBox();
            txtGen = new TextBox();
            txtPubli = new TextBox();
            lblAutor = new Label();
            lblEditora = new Label();
            lblGenero = new Label();
            button3 = new Button();
            sqlDataAdapter1 = new Microsoft.Data.SqlClient.SqlDataAdapter();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(54, 74);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 27;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(54, 73);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(57, 23);
            lblTitulo.TabIndex = 41;
            lblTitulo.Text = "Título";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(433, 73);
            label5.Name = "label5";
            label5.Size = new Size(163, 23);
            label5.TabIndex = 44;
            label5.Text = "Data de Publicação";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(32, 33, 57);
            panel1.Location = new Point(-1, 403);
            panel1.Name = "panel1";
            panel1.Size = new Size(803, 47);
            panel1.TabIndex = 47;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(32, 33, 57);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 55);
            panel2.TabIndex = 48;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(757, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
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
            // txtEditora
            // 
            txtEditora.BackColor = Color.White;
            txtEditora.BorderStyle = BorderStyle.None;
            txtEditora.Font = new Font("Arial", 18.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtEditora.Location = new Point(54, 270);
            txtEditora.Margin = new Padding(4, 3, 4, 3);
            txtEditora.Name = "txtEditora";
            txtEditora.Size = new Size(301, 35);
            txtEditora.TabIndex = 28;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(32, 33, 57);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(433, 258);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(301, 47);
            button1.TabIndex = 29;
            button1.Text = "REGISTRAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtTitulo
            // 
            txtTitulo.BackColor = Color.White;
            txtTitulo.BorderStyle = BorderStyle.None;
            txtTitulo.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtTitulo.Location = new Point(54, 99);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(301, 35);
            txtTitulo.TabIndex = 31;
            // 
            // txtAutor
            // 
            txtAutor.BackColor = Color.White;
            txtAutor.BorderStyle = BorderStyle.None;
            txtAutor.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtAutor.Location = new Point(54, 182);
            txtAutor.Margin = new Padding(4, 3, 4, 3);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(301, 35);
            txtAutor.TabIndex = 34;
            txtAutor.TextChanged += txtAutor_TextChanged;
            // 
            // txtGen
            // 
            txtGen.BackColor = Color.White;
            txtGen.BorderStyle = BorderStyle.None;
            txtGen.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtGen.Location = new Point(433, 182);
            txtGen.Margin = new Padding(4, 3, 4, 3);
            txtGen.Name = "txtGen";
            txtGen.Size = new Size(301, 35);
            txtGen.TabIndex = 35;
            // 
            // txtPubli
            // 
            txtPubli.BackColor = Color.White;
            txtPubli.BorderStyle = BorderStyle.None;
            txtPubli.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtPubli.Location = new Point(433, 99);
            txtPubli.Margin = new Padding(4, 3, 4, 3);
            txtPubli.Name = "txtPubli";
            txtPubli.Size = new Size(301, 35);
            txtPubli.TabIndex = 40;
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblAutor.ForeColor = Color.White;
            lblAutor.Location = new Point(54, 159);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(56, 23);
            lblAutor.TabIndex = 42;
            lblAutor.Text = "Autor";
            // 
            // lblEditora
            // 
            lblEditora.AutoSize = true;
            lblEditora.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblEditora.ForeColor = Color.White;
            lblEditora.Location = new Point(54, 242);
            lblEditora.Name = "lblEditora";
            lblEditora.Size = new Size(68, 23);
            lblEditora.TabIndex = 43;
            lblEditora.Text = "Editora";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblGenero.ForeColor = Color.White;
            lblGenero.Location = new Point(432, 159);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(67, 23);
            lblGenero.TabIndex = 45;
            lblGenero.Text = "Gênero";
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(264, 338);
            button3.Name = "button3";
            button3.Size = new Size(259, 43);
            button3.TabIndex = 8;
            button3.Text = "Voltar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // novolivro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 42, 57);
            ClientSize = new Size(800, 448);
            Controls.Add(button3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lblGenero);
            Controls.Add(label5);
            Controls.Add(lblEditora);
            Controls.Add(lblAutor);
            Controls.Add(lblTitulo);
            Controls.Add(txtPubli);
            Controls.Add(txtGen);
            Controls.Add(txtAutor);
            Controls.Add(txtTitulo);
            Controls.Add(button1);
            Controls.Add(txtEditora);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "novolivro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "novolivro";
            Load += novolivro_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblTitulo;
        private Label label5;
        private Panel panel1;
        private Panel panel2;
        private TextBox txtEditora;
        private Button button1;
        private TextBox txtTitulo;
        private TextBox txtAutor;
        private TextBox txtGen;
        private TextBox txtPubli;
        private Label lblAutor;
        private Label lblEditora;
        private Label lblGenero;
        private Button button3;
        private Label label2;
        private PictureBox pictureBox1;
        private Microsoft.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
    }
}