namespace FormDinamico
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            Inicio inicio= new Inicio();
            inicio.TopLevel= false;
            painel.Controls.Add(inicio);
            inicio.Show();
            inicio.Location= new Point(0,0);
        }
    }
}