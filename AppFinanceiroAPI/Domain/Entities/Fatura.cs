using System.Text.Json.Serialization;

namespace AppFinanceiroAPI.Domain.Entities
{
    public class Fatura
    {
        public DateTime DataVencimento { get; set; }
        public decimal Valor { get; set; }
        public bool Pago { get; set; }
        [JsonIgnore]
        public CartaoCredito Cartao { get; set; }
    }
}
