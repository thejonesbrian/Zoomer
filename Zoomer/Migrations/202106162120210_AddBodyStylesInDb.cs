namespace Zoomer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBodyStylesInDb : DbMigration
    {
        public override void Up()
        {
            //Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (1, 0, 0, 0)");
            Sql("INSERT INTO BodyStyles (BodyType) VALUES ('Sedan')");
            Sql("INSERT INTO BodyStyles (BodyType) VALUES ('Station Wagon')");
            Sql("INSERT INTO BodyStyles (BodyType) VALUES ('Van')");
        }
        
        public override void Down()
        {
        }
    }
}
