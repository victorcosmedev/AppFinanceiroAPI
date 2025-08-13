using AppFinanceiroAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AppFinanceiroAPI.Infrastructure.Data.AppData
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        public DbSet<Cartao> Cartoes { get; set; }
        public DbSet<CartaoCredito> CartoesCredito { get; set; }
        public DbSet<CartaoDebito> CartoesDebito { get; set; }
        public DbSet<ContaCorrente> Contas { get; set; }
        public DbSet<Transacao> Transacoes { get; set; }
        public DbSet<Fatura> Faturas { get; set; }
        public DbSet<InstituicaoFinanceira> InstituicaoFinanceira { get; set; }
        public DbSet<MetodoPagamento> MetodoPagamento { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
    }
}
