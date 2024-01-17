namespace Totem
{
    public partial class Fundo : Form
    {
        public Fundo()
        {
            InitializeComponent();
        }

        private void Fundo_FormClosed(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
