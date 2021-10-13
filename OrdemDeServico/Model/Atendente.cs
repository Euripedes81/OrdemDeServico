using System;

namespace OrdemDeServico.Model
{
    [Serializable]
    public class Atendente
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Nome { get; set; }

        public Atendente()
        {
                
        }
        public Atendente(int id, string usuario, string nome)
        {
            Id = id;
            Usuario = usuario;
            Nome = nome;
        }
    }
}
