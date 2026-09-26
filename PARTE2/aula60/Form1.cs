namespace aula60
{
    public partial class F_Principal : Form
    {
        public F_Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_texto_Click(object sender, EventArgs e)
        {
            string txt;
            txt = tb_texto.Text;
            lb_texto.Text = txt;

            //Essa de baixo é a maneira mais simples sem aramzenar em uma variável e depois para o label.
            //lb_texto.Text = tb_texto.Text;
        }
    }
}
