namespace BizHacksApp.Migrations.Products
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateProductstabletoincludebatterylife : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "BatteryLife", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "BatteryLife");
        }
    }
}
