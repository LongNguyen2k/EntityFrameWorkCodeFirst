using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnityFrameWorkCodeFirst.Model
{
    class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Required, StringLength(50), Display(Name = "Tên Sản Phẩm ")]
        public string ProductName { get; set; }

        [Display(Name = "Mô Tả Sản Phẩm ")]
        public string Description { get; set; }

        [Required, Display(Name = "Giá Sản Phẩm ")]
        public decimal Price { get; set; }

        [ Display(Name = " Màu ")]
        public string Color { get; set; }

        [ Display(Name = "Nhà Sản Xuất")]
        public string Producer { get; set; }

        [ Display(Name = " Ảnh Đại Diện ")]
        public string Image { get; set; }

        [ Display(Name = " Người tạo ")]
        public string Creator { get; set; }

        [Required, Display(Name = " Danh Mục ")]
        public int CategoryID { get; set; }

        public virtual Category Cate { get; set; }
    }
}
