namespace _01___Introducao
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
            Label label1;
            panel1 = new Panel();
            btnTela2 = new Button();
            lblPalavra = new Label();
            lblDigite = new Label();
            textEntrada = new TextBox();
            button1 = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(316, 101);
            label1.Name = "label1";
            label1.Size = new Size(336, 50);
            label1.TabIndex = 7;
            label1.Text = "Meu Primeiro App\r\n";
            // 
            // panel1
            // 
            panel1.BackColor = Color.AntiqueWhite;
            panel1.Controls.Add(btnTela2);
            panel1.Controls.Add(lblPalavra);
            panel1.Controls.Add(lblDigite);
            panel1.Controls.Add(textEntrada);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(947, 484);
            panel1.TabIndex = 4;
            // 
            // btnTela2
            // 
            btnTela2.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnTela2.Location = new Point(866, 202);
            btnTela2.Name = "btnTela2";
            btnTela2.Size = new Size(48, 57);
            btnTela2.TabIndex = 11;
            btnTela2.Text = ">";
            btnTela2.UseVisualStyleBackColor = true;
            btnTela2.Click += btnTela2_Click;
            // 
            // lblPalavra
            // 
            lblPalavra.AutoSize = true;
            lblPalavra.Font = new Font("Calisto MT", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPalavra.Location = new Point(438, 276);
            lblPalavra.Name = "lblPalavra";
            lblPalavra.Size = new Size(93, 29);
            lblPalavra.TabIndex = 10;
            lblPalavra.Text = "Palavra";
            // 
            // lblDigite
            // 
            lblDigite.AutoSize = true;
            lblDigite.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDigite.ForeColor = SystemColors.ActiveCaptionText;
            lblDigite.Location = new Point(414, 179);
            lblDigite.Name = "lblDigite";
            lblDigite.Size = new Size(137, 20);
            lblDigite.TabIndex = 9;
            lblDigite.Text = "Digite uma Palavra:";
            // 
            // textEntrada
            // 
            textEntrada.Location = new Point(347, 202);
            textEntrada.Name = "textEntrada";
            textEntrada.Size = new Size(275, 27);
            textEntrada.TabIndex = 8;
            // 
            // button1
            // 
            button1.Font = new Font("Rockwell Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(391, 345);
            button1.Name = "button1";
            button1.Size = new Size(186, 39);
            button1.TabIndex = 6;
            button1.Text = "Atualizar";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(974, 510);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label lblPalavra;
        private Label lblDigite;
        private TextBox textEntrada;
        private Button button1;
        private Button btnTela2;
    }
}
