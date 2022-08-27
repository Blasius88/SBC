namespace SBC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sec : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.QuestionItems", "NumberQustion", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.QuestionItems", "NumberQustion");
        }
    }
}
