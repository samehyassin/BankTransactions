namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Intial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustId = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(nullable: false, maxLength: 200),
                        Phone = c.String(maxLength: 50),
                        Mobile = c.String(maxLength: 50),
                        Email = c.String(maxLength: 100),
                        Address = c.String(maxLength: 300),
                        TaxFileNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CustId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmpId = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 100),
                        Title = c.String(maxLength: 50),
                        Mobile = c.Int(nullable: false),
                        IsActive = c.String(maxLength: 1),
                    })
                .PrimaryKey(t => t.EmpId);
            
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        TransId = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        InvoiceNumber = c.Int(nullable: false),
                        InvoiceAmount = c.Decimal(nullable: false, precision: 9, scale: 2),
                        AmountAdded = c.Decimal(nullable: false, precision: 9, scale: 2),
                        SalesReceiptNumber = c.Int(nullable: false),
                        SalesRecieptAmount = c.Decimal(nullable: false, precision: 9, scale: 2),
                        PaymentMethod = c.String(),
                        CheckNumber = c.Int(nullable: false),
                        RefNumber = c.Int(nullable: false),
                        WithdrawalAmount = c.Decimal(nullable: false, precision: 9, scale: 2),
                        WithdRefNumber = c.Int(nullable: false),
                        Note = c.String(maxLength: 300),
                        EmpId = c.Int(nullable: false),
                        CustId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TransId)
                .ForeignKey("dbo.Customers", t => t.CustId, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.EmpId, cascadeDelete: true)
                .Index(t => t.EmpId)
                .Index(t => t.CustId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transactions", "EmpId", "dbo.Employees");
            DropForeignKey("dbo.Transactions", "CustId", "dbo.Customers");
            DropIndex("dbo.Transactions", new[] { "CustId" });
            DropIndex("dbo.Transactions", new[] { "EmpId" });
            DropTable("dbo.Transactions");
            DropTable("dbo.Employees");
            DropTable("dbo.Customers");
        }
    }
}
