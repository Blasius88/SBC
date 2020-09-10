namespace SBC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CoursesItems",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        NameCourses = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        Image = c.Binary(),
                        MineType = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.LernenItems",
                c => new
                    {
                        idLernen = c.Int(nullable: false, identity: true),
                        nameLernen = c.String(nullable: false),
                        Courses_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idLernen)
                .ForeignKey("dbo.CoursesItems", t => t.Courses_id, cascadeDelete: true)
                .Index(t => t.Courses_id);
            
            CreateTable(
                "dbo.TestItems",
                c => new
                    {
                        idTest = c.Int(nullable: false, identity: true),
                        NameThema = c.String(nullable: false),
                        Courses_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idTest)
                .ForeignKey("dbo.CoursesItems", t => t.Courses_id, cascadeDelete: true)
                .Index(t => t.Courses_id);
            
            CreateTable(
                "dbo.QuestionItems",
                c => new
                    {
                        idQuestion = c.Int(nullable: false, identity: true),
                        question = c.String(nullable: false),
                        possibleAnswerOne = c.String(nullable: false),
                        possibleAnswerTwo = c.String(nullable: false),
                        possibleAnswerThree = c.String(nullable: false),
                        possibleAnswerFour = c.String(nullable: false),
                        possibleAnswerFive = c.String(nullable: false),
                        Answer = c.String(nullable: false),
                        imageBool = c.Boolean(nullable: false),
                        image = c.Binary(),
                        mimeType = c.String(),
                        Test_idTest = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idQuestion)
                .ForeignKey("dbo.TestItems", t => t.Test_idTest, cascadeDelete: true)
                .Index(t => t.Test_idTest);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        NickName = c.String(),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.QuestionItems", "Test_idTest", "dbo.TestItems");
            DropForeignKey("dbo.TestItems", "Courses_id", "dbo.CoursesItems");
            DropForeignKey("dbo.LernenItems", "Courses_id", "dbo.CoursesItems");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.QuestionItems", new[] { "Test_idTest" });
            DropIndex("dbo.TestItems", new[] { "Courses_id" });
            DropIndex("dbo.LernenItems", new[] { "Courses_id" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.QuestionItems");
            DropTable("dbo.TestItems");
            DropTable("dbo.LernenItems");
            DropTable("dbo.CoursesItems");
        }
    }
}
