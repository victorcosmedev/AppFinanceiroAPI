using System.ComponentModel;

namespace AppFinanceiroAPI.Domain.Entities
{
    public class InstituicaoFinanceira
    {
        public string Nome { get; set; }
        public TipoInstituicao Tipo { get; set; }
        public bool IsDigital { get; set; }
        public List<ContaCorrente>? Contas { get; set; }
    }

    public enum TipoInstituicao
    {
        [Description("Banco Comercial")]
        BancoComercial = 1,

        [Description("Banco de Investimento")]
        BancoInvestimento = 2,

        [Description("Cooperativa de Crédito")]
        CooperativaCredito = 3,

        [Description("Fintech")]
        Fintech = 4,

        [Description("Banco de Desenvolvimento")]
        BancoDesenvolvimento = 5,

        [Description("Sociedade de Crédito")]
        SociedadeCredito = 6,

        [Description("Instituição de Pagamento")]
        InstituicaoPagamento = 7,

        [Description("Corretora de Valores")]
        CorretoraValores = 8,

        [Description("Administradora de Consórcio")]
        AdministradoraConsorcio = 9,

        [Description("Credireireira")]
        Financeira = 10,

        [Description("Banco Digital")]
        BancoDigital = 11,

        [Description("Outro Tipo")]
        Outro = 99
    }
}
