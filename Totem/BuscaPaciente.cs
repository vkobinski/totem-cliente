namespace Totem
{
    public partial class BuscaPaciente : Form
    {
        public BuscaPaciente()
        {
            InitializeComponent();
            AttachButtonClickHandlers();
        }
        private void AttachButtonClickHandlers()
        {
            // Get all the buttons in the form
            var buttons = tableLayoutPanel1.Controls.OfType<Button>().Where(btn => btn.Name.StartsWith("btn"));

            foreach (var button in buttons)
            {
                // Get the letter from the button's name
                string buttonText = button.Name.Substring(3);

                // Attach the event handler to the button's Click event
                button.Click += (sender, e) => ButtonClickHandler(sender, e);
            }
        }
        private void ButtonClickHandler(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string buttonText = clickedButton.Name.Substring(3);

            HandlerButtonLetter(buttonText);
        }

        private void HandlerButtonLetter(String letter)
        {
            new ListaPaciente(letter).Show();
            this.Close();
        }

        private void atualizaTabela()
        {

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Form1 chegada = new Form1();
            chegada.Show();
            Close();
        }

        private void BuscaPaciente_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
