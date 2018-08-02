namespace APP.UI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.sys_menu",
                c => new
                    {
                        menuId = c.Int(nullable: false, identity: true),
                        parentId = c.Int(),
                        menuName = c.String(unicode: false),
                        menuIcon = c.String(unicode: false),
                        menuUrl = c.String(unicode: false),
                        menuType = c.String(unicode: false),
                        menuOrder = c.String(unicode: false),
                        menuStatus = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.menuId);
            
            CreateTable(
                "dbo.sys_permission",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        pdesc = c.String(unicode: false),
                        name = c.String(unicode: false),
                        menuId = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.sys_menu", t => t.menuId)
                .Index(t => t.menuId);
            
            CreateTable(
                "dbo.sys_operation",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        desc = c.String(unicode: false),
                        name = c.String(unicode: false),
                        operation = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.sys_role_permission",
                c => new
                    {
                        rpId = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        roleId = c.Int(nullable: false),
                        permissionId = c.Int(nullable: false),
                        sys_permission_id = c.Int(),
                    })
                .PrimaryKey(t => t.rpId)
                .ForeignKey("dbo.sys_permission", t => t.sys_permission_id)
                .ForeignKey("dbo.sys_role", t => t.roleId, cascadeDelete: true)
                .Index(t => t.roleId)
                .Index(t => t.sys_permission_id);
            
            CreateTable(
                "dbo.sys_role",
                c => new
                    {
                        roleId = c.Int(nullable: false, identity: true),
                        roleName = c.String(unicode: false),
                        roleDesc = c.String(unicode: false),
                        role = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.roleId);
            
            CreateTable(
                "dbo.sys_user",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        username = c.String(unicode: false),
                        password = c.String(unicode: false),
                        phone = c.String(unicode: false),
                        sex = c.String(unicode: false),
                        email = c.String(unicode: false),
                        mark = c.String(unicode: false),
                        rank = c.String(unicode: false),
                        lastLogin = c.DateTime(precision: 0),
                        loginIp = c.String(unicode: false),
                        imageUrl = c.String(unicode: false),
                        regTime = c.DateTime(nullable: false, precision: 0),
                        locked = c.Boolean(),
                        rights = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.sys_operationsys_permission",
                c => new
                    {
                        sys_operation_id = c.Int(nullable: false),
                        sys_permission_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.sys_operation_id, t.sys_permission_id })
                .ForeignKey("dbo.sys_operation", t => t.sys_operation_id, cascadeDelete: true)
                .ForeignKey("dbo.sys_permission", t => t.sys_permission_id, cascadeDelete: true)
                .Index(t => t.sys_operation_id)
                .Index(t => t.sys_permission_id);
            
            CreateTable(
                "dbo.sys_usersys_role",
                c => new
                    {
                        sys_user_id = c.Int(nullable: false),
                        sys_role_roleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.sys_user_id, t.sys_role_roleId })
                .ForeignKey("dbo.sys_user", t => t.sys_user_id, cascadeDelete: true)
                .ForeignKey("dbo.sys_role", t => t.sys_role_roleId, cascadeDelete: true)
                .Index(t => t.sys_user_id)
                .Index(t => t.sys_role_roleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.sys_usersys_role", "sys_role_roleId", "dbo.sys_role");
            DropForeignKey("dbo.sys_usersys_role", "sys_user_id", "dbo.sys_user");
            DropForeignKey("dbo.sys_role_permission", "roleId", "dbo.sys_role");
            DropForeignKey("dbo.sys_role_permission", "sys_permission_id", "dbo.sys_permission");
            DropForeignKey("dbo.sys_operationsys_permission", "sys_permission_id", "dbo.sys_permission");
            DropForeignKey("dbo.sys_operationsys_permission", "sys_operation_id", "dbo.sys_operation");
            DropForeignKey("dbo.sys_permission", "menuId", "dbo.sys_menu");
            DropIndex("dbo.sys_usersys_role", new[] { "sys_role_roleId" });
            DropIndex("dbo.sys_usersys_role", new[] { "sys_user_id" });
            DropIndex("dbo.sys_operationsys_permission", new[] { "sys_permission_id" });
            DropIndex("dbo.sys_operationsys_permission", new[] { "sys_operation_id" });
            DropIndex("dbo.sys_role_permission", new[] { "sys_permission_id" });
            DropIndex("dbo.sys_role_permission", new[] { "roleId" });
            DropIndex("dbo.sys_permission", new[] { "menuId" });
            DropTable("dbo.sys_usersys_role");
            DropTable("dbo.sys_operationsys_permission");
            DropTable("dbo.sys_user");
            DropTable("dbo.sys_role");
            DropTable("dbo.sys_role_permission");
            DropTable("dbo.sys_operation");
            DropTable("dbo.sys_permission");
            DropTable("dbo.sys_menu");
        }
    }
}
