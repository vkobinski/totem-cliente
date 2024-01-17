namespace Totem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnChegada = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChegada
            // 
            this.btnChegada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChegada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(12)))));
            this.btnChegada.FlatAppearance.BorderSize = 0;
            this.btnChegada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChegada.Font = new System.Drawing.Font("Arial", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChegada.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnChegada.Location = new System.Drawing.Point(479, 415);
            this.btnChegada.Name = "btnChegada";
            this.btnChegada.Size = new System.Drawing.Size(842, 194);
            this.btnChegada.TabIndex = 0;
            this.btnChegada.Text = "Cheguei agora!";
            this.btnChegada.UseVisualStyleBackColor = false;
            this.btnChegada.Click += new System.EventHandler(this.btnChegada_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(170)))));
            this.ClientSize = new System.Drawing.Size(1800, 1024);
            this.Controls.Add(this.btnChegada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnChegada;
    }
}