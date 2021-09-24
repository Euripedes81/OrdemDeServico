namespace OrdemDeServico.Model
{
    public class Solicitante
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public Setor setor { get; set; }
        public Solicitante()
        {
            setor = new Setor();
        }
    }
}
