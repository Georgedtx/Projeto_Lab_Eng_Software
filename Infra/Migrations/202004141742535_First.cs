namespace Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Administrador",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 30),
                        IdUsuario = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuario", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(nullable: false),
                        Senha = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Medico",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 30),
                        Crm = c.String(nullable: false, maxLength: 10),
                        IdUsuario = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuario", t => t.Id)
                .Index(t => t.Id)
                .Index(t => t.Crm, unique: true);
            
            CreateTable(
                "dbo.Docente",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        TitUniversitaria = c.String(nullable: false, maxLength: 10),
                        IdMedico = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Medico", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.RegistroExames",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Data = c.DateTime(nullable: false),
                        Laudo = c.String(),
                        Status = c.Boolean(nullable: false),
                        IdDocente = c.Int(),
                        IdResidente = c.Int(),
                        IdPedidoExame = c.Int(nullable: false),
                        Docente_Id = c.Int(),
                        Residente_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Docente", t => t.Docente_Id)
                .ForeignKey("dbo.PedidoExame", t => t.Id)
                .ForeignKey("dbo.Residente", t => t.Residente_Id)
                .Index(t => t.Id)
                .Index(t => t.Docente_Id)
                .Index(t => t.Residente_Id);
            
            CreateTable(
                "dbo.Arquivo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Caminho = c.String(nullable: false),
                        IdRegistroExame = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.RegistroExames", t => t.IdRegistroExame, cascadeDelete: true)
                .Index(t => t.IdRegistroExame);
            
            CreateTable(
                "dbo.PedidoExame",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataEmissao = c.DateTime(nullable: false, storeType: "date"),
                        DataRealizacao = c.DateTime(nullable: false, storeType: "date"),
                        Hipotese = c.String(nullable: false),
                        IdPaciente = c.Int(nullable: false),
                        IdExame = c.Int(nullable: false),
                        IdMedico = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Exame", t => t.IdExame, cascadeDelete: true)
                .ForeignKey("dbo.Medico", t => t.IdMedico, cascadeDelete: true)
                .ForeignKey("dbo.Paciente", t => t.IdPaciente, cascadeDelete: true)
                .Index(t => t.IdPaciente)
                .Index(t => t.IdExame)
                .Index(t => t.IdMedico);
            
            CreateTable(
                "dbo.Exame",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 25),
                        Descricao = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Paciente",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cpf = c.String(nullable: false, maxLength: 11),
                        Nome = c.String(nullable: false, maxLength: 35),
                        Sexo = c.String(nullable: false, maxLength: 1),
                        Cor = c.String(nullable: false, maxLength: 10),
                        Nascimento = c.DateTime(nullable: false, storeType: "date"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Residente",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        AnoResidencia = c.DateTime(nullable: false, storeType: "date"),
                        IdMedico = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Medico", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Recepcionista",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 30),
                        Nascimento = c.DateTime(nullable: false, storeType: "date"),
                        IdUsuario = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuario", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Administrador", "Id", "dbo.Usuario");
            DropForeignKey("dbo.Recepcionista", "Id", "dbo.Usuario");
            DropForeignKey("dbo.Medico", "Id", "dbo.Usuario");
            DropForeignKey("dbo.RegistroExames", "Residente_Id", "dbo.Residente");
            DropForeignKey("dbo.Residente", "Id", "dbo.Medico");
            DropForeignKey("dbo.RegistroExames", "Id", "dbo.PedidoExame");
            DropForeignKey("dbo.PedidoExame", "IdPaciente", "dbo.Paciente");
            DropForeignKey("dbo.PedidoExame", "IdMedico", "dbo.Medico");
            DropForeignKey("dbo.PedidoExame", "IdExame", "dbo.Exame");
            DropForeignKey("dbo.RegistroExames", "Docente_Id", "dbo.Docente");
            DropForeignKey("dbo.Arquivo", "IdRegistroExame", "dbo.RegistroExames");
            DropForeignKey("dbo.Docente", "Id", "dbo.Medico");
            DropIndex("dbo.Recepcionista", new[] { "Id" });
            DropIndex("dbo.Residente", new[] { "Id" });
            DropIndex("dbo.PedidoExame", new[] { "IdMedico" });
            DropIndex("dbo.PedidoExame", new[] { "IdExame" });
            DropIndex("dbo.PedidoExame", new[] { "IdPaciente" });
            DropIndex("dbo.Arquivo", new[] { "IdRegistroExame" });
            DropIndex("dbo.RegistroExames", new[] { "Residente_Id" });
            DropIndex("dbo.RegistroExames", new[] { "Docente_Id" });
            DropIndex("dbo.RegistroExames", new[] { "Id" });
            DropIndex("dbo.Docente", new[] { "Id" });
            DropIndex("dbo.Medico", new[] { "Crm" });
            DropIndex("dbo.Medico", new[] { "Id" });
            DropIndex("dbo.Administrador", new[] { "Id" });
            DropTable("dbo.Recepcionista");
            DropTable("dbo.Residente");
            DropTable("dbo.Paciente");
            DropTable("dbo.Exame");
            DropTable("dbo.PedidoExame");
            DropTable("dbo.Arquivo");
            DropTable("dbo.RegistroExames");
            DropTable("dbo.Docente");
            DropTable("dbo.Medico");
            DropTable("dbo.Usuario");
            DropTable("dbo.Administrador");
        }
    }
}
