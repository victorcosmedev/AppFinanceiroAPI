namespace AppFinanceiroAPI.Domain.Entities
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public DateTime DataNascimento { get; set; }
        public List<ContaCorrente> Contas { get; set; }
    }
}
