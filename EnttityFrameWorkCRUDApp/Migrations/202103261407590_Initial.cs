namespace EnttityFrameWorkCRUDApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        productId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.productId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
        }
    }
}
