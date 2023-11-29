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

        private void frm_Home_Load(object sender, EventArgs e)
        {
            load_lstNhomThuoc_KiemKe();
            txtSoLuongTonKK.Enabled = false;
        }

        private DataGridViewTextBoxColumn newCol(string name)
        {
            DataGridViewTextBoxColumn Col = new DataGridViewTextBoxColumn();
            Col.HeaderText = name;
            Col.ValueType = typeof(int);
            return Col;
        }

        private void load_lstNhomThuoc_KiemKe()
        {
            string query = "select * from NhomThuoc";
            DataTable dt = db.getDatatable(query);

            lstNhomThuocKiemKe.DataSource = dt;
            lstNhomThuocKiemKe.DisplayMember = "TenNhomThuoc";
            lstNhomThuocKiemKe.ValueMember = "MaNhomThuoc";
        }

        private void load_cboThuoc_KiemKe(string MaNhomThuoc)
        {
            MaNhomThuoc = lstNhomThuocKiemKe.SelectedValue.ToString();

            string query = "select * from thuoc where MaNhomThuoc = '" + MaNhomThuoc + "'";

            DataTable dt = db.getDatatable(query);

            cboTenThuocKK.DataSource = dt;
            cboTenThuocKK.ValueMember = "MaThuoc";
            cboTenThuocKK.DisplayMember = "TenThuoc";


            txtMaThuocKK.DataBindings.Clear();
            txtMaThuocKK.DataBindings.Add("Text", dt, "MaThuoc");
            txtMaLoaiKK.DataBindings.Clear();
            txtMaLoaiKK.DataBindings.Add("Text", dt, "MaLoaiThuoc");
            txtNhomThuocKK.DataBindings.Clear();
            txtNhomThuocKK.DataBindings.Add("Text", dt, "MaNhomThuoc");
            txtXuatXuKK.DataBindings.Clear();
            txtXuatXuKK.DataBindings.Add("Text", dt, "XuatXu");
            txtSoLuongTonKK.DataBindings.Clear();
            txtSoLuongTonKK.DataBindings.Add("Text", dt, "SoLuong");

        }

        private void lstThuocKiemKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            string MaNhomThuoc = lstNhomThuocKiemKe.SelectedValue.ToString();
            load_cboThuoc_KiemKe(MaNhomThuoc);
        }

        private void load_dgvLoThuoc_KiemKe(string maThuoc)
        {
            dgvLoThuocKK.AllowUserToAddRows = false;

            string query = "select * from LoThuoc where MaThuoc = '" + maThuoc + "'";

            DataTable dt = db.getDatatable(query);
            dgvLoThuocKK.DataSource = dt;

            dgvLoThuocKK.Columns[0].HeaderText = "Mã lô";
            dgvLoThuocKK.Columns[1].HeaderText = "Số lô";
            dgvLoThuocKK.Columns[2].HeaderText = "Số lượng tồn";
            dgvLoThuocKK.Columns[3].HeaderText = "Hạn sử dụng";
            dgvLoThuocKK.Columns[4].HeaderText = "Mã thuốc";


            txtMaLoKK.DataBindings.Clear();
            txtMaLoKK.DataBindings.Add("Text", dt, "MaLo");
            txtSoLuongThucKK.DataBindings.Clear();
            txtSoLuongThucKK.DataBindings.Add("Text", dt, "SoLuongTon");


        }
        private void cboTenThuocKK_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtChenhLech.Clear();
            string maThuoc = cboTenThuocKK.SelectedValue.ToString();
            load_dgvLoThuoc_KiemKe(maThuoc);
        }

        private void UpdateSoLuongTon_Chenhlech()
        {
            try
            {
                int tongSoluongTonThucTe = 0;
                foreach (DataGridViewRow row in dgvLoThuocKK.Rows)
                {
                    tongSoluongTonThucTe += Convert.ToInt32(row.Cells["SoLuongTon"].Value);
                }

                int soLuong = Convert.ToInt32(txtSoLuongTonKK.Text);
                int chenhLech = tongSoluongTonThucTe - soLuong;

                txtChenhLech.Text = chenhLech.ToString();

            }
            catch { }
            dgvLoThuocKK.Refresh();



        }

        ds_ChenhLech dsChenhLech = new ds_ChenhLech();
        private void btnSuaKK_Click(object sender, EventArgs e)
        {
            UpdateSoLuongTon_Chenhlech();
            update_LoThuoc();


        }

        bool check_UpdateSLTon_kk = false;
        private void update_Thuoc()
        {
            string maThuoc = txtMaThuocKK.Text.Trim();
            int soluong = Convert.ToInt32(txtSoLuongTonKK.Text);


            string query = "update thuoc set SoLuong = "+soluong+" where MaThuoc = '"+maThuoc+"'";

            int kq = db.getNonQuery(query);
            if (kq > 0)
            {
                check_UpdateSLTon_kk = true;
            }
            else
            {
                MessageBox.Show("Cập nhật số lượng tồn thất bại");
            }
        }

        private void update_LoThuoc()
        {
            int index = dgvLoThuocKK.CurrentCell.RowIndex;

            string maLo = dgvLoThuocKK.Rows[index].Cells["MaLo"].Value.ToString();
            int soLuong = Convert.ToInt32(dgvLoThuocKK.Rows[index].Cells["SoLuongTon"].Value);

            string query = "update LoThuoc set SoLuongTon = " + soLuong + " where MaLo = '" + maLo + "'";
            int kq = db.getNonQuery(query);

            if(kq > 0)
            {
                MessageBox.Show("Cập nhật số lượng thành công.", "Thông báo");
            }
            else
            {
                MessageBox.Show("Cập nhật số lượng thất bại.", "Thông báo");
            }


        }

        private void update_dsChenhLech()
        {

            string maThuoc = txtMaThuocKK.Text;
            foreach (DataRow dr in dsChenhLech.Tables["ChenhLechKiemKe"].Rows)
            {
                if (maThuoc == dr["MaThuoc"].ToString())
                {
                    dr["ChenhLech"] = txtChenhLech.Text;
                }
            }

        }

        private void btnLuuKK_Click(object sender, EventArgs e)
        {
            UpdateSoLuongTon_Chenhlech();

            try
            {
                int value = Convert.ToInt32(txtChenhLech.Text);
                if (value != 0)
                {
                        MessageBox.Show("Số lượng thuốc có sự chênh lệch.", "Nhắc nhở");
                        return;
                }
               
                MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK);

                update_dsChenhLech();

                update_Thuoc();
                if(check_UpdateSLTon_kk == true)
                {
                    check_UpdateSLTon_kk=false;
                }


            }
                catch
                {
                    MessageBox.Show("Vui lòng nhập số lượng kiểm kê");
                }
            
            }
        private void btnPhieuKiemKe_Click(object sender, EventArgs e)
        {
            

            txtSoLuongTonKK.Enabled = true;

            rpt_KiemKe rpt = new rpt_KiemKe();
            rpt.SetDataSource(dsChenhLech.Tables["ChenhLechKiemKe"]);

            frm_Report_KiemKe reportForm = new frm_Report_KiemKe();
            reportForm.crystalReportViewer1.ReportSource = rpt;
            reportForm.ShowDialog();

            

        }

       

        private void btnLuuChenhLech_Click(object sender, EventArgs e)
        {

            if (txtChenhLech.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số lượng thực tế.", "Nhắc nhở");
                return;
            }


            DataTable dt = dsChenhLech.Tables["ChenhLechKiemKe"];

            foreach (DataRow row1 in dt.Rows)
            {
                if (row1["MaThuoc"].ToString() == txtMaThuocKK.Text)
                {
                    DialogResult a = MessageBox.Show("Bạn có muốn lưu lại chênh lệch của thuốc này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if(a == DialogResult.Yes)
                    {
                        update_dsChenhLech();
                        MessageBox.Show("Cập nhật thành công", "Thông báo");
                        return;
                    }
                    else
                    {
                        return;
                    }

                }
            }

            int SoLuongThuc = 0;
            foreach(DataGridViewRow dvr in dgvLoThuocKK.Rows)
            {
                SoLuongThuc += Convert.ToInt32(dvr.Cells["SoLuongTon"].Value);
            }

            DataRow row = dsChenhLech.Tables["ChenhLechKiemKe"].NewRow();
            row["TenThuoc"] = cboTenThuocKK.Text.Trim();
            row["MaThuoc"] = txtMaThuocKK.Text.Trim();
            row["ChenhLech"] = Convert.ToInt32(txtChenhLech.Text.Trim());
            row["SoLuong"] = SoLuongThuc;
            row["SoLuongTon"] = txtSoLuongTonKK.Text.Trim();
            dsChenhLech.Tables["ChenhLechKiemKe"].Rows.Add(row);

            int chenhlech = Convert.ToInt32(txtChenhLech.Text);

            if(chenhlech > 0)
            {
                MessageBox.Show(cboTenThuocKK.Text + " dư " + txtChenhLech.Text);

            }
            else if (chenhlech < 0)
            {
                MessageBox.Show(cboTenThuocKK.Text + " thiếu  " + txtChenhLech.Text);
            }
            else
            {
                MessageBox.Show(cboTenThuocKK.Text + " chênh lệch " + txtChenhLech.Text, "Thông báo");

            }



        }

        private void txtMaThuocKK_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = dsChenhLech.Tables["ChenhLechKiemKe"];
            foreach (DataRow row in dt.Rows)
            {
                if (txtMaThuocKK.Text == row["MaThuoc"].ToString())
                {
                    txtChenhLech.Text = row["ChenhLech"].ToString();
                }
            }
        }
    }
}
    
