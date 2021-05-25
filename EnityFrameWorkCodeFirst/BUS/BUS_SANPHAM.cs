using EnityFrameWorkCodeFirst.DAO;
using EnityFrameWorkCodeFirst.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnityFrameWorkCodeFirst.BUS
{
    class BUS_SANPHAM
    {
        // Giao Thức kết nối với DAO là phần trung gian giữa GUI và DAO 


        DAO_SANPHAM daoSP;
        public BUS_SANPHAM()
        {
            daoSP = new DAO_SANPHAM(); 
        }
        public void HienThiDSLoaiSanPham(ComboBox cb)
        {
            cb.DataSource = daoSP.LayDSLoaiSP();
            cb.DisplayMember = "CategoryName";
            cb.ValueMember = "CategoryID";

        }
        public void HienThiDSSanPham(DataGridView dg)
        {
            dg.DataSource = daoSP.LayDSSanPham();
            

        }
        // zbat loi chu yeu o BUS
        public void ThemSanPham(Product p)
        {
            try
            {
                daoSP.ThemSanPham(p);
                MessageBox.Show("Them Thanh Cong !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + " ====== Them That Bai !");

                throw;
            }
        }
    }
}
