using AloqueInfra.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace SiteContatos.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<ClienteModelo> Clientes { get; set; }
        public DbSet<AlocacaoModelo> Alocacoes { get; set; }
        public DbSet<RecursoModelo> Funcionario { get; set; }
        public DbSet<UsuarioModelo> Usuarios { get; set; }
        public DbSet<PermissoesModelo> Permissoes { get; set;}
    }
}