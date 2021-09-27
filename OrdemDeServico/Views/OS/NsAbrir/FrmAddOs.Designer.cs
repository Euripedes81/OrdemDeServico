
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
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbPesquisarMaquina = new System.Windows.Forms.ToolStripButton();
            this.txtPatrimonio = new System.Windows.Forms.TextBox();
            this.txtDescricaoMaquina = new System.Windows.Forms.TextBox();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescricaoSolicitante = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSolicitante
            // 
            this.txtSolicitante.Location = new System.Drawing.Point(12, 44);
            this.txtSolicitante.Name = "txtSolicitante";
            this.txtSolicitante.ReadOnly = true;
            this.txtSolicitante.Size = new System.Drawing.Size(538, 20);
            this.txtSolicitante.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbPesquisarSolicitante});
            this.toolStrip1.Location = new System.Drawing.Point(553, 39);
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
            this.tsbPesquisarSolicitante.Click += new System.EventHandler(this.tsbPesquisarSolicitante_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbPesquisarMaquina});
            this.toolStrip2.Location = new System.Drawing.Point(553, 36);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(66, 25);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsbPesquisarMaquina
            // 
            this.tsbPesquisarMaquina.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPesquisarMaquina.Image = global::OrdemDeServico.Properties.Resources.icons8_pesquisar_26;
            this.tsbPesquisarMaquina.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPesquisarMaquina.Name = "tsbPesquisarMaquina";
            this.tsbPesquisarMaquina.Size = new System.Drawing.Size(23, 22);
            this.tsbPesquisarMaquina.Text = "Pesquisar";
            this.tsbPesquisarMaquina.Click += new System.EventHandler(this.tsbPesquisarMaquina_Click);
            // 
            // txtPatrimonio
            // 
            this.txtPatrimonio.Location = new System.Drawing.Point(39, 243);
            this.txtPatrimonio.Name = "txtPatrimonio";
            this.txtPatrimonio.ReadOnly = true;
            this.txtPatrimonio.Size = new System.Drawing.Size(538, 20);
            this.txtPatrimonio.TabIndex = 2;
            // 
            // txtDescricaoMaquina
            // 
            this.txtDescricaoMaquina.Location = new System.Drawing.Point(39, 290);
            this.txtDescricaoMaquina.Multiline = true;
            this.txtDescricaoMaquina.Name = "txtDescricaoMaquina";
            this.txtDescricaoMaquina.ReadOnly = true;
            this.txtDescricaoMaquina.Size = new System.Drawing.Size(538, 86);
            this.txtDescricaoMaquina.TabIndex = 4;
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.Location = new System.Drawing.Point(27, 438);
            this.txtDiagnostico.Multiline = true;
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(600, 86);
            this.txtDiagnostico.TabIndex = 8;
            this.txtDiagnostico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiagnostico_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Número de patrimônio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Descrição";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 422);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Diagnóstico";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(231, 559);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(117, 43);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDescricaoSolicitante);
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Controls.Add(this.txtSolicitante);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(27, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 153);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Solicitante";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Descrição";
            // 
            // txtDescricaoSolicitante
            // 
            this.txtDescricaoSolicitante.Location = new System.Drawing.Point(12, 90);
            this.txtDescricaoSolicitante.Multiline = true;
            this.txtDescricaoSolicitante.Name = "txtDescricaoSolicitante";
            this.txtDescricaoSolicitante.ReadOnly = true;
            this.txtDescricaoSolicitante.Size = new System.Drawing.Size(538, 43);
            this.txtDescricaoSolicitante.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.toolStrip2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(27, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(600, 207);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Máquina";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(637, 532);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Abertura de Ordem de Serviço";
            // 
            // FrmAddOs
            // 
            this.AcceptButton = this.btnSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 625);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDiagnostico);
            this.Controls.Add(this.txtDescricaoMaquina);
            this.Controls.Add(this.txtPatrimonio);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "FrmAddOs";
            this.Text = "Adicionar O.S";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSolicitante;
        private System.Windows.Forms.ToolStrip toolStrip1;
        protected System.Windows.Forms.ToolStripButton tsbPesquisarSolicitante;
        private System.Windows.Forms.ToolStrip toolStrip2;
        protected System.Windows.Forms.ToolStripButton tsbPesquisarMaquina;
        private System.Windows.Forms.TextBox txtPatrimonio;
        private System.Windows.Forms.TextBox txtDescricaoMaquina;
        private System.Windows.Forms.TextBox txtDiagnostico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescricaoSolicitante;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}