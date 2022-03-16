using System;

namespace OrdemDeServico.Model
{
    [Serializable]
    public class Solicitante : Servidor
    {       
        public string Descricao { get; set; }
        public Setor SetorSolicitante { get; set; }
        public Solicitante()
        {
            SetorSolicitante = new Setor();
        }
    }
}
