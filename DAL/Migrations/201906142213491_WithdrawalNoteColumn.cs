namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WithdrawalNoteColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Transactions", "DepositNote", c => c.String(maxLength: 300));
            AddColumn("dbo.Transactions", "WithdrawalNote", c => c.String(maxLength: 300));
            DropColumn("dbo.Transactions", "Note");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Transactions", "Note", c => c.String(maxLength: 300));
            DropColumn("dbo.Transactions", "WithdrawalNote");
            DropColumn("dbo.Transactions", "DepositNote");
        }
    }
}
