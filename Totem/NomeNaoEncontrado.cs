namespace Totem
{
    public partial class NomeNaoEncontrado : Form
    {
        public NomeNaoEncontrado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Close();
        }

        private void NomeNaoEncontrado_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
