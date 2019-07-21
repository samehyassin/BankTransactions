namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class makedatesnullabeintranscation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Transactions", "DepositDate", c => c.DateTime());
            AlterColumn("dbo.Transactions", "WithdrawalDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Transactions", "WithdrawalDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Transactions", "DepositDate", c => c.DateTime(nullable: false));
        }
    }
}
