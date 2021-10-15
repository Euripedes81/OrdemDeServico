using OrdemDeServico.Helpers;
using OrdemDeServico.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdemDeServico.Views.Manutencao.NsMaquina
{
    public partial class FrmAddMaquina : Form
    {
        private List<Setor> setores;
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
            if (Validador.CampoBranco(txtTipo.Text, txtDescricao.Text, cbSetor))
            {
                if (MessageBox.Show("Deseja salvar os dados?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    try
                    {
                        Maquina maquina = new Maquina();
                        maquina.Patrimonio = Convert.ToInt32(mtxtNumPatrimonio.Text);
                        maquina.Tipo = txtTipo.Text;
                        maquina.Descricao = txtDescricao.Text;
                        maquina.SetorMqn.Id = setores[cbSetor.SelectedIndex].Id;
                        CrudHelper.Inserir(maquina);
                        Limpar();
                    }
                    catch (Exception ex)
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
            }

        }
        private void Limpar()
        {
            mtxtNumPatrimonio.Text = "";
            txtTipo.Text = "";
            txtDescricao.Text = "";
            cbSetor.SelectedIndex = -1;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            txtTipo.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {
            txtDescricao.CharacterCasing = CharacterCasing.Upper;
        }

       
    }
}
