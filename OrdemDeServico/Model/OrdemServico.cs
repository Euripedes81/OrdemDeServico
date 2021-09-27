using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdemDeServico.Model
{
    public class OrdemServico
    {
        public int Id { get; set; }
        public Solicitante SolicitanteOs { get; set; }
        public Maquina MaquinaOs { get; set; }
        public string Diagnostico { get; set; }
        public DateTime DataAbertura { get; set; }
        public string Solucao { get; set; }
        public DateTime DataFechamento { get; set; }
        public string Observacao { get; set; }
        public Atendente atendenteOs { get; set; }
        public OrdemServico()
        {
            SolicitanteOs = new Solicitante();
            MaquinaOs = new Maquina();
            atendenteOs = new Atendente();
        }
    }
}
