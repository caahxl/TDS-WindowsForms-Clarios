namespace _01___Introducao
{
    partial class frmNumero
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
            Label label1;
            panel1 = new Panel();
            bntSelecionar = new Button();
            nudNumero = new NumericUpDown();
            lblDigite = new Label();
            lblNumero = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudNumero).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(213, 68);
            label1.Name = "label1";
            label1.Size = new Size(369, 50);
            label1.TabIndex = 10;
            label1.Text = "Escolha um Número";
            // 
            // panel1
            // 
            panel1.BackColor = Color.AntiqueWhite;
            panel1.Controls.Add(lblNumero);
            panel1.Controls.Add(bntSelecionar);
            panel1.Controls.Add(nudNumero);
            panel1.Controls.Add(lblDigite);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 426);
            panel1.TabIndex = 0;
            // 
            // bntSelecionar
            // 
            bntSelecionar.BackColor = Color.IndianRed;
            bntSelecionar.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntSelecionar.ForeColor = SystemColors.ButtonHighlight;
            bntSelecionar.Location = new Point(299, 324);
            bntSelecionar.Name = "bntSelecionar";
            bntSelecionar.Size = new Size(197, 38);
            bntSelecionar.TabIndex = 13;
            bntSelecionar.Text = "Selecionar";
            bntSelecionar.UseVisualStyleBackColor = false;
            bntSelecionar.Click += bntSelecionar_Click;
            // 
            // nudNumero
            // 
            nudNumero.Location = new Point(299, 227);
            nudNumero.Name = "nudNumero";
            nudNumero.Size = new Size(197, 27);
            nudNumero.TabIndex = 12;
            nudNumero.TextAlign = HorizontalAlignment.Center;
            // 
            // lblDigite
            // 
            lblDigite.AutoSize = true;
            lblDigite.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDigite.ForeColor = SystemColors.ActiveCaptionText;
            lblDigite.Location = new Point(299, 204);
            lblDigite.Name = "lblDigite";
            lblDigite.Size = new Size(66, 20);
            lblDigite.TabIndex = 11;
            lblDigite.Text = "Número:";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumero.ForeColor = SystemColors.ActiveCaptionText;
            lblNumero.Location = new Point(378, 135);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(38, 46);
            lblNumero.TabIndex = 14;
            lblNumero.Text = "0";
            // 
            // frmNumero
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "frmNumero";
            Text = "frmNumero";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudNumero).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button bntSelecionar;
        private NumericUpDown nudNumero;
        private Label lblDigite;
        private Label lblNumero;
    }
}