using OrdemDeServico.Helpers;
using OrdemDeServico.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OrdemDeServico.Views.Manutencao.NsMaquina
{
    public partial class FrmEdtMaquina : Form
    {
        private Maquina maquina;
        private List<Setor> setores;
        public FrmEdtMaquina(Maquina maquina)
        {
            InitializeComponent();
            this.maquina = maquina;
        }
        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            if (Validador.CampoBranco(mtxtNumPatrimonio.Text, txtDescricao.Text, cbSetor))
            {
                if (MessageBox.Show("Deseja salvar os dados?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    try
                    {

                        maquina.Patrimonio = Convert.ToInt32(mtxtNumPatrimonio.Text);
                        maquina.Tipo = txtTipo.Text;
                        maquina.Descricao = txtDescricao.Text;
                        maquina.SetorMqn.Id = setores[cbSetor.SelectedIndex].Id;
                        CrudHelper.Inserir(maquina);
                        this.Close();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                    Limpar();
                }
            }
        }
        private void FrmEdtMaquina_Load(object sender, EventArgs e)
        {
            CarregarComboBox();
            mtxtNumPatrimonio.Text = Convert.ToString(maquina.Patrimonio);
            txtTipo.Text = maquina.Tipo;
            txtDescricao.Text = maquina.Descricao;
            cbSetor.SelectedIndex = cbSetor.Items.IndexOf(maquina.SetorMqn.Nome);
        }
       
        private void Limpar()
        {
            mtxtNumPatrimonio.Text = "";
            txtTipo.Text = "";
            txtDescricao.Text = "";
            cbSetor.SelectedIndex = -1;
        }
        private void CarregarComboBox()
        {
            if ((setores = PesquisadorHelper.PesquisarSetor("")) != null)
            {
                foreach (Setor setor in setores)
                {
                    cbSetor.Items.Add(setor.ToString());
                }
            }

        }

        private void txtTipo_TextChanged(object sender, EventArgs e)
        {
            txtTipo.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {
            txtDescricao.CharacterCasing = CharacterCasing.Upper;
        }
    }
}
