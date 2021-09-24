
namespace OrdemDeServico.Views
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secretariaTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.setorTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionarioTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.maquinaTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.oSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oSAbertaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oSFechadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.oSToolStripMenuItem,
            this.consultaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1148, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.secretariaTsmi,
            this.setorTsmi,
            this.funcionarioTsmi,
            this.maquinaTsmi});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.cadastroToolStripMenuItem.Text = "Manutenção";
            // 
            // secretariaTsmi
            // 
            this.secretariaTsmi.Name = "secretariaTsmi";
            this.secretariaTsmi.Size = new System.Drawing.Size(180, 22);
            this.secretariaTsmi.Text = "Secretaria";
            this.secretariaTsmi.Click += new System.EventHandler(this.secretariaTsmi_Click);
            // 
            // setorTsmi
            // 
            this.setorTsmi.Name = "setorTsmi";
            this.setorTsmi.Size = new System.Drawing.Size(180, 22);
            this.setorTsmi.Text = "Setor";
            this.setorTsmi.Click += new System.EventHandler(this.setorTsmi_Click);
            // 
            // funcionarioTsmi
            // 
            this.funcionarioTsmi.Name = "funcionarioTsmi";
            this.funcionarioTsmi.Size = new System.Drawing.Size(180, 22);
            this.funcionarioTsmi.Text = "Solicitante";
            this.funcionarioTsmi.Click += new System.EventHandler(this.funcionarioTsmi_Click);
            // 
            // maquinaTsmi
            // 
            this.maquinaTsmi.Name = "maquinaTsmi";
            this.maquinaTsmi.Size = new System.Drawing.Size(180, 22);
            this.maquinaTsmi.Text = "Maquina";
            this.maquinaTsmi.Click += new System.EventHandler(this.maquinaTsmi_Click);
            // 
            // oSToolStripMenuItem
            // 
            this.oSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abriToolStripMenuItem,
            this.fecharToolStripMenuItem});
            this.oSToolStripMenuItem.Name = "oSToolStripMenuItem";
            this.oSToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.oSToolStripMenuItem.Text = "O.S";
            // 
            // abriToolStripMenuItem
            // 
            this.abriToolStripMenuItem.Name = "abriToolStripMenuItem";
            this.abriToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.abriToolStripMenuItem.Text = "Abrir";
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.fecharToolStripMenuItem.Text = "Fechar";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oSAbertaToolStripMenuItem,
            this.oSFechadaToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // oSAbertaToolStripMenuItem
            // 
            this.oSAbertaToolStripMenuItem.Name = "oSAbertaToolStripMenuItem";
            this.oSAbertaToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.oSAbertaToolStripMenuItem.Text = "O.S Aberta";
            // 
            // oSFechadaToolStripMenuItem
            // 
            this.oSFechadaToolStripMenuItem.Name = "oSFechadaToolStripMenuItem";
            this.oSFechadaToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.oSFechadaToolStripMenuItem.Text = "O.S Fechada";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 646);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordem de Serviço";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secretariaTsmi;
        private System.Windows.Forms.ToolStripMenuItem setorTsmi;
        private System.Windows.Forms.ToolStripMenuItem funcionarioTsmi;
        private System.Windows.Forms.ToolStripMenuItem maquinaTsmi;
        private System.Windows.Forms.ToolStripMenuItem oSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oSAbertaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oSFechadaToolStripMenuItem;
    }
}