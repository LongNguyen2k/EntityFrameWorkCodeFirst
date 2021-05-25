using EnityFrameWorkCodeFirst.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnityFrameWorkCodeFirst.DAO
{
    class DAO_SANPHAM
    {
        // DAO Hỗ trỡ phương thức lấy chuối kết nối sql để tương tác với CSDL
        ApplicationDBContext db;
        public DAO_SANPHAM()
        {
            db = new ApplicationDBContext();

        }

        public dynamic LayDSLoaiSP()
        {
             // trả về kiểu danh sách .ToList để hiển thị lên comboBox và Datagridview
            var ds = db.Categories.Select(s => new { s.CategoryId, s.CategoryName });

            return ds.ToList();
        }

        public dynamic LayDSSanPham()
        {
            var ds = db.Products.Select(s => new { s.ProductID, s.ProductName, s.Price, s.Cate.CategoryName });

            return ds.ToList();
        }

       

        public void ThemSanPham(Product product)
        {
            // Entity su dun cu phap Add thay cho Insert cua LinQ
            db.Products.Add(product);
            db.SaveChanges();
        }
    }
}
