namespace ShopGame.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Footer",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        content = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.InfoSupport",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(storeType: "ntext"),
                        department = c.String(storeType: "ntext"),
                        skype = c.String(maxLength: 50),
                        mobile = c.String(maxLength: 50),
                        emaill = c.String(maxLength: 50),
                        facebook = c.String(maxLength: 50),
                        address = c.String(storeType: "ntext"),
                        status = c.Boolean(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(maxLength: 520),
                        url = c.String(maxLength: 520),
                        displayoder = c.Int(),
                        taget = c.String(maxLength: 50),
                        status = c.Boolean(),
                        groupid = c.Int(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.OderDetails",
                c => new
                    {
                        oderid = c.Int(nullable: false),
                        productid = c.Int(nullable: false),
                        quality = c.Int(),
                    })
                .PrimaryKey(t => new { t.oderid, t.productid });
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        custormername = c.String(maxLength: 250),
                        custormeradress = c.String(maxLength: 250),
                        custormeremail = c.String(maxLength: 250),
                        custormerphone = c.String(maxLength: 250),
                        createdat = c.DateTime(),
                        createby = c.String(maxLength: 50),
                        paymethod = c.String(maxLength: 250),
                        paystatus = c.String(maxLength: 250),
                        status = c.Boolean(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Pages",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 250),
                        content = c.String(storeType: "ntext"),
                        makekeyword = c.String(maxLength: 250),
                        makedesiption = c.String(maxLength: 250),
                        status = c.Boolean(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.PostCateGories",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 250, unicode: false),
                        alias = c.String(nullable: false, maxLength: 250, unicode: false),
                        parentid = c.Int(),
                        displayoder = c.Int(),
                        image = c.String(maxLength: 250),
                        metakeyword = c.String(maxLength: 250),
                        metaDesciption = c.String(maxLength: 250),
                        createdat = c.DateTime(),
                        createby = c.String(maxLength: 250),
                        updatedat = c.DateTime(),
                        updateby = c.String(maxLength: 250),
                        status = c.Boolean(nullable: false),
                        homeflag = c.Boolean(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 250, unicode: false),
                        alias = c.String(nullable: false, maxLength: 250, unicode: false),
                        categoryid = c.Int(),
                        desciption = c.String(maxLength: 250),
                        content = c.String(storeType: "ntext"),
                        image = c.String(maxLength: 250),
                        metakeyword = c.String(maxLength: 250),
                        metaDesciption = c.String(maxLength: 250),
                        createdat = c.DateTime(),
                        createby = c.String(maxLength: 250),
                        updatedat = c.DateTime(),
                        updateby = c.String(maxLength: 250),
                        status = c.Boolean(nullable: false),
                        homeflag = c.Boolean(),
                        hotflag = c.Boolean(),
                        viewcount = c.Long(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.PostTags",
                c => new
                    {
                        potsid = c.Int(nullable: false),
                        tagid = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => new { t.potsid, t.tagid });
            
            CreateTable(
                "dbo.ProductCateGories",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 250, unicode: false),
                        alias = c.String(nullable: false, maxLength: 250, unicode: false),
                        parentid = c.Int(),
                        displayoder = c.Int(),
                        image = c.String(maxLength: 250),
                        metakeyword = c.String(maxLength: 250),
                        metaDesciption = c.String(maxLength: 250),
                        createdat = c.DateTime(),
                        createby = c.String(maxLength: 250),
                        updatedat = c.DateTime(),
                        updateby = c.String(maxLength: 250),
                        status = c.Boolean(),
                        homeflag = c.Boolean(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 250, unicode: false),
                        alias = c.String(nullable: false, maxLength: 250, unicode: false),
                        categoryid = c.Int(),
                        desciption = c.String(maxLength: 250),
                        content = c.String(storeType: "ntext"),
                        promotion = c.Decimal(precision: 18, scale: 0),
                        warraly = c.Int(),
                        price = c.Decimal(precision: 18, scale: 0),
                        moreimage = c.String(storeType: "xml"),
                        image = c.String(maxLength: 250),
                        metakeyword = c.String(maxLength: 250),
                        metaDesciption = c.String(maxLength: 250),
                        createdat = c.DateTime(),
                        createby = c.String(maxLength: 250),
                        updatedat = c.DateTime(),
                        updateby = c.String(maxLength: 250),
                        status = c.Boolean(),
                        homeflag = c.Boolean(),
                        hotflag = c.Boolean(),
                        viewcount = c.Long(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.ProductTags",
                c => new
                    {
                        productid = c.Int(nullable: false),
                        tagid = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => new { t.productid, t.tagid });
            
            CreateTable(
                "dbo.IdentityRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IdentityUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(),
                        IdentityRole_Id = c.String(maxLength: 128),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.IdentityRoles", t => t.IdentityRole_Id)
                .ForeignKey("dbo.ApplicationUsers", t => t.ApplicationUser_Id)
                .Index(t => t.IdentityRole_Id)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.Slide",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(maxLength: 250),
                        desciption = c.String(maxLength: 250),
                        image = c.String(maxLength: 250),
                        url = c.String(maxLength: 250),
                        displayoder = c.Int(),
                        status = c.Boolean(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.SystemConfig",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        code = c.String(storeType: "ntext"),
                        valuestring = c.String(storeType: "ntext"),
                        valueInt = c.Int(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 50, unicode: false),
                        name = c.String(maxLength: 50, unicode: false),
                        type = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.ApplicationUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        fullname = c.String(maxLength: 256),
                        address = c.String(maxLength: 256),
                        birthday = c.DateTime(),
                        Email = c.String(),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IdentityUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ApplicationUsers", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.IdentityUserLogins",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        LoginProvider = c.String(),
                        ProviderKey = c.String(),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.ApplicationUsers", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.IdentityUserRoles", "ApplicationUser_Id", "dbo.ApplicationUsers");
            DropForeignKey("dbo.IdentityUserLogins", "ApplicationUser_Id", "dbo.ApplicationUsers");
            DropForeignKey("dbo.IdentityUserClaims", "ApplicationUser_Id", "dbo.ApplicationUsers");
            DropForeignKey("dbo.IdentityUserRoles", "IdentityRole_Id", "dbo.IdentityRoles");
            DropIndex("dbo.IdentityUserLogins", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.IdentityUserClaims", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.IdentityUserRoles", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.IdentityUserRoles", new[] { "IdentityRole_Id" });
            DropTable("dbo.IdentityUserLogins");
            DropTable("dbo.IdentityUserClaims");
            DropTable("dbo.ApplicationUsers");
            DropTable("dbo.Tags");
            DropTable("dbo.SystemConfig");
            DropTable("dbo.Slide");
            DropTable("dbo.IdentityUserRoles");
            DropTable("dbo.IdentityRoles");
            DropTable("dbo.ProductTags");
            DropTable("dbo.Product");
            DropTable("dbo.ProductCateGories");
            DropTable("dbo.PostTags");
            DropTable("dbo.Posts");
            DropTable("dbo.PostCateGories");
            DropTable("dbo.Pages");
            DropTable("dbo.Orders");
            DropTable("dbo.OderDetails");
            DropTable("dbo.Menus");
            DropTable("dbo.InfoSupport");
            DropTable("dbo.Footer");
        }
    }
}
