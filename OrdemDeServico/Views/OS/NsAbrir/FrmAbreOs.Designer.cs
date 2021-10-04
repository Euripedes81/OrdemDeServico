
namespace OrdemDeServico.Views.OS.NsAbrir
{
    partial class FrmAbreOs
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAbrir = new System.Windows.Forms.ToolStripButton();
            this.tsbExcluir = new System.Windows.Forms.ToolStripButton();
            this.tsbVisualizar = new System.Windows.Forms.ToolStripButton();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.txtPesquisarNome = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPesquisarOs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAbrir,
            this.tsbExcluir,
            this.tsbVisualizar});
            this.toolStrip1.Location = new System.Drawing.Point(9, 418);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(234, 25);
            this.toolStrip1.TabIndex = 20;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAbrir
            // 
            this.tsbAbrir.Image = global::OrdemDeServico.Properties.Resources.add_30;
            this.tsbAbrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAbrir.Name = "tsbAbrir";
            this.tsbAbrir.Size = new System.Drawing.Size(53, 22);
            this.tsbAbrir.Text = "Abrir";
            this.tsbAbrir.ToolTipText = "Abrir O.S";
            this.tsbAbrir.Click += new System.EventHandler(this.tsbAdicionar_Click);
            // 
            // tsbExcluir
            // 
            this.tsbExcluir.Image = global::OrdemDeServico.Properties.Resources.remove_30;
            this.tsbExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExcluir.Name = "tsbExcluir";
            this.tsbExcluir.Size = new System.Drawing.Size(62, 22);
            this.tsbExcluir.Text = "Excluir";
            this.tsbExcluir.Click += new System.EventHandler(this.tsbExcluir_Click);
            // 
            // tsbVisualizar
            // 
            this.tsbVisualizar.Image = global::OrdemDeServico.Properties.Resources.relatorio;
            this.tsbVisualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbVisualizar.Name = "tsbVisualizar";
            this.tsbVisualizar.Size = new System.Drawing.Size(76, 22);
            this.tsbVisualizar.Text = "Visualizar";
            this.tsbVisualizar.Click += new System.EventHandler(this.tsbVisualizar_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(9, 101);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowTemplate.Height = 25;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(765, 305);
            this.dgv.TabIndex = 19;
            // 
            // txtPesquisarNome
            // 
            this.txtPesquisarNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisarNome.Location = new System.Drawing.Point(111, 39);
            this.txtPesquisarNome.Name = "txtPesquisarNome";
            this.txtPesquisarNome.Size = new System.Drawing.Size(551, 20);
            this.txtPesquisarNome.TabIndex = 17;
            this.txtPesquisarNome.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPesquisarNome_MouseClick);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisar.Location = new System.Drawing.Point(668, 37);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(77, 23);
            this.btnPesquisar.TabIndex = 18;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtPesquisarOs);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.txtPesquisarNome);
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 83);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar por:";
            // 
            // txtPesquisarOs
            // 
            this.txtPesquisarOs.Location = new System.Drawing.Point(16, 39);
            this.txtPesquisarOs.Name = "txtPesquisarOs";
            this.txtPesquisarOs.Size = new System.Drawing.Size(87, 20);
            this.txtPesquisarOs.TabIndex = 22;
            this.txtPesquisarOs.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPesquisarOs_MouseClick);
            this.txtPesquisarOs.TextChanged += new System.EventHandler(this.txtPesquisaOs_TextChanged);
            this.txtPesquisarOs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisaOs_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nome do solicitante";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Número da O.S";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmAbreOs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAbreOs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Abrir Ordem de Serviço";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAbrir;
        private System.Windows.Forms.ToolStripButton tsbExcluir;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox txtPesquisarNome;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtPesquisarOs;
        private System.Windows.Forms.ToolStripButton tsbVisualizar;
    }
}