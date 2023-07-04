namespace VStoDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StudentDBs",
                c => new
                    {
                        sID = c.Int(nullable: false, identity: true),
                        sName = c.String(nullable: false, maxLength: 50),
                        sFirstName = c.String(nullable: false, maxLength: 50),
                        sLastName = c.String(nullable: false, maxLength: 50),
                        sMarks = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.sID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.StudentDBs");
        }
    }
}
