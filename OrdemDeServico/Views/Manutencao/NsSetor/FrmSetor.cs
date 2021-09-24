﻿using OrdemDeServico.Helpers;
using OrdemDeServico.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OrdemDeServico.Views.Manutencao.NsSetor
{
    public partial class FrmSetor : Form
    {
        private Setor setor = new Setor();
        private List<Setor> setores = new List<Setor>();
        private Secretaria secretaria;
        public FrmSetor()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisaDgv();
        }

        private void tsbAdicionar_Click(object sender, EventArgs e)
        {
            FrmAddSetor frmAdicionar = new FrmAddSetor();
            frmAdicionar.ShowDialog();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (ObterLinhaDgv())
            {
                FrmEdtSetor frmEditar = new FrmEdtSetor(setor);
                frmEditar.ShowDialog();
            }
        }
        private void tsbExcluir_Click(object sender, EventArgs e)
        {
            if (ObterLinhaDgv())
            {
                if (MessageBox.Show("Deseja excluir este registro?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                     == DialogResult.Yes)
                {
                    CrudHelper.Excluir(setor);
                    PesquisaDgv();
                }
            }
        }
        private void CriarDgv()
        {
            string[] nomeColuna = new string[] { "Id", "Nome", "Descricao", "Secretaria", "IdSecretaria" };
            string[] textoColuna = new string[] { "Id", "Nome", "Descrição", "Secretaria", "IdSecretaria" };
            int[] tamanho = new[] { 50, 250, 250, 250, 50 };
            bool[] visibilidade = new[] { true, true, true, true, false };
            Criador.CriaDataGridView(dgv, nomeColuna, textoColuna, tamanho, visibilidade);
        }
        private void PesquisaDgv()
        {
            CriarDgv();
            if ((setores = PesquisadorHelper.PesquisarSetor(txtPesquisar.Text)) != null)
            {
                foreach (Setor setor in setores)
                {
                    if ((secretaria = PesquisadorHelper.PesquisarSecretaria(setor.secretaria.Id)) != null)
                    {

                        setor.secretaria = secretaria;
                        dgv.Rows.Add(setor.Id, setor.Nome, setor.Descricao, setor.secretaria.Nome, setor.secretaria.Id);

                    }
                }
            }
        }
        private bool ObterLinhaDgv()
        {

            if (dgv.SelectedRows.Count > 0)
            {
                setor.Id = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value.ToString());
                setor.Nome = dgv.CurrentRow.Cells[1].Value.ToString();
                setor.Descricao = dgv.CurrentRow.Cells[2].Value.ToString();
                setor.secretaria.Nome = dgv.CurrentRow.Cells[3].Value.ToString();
                setor.secretaria.Id = Convert.ToInt32(dgv.CurrentRow.Cells[4].Value);
                return true;
            }
            else
            {
                return false;
            }

        }


    }
}
