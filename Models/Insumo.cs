using System.ComponentModel.DataAnnotations;

namespace ZCK.OrdensProducao.Api.Models
{
    public class Insumo
    {
        public int Id { get; set; } 
        public string Nome { get; set; } = string.Empty;
        public string UnidadeMedida { get; set; } = string.Empty;
        public decimal Custo { get; set; } 
    }
}