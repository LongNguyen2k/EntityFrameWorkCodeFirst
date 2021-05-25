using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnityFrameWorkCodeFirst.Model
{
    class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required , StringLength(50) ,Display(Name = "Tên Danh Mục")]
        public string CategoryName { get; set; }

        [Display(Name = "Mô Tả Chi Tiết ")]
        public string Description { get; set; }

    }
}
