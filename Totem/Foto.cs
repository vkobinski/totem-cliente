using AForge.Video;
using AForge.Video.DirectShow;
using System.Media;

namespace Totem
{
    public partial class Foto : Form
    {

        private String idAtendimento;
        private String nomePaciente;
        private byte[] imagemMedico;
        private int counter = 5;
        private System.Windows.Forms.Timer timer;

        private float progress = 0.0f;
        private System.Windows.Forms.Timer timerProgress;

        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        private NewFrameEventHandler newFrameEventHandler;

        public Foto(String idAtendimento, String nomeMedico, byte[] imagemMedico)
        {
            this.idAtendimento = idAtendimento;
            this.nomePaciente = nomeMedico;
            InitializeComponent();
            InitializeWebcam();
            this.imagemMedico = imagemMedico;
            btnConfirmar.Enabled = false;
            btnRecarregar.Enabled = false;

        }

        private void InitializeWebcam()
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count == 0)
            {
                MessageBox.Show("No video devices found.");
                return;
            }

            videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
            newFrameEventHandler = new NewFrameEventHandler(videoSource_NewFrame);
            videoSource.NewFrame += newFrameEventHandler;
            videoSource.Start();

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += RunEvent;
            timer.Start();

        }

        private void carregarFinalizar_Tick(object sender, EventArgs e)
        {
            progress += 0.02f;
            btnConfirmar.Invalidate();

            if (progress >= 1.0f)
            {
                timerProgress.Stop();
                new CheckIn(this.idAtendimento, nomePaciente, imagemMedico).Show();
                this.Close();

            }
        }

        private void RunEvent(object sender, EventArgs e)
        {
            try
            {

                string valor = counter.ToString();
                if (counter >= 1)
                {
                    timerLabel.Text = valor;
                    counter--;
                    return;
                }
                if (counter == 0)
                {

                    if (pictureBox1.Image != null)
                    {

                        try
                        {

                            File.Delete("captured_image.jpg");
                        }
                        catch
                        {

                        }


                        using var memoryStream = new System.IO.MemoryStream();
                        pictureBox1.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);

                        var coreImage = SixLabors.ImageSharp.Image.Load(memoryStream.ToArray());
                        coreImage.Save("captured_image.jpg"); // Provide 

                        videoSource.NewFrame -= newFrameEventHandler;
                        timerLabel.Visible = false;
                        SoundPlayer simpleSound = new SoundPlayer("camera-13695.wav");
                        simpleSound.Play();
                        btnConfirmar.Enabled = true;
                        btnRecarregar.Enabled = true;
                        videoSource.SignalToStop();
                        videoSource.WaitForStop();

                        timerProgress = new System.Windows.Forms.Timer();
                        timerProgress.Interval = 100;
                        timerProgress.Tick += carregarFinalizar_Tick;
                        timerProgress.Start();
                    }
                    else
                    {
                        MessageBox.Show("Nenhuma imagem pode ser capturada.");
                    }

                    timer.Stop();
                }
            }
            catch
            {
            }
        }
        private void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
            }
            catch
            {
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (timer != null)
            {
                timer.Tick -= RunEvent;

            }

            if (timerProgress != null)
            {
                timerProgress.Tick -= carregarFinalizar_Tick;
            }

            BuscaPaciente bp = new BuscaPaciente();
            bp.Show();
            Close();
            Dispose();
        }

        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {
            timerProgress.Tick -= carregarFinalizar_Tick;
            new CheckIn(this.idAtendimento, nomePaciente, imagemMedico).Show();
            this.Close();
            Dispose();
        }
        private void btnRecarregar_Click(object sender, EventArgs e)
        {
            timerProgress.Tick -= carregarFinalizar_Tick;
            new Foto(idAtendimento, nomePaciente, imagemMedico).Show();
            this.Close();
            Dispose();
        }

        private void Foto_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnConfirmar_Paint(object sender, PaintEventArgs e)
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
