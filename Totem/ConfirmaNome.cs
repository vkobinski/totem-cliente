namespace Totem
{
    public partial class ConfirmaNome : Form
    {
        private string idAtendimento;
        private string nomePaciente;
        private string nomeMedico;
        private byte[] imagemMedico;
        public ConfirmaNome(string idAtendimento, string nomePaciente, string nomeMedico, byte[] imagemMedico)
        {
            this.idAtendimento = idAtendimento;
            this.nomePaciente = nomePaciente;
            this.nomeMedico = nomeMedico;
            InitializeComponent();
            lblAviso.Text = nomePaciente + "?";
            lblAviso.Left = (this.ClientSize.Width - lblAviso.Width) / 2;
            this.imagemMedico = imagemMedico;
        }

        private void btnPacienteErrado_Click(object sender, EventArgs e)
        {
            new BuscaPaciente().Show();
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            new Foto(idAtendimento, nomeMedico, imagemMedico).Show();
            this.Close();
        }
    }
}
