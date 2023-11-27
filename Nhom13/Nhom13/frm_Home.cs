using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom13
{
    public partial class frm_Home : Form
    {
        DBConnect db = new DBConnect();

        public frm_Home()
        {
            InitializeComponent();
        }

        private void load_lstThuoc_KiemKe()
        {
            string query = "select * from NhomThuoc";
            DataTable dt = db.getDatatable(query);

            lstThuocKiemKe.DataSource = dt;
            lstThuocKiemKe.DisplayMember = "TenNhomThuoc";
            lstThuocKiemKe.ValueMember = "MaNhomThuoc";

            /*
            txtTenThuocKK.DataBindings.Clear();
            txtTenThuocKK.DataBindings.Add("Text", dt, "TenThuoc");
            txtMaThuocKK.DataBindings.Clear();
            txtMaThuocKK.DataBindings.Add("Text", dt, "MaThuoc");
            txtMaLoaiKK.DataBindings.Clear();
            txtMaLoaiKK.DataBindings.Add("Text", dt, "MaLoaiThuoc");
            txtNhomThuocKK.DataBindings.Clear();
            txtNhomThuocKK.DataBindings.Add("Text", dt, "MaNhomThuoc");
            txtXuatXuKK.DataBindings.Clear();
            txtXuatXuKK.DataBindings.Add("Text", dt, "XuatXu");
            txtSoLuongKK.DataBindings.Clear();
            txtSoLuongKK.DataBindings.Add("Text", dt, "SoLuong");
            */
        }

        private void load_cboLoThuoc_KiemKe(string MaThuoc)
        {
            string query = "select * from LoThuoc where MaThuoc = '"+MaThuoc+"' ";
            DataTable dt = db.getDatatable(query);

            cboLoThuocKK.DataSource = dt;
            cboLoThuocKK.ValueMember = "MaLo";

        }

        private void frm_Home_Load(object sender, EventArgs e)
        {
            load_lstThuoc_KiemKe();

        }
        private void load_dgvLoThuoc_KiemKe(string maLo)
        {
            maLo = cboLoThuocKK.SelectedValue.ToString();

            string query = "select * from LoThuoc where ";
        }

        private void lstThuocKiemKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maThuoc = lstThuocKiemKe.SelectedValue.ToString();
            load_cboLoThuoc_KiemKe(maThuoc);
        }
    }
}
