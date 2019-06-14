namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class withdrawalDateColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Transactions", "DepositDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Transactions", "WithdrawalDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Transactions", "Date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Transactions", "Date", c => c.DateTime(nullable: false));
            DropColumn("dbo.Transactions", "WithdrawalDate");
            DropColumn("dbo.Transactions", "DepositDate");
        }
    }
}
