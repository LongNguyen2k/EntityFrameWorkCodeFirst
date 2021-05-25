using EnityFrameWorkCodeFirst.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnityFrameWorkCodeFirst
{
    class ApplicationDBContext:DbContext
    {
        // ket noi class den database

        public ApplicationDBContext():base ("CnStr")
        {

        }

        // tạo ra 3 bảng

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDeTails { get; set; }

        // tim hieu them ve onModelCreating
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // tạo ràng buộc khóa ngoại và khóa chính của 2 bảng 
            modelBuilder.Entity<OrderDetail>().HasRequired(a => a.productTable)
                .WithMany()
                .WillCascadeOnDelete(false);

            // xoa day chuyen va cap nhat day chuyen database
            base.OnModelCreating(modelBuilder);
        }
    }
}
