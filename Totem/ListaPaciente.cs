using Newtonsoft.Json;
using System.Globalization;
using Totem.Models;

namespace Totem
{
    public partial class ListaPaciente : Form
    {

        private String letter;
        private int currentIndex = 0;
        private List<Atendimento> atendimentos;
        private List<string> nomes = new List<string>();

        public ListaPaciente(String letter)
        {
            this.letter = letter;
            InitializeComponent();
            atualizaTabela();

            botaoEsquerda.Enabled = false;
        }
        private List<Atendimento> GetNextFive()
        {
            var nextFive = atendimentos.Skip(currentIndex).Take(5).ToList();

            currentIndex += nextFive.Count;

            if (atendimentos.Count < 5)
            {
                botaoDireita.Enabled = false;
            }

            if (currentIndex >= atendimentos.Count)
            {
                botaoDireita.Enabled = false;
            }


            return nextFive;
        }
        private List<Atendimento> GetLastFive()
        {
            currentIndex = Math.Max(currentIndex - 5, 0);

            var lastFive = atendimentos.Skip(currentIndex).Take(5).ToList();

            if (currentIndex <= 0)
            {
                botaoEsquerda.Enabled = false;
            }

            botaoDireita.Enabled = true;

            return lastFive;
        }

        private async void preencheTabela(List<Atendimento> lista)
        {
            try
            {

                lista.ForEach(atendimento =>
                {

                    DataGridViewRow linha = new DataGridViewRow();

                    linha.Height = 100;
                    linha.DividerHeight = 20;

                    DataGridViewTextBoxCell nomeMedicoCelula = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell nomePacienteCelula = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell dataCelula = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell idCelula = new DataGridViewTextBoxCell();
                    DataGridViewImageCell image = new DataGridViewImageCell();
                    DataGridViewTextBoxCell nascimentoCelula = new DataGridViewTextBoxCell();


                    nomePacienteCelula.Value = atendimento.Paciente.NomeCompleto;
                    nomeMedicoCelula.Value = atendimento.Medico.NomeCompleto;
                    idCelula.Value = atendimento.Paciente.PacienteId;
                    image.Value = atendimento.Medico.Foto;
                    nascimentoCelula.Value = atendimento.Paciente.DataNascimento;

                    if (nomes.Contains(nomePacienteCelula.Value.ToString()))
                    {
                        visualizaPaciente.Columns[5].Visible = true;
                    }

                    nomes.Add(nomePacienteCelula.Value.ToString().Trim());

                    string inputString = atendimento.DataAtendimento;

                    string formattedDateTime;

                    try
                    {
                        DateTime dateTime = DateTime.ParseExact(inputString, "yyyy-MM-dd'T'HH:mm:ss", CultureInfo.InvariantCulture);
                        formattedDateTime = dateTime.ToString("dd/MM/yyyy HH:mm");
                    }
                    catch (Exception e)
                    {
                        DateTime dateTime = DateTime.Parse(inputString, CultureInfo.CurrentCulture);
                        DateTime newDateTime = new DateTime(dateTime.Ticks);
                        formattedDateTime = newDateTime.ToString("dd/MM/yyyy HH:mm");
                    }

                    dataCelula.Value = formattedDateTime;

                    linha.Cells.AddRange(idCelula, nomePacienteCelula, nomeMedicoCelula, dataCelula, image, nascimentoCelula);

                    visualizaPaciente.Rows.Add(linha);

                });
            }
            catch (Exception e)
            {
                MessageBox.Show("Não há pacientes para serem mostrados");
            }

        }
        private async void atualizaTabela()
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(Utils.GetIp("/api/v1/atendimento/paciente/") + this.letter);

                string v = await httpResponseMessage.Content.ReadAsStringAsync();

                atendimentos = JsonConvert.DeserializeObject<List<Atendimento>>(v);

                atendimentos.RemoveAll(x => x.Chegou);

                preencheTabela(GetNextFive());

            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível conectar ao servidor");
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            BuscaPaciente bp = new BuscaPaciente();
            bp.Show();
            Close();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            if (visualizaPaciente.SelectedRows.Count < 1 || visualizaPaciente.SelectedRows[0].Cells.Count < 1) return;

            DataGridViewCell selectedCell = visualizaPaciente.SelectedRows[0].Cells[0];
            DataGridViewCell nomePacienteCell = visualizaPaciente.SelectedRows[0].Cells[1];
            DataGridViewCell nomeMedicoCell = visualizaPaciente.SelectedRows[0].Cells[2];
            DataGridViewImageCell imageCell = (DataGridViewImageCell)visualizaPaciente.SelectedRows[0].Cells[4];

            if (!(selectedCell is DataGridViewTextBoxCell) || selectedCell.Value == null) return;

            String idAtendimento = selectedCell.Value.ToString();
            String nomePaciente = nomePacienteCell.Value.ToString();
            String nomeMedico = nomeMedicoCell.Value.ToString();
            byte[] imagemMedico = (byte[])imageCell.Value;

            new ConfirmaNome(idAtendimento, nomePaciente, nomeMedico, imagemMedico).Show();
            this.Close();

        }

        private void btnNomeNaoEncontrado_Click(object sender, EventArgs e)
        {
            NomeNaoEncontrado naoEncontrado = new NomeNaoEncontrado();
            naoEncontrado.Show();
            this.Close();

        }

        private void botaoDireita_Click(object sender, EventArgs e)
        {
            try
            {
                nomes.Clear();
                var nextFive = GetNextFive();
                visualizaPaciente.Rows.Clear();
                preencheTabela(nextFive);
                botaoEsquerda.Enabled = true;
            }
            catch
            {
                return;
            }
        }

        private void botaoEsquerda_Click(object sender, EventArgs e)
        {
            try
            {
                nomes.Clear();
                var nextFive = GetLastFive();
                visualizaPaciente.Rows.Clear();
                preencheTabela(nextFive);
            }
            catch
            {
                return;
            }
        }

        private void ListaPaciente_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
