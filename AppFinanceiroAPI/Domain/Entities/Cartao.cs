using System.ComponentModel;
using System.Text.Json.Serialization;

namespace AppFinanceiroAPI.Domain.Entities
{
    public abstract class Cartao
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public BandeiraCartao Bandeira { get; set; }
        public List<Transacao>? Transacoes { get; set; }
        [JsonIgnore]
        public ContaCorrente Conta { get; set; }
    }

    public enum BandeiraCartao
    {
        [Description("Visa")]
        Visa = 1,

        [Description("Mastercard")]
        Mastercard = 2,

        [Description("American Express")]
        AmericanExpress = 3,

        [Description("Elo")]
        Elo = 4,

        [Description("Hipercard")]
        Hipercard = 5,

        [Description("Discover")]
        Discover = 6,

        [Description("Diners Club")]
        DinersClub = 7,

        [Description("JCB")]
        JCB = 8,

        [Description("Aura")]
        Aura = 9,

        [Description("Outra")]
        Outra = 99
    }
}
