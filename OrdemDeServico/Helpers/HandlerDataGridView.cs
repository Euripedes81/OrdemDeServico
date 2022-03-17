using OrdemDeServico.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OrdemDeServico.Helpers
{
    class HandlerDataGridView
    {
        private static void CriarDgvMaquina(DataGridView dgv)
        {
            string[] nomeColuna = new string[] { "Id", "Patrimonio", "Tipo", "Descricao", "Setor", "IdSetor", "Secretaria" };
            string[] textoColuna = new string[] { "Id", "Patrimônio", "Tipo", "Descrição", "Setor", "IdSetor", "Secretaria" };
            int[] tamanho = new[] { 50, 100, 250, 250, 250, 50, 250 };
            bool[] visibilidade = new[] { true, true, true, true, true, false, true };
            CriadorDataCridViewHelper.CriaDataGridView(dgv, nomeColuna, textoColuna, tamanho, visibilidade);
        }
        private static void CriarDgvSolicitante(DataGridView dgv)
        {
            string[] nomeColuna = new string[] { "Id", "Nome", "Descricao", "Setor", "IdSetor", "Secretaria" };
            string[] textoColuna = new string[] { "Id", "Nome", "Descrição", "Setor", "IdSetor", "Secretaria" };
            int[] tamanho = new[] { 50, 250, 250, 250, 50, 250 };
            bool[] visibilidade = new[] { true, true, true, true, false, true };
            CriadorDataCridViewHelper.CriaDataGridView(dgv, nomeColuna, textoColuna, tamanho, visibilidade);
        }
        private static void CriarDgvAtendente(DataGridView dgv)
        {
            string[] nomeColuna = new string[] { "Id", "Usuario", "Nome" };
            string[] textoColuna = new string[] { "Id", "Usuario", "Nome" };
            int[] tamanho = new[] { 50, 250, 250 };           
            CriadorDataCridViewHelper.CriaDataGridView(dgv, nomeColuna, textoColuna, tamanho);
        }
        private static void CriarDgvSecretaria(DataGridView dgv)
        {
            string[] nomeColuna = new string[] { "Id", "Nome", "Descricao", "Telefone" };
            string[] textoColuna = new string[] { "Id", "Nome", "Descrição", "Telefone" };
            int[] tamanho = new[] { 50, 250, 250, 100 };
            CriadorDataCridViewHelper.CriaDataGridView(dgv, nomeColuna, textoColuna, tamanho);
        }
        private static void CriarDgvOrdemServico(DataGridView dgv, string status)
        {
            if (status == "abertura")
            {

                string[] nomeColuna = new string[] { "Id", "Solicitante", "Maquina", "Tipo", "Diagnostico", "DataAbertura", "IdAtendente", "Atendente" };
                string[] textoColuna = new string[] { "Número", "Solicitante", "Máquina", "Tipo", "Diagnóstico", "Abertura", "IdAtendente","Atendente" };
                int[] tamanho = new[] { 50, 250, 250, 250, 250, 250, 150, 150 };
                bool[] visibilidade = new[] { true, true, true, true, true, true, false, true };
                CriadorDataCridViewHelper.CriaDataGridView(dgv, nomeColuna, textoColuna, tamanho, visibilidade);
            }
            else
            {
                string[] nomeColuna = new string[] { "Id", "Solicitante", "Maquina","Tipo", "Diagnostico", "DataAbertura", "Solucao", "DataFechamento",
                    "Observacao", "Atendente" };
                string[] textoColuna = new string[] { "Número", "Solicitante", "Máquina", "Tipo", "Diagnóstico", "Abertura", "Solução", "Fechamento",
                    "Observação", "Atendente" };
                int[] tamanho = new[] { 50, 250, 250, 250, 250, 250, 250, 250, 250, 150 };                
                CriadorDataCridViewHelper.CriaDataGridView(dgv, nomeColuna, textoColuna, tamanho);
            }
        }
       
        public static void PesquisaDgv(DataGridView dgv, string txtPesquisar, List<Secretaria> secretarias)
        {
            CriarDgvSecretaria(dgv);
            if((secretarias = SelectData.PesquisarSecretaria(txtPesquisar)) != null)
            {
                foreach(Secretaria secretaria in secretarias)
                {
                    dgv.Rows.Add(secretaria.Id, secretaria.Nome, secretaria.Descricao, secretaria.Telefone);
                }
            }
        }
        public static void PesquisaDgv(DataGridView dgv, string txtPesquisar, List<Maquina> maquinas, Setor setor )
        {
            CriarDgvMaquina(dgv);

            int patrimonio = Convert.ToInt32(txtPesquisar);
            if ((maquinas = SelectData.PesquisarMaquinaPatrimonio(patrimonio)) != null)
            {
                foreach (Maquina maquina in maquinas)
                {
                    if ((setor = SelectData.PesquisarSetorId(maquina.SetorMqn.Id)) != null)
                    {
                        maquina.SetorMqn = setor;
                        if ((maquina.SetorMqn.SecretariaStr = SelectData.PesquisarSecretariaId(maquina.SetorMqn.SecretariaStr.Id)) != null)
                        {
                            dgv.Rows.Add(maquina.Id, maquina.Patrimonio, maquina.Tipo, maquina.Descricao, maquina.SetorMqn.Nome,
                                maquina.SetorMqn.Id, maquina.SetorMqn.SecretariaStr.Nome);
                        }

                    }
                }
            }
        }
        public static void PesquisaDgv(DataGridView dgv, string textoPesquisa, List<Solicitante> solicitantes, Setor setor)
        {
            CriarDgvSolicitante(dgv);
            if ((solicitantes = SelectData.PesquisarSolicitante(textoPesquisa)) != null)
            {
                foreach (Solicitante solicitante in solicitantes)
                {
                    if ((setor = SelectData.PesquisarSetorId(solicitante.SetorSolicitante.Id)) != null)
                    {
                        solicitante.SetorSolicitante = setor;
                        if ((solicitante.SetorSolicitante.SecretariaStr = SelectData.PesquisarSecretariaId(solicitante.SetorSolicitante.SecretariaStr.Id)) != null)
                        {
                            dgv.Rows.Add(solicitante.Id, solicitante.Nome, solicitante.Descricao, solicitante.SetorSolicitante.Nome,
                                solicitante.SetorSolicitante.Id, solicitante.SetorSolicitante.SecretariaStr.Nome);
                        }                        
                    }
                }                
            }
        }
        public static void PesquisaDgv(DataGridView dgv, string textoPesquisa, List<Atendente> atendentes)
        {
            CriarDgvAtendente(dgv);
            if ((atendentes = SelectData.PesquisarAtendente(textoPesquisa)) != null)
            {
                foreach (Atendente atendente in atendentes)
                {
                    dgv.Rows.Add(atendente.Id, atendente.Usuario, atendente.Nome);

                }
            }
        }
        public static void PesquisaDgvOsAberta(DataGridView dgv, string textoPesquisa)
        {
            List<Solicitante> solicitantes;
            List<OrdemServico> ordemServicos;

            CriarDgvOrdemServico(dgv, "abertura");
            if ((solicitantes = SelectData.PesquisarSolicitante(textoPesquisa)) != null)
            {
                foreach (Solicitante solicitante in solicitantes)
                {
                    if ((ordemServicos = SelectData.PesquisarOrdemServicoSolicitante(solicitante.Id)) != null)
                    {
                       foreach(OrdemServico ordemServico in ordemServicos)
                       {
                            if (string.IsNullOrEmpty(ordemServico.Solucao))
                            {
                                ordemServico.SolicitanteOs = SelectData.PesquisarSolicitanteId(ordemServico.SolicitanteOs.Id);
                                ordemServico.MaquinaOs = SelectData.PesquisarMaquinaId(ordemServico.MaquinaOs.Id);
                                ordemServico.AtendenteOs = SelectData.PesquisarAtendenteId(ordemServico.AtendenteOs.Id);
                                dgv.Rows.Add(ordemServico.Id, ordemServico.SolicitanteOs.Nome, ordemServico.MaquinaOs.Patrimonio, ordemServico.MaquinaOs.Tipo,
                                    ordemServico.Diagnostico, ordemServico.DataAbertura, ordemServico.AtendenteOs.Id, ordemServico.AtendenteOs.Nome); 
                            }
                       }
                    }
                }
            }
        }
        public static void PesquisaDgvOsAberta(DataGridView dgv, int numeroOs)
        {
            List<OrdemServico> ordemServicos;

            CriarDgvOrdemServico(dgv, "abertura");

            if ((ordemServicos = SelectData.PesquisarOrdemServico(numeroOs)) != null)
            {
                foreach (OrdemServico ordemServico in ordemServicos)
                {
                    if (string.IsNullOrEmpty(ordemServico.Solucao))
                    {
                        ordemServico.SolicitanteOs = SelectData.PesquisarSolicitanteId(ordemServico.SolicitanteOs.Id);
                        ordemServico.MaquinaOs = SelectData.PesquisarMaquinaId(ordemServico.MaquinaOs.Id);
                        ordemServico.AtendenteOs = SelectData.PesquisarAtendenteId(ordemServico.AtendenteOs.Id);
                        dgv.Rows.Add(ordemServico.Id, ordemServico.SolicitanteOs.Nome, ordemServico.MaquinaOs.Patrimonio, ordemServico.MaquinaOs.Tipo,
                            ordemServico.Diagnostico, ordemServico.DataAbertura, ordemServico.AtendenteOs.Id, ordemServico.AtendenteOs.Nome); 
                    }
                }
            }

        }
        public static void PesquisaDgvOsFechada(DataGridView dgv, string textoPesquisa)
        {
            List<Solicitante> solicitantes;
            List<OrdemServico> ordemServicos;

            CriarDgvOrdemServico(dgv, "fechada");
            if ((solicitantes = SelectData.PesquisarSolicitante(textoPesquisa)) != null)
            {
                foreach (Solicitante solicitante in solicitantes)
                {
                    if ((ordemServicos = SelectData.PesquisarOrdemServicoSolicitante(solicitante.Id)) != null)
                    {
                        foreach (var ordemServico in ordemServicos)
                        {
                            if (!string.IsNullOrEmpty(ordemServico.Solucao))
                            {
                                ordemServico.SolicitanteOs = SelectData.PesquisarSolicitanteId(ordemServico.SolicitanteOs.Id);
                                ordemServico.MaquinaOs = SelectData.PesquisarMaquinaId(ordemServico.MaquinaOs.Id);
                                ordemServico.AtendenteOs = SelectData.PesquisarAtendenteId(ordemServico.AtendenteOs.Id);
                                dgv.Rows.Add(ordemServico.Id, ordemServico.SolicitanteOs.Nome, ordemServico.MaquinaOs.Patrimonio, ordemServico.MaquinaOs.Tipo,
                                    ordemServico.Diagnostico, ordemServico.DataAbertura, ordemServico.Solucao, ordemServico.DataFechamento, ordemServico.Observacao,
                                    ordemServico.AtendenteOs.Nome); 
                            }
                        }
                    }
                }
            }
        }
        public static void PesquisaDgvOsFechada(DataGridView dgv, int numeroOs)
        {
            List<OrdemServico> ordemServicos;

            CriarDgvOrdemServico(dgv, "fechada");

            if ((ordemServicos = SelectData.PesquisarOrdemServico(numeroOs)) != null)
            {
                foreach (var ordemServico in ordemServicos)
                {
                    if (!string.IsNullOrEmpty(ordemServico.Solucao))
                    {
                        ordemServico.SolicitanteOs = SelectData.PesquisarSolicitanteId(ordemServico.SolicitanteOs.Id);
                        ordemServico.MaquinaOs = SelectData.PesquisarMaquinaId(ordemServico.MaquinaOs.Id);
                        ordemServico.AtendenteOs = SelectData.PesquisarAtendenteId(ordemServico.AtendenteOs.Id);
                        dgv.Rows.Add(ordemServico.Id, ordemServico.SolicitanteOs.Nome, ordemServico.MaquinaOs.Patrimonio, ordemServico.MaquinaOs.Tipo,
                            ordemServico.Diagnostico, ordemServico.DataAbertura, ordemServico.Solucao, ordemServico.DataFechamento, ordemServico.Observacao,
                            ordemServico.AtendenteOs.Nome);
                    }
                }
            }

        }
        public static bool ObterLinhaDgv(DataGridView dgv, Maquina maquina)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                maquina.Id = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value.ToString());
                maquina.Patrimonio = Convert.ToInt32(dgv.CurrentRow.Cells[1].Value.ToString());
                maquina.Tipo = dgv.CurrentRow.Cells[2].Value.ToString();
                maquina.Descricao = dgv.CurrentRow.Cells[3].Value.ToString();
                maquina.SetorMqn.Nome = dgv.CurrentRow.Cells[4].Value.ToString();
                maquina.SetorMqn.Id = Convert.ToInt32(dgv.CurrentRow.Cells[5].Value);
                return true;
            }
            else
            {
                return false;
            }
        }       
       
        public static bool ObterLinhaDgv(DataGridView dgv, Solicitante solicitante)
        {
            if (dgv.SelectedRows.Count > 0)
            {                
                solicitante.Id = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value.ToString());
                solicitante.Nome = dgv.CurrentRow.Cells[1].Value.ToString();
                solicitante.Descricao = dgv.CurrentRow.Cells[2].Value.ToString();
                solicitante.SetorSolicitante.Nome = dgv.CurrentRow.Cells[3].Value.ToString();
                solicitante.SetorSolicitante.Id = Convert.ToInt32(dgv.CurrentRow.Cells[4].Value);
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool ObterLinhaDgv(DataGridView dgv, Secretaria secretaria)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                secretaria.Id = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value.ToString());
                secretaria.Nome = dgv.CurrentRow.Cells[1].Value.ToString();
                secretaria.Descricao = dgv.CurrentRow.Cells[2].Value.ToString();
                secretaria.Telefone = dgv.CurrentRow.Cells[3].Value.ToString();                
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool ObterLinhaDgv(DataGridView dgv, Atendente atendente)
        {
            if (dgv.SelectedRows.Count > 0)
            {                
                atendente.Id = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value.ToString());
                atendente.Usuario = dgv.CurrentRow.Cells[1].Value.ToString();
                atendente.Nome = dgv.CurrentRow.Cells[2].Value.ToString();               
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool ObterLinhaDgvOsAberta(DataGridView dgv, OrdemServico ordemServico)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                ordemServico.Id = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value.ToString());
                ordemServico.SolicitanteOs.Nome = dgv.CurrentRow.Cells[1].Value.ToString();
                ordemServico.MaquinaOs.Patrimonio = Convert.ToInt32(dgv.CurrentRow.Cells[2].Value.ToString());
                ordemServico.MaquinaOs.Tipo = dgv.CurrentRow.Cells[3].Value.ToString();
                ordemServico.Diagnostico = dgv.CurrentRow.Cells[4].Value.ToString();
                ordemServico.DataAbertura = Convert.ToDateTime(dgv.CurrentRow.Cells[5].Value);
                ordemServico.AtendenteOs.Id = Convert.ToInt32(dgv.CurrentRow.Cells[6].Value.ToString());
                ordemServico.AtendenteOs.Nome = dgv.CurrentRow.Cells[7].Value.ToString();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool ObterLinhaDgvOsFechada(DataGridView dgv, OrdemServico ordemServico)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                ordemServico.Id = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value.ToString());
                ordemServico.SolicitanteOs.Nome = dgv.CurrentRow.Cells[1].Value.ToString();
                ordemServico.MaquinaOs.Patrimonio = Convert.ToInt32(dgv.CurrentRow.Cells[2].Value.ToString());
                ordemServico.MaquinaOs.Tipo = dgv.CurrentRow.Cells[3].Value.ToString();
                ordemServico.Diagnostico = dgv.CurrentRow.Cells[4].Value.ToString();
                ordemServico.DataAbertura = Convert.ToDateTime(dgv.CurrentRow.Cells[5].Value);
                ordemServico.Solucao = dgv.CurrentRow.Cells[6].Value.ToString();
                ordemServico.DataFechamento = Convert.ToDateTime(dgv.CurrentRow.Cells[7].Value);
                ordemServico.Observacao = dgv.CurrentRow.Cells[8].Value.ToString();
                ordemServico.AtendenteOs.Nome = dgv.CurrentRow.Cells[9].Value.ToString();
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
