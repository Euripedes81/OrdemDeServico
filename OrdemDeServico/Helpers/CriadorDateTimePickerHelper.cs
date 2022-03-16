using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdemDeServico.Helpers
{
    public class CriadorDateTimePickerHelper
    {
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
