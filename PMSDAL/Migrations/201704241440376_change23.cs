namespace PMSDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change23 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OutSourceHistories",
                c => new
                    {
                        HistoryID = c.Guid(nullable: false),
                        ID = c.Guid(nullable: false),
                        Creator = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        State = c.String(),
                        OrderName = c.String(),
                        Supplier = c.String(),
                        Quantity = c.Double(nullable: false),
                        QuantityUnit = c.String(),
                        Cost = c.Double(nullable: false),
                        Remark = c.String(),
                        Operator = c.String(),
                        OperateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.HistoryID);
            
            CreateTable(
                "dbo.OutSources",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Creator = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        State = c.String(),
                        OrderName = c.String(),
                        Supplier = c.String(),
                        Quantity = c.Double(nullable: false),
                        QuantityUnit = c.String(),
                        Cost = c.Double(nullable: false),
                        Remark = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.OutSources");
            DropTable("dbo.OutSourceHistories");
        }
    }
}
