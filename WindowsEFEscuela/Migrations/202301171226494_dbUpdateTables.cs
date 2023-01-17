using System;
using System.Data.Entity.Migrations;

namespace WindowsEFEscuela.Migrations
{
    public partial class dbUpdateTables : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Alumnos", "ProfesorId", c => c.Int(nullable: false));
            AddColumn("dbo.Materias", "AulaId", c => c.Int(nullable: false));
            CreateIndex("dbo.Alumnos", "ProfesorId");
            CreateIndex("dbo.Materias", "AulaId");
            AddForeignKey("dbo.Alumnos", "ProfesorId", "dbo.Profesores", "ProfesorId", cascadeDelete: true);
            AddForeignKey("dbo.Materias", "AulaId", "dbo.Aulas", "Id", cascadeDelete: true);
        }

        public override void Down()
        {
            DropForeignKey("dbo.Materias", "AulaId", "dbo.Aulas");
            DropForeignKey("dbo.Alumnos", "ProfesorId", "dbo.Profesores");
            DropIndex("dbo.Materias", new[] { "AulaId" });
            DropIndex("dbo.Alumnos", new[] { "ProfesorId" });
            DropColumn("dbo.Materias", "AulaId");
            DropColumn("dbo.Alumnos", "ProfesorId");
        }
    }
}
