using OrdemDeServico.Helpers;
using OrdemDeServico.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OrdemDeServico.Views.Manutencao.NsMaquina
{
    public partial class FrmEdtMaquina : Form
    {
        private readonly Maquina _maquina;
        private List<Setor> setores;
        public FrmEdtMaquina(Maquina maquina)
        {
            InitializeComponent();
            _maquina = maquina;
        }
        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            if (ValidadorCampoHelper.CampoBranco(mtxtNumPatrimonio.Text, txtDescricao.Text, cbSetor))
            {
                if (MessageBox.Show("Deseja salvar os dados?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    try
                    {

                        _maquina.Patrimonio = Convert.ToInt32(mtxtNumPatrimonio.Text);
                        _maquina.Tipo = txtTipo.Text;
                        _maquina.Descricao = txtDescricao.Text;
                        _maquina.SetorMqn.Id = setores[cbSetor.SelectedIndex].Id;
                        InsertData.Inserir(_maquina);
                        Limpar();
                    }
                    catch (Exception)
                    {

                        MensagemEntidades.MaquinaMsgAdicionar();
                    }
                    
                }
            }
        }
        private void FrmEdtMaquina_Load(object sender, EventArgs e)
        {
            CarregarComboBox();
            mtxtNumPatrimonio.Text = Convert.ToString(_maquina.Patrimonio);
            txtTipo.Text = _maquina.Tipo;
            txtDescricao.Text = _maquina.Descricao;
            cbSetor.SelectedIndex = cbSetor.Items.IndexOf(_maquina.SetorMqn.Nome);
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
            if ((setores = SelectData.PesquisarSetor("")) != null)
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
