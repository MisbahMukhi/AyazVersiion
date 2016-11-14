namespace LonghornMusic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialSetup : DbMigration
    {
        public override void Up()
        {

        }
        
        public override void Down()
        {
            DropIndex("dbo.Carts", new[] { "AlbumId" });
            DropIndex("dbo.OrderDetails", new[] { "AlbumId" });
            DropIndex("dbo.OrderDetails", new[] { "OrderId" });
            DropIndex("dbo.Albums", new[] { "ArtistId" });
        }
    }
}
