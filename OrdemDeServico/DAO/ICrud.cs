namespace OrdemDeServico.DAO
{
    interface ICrud
    {
        void Insert(object obj);
        void Update(object obj);
        void Delete(object obj);
    }
}
