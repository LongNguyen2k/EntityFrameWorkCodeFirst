namespace EnityFrameWorkCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ThemDuLieuVaoCate : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Categories([CategoryName],[Description]) Values(N'Điện Thoại',N'Bán Lẻ')");
            Sql("Insert into Categories([CategoryName],[Description]) Values(N'Máy Tính Bảng',N'Bán Theo Lô')");
            Sql("Insert into Categories([CategoryName],[Description]) Values(N'Laptop',N'Bán Giá Sĩ')");
        }
        
        public override void Down()
        {
        }
    }
}
