using System.Linq;
using System.Windows.Forms;

namespace OrdemDeServico.Helpers
{
    static class ValidadorCampoHelper
    {
        public static bool ValidaSenha(string novaSenha, string confirmarSenha)
        {
            if (novaSenha == confirmarSenha)
            {
                if (!string.IsNullOrEmpty(novaSenha) && novaSenha.Length >= 7 && novaSenha.Any(c => char.IsLower(c))
                    && novaSenha.Any(c => char.IsUpper(c)) && novaSenha.Any(c => char.IsDigit(c)))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("A senha deve conter pelo menos um número, uma letra maiúscula e minúscula; " +
                        "e no mínimo o comprimento de 7 caracteres!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("As senhas digitadas não conferem!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return false;
        }
        public static bool CampoBranco(string nomeCampo)
        {
            if (string.IsNullOrEmpty(nomeCampo))
            {
                MessageBox.Show("Todos os campos são obrigatórios!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool CampoBranco(string nomeCampo, string nomeCampo2)
        {
            if (string.IsNullOrEmpty(nomeCampo) || string.IsNullOrEmpty(nomeCampo2))
            {
                MessageBox.Show("Todos os campos são obrigatórios!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                return true;
            }
        }        
        public static bool CampoBranco(string nomeCampo, string nomeCampo2, string nomeCampo3)
        {
            if (string.IsNullOrEmpty(nomeCampo) || string.IsNullOrEmpty(nomeCampo2) || string.IsNullOrEmpty(nomeCampo3))
            {
                MessageBox.Show("Todos os campos são obrigatórios!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                return true;
            }

        }
        public static bool CampoBranco(string nomeCampo, string nomeCampo2, ComboBox cb)
        {
            if (string.IsNullOrEmpty(nomeCampo) || string.IsNullOrEmpty(nomeCampo2) || (cb.SelectedItem == null))
            {
                MessageBox.Show("Todos os campos são obrigatórios!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                return true;
            }

        }
        public static bool CampoBranco(string nomeCampo, ComboBox cb1, ComboBox cb2)
        {
            if (string.IsNullOrEmpty(nomeCampo) || (cb1.SelectedItem == null) || (cb2.SelectedItem == null))
            {
                MessageBox.Show("Todos os campos são obrigatórios!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                return true;
            }

        }
        public static bool CampoNumerico(string nomeCampo)
        {
            if(nomeCampo.Any(c => char.IsDigit(c)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}

