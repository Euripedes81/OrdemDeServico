using System;

namespace OrdemDeServico.Model
{
    [Serializable]
    public class Atendente : Servidor
    {       
        public string Usuario { get; set; }        
        public string Senha { get; set; }
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
