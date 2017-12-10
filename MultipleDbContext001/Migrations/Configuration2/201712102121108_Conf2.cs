namespace MultipleDbContext001.Migrations.Configuration2
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Conf2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Matieres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Coefficient = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Matieres");
        }
    }
}
