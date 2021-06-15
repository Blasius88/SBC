namespace SBC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.QuestionItems", "TestItem_idTest", "dbo.TestItems");
            DropIndex("dbo.QuestionItems", new[] { "TestItem_idTest" });
            DropColumn("dbo.QuestionItems", "TestItem_idTest");
        }
        
        public override void Down()
        {
            AddColumn("dbo.QuestionItems", "TestItem_idTest", c => c.Int());
            CreateIndex("dbo.QuestionItems", "TestItem_idTest");
            AddForeignKey("dbo.QuestionItems", "TestItem_idTest", "dbo.TestItems", "idTest");
        }
    }
}
