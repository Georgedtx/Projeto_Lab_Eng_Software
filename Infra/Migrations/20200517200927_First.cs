using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Exames",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(maxLength: 25, nullable: false),
                    Descricao = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exames", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Cpf = table.Column<string>(maxLength: 11, nullable: false),
                    Nome = table.Column<string>(maxLength: 35, nullable: false),
                    Sexo = table.Column<string>(maxLength: 9, nullable: false),
                    Cor = table.Column<string>(maxLength: 10, nullable: false),
                    Nascimento = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Senha = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Administradores",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(maxLength: 30, nullable: false),
                    IdUsuario = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administradores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Administradores_Usuarios_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Medicos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(maxLength: 30, nullable: false),
                    Crm = table.Column<string>(maxLength: 10, nullable: false),
                    IdUsuario = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Medicos_Usuarios_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Recepcionistas",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(maxLength: 30, nullable: false),
                    Nascimento = table.Column<DateTime>(nullable: false),
                    IdUsuario = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recepcionistas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recepcionistas_Usuarios_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Docentes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    TitUniversitaria = table.Column<string>(maxLength: 10, nullable: false),
                    IdMedico = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Docentes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Docentes_Medicos_IdMedico",
                        column: x => x.IdMedico,
                        principalTable: "Medicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PedidosExames",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DataEmissao = table.Column<DateTime>(nullable: false),
                    DataRealizacao = table.Column<DateTime>(nullable: false),
                    Hipotese = table.Column<string>(nullable: false),
                    IdPaciente = table.Column<Guid>(nullable: false),
                    IdExame = table.Column<Guid>(nullable: false),
                    IdMedico = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidosExames", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PedidosExames_Exames_IdExame",
                        column: x => x.IdExame,
                        principalTable: "Exames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PedidosExames_Medicos_IdMedico",
                        column: x => x.IdMedico,
                        principalTable: "Medicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PedidosExames_Pacientes_IdPaciente",
                        column: x => x.IdPaciente,
                        principalTable: "Pacientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Residentes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AnoResidencia = table.Column<int>(nullable: false),
                    IdMedico = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Residentes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Residentes_Medicos_IdMedico",
                        column: x => x.IdMedico,
                        principalTable: "Medicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RegistrosExames",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Data = table.Column<DateTime>(nullable: false),
                    Laudo = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    IdDocente = table.Column<Guid>(nullable: true),
                    IdResidente = table.Column<Guid>(nullable: true),
                    IdPedidoExame = table.Column<Guid>(nullable: false),
                    DocenteId = table.Column<Guid>(nullable: true),
                    ResidenteId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistrosExames", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegistrosExames_Docentes_DocenteId",
                        column: x => x.DocenteId,
                        principalTable: "Docentes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RegistrosExames_PedidosExames_IdPedidoExame",
                        column: x => x.IdPedidoExame,
                        principalTable: "PedidosExames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RegistrosExames_Residentes_ResidenteId",
                        column: x => x.ResidenteId,
                        principalTable: "Residentes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Arquivo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(nullable: false),
                    Caminho = table.Column<string>(nullable: false),
                    IdRegistroExame = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arquivo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Arquivo_RegistrosExames_IdRegistroExame",
                        column: x => x.IdRegistroExame,
                        principalTable: "RegistrosExames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Email", "Senha" },
                values: new object[] { new Guid("4bf1edf3-c813-4478-859c-545e48bf882d"), "admin@hotmail.com", "Admin2020" });

            migrationBuilder.InsertData(
                table: "Administradores",
                columns: new[] { "Id", "IdUsuario", "Nome" },
                values: new object[] { new Guid("2caae95b-6626-4413-b2f8-b0ce08f2fafd"), new Guid("4bf1edf3-c813-4478-859c-545e48bf882d"), "Administrador" });

            migrationBuilder.CreateIndex(
                name: "IX_Administradores_IdUsuario",
                table: "Administradores",
                column: "IdUsuario",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Arquivo_IdRegistroExame",
                table: "Arquivo",
                column: "IdRegistroExame");

            migrationBuilder.CreateIndex(
                name: "IX_Docentes_IdMedico",
                table: "Docentes",
                column: "IdMedico",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Medicos_IdUsuario",
                table: "Medicos",
                column: "IdUsuario",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PedidosExames_IdExame",
                table: "PedidosExames",
                column: "IdExame");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosExames_IdMedico",
                table: "PedidosExames",
                column: "IdMedico");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosExames_IdPaciente",
                table: "PedidosExames",
                column: "IdPaciente");

            migrationBuilder.CreateIndex(
                name: "IX_Recepcionistas_IdUsuario",
                table: "Recepcionistas",
                column: "IdUsuario",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RegistrosExames_DocenteId",
                table: "RegistrosExames",
                column: "DocenteId");

            migrationBuilder.CreateIndex(
                name: "IX_RegistrosExames_IdPedidoExame",
                table: "RegistrosExames",
                column: "IdPedidoExame",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RegistrosExames_ResidenteId",
                table: "RegistrosExames",
                column: "ResidenteId");

            migrationBuilder.CreateIndex(
                name: "IX_Residentes_IdMedico",
                table: "Residentes",
                column: "IdMedico",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_Email",
                table: "Usuarios",
                column: "Email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Administradores");

            migrationBuilder.DropTable(
                name: "Arquivo");

            migrationBuilder.DropTable(
                name: "Recepcionistas");

            migrationBuilder.DropTable(
                name: "RegistrosExames");

            migrationBuilder.DropTable(
                name: "Docentes");

            migrationBuilder.DropTable(
                name: "PedidosExames");

            migrationBuilder.DropTable(
                name: "Residentes");

            migrationBuilder.DropTable(
                name: "Exames");

            migrationBuilder.DropTable(
                name: "Pacientes");

            migrationBuilder.DropTable(
                name: "Medicos");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
