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
            if (ValidadorCampoHelper.CampoBranco( txtDescricao.Text,cbTipoMaquina, cbSetor))
            {
                if (MessageBox.Show("Deseja salvar os dados?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    try
                    {                                      
                        Maquina maquina = new Maquina();
                        maquina.Patrimonio = Convert.ToInt32(mtxtNumPatrimonio.Text);
                        maquina.Tipo = cbTipoMaquina.Items[cbTipoMaquina.SelectedIndex].ToString();
                        maquina.SetorMqn.Id = setores[cbSetor.SelectedIndex].Id;
                        maquina.Descricao = txtDescricao.Text;
                        InsertData.Inserir(maquina);
                        Limpar();
                    }
                    catch (Exception )
                    {
                        MensagemEntidades.MaquinaMsgAdicionar();
                    }
                }
            }
        }
        private void CarregarComboBox()
        {
            if ((setores = SelectData.PesquisarSetor("")) != null)
            {
                foreach (Setor setor in setores)
                {
                    cbSetor.Items.Add(setor.ToString());
                }                
                foreach(var tipoMaquina in Enum.GetNames(typeof(TipoMaquina)))
                {
                    cbTipoMaquina.Items.Add(tipoMaquina.ToString().Replace("_", " "));
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
