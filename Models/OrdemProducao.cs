namespace ZCK.OrdensProducao.Api.Models
{
    public class OrdemProducao
    {
        public int Id { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public string Status { get; set; } = "Pendente";
        public List<ItemReceita> Itens { get; set; } = new();
    }
}