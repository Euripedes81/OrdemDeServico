using System;

namespace OrdemDeServico.Model
{
    [Serializable]
    public class Secretaria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Telefone { get; set; }
        public override string ToString()
        {
            return Nome;
        }
    }
}
