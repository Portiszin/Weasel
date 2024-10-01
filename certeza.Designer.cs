namespace Weasel
{
    partial class certeza
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
            panel1 = new Panel();
            btnNao = new Button();
            btnSim = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 42, 57);
            panel1.Controls.Add(btnNao);
            panel1.Controls.Add(btnSim);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(278, 135);
            panel1.TabIndex = 0;
            // 
            // btnNao
            // 
            btnNao.BackColor = Color.White;
            btnNao.FlatStyle = FlatStyle.Flat;
            btnNao.ForeColor = Color.Black;
            btnNao.Location = new Point(164, 83);
            btnNao.Name = "btnNao";
            btnNao.Size = new Size(94, 29);
            btnNao.TabIndex = 2;
            btnNao.Text = "Não";
            btnNao.UseVisualStyleBackColor = false;
            btnNao.Click += btnNao_Click;
            // 
            // btnSim
            // 
            btnSim.BackColor = Color.Red;
            btnSim.FlatStyle = FlatStyle.Flat;
            btnSim.Font = new Font("Lucida Console", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSim.ForeColor = Color.White;
            btnSim.Location = new Point(16, 84);
            btnSim.Name = "btnSim";
            btnSim.Size = new Size(94, 29);
            btnSim.TabIndex = 1;
            btnSim.Text = "Sim";
            btnSim.UseVisualStyleBackColor = false;
            btnSim.Click += btnSim_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Console", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(39, 13);
            label1.Name = "label1";
            label1.Size = new Size(190, 23);
            label1.TabIndex = 0;
            label1.Text = "Tem certeza?";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // certeza
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 159);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "certeza";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "certeza";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnNao;
        private Button btnSim;
        private Label label1;
    }
}