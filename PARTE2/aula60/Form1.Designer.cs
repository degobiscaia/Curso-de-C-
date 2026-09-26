namespace aula60
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
            btn_texto = new Button();
            lb_texto = new Label();
            tb_texto = new TextBox();
            SuspendLayout();
            // 
            // btn_texto
            // 
            btn_texto.BackColor = Color.Black;
            btn_texto.Font = new Font("Segoe UI", 15F);
            btn_texto.ForeColor = Color.Red;
            btn_texto.Location = new Point(12, 42);
            btn_texto.Name = "btn_texto";
            btn_texto.Size = new Size(238, 60);
            btn_texto.TabIndex = 0;
            btn_texto.Text = "Ok";
            btn_texto.UseVisualStyleBackColor = false;
            btn_texto.Click += btn_texto_Click;
            // 
            // lb_texto
            // 
            lb_texto.AutoSize = true;
            lb_texto.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_texto.Location = new Point(38, 116);
            lb_texto.Name = "lb_texto";
            lb_texto.Size = new Size(190, 21);
            lb_texto.TabIndex = 1;
            lb_texto.Text = "youtube.com/cfbcursos";
            lb_texto.Click += label1_Click;
            // 
            // tb_texto
            // 
            tb_texto.Location = new Point(12, 12);
            tb_texto.Name = "tb_texto";
            tb_texto.Size = new Size(238, 23);
            tb_texto.TabIndex = 2;
            // 
            // F_Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 491);
            Controls.Add(tb_texto);
            Controls.Add(lb_texto);
            Controls.Add(btn_texto);
            Name = "F_Principal";
            Text = "Curso de C# - CFB Cursos";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_texto;
        private Label lb_texto;
        private TextBox tb_texto;
    }
}
