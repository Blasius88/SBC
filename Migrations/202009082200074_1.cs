namespace SBC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.LernenItems", name: "Courses_id", newName: "coursesItemId");
            RenameIndex(table: "dbo.LernenItems", name: "IX_Courses_id", newName: "IX_coursesItemId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.LernenItems", name: "IX_coursesItemId", newName: "IX_Courses_id");
            RenameColumn(table: "dbo.LernenItems", name: "coursesItemId", newName: "Courses_id");
        }
    }
}
