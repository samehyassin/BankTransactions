namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyingPropName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "EmpName", c => c.String(maxLength: 100));
            AddColumn("dbo.Employees", "EmpTitle", c => c.String(maxLength: 50));
            AddColumn("dbo.Employees", "EmpMobile", c => c.Int(nullable: false));
            DropColumn("dbo.Employees", "Name");
            DropColumn("dbo.Employees", "Title");
            DropColumn("dbo.Employees", "Mobile");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "Mobile", c => c.Int(nullable: false));
            AddColumn("dbo.Employees", "Title", c => c.String(maxLength: 50));
            AddColumn("dbo.Employees", "Name", c => c.String(maxLength: 100));
            DropColumn("dbo.Employees", "EmpMobile");
            DropColumn("dbo.Employees", "EmpTitle");
            DropColumn("dbo.Employees", "EmpName");
        }
    }
}
