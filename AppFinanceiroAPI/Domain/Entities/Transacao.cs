using System.Text.Json.Serialization;

namespace AppFinanceiroAPI.Domain.Entities
{
    public class Transacao
    {
        public int Id { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataTransacao { get; set; }
        public MetodoPagamento? MetodoPagamento { get; set; }
        [JsonIgnore]
        public Cartao Cartao { get; set; }
        public int Cartao_Id { get; set; }
    }
}
