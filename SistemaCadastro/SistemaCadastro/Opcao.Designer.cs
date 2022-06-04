namespace SistemaCadastro
{
    partial class frmOpcao
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
            this.btnVotar = new MetroFramework.Controls.MetroButton();
            this.btnCriarRanking = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnVotar
            // 
            this.btnVotar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnVotar.Location = new System.Drawing.Point(32, 94);
            this.btnVotar.Name = "btnVotar";
            this.btnVotar.Size = new System.Drawing.Size(210, 135);
            this.btnVotar.TabIndex = 0;
            this.btnVotar.Text = "Votar ?";
            this.btnVotar.UseSelectable = true;
            this.btnVotar.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btnCriarRanking
            // 
            this.btnCriarRanking.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnCriarRanking.Location = new System.Drawing.Point(265, 94);
            this.btnCriarRanking.Name = "btnCriarRanking";
            this.btnCriarRanking.Size = new System.Drawing.Size(210, 135);
            this.btnCriarRanking.TabIndex = 1;
            this.btnCriarRanking.Text = "Criar Ranking";
            this.btnCriarRanking.UseSelectable = true;
            this.btnCriarRanking.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // frmOpcao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 284);
            this.Controls.Add(this.btnCriarRanking);
            this.Controls.Add(this.btnVotar);
            this.Name = "frmOpcao";
            this.Text = "Escolha";
            this.Load += new System.EventHandler(this.frmOpcao_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnVotar;
        private MetroFramework.Controls.MetroButton btnCriarRanking;
    }
}