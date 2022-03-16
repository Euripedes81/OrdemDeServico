using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdemDeServico.Model
{
    [Serializable]
    public abstract class Servidor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
