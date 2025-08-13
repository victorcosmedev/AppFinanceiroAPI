using System.Text.Json.Serialization;

namespace AppFinanceiroAPI.Domain.Entities
{
    public class ContaCorrente
    {
        public decimal Saldo { get; set; }
        public List<Transacao> Transacoes { get; set; }
        public List<Cartao> Cartoes { get; set; }
        [JsonIgnore]
        public InstituicaoFinanceira InstituicaoFinanceira { get; set; }
    }
}
