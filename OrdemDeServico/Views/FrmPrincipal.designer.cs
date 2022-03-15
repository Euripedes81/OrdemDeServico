
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
            this.gerenciadorOsTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tslUsuario = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tslNome = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAterarSenha = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSair = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.setorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.oSToolStripMenuItem,
            this.relatórioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1126, 24);
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
            this.secretariaTsmi.Size = new System.Drawing.Size(129, 22);
            this.secretariaTsmi.Text = "Secretaria";
            this.secretariaTsmi.Click += new System.EventHandler(this.SecretariaTsmi_Click);
            // 
            // setorTsmi
            // 
            this.setorTsmi.Name = "setorTsmi";
            this.setorTsmi.Size = new System.Drawing.Size(129, 22);
            this.setorTsmi.Text = "Setor";
            this.setorTsmi.Click += new System.EventHandler(this.SetorTsmi_Click);
            // 
            // funcionarioTsmi
            // 
            this.funcionarioTsmi.Name = "funcionarioTsmi";
            this.funcionarioTsmi.Size = new System.Drawing.Size(129, 22);
            this.funcionarioTsmi.Text = "Solicitante";
            this.funcionarioTsmi.Click += new System.EventHandler(this.FuncionarioTsmi_Click);
            // 
            // maquinaTsmi
            // 
            this.maquinaTsmi.Name = "maquinaTsmi";
            this.maquinaTsmi.Size = new System.Drawing.Size(129, 22);
            this.maquinaTsmi.Text = "Maquina";
            this.maquinaTsmi.Click += new System.EventHandler(this.MaquinaTsmi_Click);
            // 
            // oSToolStripMenuItem
            // 
            this.oSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerenciadorOsTsmi,
            this.consultaToolStripMenuItem});
            this.oSToolStripMenuItem.Name = "oSToolStripMenuItem";
            this.oSToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.oSToolStripMenuItem.Text = "O.S";
            // 
            // gerenciadorOsTsmi
            // 
            this.gerenciadorOsTsmi.Name = "gerenciadorOsTsmi";
            this.gerenciadorOsTsmi.Size = new System.Drawing.Size(180, 22);
            this.gerenciadorOsTsmi.Text = "Gerenciador";
            this.gerenciadorOsTsmi.Click += new System.EventHandler(this.GerenciadorOsTsmi_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultaToolStripMenuItem.Text = "Consulta O.S Aberta";
            this.consultaToolStripMenuItem.Click += new System.EventHandler(this.ConsultaToolStripMenuItem_Click);
            // 
            // relatórioToolStripMenuItem
            // 
            this.relatórioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setorToolStripMenuItem});
            this.relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            this.relatórioToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.relatórioToolStripMenuItem.Text = "Relatório";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tslUsuario,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.tslNome,
            this.toolStripSeparator2,
            this.tsbAterarSenha,
            this.toolStripSeparator3,
            this.tsbSair,
            this.toolStripSeparator4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 644);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1126, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(53, 22);
            this.toolStripLabel1.Text = "Usuário: ";
            // 
            // tslUsuario
            // 
            this.tslUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslUsuario.Name = "tslUsuario";
            this.tslUsuario.Size = new System.Drawing.Size(47, 22);
            this.tslUsuario.Text = "usuario";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(46, 22);
            this.toolStripLabel2.Text = "Nome: ";
            // 
            // tslNome
            // 
            this.tslNome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslNome.Name = "tslNome";
            this.tslNome.Size = new System.Drawing.Size(39, 22);
            this.tslNome.Text = "nome";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbAterarSenha
            // 
            this.tsbAterarSenha.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbAterarSenha.Image = ((System.Drawing.Image)(resources.GetObject("tsbAterarSenha.Image")));
            this.tsbAterarSenha.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAterarSenha.Name = "tsbAterarSenha";
            this.tsbAterarSenha.Size = new System.Drawing.Size(80, 22);
            this.tsbAterarSenha.Text = "Alterar senha";
            this.tsbAterarSenha.Click += new System.EventHandler(this.TsbAterarSenha_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbSair
            // 
            this.tsbSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSair.Image = ((System.Drawing.Image)(resources.GetObject("tsbSair.Image")));
            this.tsbSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSair.Name = "tsbSair";
            this.tsbSair.Size = new System.Drawing.Size(30, 22);
            this.tsbSair.Text = "Sair";
            this.tsbSair.Click += new System.EventHandler(this.TsbSair_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // setorToolStripMenuItem
            // 
            this.setorToolStripMenuItem.Name = "setorToolStripMenuItem";
            this.setorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setorToolStripMenuItem.Text = "Setor";
            this.setorToolStripMenuItem.Click += new System.EventHandler(this.SetorToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 669);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordem de Serviço";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem gerenciadorOsTsmi;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel tslUsuario;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel tslNome;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbAterarSenha;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbSair;
        private System.Windows.Forms.ToolStripMenuItem relatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem setorToolStripMenuItem;
    }
}