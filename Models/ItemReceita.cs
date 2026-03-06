namespace ZCK.OrdensProducao.Api.Models
{
    public class ItemReceita
    {
        public int Id { get; set; }
        public int OrdemProducaoId { get; set; }
        public string NomeInsumo { get; set; } = string.Empty;
        public decimal Quantidade { get; set; }
    }
}