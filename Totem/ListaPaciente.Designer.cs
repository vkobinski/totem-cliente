namespace Totem
{
    partial class ListaPaciente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            btnResultado = new Label();
            btnCancelar = new Button();
            btnNomeNaoEncontrado = new Button();
            visualizaPaciente = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            medico = new DataGridViewTextBoxColumn();
            horario = new DataGridViewTextBoxColumn();
            Foto = new DataGridViewTextBoxColumn();
            datanascimento = new DataGridViewTextBoxColumn();
            botaoDireita = new Button();
            botaoEsquerda = new Button();
            ((System.ComponentModel.ISupportInitialize)visualizaPaciente).BeginInit();
            SuspendLayout();
            // 
            // btnResultado
            // 
            btnResultado.Anchor = AnchorStyles.None;
            btnResultado.AutoSize = true;
            btnResultado.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point);
            btnResultado.ForeColor = System.Drawing.Color.White;
            btnResultado.Location = new System.Drawing.Point(548, 61);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new System.Drawing.Size(643, 56);
            btnResultado.TabIndex = 0;
            btnResultado.Text = "Clique no seu nome abaixo";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.BackColor = System.Drawing.Color.FromArgb(255, 180, 12);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = SystemColors.ControlLightLight;
            btnCancelar.Location = new System.Drawing.Point(718, 888);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(364, 64);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnNomeNaoEncontrado
            // 
            btnNomeNaoEncontrado.Anchor = AnchorStyles.None;
            btnNomeNaoEncontrado.BackColor = System.Drawing.Color.FromArgb(255, 180, 12);
            btnNomeNaoEncontrado.FlatAppearance.BorderSize = 0;
            btnNomeNaoEncontrado.FlatStyle = FlatStyle.Flat;
            btnNomeNaoEncontrado.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnNomeNaoEncontrado.ForeColor = System.Drawing.Color.White;
            btnNomeNaoEncontrado.Location = new System.Drawing.Point(718, 780);
            btnNomeNaoEncontrado.Name = "btnNomeNaoEncontrado";
            btnNomeNaoEncontrado.Size = new System.Drawing.Size(364, 63);
            btnNomeNaoEncontrado.TabIndex = 2;
            btnNomeNaoEncontrado.Text = "Não encontro meu nome";
            btnNomeNaoEncontrado.UseVisualStyleBackColor = false;
            btnNomeNaoEncontrado.Click += btnNomeNaoEncontrado_Click;
            // 
            // visualizaPaciente
            // 
            visualizaPaciente.AllowUserToAddRows = false;
            visualizaPaciente.AllowUserToDeleteRows = false;
            visualizaPaciente.AllowUserToResizeColumns = false;
            visualizaPaciente.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(0, 97, 170);
            visualizaPaciente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            visualizaPaciente.Anchor = AnchorStyles.None;
            visualizaPaciente.BackgroundColor = System.Drawing.Color.FromArgb(0, 97, 170);
            visualizaPaciente.BorderStyle = BorderStyle.None;
            visualizaPaciente.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            visualizaPaciente.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(0, 97, 170);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            visualizaPaciente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            visualizaPaciente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            visualizaPaciente.ColumnHeadersVisible = false;
            visualizaPaciente.Columns.AddRange(new DataGridViewColumn[] { ID, Nome, medico, horario, Foto, datanascimento });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(0, 97, 170);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            visualizaPaciente.DefaultCellStyle = dataGridViewCellStyle3;
            visualizaPaciente.GridColor = System.Drawing.Color.FromArgb(0, 97, 170);
            visualizaPaciente.Location = new System.Drawing.Point(548, 136);
            visualizaPaciente.Margin = new Padding(3, 2, 3, 2);
            visualizaPaciente.MultiSelect = false;
            visualizaPaciente.Name = "visualizaPaciente";
            visualizaPaciente.ReadOnly = true;
            visualizaPaciente.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(0, 97, 170);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            visualizaPaciente.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            visualizaPaciente.RowHeadersVisible = false;
            visualizaPaciente.RowHeadersWidth = 51;
            visualizaPaciente.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            visualizaPaciente.RowsDefaultCellStyle = dataGridViewCellStyle5;
            visualizaPaciente.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            visualizaPaciente.RowTemplate.DividerHeight = 20;
            visualizaPaciente.RowTemplate.Height = 100;
            visualizaPaciente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            visualizaPaciente.Size = new System.Drawing.Size(682, 572);
            visualizaPaciente.TabIndex = 3;
            visualizaPaciente.Click += buscar_Click;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            ID.Width = 125;
            // 
            // Nome
            // 
            Nome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nome.HeaderText = "Paciente";
            Nome.MinimumWidth = 6;
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            // 
            // medico
            // 
            medico.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            medico.HeaderText = "Médico";
            medico.MinimumWidth = 6;
            medico.Name = "medico";
            medico.ReadOnly = true;
            medico.Visible = false;
            // 
            // horario
            // 
            horario.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            horario.HeaderText = "Horário";
            horario.MinimumWidth = 6;
            horario.Name = "horario";
            horario.ReadOnly = true;
            horario.Visible = false;
            // 
            // Foto
            // 
            Foto.HeaderText = "Foto";
            Foto.Name = "Foto";
            Foto.ReadOnly = true;
            Foto.Visible = false;
            // 
            // datanascimento
            // 
            datanascimento.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            datanascimento.HeaderText = "Data de Nascimento";
            datanascimento.Name = "datanascimento";
            datanascimento.ReadOnly = true;
            datanascimento.Visible = false;
            // 
            // botaoDireita
            // 
            botaoDireita.Anchor = AnchorStyles.None;
            botaoDireita.FlatAppearance.BorderSize = 0;
            botaoDireita.FlatStyle = FlatStyle.Flat;
            botaoDireita.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            botaoDireita.ForeColor = System.Drawing.Color.White;
            botaoDireita.Image = Properties.Resources.Design_sem_nome;
            botaoDireita.Location = new System.Drawing.Point(1276, 463);
            botaoDireita.Name = "botaoDireita";
            botaoDireita.Size = new System.Drawing.Size(93, 63);
            botaoDireita.TabIndex = 2;
            botaoDireita.UseVisualStyleBackColor = false;
            // 
            // botaoEsquerda
            // 
            botaoEsquerda.Anchor = AnchorStyles.None;
            botaoEsquerda.FlatAppearance.BorderSize = 0;
            botaoEsquerda.FlatStyle = FlatStyle.Flat;
            botaoEsquerda.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            botaoEsquerda.ForeColor = System.Drawing.Color.White;
            botaoEsquerda.Image = Properties.Resources.Design_sem_nome__1_;
            botaoEsquerda.Location = new System.Drawing.Point(432, 463);
            botaoEsquerda.Name = "botaoEsquerda";
            botaoEsquerda.Size = new System.Drawing.Size(93, 63);
            botaoEsquerda.TabIndex = 4;
            botaoEsquerda.UseVisualStyleBackColor = false;
            // 
            // ListaPaciente
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = System.Drawing.Color.FromArgb(0, 97, 170);
            ClientSize = new System.Drawing.Size(1800, 1024);
            Controls.Add(botaoEsquerda);
            Controls.Add(visualizaPaciente);
            Controls.Add(botaoDireita);
            Controls.Add(btnNomeNaoEncontrado);
            Controls.Add(btnCancelar);
            Controls.Add(btnResultado);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListaPaciente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListaPaciente";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)visualizaPaciente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label btnResultado;
        private Button btnCancelar;
        private Button btnNomeNaoEncontrado;
        private DataGridView visualizaPaciente;
        private Button botaoDireita;
        private Button botaoEsquerda;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn medico;
        private DataGridViewTextBoxColumn horario;
        private DataGridViewTextBoxColumn Foto;
        private DataGridViewTextBoxColumn datanascimento;
    }
}