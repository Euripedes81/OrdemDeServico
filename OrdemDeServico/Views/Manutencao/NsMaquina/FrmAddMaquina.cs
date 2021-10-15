using OrdemDeServico.Helpers;
using OrdemDeServico.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OrdemDeServico.Views.Manutencao.NsMaquina
{
    public partial class FrmAddMaquina : Form
    {
        private List<Setor> setores;
        private string[] tipoSetor = new string[] {"COMPUTADOR DESKTOP", "COMPUTADOR NOTEBOOK", "IMPRESSORA LASERJET", "IMPRESSORA DESKJET" };       

        public FrmAddMaquina()
        {
            InitializeComponent();
        }
        private void FrmAddMaquina_Load(object sender, EventArgs e)
        {
            CarregarComboBox();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Validador.CampoBranco( txtDescricao.Text,cbTipoMaquina, cbSetor))
            {
                if (MessageBox.Show("Deseja salvar os dados?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    try
                    {
                        Maquina maquina = new Maquina();
                        maquina.Patrimonio = Convert.ToInt32(mtxtNumPatrimonio.Text);
                        maquina.Tipo = tipoSetor[cbTipoMaquina.SelectedIndex];
                        maquina.Descricao = txtDescricao.Text;
                        maquina.SetorMqn.Id = setores[cbSetor.SelectedIndex].Id;
                        CrudHelper.Inserir(maquina);
                        Limpar();
                    }
                    catch (Exception )
                    {
                        Mensagem.MaquinaMsgAdicionar();
                    }
                }
            }
        }
        private void CarregarComboBox()
        {
            if ((setores = PesquisadorHelper.PesquisarSetor("")) != null)
            {
                foreach (Setor setor in setores)
                {
                    cbSetor.Items.Add(setor.ToString());
                }                
                for (int i = 0; i < tipoSetor.Length; i++)
                {
                    cbTipoMaquina.Items.Add(tipoSetor[i]);
                }
            }

        }
        private void Limpar()
        {
            mtxtNumPatrimonio.Text = "";
            txtDescricao.Text = "";
            cbSetor.SelectedIndex = -1;
            cbTipoMaquina.SelectedIndex = -1;
        }        

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {
            txtDescricao.CharacterCasing = CharacterCasing.Upper;
        }

       
    }
}
