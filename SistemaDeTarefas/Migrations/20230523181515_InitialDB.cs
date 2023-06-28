using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaDeTarefas.Migrations
{
    public partial class InitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pessoas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Familia = table.Column<int>(type: "int", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Nis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Parentesco = table.Column<int>(type: "int", nullable: true),
                    Responsavel_familiar = table.Column<int>(type: "int", nullable: true),
                    Sexo = table.Column<int>(type: "int", nullable: true),
                    Data_nascimento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Nacionalidade = table.Column<int>(type: "int", nullable: true),
                    Nome_pai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nome_mae = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado_civil = table.Column<int>(type: "int", nullable: true),
                    Escolaridade = table.Column<int>(type: "int", nullable: true),
                    Serie_escolar = table.Column<int>(type: "int", nullable: true),
                    UnidadeEscolar = table.Column<int>(type: "int", nullable: true),
                    Tipo_escola = table.Column<int>(type: "int", nullable: true),
                    Cor = table.Column<int>(type: "int", nullable: true),
                    Certidao_nascimento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Data_cadastro = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EnderecoId = table.Column<int>(type: "int", nullable: true),
                    Numero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bairro = table.Column<int>(type: "int", nullable: true),
                    CEP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UF = table.Column<int>(type: "int", nullable: true),
                    Cidade = table.Column<int>(type: "int", nullable: true),
                    Reservista = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Titulo_eleitor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zona = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Secao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UF_nascimento = table.Column<int>(type: "int", nullable: true),
                    Cidade_nascimento = table.Column<int>(type: "int", nullable: true),
                    Telefone_pessoal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emissao_rg = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UF_rg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Orgao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pessoas_Enderecos_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Enderecos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Tarefas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarefas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tarefas_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pessoas_EnderecoId",
                table: "Pessoas",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_Tarefas_UsuarioId",
                table: "Tarefas",
                column: "UsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pessoas");

            migrationBuilder.DropTable(
                name: "Tarefas");

            migrationBuilder.DropTable(
                name: "Enderecos");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
