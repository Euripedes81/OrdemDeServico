using System.Windows.Forms;

namespace OrdemDeServico.Helpers
{
    class Criador
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
        public static void FormataDateTimePicker(DateTimePicker dtpInicio, DateTimePicker dtpFim)
        {
            dtpInicio.Format = DateTimePickerFormat.Custom;
            dtpInicio.CustomFormat = "__/__/__ ";
            dtpFim.Format = DateTimePickerFormat.Custom;
            dtpFim.CustomFormat = "__/__/__ ";
        }
        public static void SelecionaDateTimePicker(DateTimePicker dtp)
        {
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.CustomFormat = "dd/MM/yyyy";
        }
    }
}
