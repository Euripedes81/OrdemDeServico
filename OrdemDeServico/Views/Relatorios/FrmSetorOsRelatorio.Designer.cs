
namespace OrdemDeServico.Views.Relatorios
{
    partial class FrmSetorOsRelatorio
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSetorOsRelatorio));
            this.cbSetor = new System.Windows.Forms.ComboBox();
            this.btnGerarRelatorio = new System.Windows.Forms.Button();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSecretaria = new System.Windows.Forms.ComboBox();
            this.rprtvSetor = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ordemServicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ordemServicoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSetor
            // 
            this.cbSetor.FormattingEnabled = true;
            this.cbSetor.Location = new System.Drawing.Point(12, 64);
            this.cbSetor.Name = "cbSetor";
            this.cbSetor.Size = new System.Drawing.Size(460, 21);
            this.cbSetor.TabIndex = 1;
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.Location = new System.Drawing.Point(221, 116);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Size = new System.Drawing.Size(90, 23);
            this.btnGerarRelatorio.TabIndex = 6;
            this.btnGerarRelatorio.Text = "Gerar";
            this.btnGerarRelatorio.UseVisualStyleBackColor = true;
            this.btnGerarRelatorio.Click += new System.EventHandler(this.btnGerarRelatorio_Click);
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(13, 119);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(85, 20);
            this.dtpInicio.TabIndex = 3;
            this.dtpInicio.ValueChanged += new System.EventHandler(this.dtpInicio_ValueChanged);
            // 
            // dtpFim
            // 
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFim.Location = new System.Drawing.Point(116, 119);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(85, 20);
            this.dtpFim.TabIndex = 5;
            this.dtpFim.ValueChanged += new System.EventHandler(this.dtpFim_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Início";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fim";
            // 
            // cbSecretaria
            // 
            this.cbSecretaria.FormattingEnabled = true;
            this.cbSecretaria.Location = new System.Drawing.Point(14, 21);
            this.cbSecretaria.Name = "cbSecretaria";
            this.cbSecretaria.Size = new System.Drawing.Size(460, 21);
            this.cbSecretaria.TabIndex = 0;
            this.cbSecretaria.SelectedIndexChanged += new System.EventHandler(this.cbSecretaria_SelectedIndexChanged);
            // 
            // rprtvSetor
            // 
            this.rprtvSetor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "dsOrdemServicoSetor";
            reportDataSource1.Value = this.ordemServicoBindingSource;
            this.rprtvSetor.LocalReport.DataSources.Add(reportDataSource1);
            this.rprtvSetor.LocalReport.ReportEmbeddedResource = "OrdemDeServico.Reports.RprtOsSetor.rdlc";
            this.rprtvSetor.Location = new System.Drawing.Point(12, 159);
            this.rprtvSetor.Name = "rprtvSetor";
            this.rprtvSetor.ServerReport.BearerToken = null;
            this.rprtvSetor.Size = new System.Drawing.Size(975, 430);
            this.rprtvSetor.TabIndex = 7;
            // 
            // ordemServicoBindingSource
            // 
            this.ordemServicoBindingSource.DataSource = typeof(OrdemDeServico.Model.OrdemServico);
            // 
            // FrmSetorOsRelatorio
            // 
            this.AcceptButton = this.btnGerarRelatorio;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 601);
            this.Controls.Add(this.rprtvSetor);
            this.Controls.Add(this.cbSecretaria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFim);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.btnGerarRelatorio);
            this.Controls.Add(this.cbSetor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSetorOsRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório por Setor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmSetorOsRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordemServicoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSetor;
        private System.Windows.Forms.Button btnGerarRelatorio;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSecretaria;
        private System.Windows.Forms.BindingSource ordemServicoBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer rprtvSetor;
    }
}