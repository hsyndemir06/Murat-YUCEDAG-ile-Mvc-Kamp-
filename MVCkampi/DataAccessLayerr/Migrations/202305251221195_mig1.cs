namespace DataAccessLayerr.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contents", "WriteriD", c => c.Int());
            CreateIndex("dbo.Contents", "WriteriD");
            AddForeignKey("dbo.Contents", "WriteriD", "dbo.Writers", "WriteriD");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contents", "WriteriD", "dbo.Writers");
            DropIndex("dbo.Contents", new[] { "WriteriD" });
            DropColumn("dbo.Contents", "WriteriD");
        }
    }
}
