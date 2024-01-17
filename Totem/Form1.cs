using Totem.Models;

namespace Totem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChegada_Click(object sender, EventArgs e)
        {
            FundoSingleton.Instance.ShowFundo();
            new BuscaPaciente().Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}