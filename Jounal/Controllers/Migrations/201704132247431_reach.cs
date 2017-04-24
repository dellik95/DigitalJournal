namespace Jounal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reach : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Academic_degree",
                c => new
                    {
                        Academic_degree_ID = c.Short(nullable: false, identity: true),
                        AcademicDegree = c.String(),
                    })
                .PrimaryKey(t => t.Academic_degree_ID);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        Teacher_ID = c.Short(nullable: false, identity: true),
                        LName = c.String(),
                        FName = c.String(),
                        SName = c.String(),
                        Position_ID = c.Short(nullable: false),
                        Academic_degree = c.Short(nullable: false),
                        Academic_degree1_Academic_degree_ID = c.Short(),
                    })
                .PrimaryKey(t => t.Teacher_ID)
                .ForeignKey("dbo.Academic_degree", t => t.Academic_degree1_Academic_degree_ID)
                .ForeignKey("dbo.Positions", t => t.Position_ID, cascadeDelete: true)
                .Index(t => t.Position_ID)
                .Index(t => t.Academic_degree1_Academic_degree_ID);
            
            CreateTable(
                "dbo.Authorizations",
                c => new
                    {
                        Authorizations_ID = c.Short(nullable: false, identity: true),
                        Ligin = c.String(),
                        Pass = c.String(),
                        Teacher_ID = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.Authorizations_ID)
                .ForeignKey("dbo.Teachers", t => t.Teacher_ID, cascadeDelete: true)
                .Index(t => t.Teacher_ID);
            
            CreateTable(
                "dbo.Positions",
                c => new
                    {
                        Position_ID = c.Short(nullable: false, identity: true),
                        PName = c.String(),
                    })
                .PrimaryKey(t => t.Position_ID);
            
            CreateTable(
                "dbo.TeacherCathedras",
                c => new
                    {
                        TeacherCathedra_ID = c.Short(nullable: false, identity: true),
                        Teacher_ID = c.Short(nullable: false),
                        Cathedra_ID = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.TeacherCathedra_ID)
                .ForeignKey("dbo.Cathedras", t => t.Cathedra_ID, cascadeDelete: true)
                .ForeignKey("dbo.Teachers", t => t.Teacher_ID, cascadeDelete: true)
                .Index(t => t.Teacher_ID)
                .Index(t => t.Cathedra_ID);
            
            CreateTable(
                "dbo.Cathedras",
                c => new
                    {
                        Cathedra_ID = c.Short(nullable: false, identity: true),
                        CathName = c.String(),
                    })
                .PrimaryKey(t => t.Cathedra_ID);
            
            CreateTable(
                "dbo.TeacherSubjectsStatus",
                c => new
                    {
                        TeacherSubjects_ID = c.Short(nullable: false, identity: true),
                        Teacher_ID = c.Short(nullable: false),
                        Subjects_ID = c.Short(nullable: false),
                        Statuss_ID = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.TeacherSubjects_ID)
                .ForeignKey("dbo.Statusses", t => t.Statuss_ID, cascadeDelete: true)
                .ForeignKey("dbo.Subjects", t => t.Subjects_ID, cascadeDelete: true)
                .ForeignKey("dbo.Teachers", t => t.Teacher_ID, cascadeDelete: true)
                .Index(t => t.Teacher_ID)
                .Index(t => t.Subjects_ID)
                .Index(t => t.Statuss_ID);
            
            CreateTable(
                "dbo.Statusses",
                c => new
                    {
                        Statuss_ID = c.Short(nullable: false, identity: true),
                        StatName = c.String(),
                    })
                .PrimaryKey(t => t.Statuss_ID);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        Subjects_ID = c.Short(nullable: false, identity: true),
                        SubName = c.String(),
                    })
                .PrimaryKey(t => t.Subjects_ID);
            
            CreateTable(
                "dbo.GroupsSubjects",
                c => new
                    {
                        GroupsSubjects_ID = c.Short(nullable: false, identity: true),
                        Group_ID = c.Short(nullable: false),
                        Subjects_ID = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.GroupsSubjects_ID)
                .ForeignKey("dbo.Groups", t => t.Group_ID, cascadeDelete: true)
                .ForeignKey("dbo.Subjects", t => t.Subjects_ID, cascadeDelete: true)
                .Index(t => t.Group_ID)
                .Index(t => t.Subjects_ID);
            
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        Group_ID = c.Short(nullable: false, identity: true),
                        NumGroup = c.String(),
                    })
                .PrimaryKey(t => t.Group_ID);
            
            CreateTable(
                "dbo.Marks",
                c => new
                    {
                        Marks_ID = c.Short(nullable: false, identity: true),
                        Mark = c.Int(),
                        Subjects_ID = c.Short(nullable: false),
                        Student_ID = c.Short(nullable: false),
                        Group_ID = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.Marks_ID)
                .ForeignKey("dbo.Groups", t => t.Group_ID, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.Student_ID, cascadeDelete: true)
                .ForeignKey("dbo.Subjects", t => t.Subjects_ID, cascadeDelete: true)
                .Index(t => t.Subjects_ID)
                .Index(t => t.Student_ID)
                .Index(t => t.Group_ID);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Student_ID = c.Short(nullable: false, identity: true),
                        LName = c.String(),
                        FName = c.String(),
                        SName = c.String(),
                        Group_ID = c.Short(nullable: false),
                        Cours_ID = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.Student_ID)
                .ForeignKey("dbo.Cours", t => t.Cours_ID, cascadeDelete: false)
                .ForeignKey("dbo.Groups", t => t.Group_ID, cascadeDelete: false)
                .Index(t => t.Group_ID)
                .Index(t => t.Cours_ID);
            
            CreateTable(
                "dbo.Cours",
                c => new
                    {
                        Cours_ID = c.Short(nullable: false, identity: true),
                        NumCours = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.Cours_ID);
            
            CreateTable(
                "dbo.Curricula",
                c => new
                    {
                        Curriculum_ID = c.Short(nullable: false, identity: true),
                        CurName = c.String(),
                    })
                .PrimaryKey(t => t.Curriculum_ID);
            
            CreateTable(
                "dbo.Number_lab_modules",
                c => new
                    {
                        Number_lab_modules_ID = c.Short(nullable: false, identity: true),
                        NlM = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.Number_lab_modules_ID);
            
            CreateTable(
                "dbo.Number_of_modules",
                c => new
                    {
                        Number_of_modules_ID = c.Short(nullable: false, identity: true),
                        NoM = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.Number_of_modules_ID);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                        Discriminator = c.String(nullable: false, maxLength: 128),
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
            DropForeignKey("dbo.TeacherSubjectsStatus", "Teacher_ID", "dbo.Teachers");
            DropForeignKey("dbo.TeacherSubjectsStatus", "Subjects_ID", "dbo.Subjects");
            DropForeignKey("dbo.GroupsSubjects", "Subjects_ID", "dbo.Subjects");
            DropForeignKey("dbo.Marks", "Subjects_ID", "dbo.Subjects");
            DropForeignKey("dbo.Marks", "Student_ID", "dbo.Students");
            DropForeignKey("dbo.Students", "Group_ID", "dbo.Groups");
            DropForeignKey("dbo.Students", "Cours_ID", "dbo.Cours");
            DropForeignKey("dbo.Marks", "Group_ID", "dbo.Groups");
            DropForeignKey("dbo.GroupsSubjects", "Group_ID", "dbo.Groups");
            DropForeignKey("dbo.TeacherSubjectsStatus", "Statuss_ID", "dbo.Statusses");
            DropForeignKey("dbo.TeacherCathedras", "Teacher_ID", "dbo.Teachers");
            DropForeignKey("dbo.TeacherCathedras", "Cathedra_ID", "dbo.Cathedras");
            DropForeignKey("dbo.Teachers", "Position_ID", "dbo.Positions");
            DropForeignKey("dbo.Authorizations", "Teacher_ID", "dbo.Teachers");
            DropForeignKey("dbo.Teachers", "Academic_degree1_Academic_degree_ID", "dbo.Academic_degree");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Students", new[] { "Cours_ID" });
            DropIndex("dbo.Students", new[] { "Group_ID" });
            DropIndex("dbo.Marks", new[] { "Group_ID" });
            DropIndex("dbo.Marks", new[] { "Student_ID" });
            DropIndex("dbo.Marks", new[] { "Subjects_ID" });
            DropIndex("dbo.GroupsSubjects", new[] { "Subjects_ID" });
            DropIndex("dbo.GroupsSubjects", new[] { "Group_ID" });
            DropIndex("dbo.TeacherSubjectsStatus", new[] { "Statuss_ID" });
            DropIndex("dbo.TeacherSubjectsStatus", new[] { "Subjects_ID" });
            DropIndex("dbo.TeacherSubjectsStatus", new[] { "Teacher_ID" });
            DropIndex("dbo.TeacherCathedras", new[] { "Cathedra_ID" });
            DropIndex("dbo.TeacherCathedras", new[] { "Teacher_ID" });
            DropIndex("dbo.Authorizations", new[] { "Teacher_ID" });
            DropIndex("dbo.Teachers", new[] { "Academic_degree1_Academic_degree_ID" });
            DropIndex("dbo.Teachers", new[] { "Position_ID" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Number_of_modules");
            DropTable("dbo.Number_lab_modules");
            DropTable("dbo.Curricula");
            DropTable("dbo.Cours");
            DropTable("dbo.Students");
            DropTable("dbo.Marks");
            DropTable("dbo.Groups");
            DropTable("dbo.GroupsSubjects");
            DropTable("dbo.Subjects");
            DropTable("dbo.Statusses");
            DropTable("dbo.TeacherSubjectsStatus");
            DropTable("dbo.Cathedras");
            DropTable("dbo.TeacherCathedras");
            DropTable("dbo.Positions");
            DropTable("dbo.Authorizations");
            DropTable("dbo.Teachers");
            DropTable("dbo.Academic_degree");
        }
    }
}
