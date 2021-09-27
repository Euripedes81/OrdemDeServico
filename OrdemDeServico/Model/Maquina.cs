using System;

namespace OrdemDeServico.Model
{
    [Serializable]
    public class Maquina
    {
        public int Id { get; set; }
        public int Patrimonio { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public Setor SetorMqn { get; set; }

        public Maquina()
        {
            SetorMqn = new Setor();
        }
    }
}
