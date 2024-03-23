namespace Automoção
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGit = new System.Windows.Forms.Button();
            this.btnLinkedin = new System.Windows.Forms.Button();
            this.btnYoutube = new System.Windows.Forms.Button();
            this.painel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnGit
            // 
            this.btnGit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGit.Location = new System.Drawing.Point(10, 12);
            this.btnGit.Name = "btnGit";
            this.btnGit.Size = new System.Drawing.Size(87, 35);
            this.btnGit.TabIndex = 0;
            this.btnGit.Text = "GitHub";
            this.btnGit.UseVisualStyleBackColor = false;
            this.btnGit.Click += new System.EventHandler(this.btnEmail_Click);
            // 
            // btnLinkedin
            // 
            this.btnLinkedin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLinkedin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLinkedin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLinkedin.Location = new System.Drawing.Point(118, 12);
            this.btnLinkedin.Name = "btnLinkedin";
            this.btnLinkedin.Size = new System.Drawing.Size(87, 35);
            this.btnLinkedin.TabIndex = 1;
            this.btnLinkedin.Text = "LinkedIn";
            this.btnLinkedin.UseVisualStyleBackColor = false;
            this.btnLinkedin.Click += new System.EventHandler(this.btnLinkedin_Click);
            // 
            // btnYoutube
            // 
            this.btnYoutube.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnYoutube.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYoutube.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnYoutube.Location = new System.Drawing.Point(226, 12);
            this.btnYoutube.Name = "btnYoutube";
            this.btnYoutube.Size = new System.Drawing.Size(87, 35);
            this.btnYoutube.TabIndex = 2;
            this.btnYoutube.Text = "You Tube";
            this.btnYoutube.UseVisualStyleBackColor = false;
            this.btnYoutube.Click += new System.EventHandler(this.btnYoutube_Click);
            // 
            // painel
            // 
            this.painel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.painel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.painel.Location = new System.Drawing.Point(12, 70);
            this.painel.Name = "painel";
            this.painel.Size = new System.Drawing.Size(1150, 490);
            this.painel.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1168, 572);
            this.Controls.Add(this.painel);
            this.Controls.Add(this.btnYoutube);
            this.Controls.Add(this.btnLinkedin);
            this.Controls.Add(this.btnGit);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Automoção de Processos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGit;
        private System.Windows.Forms.Button btnLinkedin;
        private System.Windows.Forms.Button btnYoutube;
        private System.Windows.Forms.Panel painel;
    }
}

