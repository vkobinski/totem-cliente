using Totem.Models;

namespace Totem
{
    public partial class CheckIn : Form
    {




        private System.Drawing.Image imagem;
        private String idAtendimento;
        private String nomeMedico;
        private byte[] imagemMedico;
        private float progress = 0.0f;
        private System.Windows.Forms.Timer timerProgress;

        public CheckIn(String idAtendimento, string nomeMedico, byte[] imagemMedico)
        {
            this.idAtendimento = idAtendimento;
            this.nomeMedico = nomeMedico;
            this.imagemMedico = imagemMedico;
            InitializeComponent();
            //richTextBox1.Text = "Em breve,";
            //richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
            //richTextBox1.AppendText("Dr(a). " + nomeMedico);
            richTextBox1.Rtf = @"{\rtf1\ansi Em breve, \b Dr(a). " + nomeMedico + @"\b0}";
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            lblChegada.Left = (this.ClientSize.Width - lblChegada.Width) / 2;
            enviarForm();

            timerProgress = new System.Windows.Forms.Timer();
            timerProgress.Interval = 100;
            timerProgress.Tick += carregarFinalizar_Tick;
            timerProgress.Start();

        }

        private async void enviarForm()
        {
            try
            {

                HttpClient httpClient = new HttpClient();

                MultipartFormDataContent formData = new MultipartFormDataContent();

                StreamContent fileContent = new StreamContent(File.OpenRead("./captured_image.jpg"));
                formData.Add(fileContent, "fotoPaciente", "fotoPaciente");
                formData.Add(new StringContent(idAtendimento), "id");

                HttpResponseMessage response = await httpClient.PutAsync(Utils.GetIp("/api/v1/atendimento/chegou/") + this.idAtendimento, formData);

                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Form data sent successfully.");
                }
                else
                {
                    Console.WriteLine("Failed to send form data. Response status: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível finalizar o check-in");
            }
        }

        private void carregarFinalizar_Tick(object sender, EventArgs e)
        {
            progress += 0.02f;
            btnMenuPrincipal.Invalidate();

            if (progress >= 2.0f)
            {
                timerProgress.Stop();
                new Form1().Show();
                Close();


            }
        }


        public Bitmap ByteArrayToBitmap(byte[] byteArrayIn)
        {
            try
            {
                using (var ms = new MemoryStream(byteArrayIn))
                {
                    Bitmap returnBitmap = new Bitmap(ms);
                    return returnBitmap;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível baixar a foto do médico");
                return null;
            }
        }
        private void CheckIn_Load(object sender, EventArgs e)
        {
            try
            {

                pictureBox2.Image = ByteArrayToBitmap(imagemMedico);

                System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
                gp.AddEllipse(new System.Drawing.Rectangle(0, 0, pictureBox2.Width, pictureBox2.Height));
                pictureBox2.Region = new Region(gp);
                pictureBox2.Left = (this.ClientSize.Width - pictureBox2.Width) / 2;
            }
            catch
            {
                MessageBox.Show("Imagem não encontrada.");
            }
        }


        private void btnMenuPrincipal_Click_1(object sender, EventArgs e)
        {
            timerProgress.Tick -= carregarFinalizar_Tick;
            new Form1().Show();
            Close();

        }

        private void lblTudoCerto_Click(object sender, EventArgs e)
        {
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMenuPrincipal_Paint(object sender, PaintEventArgs e)
        {
            var button = sender as Button;

            System.Drawing.Color darkerYellow = System.Drawing.ColorTranslator.FromHtml("#7F5A06");
            System.Drawing.Rectangle rect = new System.Drawing.Rectangle(0, 0, (int)(button.Width * progress), button.Height);
            e.Graphics.FillRectangle(new System.Drawing.SolidBrush(darkerYellow), rect);


            TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter;
            System.Drawing.Rectangle textRect = new System.Drawing.Rectangle(0, 0, button.Width, button.Height);
            TextRenderer.DrawText(e.Graphics, button.Text, button.Font, textRect, button.ForeColor, flags);

        }
    }
}
