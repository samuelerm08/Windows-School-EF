namespace WindowsEFEscuela.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lastlastMig : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Alumnos", "FechaNacimiento", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Alumnos", "FechaNacimiento", c => c.DateTime(precision: 7, storeType: "datetime2"));
        }
    }
}
