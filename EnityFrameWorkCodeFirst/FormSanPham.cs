using EnityFrameWorkCodeFirst.BUS;
using EnityFrameWorkCodeFirst.Model;
using EnityFrameWorkCodeFirst.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnityFrameWorkCodeFirst
{
    public partial class FormSanPham : Form
    {
        // Kết nối để giao tiếp với lớp BUS 
        BUS_SANPHAM busSP;
        public FormSanPham()
        {
            InitializeComponent();
            busSP = new BUS_SANPHAM();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            // 
            Product p = new Product();
            p.ProductName = txtTenSP.Text;
            p.Price = int.Parse(txtDonGia.Text);
            p.CategoryID = int.Parse(cbLoaiSP.SelectedValue.ToString());
            p.Description = txtMoTa.Text;

            busSP.ThemSanPham(p);

            HienThiDG();


        }

        private void FormSanPham_Leave(object sender, EventArgs e)
        {
            
        }

        private void FormSanPham_Load(object sender, EventArgs e)
        {
            busSP.HienThiDSLoaiSanPham(cbLoaiSP);
            HienThiDG();
           
        }

        void HienThiDG()
        {
            dGSP.DataSource = null;
            busSP.HienThiDSSanPham(dGSP);
            dGSP.Columns[0].Width = (int)(dGSP.Width * 0.24);
            dGSP.Columns[1].Width = (int)(dGSP.Width * 0.24);
            dGSP.Columns[2].Width = (int)(dGSP.Width * 0.24);
            dGSP.Columns[3].Width = (int)(dGSP.Width * 0.24);
            // reset gia tri ve chua nhap 
            txtDonGia.Text = txtTenSP.Text = txtMoTa.Text = "";
            cbLoaiSP.SelectedIndex = 0;

        }

        private void buttonReportCtP_Click(object sender, EventArgs e)
        {
            // gọi form crystal report lay du lieu 
            ctpProduct c = new ctpProduct();


            // gọi form  report 
            FormReportProduct f = new FormReportProduct();
            f.crystalReportViewer1.ReportSource = c;
            f.ShowDialog();
        }
    }
}
