namespace Zoomer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCarModelAndBodyStyle : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Make = c.String(nullable: false),
                        Model = c.String(nullable: false),
                        YearOfMake = c.String(nullable: false),
                        DateAdded = c.DateTime(nullable: false),
                        BodyStyle_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BodyStyles", t => t.BodyStyle_Id, cascadeDelete: true)
                .Index(t => t.BodyStyle_Id);
            
            CreateTable(
                "dbo.BodyStyles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BodyType = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "BodyStyle_Id", "dbo.BodyStyles");
            DropIndex("dbo.Cars", new[] { "BodyStyle_Id" });
            DropTable("dbo.BodyStyles");
            DropTable("dbo.Cars");
        }
    }
}
