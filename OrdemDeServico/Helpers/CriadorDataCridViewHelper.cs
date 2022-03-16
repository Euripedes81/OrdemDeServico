using System.Windows.Forms;

namespace OrdemDeServico.Helpers
{
    class CriadorDataCridViewHelper
    {
        public static void CriaDataGridView(DataGridView dgv, string[] columnName, string[] headerText, int[] tamanhoCol)
        {
            ConfigurarDgv(dgv);
            for (int i = 0; i < columnName.Length; i++)
            {
                dgv.Columns.Add(columnName[i], headerText[i]);
                dgv.Columns[columnName[i]].Width = tamanhoCol[i];
            }
        }
        public static void CriaDataGridView(DataGridView dgv, string[] columnName, string[] headerText, int[] tamanhoCol, bool[] visibilidade)
        {
            ConfigurarDgv(dgv);
            for (int i = 0; i < columnName.Length; i++)
            {
                dgv.Columns.Add(columnName[i], headerText[i]);
                dgv.Columns[columnName[i]].Width = tamanhoCol[i];
                dgv.Columns[columnName[i]].Visible = visibilidade[i];
            }
        }
        private static void ConfigurarDgv(DataGridView dgv)
        {
            dgv.Columns.Clear();
            dgv.AllowUserToAddRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        
    }
}
