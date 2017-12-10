namespace MultipleDbContext001.Migrations.Configuration1
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMatiereAndRelation : DbMigration
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
            
            AddColumn("dbo.Employees", "MatiereId", c => c.Int(nullable: false));
            CreateIndex("dbo.Employees", "MatiereId");
            AddForeignKey("dbo.Employees", "MatiereId", "dbo.Matieres", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "MatiereId", "dbo.Matieres");
            DropIndex("dbo.Employees", new[] { "MatiereId" });
            DropColumn("dbo.Employees", "MatiereId");
            DropTable("dbo.Matieres");
        }
    }
}
