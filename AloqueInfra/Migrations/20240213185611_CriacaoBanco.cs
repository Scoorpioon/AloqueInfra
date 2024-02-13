using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AloqueInfra.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoBanco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alocacoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValorAlocacao = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    valorFechado = table.Column<bool>(type: "bit", nullable: false),
                    dataInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dataFim = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alocacoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contatos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    clienteNome = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    clienteCNPJ = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    clienteTelefone = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    clienteEmail = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    clienteEndereco = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    clienteEmDebito = table.Column<bool>(type: "bit", nullable: false),
                    Datacad = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedat = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contatos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Funcionario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    funcNome = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    funcCPF = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    funcRG = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    funcEmail = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    FuncTempoAlocacao = table.Column<int>(type: "int", nullable: false),
                    funcValorDiario = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionario", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alocacoes");

            migrationBuilder.DropTable(
                name: "Contatos");

            migrationBuilder.DropTable(
                name: "Funcionario");
        }
    }
}
