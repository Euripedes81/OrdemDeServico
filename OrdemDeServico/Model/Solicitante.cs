using System;

namespace OrdemDeServico.Model
{
    [Serializable]
    public class Solicitante
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public Setor SetorSlc { get; set; }
        public Solicitante()
        {
            SetorSlc = new Setor();
        }
    }
}
