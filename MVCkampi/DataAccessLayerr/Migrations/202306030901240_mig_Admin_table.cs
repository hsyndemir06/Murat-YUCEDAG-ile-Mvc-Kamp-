namespace DataAccessLayerr.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_Admin_table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        AdminiD = c.Int(nullable: false, identity: true),
                        AdminUserName = c.String(maxLength: 50),
                        AdmibPassword = c.String(maxLength: 50),
                        AdminRole = c.String(maxLength: 1),
                    })
                .PrimaryKey(t => t.AdminiD);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Admins");
        }
    }
}
