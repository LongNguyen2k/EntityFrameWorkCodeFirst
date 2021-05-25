using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnityFrameWorkCodeFirst.Model
{
    class OrderDetail
    {
        [Key]
        [Column(Order = 1) ]
        public int OrderId { get; set; }

        // cau lenh dinh nghia khoa ngoai virtual
        public virtual Order orderTable {get;set;}
        [Key]
        [Column(Order = 2)]
        public int ProductID { get; set; }
        public virtual Product productTable { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

    }
}
