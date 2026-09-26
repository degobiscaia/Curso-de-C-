namespace Componentes
{
    partial class F_Principal
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
            btn_adcionar = new Button();
            tb_listaVeiculos = new TextBox();
            label1 = new Label();
            tb_veiculo = new TextBox();
            btn_limpar = new Button();
            SuspendLayout();
            // 
            // btn_adcionar
            // 
            btn_adcionar.BackColor = SystemColors.ControlLight;
            btn_adcionar.FlatStyle = FlatStyle.Popup;
            btn_adcionar.Location = new Point(201, 53);
            btn_adcionar.Name = "btn_adcionar";
            btn_adcionar.Size = new Size(126, 23);
            btn_adcionar.TabIndex = 0;
            btn_adcionar.Text = "Adcionar";
            btn_adcionar.UseVisualStyleBackColor = false;
            btn_adcionar.Click += btn_veiculo_Click;
            // 
            // tb_listaVeiculos
            // 
            tb_listaVeiculos.Font = new Font("Segoe UI", 12F);
            tb_listaVeiculos.Location = new Point(25, 82);
            tb_listaVeiculos.Multiline = true;
            tb_listaVeiculos.Name = "tb_listaVeiculos";
            tb_listaVeiculos.Size = new Size(302, 324);
            tb_listaVeiculos.TabIndex = 1;
            tb_listaVeiculos.TextChanged += btn_lista_viculos;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 26);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 2;
            label1.Text = "Digite um Veículo";
            // 
            // tb_veiculo
            // 
            tb_veiculo.Location = new Point(25, 53);
            tb_veiculo.Name = "tb_veiculo";
            tb_veiculo.Size = new Size(170, 23);
            tb_veiculo.TabIndex = 3;
            // 
            // btn_limpar
            // 
            btn_limpar.BackColor = SystemColors.ControlLight;
            btn_limpar.FlatStyle = FlatStyle.Popup;
            btn_limpar.Location = new Point(25, 412);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(302, 33);
            btn_limpar.TabIndex = 4;
            btn_limpar.Text = "Limpar";
            btn_limpar.UseVisualStyleBackColor = false;
            btn_limpar.Click += btn_limpar_Click;
            // 
            // F_Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 461);
            Controls.Add(btn_limpar);
            Controls.Add(tb_veiculo);
            Controls.Add(label1);
            Controls.Add(tb_listaVeiculos);
            Controls.Add(btn_adcionar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "F_Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Componentes - CFB Cursos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_adcionar;
        private TextBox tb_listaVeiculos;
        private Label label1;
        private TextBox tb_veiculo;
        private Button btn_limpar;
    }
}
