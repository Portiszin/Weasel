namespace Weasel
{
    partial class teste
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
            btnSair = new Button();
            SuspendLayout();
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.FromArgb(192, 0, 0);
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Lucida Sans Unicode", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(415, 62);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(61, 32);
            btnSair.TabIndex = 160;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            // 
            // teste
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1241, 615);
            Controls.Add(btnSair);
            Name = "teste";
            Text = "teste";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSair;
    }
}