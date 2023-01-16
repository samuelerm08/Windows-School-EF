using System;
using System.Data.Entity.Migrations;
namespace WindowsEFEscuela.Migrations
{       
    public partial class dbUpdate3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Alumnos", "Nombre", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Alumnos", "Apellido", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Aulas", "Codigo", c => c.String(nullable: false, maxLength: 1, fixedLength: true, unicode: false));
            AlterColumn("dbo.Materias", "Nombre", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Materias", "Programa", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Profesores", "Apellido", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Profesores", "Nombre", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Profesores", "Titulo", c => c.String(nullable: false, maxLength: 50, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Profesores", "Titulo", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.Profesores", "Nombre", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.Profesores", "Apellido", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.Materias", "Programa", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.Materias", "Nombre", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.Aulas", "Codigo", c => c.String(maxLength: 1, fixedLength: true, unicode: false));
            AlterColumn("dbo.Alumnos", "Apellido", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.Alumnos", "Nombre", c => c.String(maxLength: 50, unicode: false));
        }
    }
}
