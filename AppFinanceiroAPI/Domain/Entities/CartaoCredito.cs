namespace AppFinanceiroAPI.Domain.Entities
{
    public class CartaoCredito : Cartao
    {
        public decimal Limite { get; set; }
        public List<Fatura>? Faturas { get; set; }
    }
}
