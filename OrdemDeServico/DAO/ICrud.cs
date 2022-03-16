using System.Collections.Generic;

namespace OrdemDeServico.DAO
{
    interface ICrud<T> : System.IDisposable
    {
        void Insert(T obj);
        void Update(T obj);
        void Delete(T obj);
        T SelectId(int id);
        List<T> SelectNome(string nome);
        
    }
}
