
namespace OrdemDeServico.Views.OS.NsAbrir
{
    partial class FrmAddOs
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
            this.txtSolicitante = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbPesquisarSolicitante = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSolicitante
            // 
            this.txtSolicitante.Location = new System.Drawing.Point(21, 29);
            this.txtSolicitante.Name = "txtSolicitante";
            this.txtSolicitante.ReadOnly = true;
            this.txtSolicitante.Size = new System.Drawing.Size(371, 20);
            this.txtSolicitante.TabIndex = 0;
            this.txtSolicitante.Text = "Solicitante";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbPesquisarSolicitante});
            this.toolStrip1.Location = new System.Drawing.Point(395, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(35, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbPesquisarSolicitante
            // 
            this.tsbPesquisarSolicitante.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPesquisarSolicitante.Image = global::OrdemDeServico.Properties.Resources.icons8_pesquisar_26;
            this.tsbPesquisarSolicitante.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPesquisarSolicitante.Name = "tsbPesquisarSolicitante";
            this.tsbPesquisarSolicitante.Size = new System.Drawing.Size(23, 22);
            this.tsbPesquisarSolicitante.Text = "Pesquisar";
            // 
            // FrmAddOs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtSolicitante);
            this.Name = "FrmAddOs";
            this.Text = "Adicionar O.S";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSolicitante;
        private System.Windows.Forms.ToolStrip toolStrip1;
        protected System.Windows.Forms.ToolStripButton tsbPesquisarSolicitante;
    }
}