
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
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.txtPatrimonio = new System.Windows.Forms.TextBox();
            this.txtDescricaoMaquina = new System.Windows.Forms.TextBox();
            this.dtpAberturaOs = new System.Windows.Forms.DateTimePicker();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsbPesquisarSolicitante = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSolicitante
            // 
            this.txtSolicitante.Location = new System.Drawing.Point(12, 43);
            this.txtSolicitante.Name = "txtSolicitante";
            this.txtSolicitante.ReadOnly = true;
            this.txtSolicitante.Size = new System.Drawing.Size(495, 20);
            this.txtSolicitante.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbPesquisarSolicitante});
            this.toolStrip1.Location = new System.Drawing.Point(510, 38);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(35, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip2.Location = new System.Drawing.Point(510, 88);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(66, 25);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // txtPatrimonio
            // 
            this.txtPatrimonio.Location = new System.Drawing.Point(12, 93);
            this.txtPatrimonio.Name = "txtPatrimonio";
            this.txtPatrimonio.ReadOnly = true;
            this.txtPatrimonio.Size = new System.Drawing.Size(495, 20);
            this.txtPatrimonio.TabIndex = 2;
            // 
            // txtDescricaoMaquina
            // 
            this.txtDescricaoMaquina.Location = new System.Drawing.Point(12, 140);
            this.txtDescricaoMaquina.Multiline = true;
            this.txtDescricaoMaquina.Name = "txtDescricaoMaquina";
            this.txtDescricaoMaquina.ReadOnly = true;
            this.txtDescricaoMaquina.Size = new System.Drawing.Size(527, 86);
            this.txtDescricaoMaquina.TabIndex = 4;
            // 
            // dtpAberturaOs
            // 
            this.dtpAberturaOs.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAberturaOs.Location = new System.Drawing.Point(12, 374);
            this.dtpAberturaOs.Name = "dtpAberturaOs";
            this.dtpAberturaOs.Size = new System.Drawing.Size(105, 20);
            this.dtpAberturaOs.TabIndex = 7;
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.Location = new System.Drawing.Point(12, 256);
            this.txtDiagnostico.Multiline = true;
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(527, 86);
            this.txtDiagnostico.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Solicitante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Número de patrimônio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Descrição da máquina";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Diagnóstico";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Data de abertura";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(423, 358);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(117, 43);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::OrdemDeServico.Properties.Resources.icons8_pesquisar_26;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Pesquisar";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
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
            // FrmAddOs
            // 
            this.AcceptButton = this.btnSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 415);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDiagnostico);
            this.Controls.Add(this.dtpAberturaOs);
            this.Controls.Add(this.txtDescricaoMaquina);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.txtPatrimonio);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtSolicitante);
            this.Name = "FrmAddOs";
            this.Text = "Adicionar O.S";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSolicitante;
        private System.Windows.Forms.ToolStrip toolStrip1;
        protected System.Windows.Forms.ToolStripButton tsbPesquisarSolicitante;
        private System.Windows.Forms.ToolStrip toolStrip2;
        protected System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TextBox txtPatrimonio;
        private System.Windows.Forms.TextBox txtDescricaoMaquina;
        private System.Windows.Forms.DateTimePicker dtpAberturaOs;
        private System.Windows.Forms.TextBox txtDiagnostico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalvar;
    }
}