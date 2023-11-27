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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Nhom13
{
    public partial class frmKiemKe : Form
    {
        DBConnect db = new DBConnect();
        public frmKiemKe()
        {
            InitializeComponent();
        }

        private DataGridViewTextBoxColumn newCol (string name)
        {
            DataGridViewTextBoxColumn Col = new DataGridViewTextBoxColumn();
            Col.HeaderText = name;
            Col.ValueType = typeof(int);
            return Col;
        }

        private void load_cboNhomThuoc()
        {
            string query = "select * from NhomThuoc";
            DataTable dt = db.getDatatable(query);

            cboNhomThuoc.DataSource = dt;
            cboNhomThuoc.DisplayMember = "TenNhomThuoc";
            cboNhomThuoc.ValueMember = "MaNhomThuoc";
        }

        private void load_dgvKiemKe ()
        {
            dgvKiemKe.AllowUserToAddRows = false;
            string query = "select MaThuoc, TenThuoc, MaNhomThuoc, SoLuong from THUOC";
            DataTable dt = db.getDatatable(query);
            
            dt.Columns.Add("SoluongTonThucTe");
            dt.Columns.Add("ChenhLech");

            dgvKiemKe.DataSource = dt;

            dgvKiemKe.Columns[0].HeaderText = "Mã thuốc";
            dgvKiemKe.Columns[1].HeaderText = "Tên thuốc";
            dgvKiemKe.Columns[2].HeaderText = "Mã nhóm thuốc";
            dgvKiemKe.Columns[3].HeaderText = "Số lượng tồn";
            dgvKiemKe.Columns[4].HeaderText = "Số lượng tồn thực tế";
            dgvKiemKe.Columns[5].HeaderText = "Chênh lệch";

            txtMaThuoc.DataBindings.Clear();
            txtMaThuoc.DataBindings.Add("Text", dt, "MaThuoc");
            txtTenThuoc.DataBindings.Clear();
            txtTenThuoc.DataBindings.Add("Text", dt, "TenThuoc");
            cboNhomThuoc.DataBindings.Clear();
            cboNhomThuoc.DataBindings.Add("SelectedValue", dt, "MaNhomThuoc");
            txtSLTon.DataBindings.Clear();
            txtSLTon.DataBindings.Add("Text", dt, "SoLuong");
            txtSLThucTe.DataBindings.Clear();
            txtSLThucTe.DataBindings.Add("Text", dt, "SoLuongTonThucTe");
            txtChenhLech.DataBindings.Add("Text", dt, "ChenhLech");

        }

        private void frmKiemKe_Load(object sender, EventArgs e)
        {
            load_cboNhomThuoc();
            load_dgvKiemKe();
        }

        private void txtChenhLech_TextChanged(object sender, EventArgs e)
        {
            int chenhLech = 0;
            if (txtChenhLech.Text != "")
            {
                chenhLech = Convert.ToInt32(txtChenhLech.Text);
            }

            if (chenhLech > 0)
            {
                errorProvider1.SetError(txtChenhLech, "Sản phầm bị thừa!");
            }
            else if (chenhLech < 0)
            {
                errorProvider1.SetError(txtChenhLech, "Sản phẩm bị thiếu!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtSLThucTe_TextChanged(object sender, EventArgs e)
        {

            foreach (DataGridViewRow dgvRow in dgvKiemKe.Rows)
            {
                int rowIndex = dgvRow.Index;
                if (dgvRow.Cells["SoluongTonThucTe"].Value != DBNull.Value && dgvRow.Cells["SoluongTonThucTe"].Value != DBNull.Value)
                {
                    int soluongTonThucTe = Convert.ToInt32(dgvRow.Cells["SoluongTonThucTe"].Value);
                    int soLuong = Convert.ToInt32(dgvRow.Cells["SoLuong"].Value);
                    int chenhLech = soluongTonThucTe - soLuong;
                    dgvKiemKe.Rows[rowIndex].Cells["ChenhLech"].Value = chenhLech;
                    
                }
            }
            dgvKiemKe.Refresh();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dgvKiemKe.Rows)
            {
                int value = 0;
                try
                {
                    value = Convert.ToInt32(row.Cells["ChenhLech"].Value);
                }
                catch 
                {
                    MessageBox.Show("Vui lòng nhập số lượng thực tế");
                }

                if (value != 0)
                {
                    MessageBox.Show("Số lượng thuốc có sự chênh lệch");
                    return;
                }
            }
                
        }
    }
}
