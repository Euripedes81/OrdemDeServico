using System;

namespace OrdemDeServico.Model
{
    [Serializable]
    public class Setor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public Secretaria SecretariaStr { get; set; }
        public Setor()
        {
            SecretariaStr = new Secretaria();
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}
