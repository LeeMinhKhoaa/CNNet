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
            string sql = "select * from THUOC WHERE HanSuDung >= GETDATE()";
            load_dgvThuoc(sql);
            load_cboNhomThuoc();

        }

        private void load_dgvThuoc(string sql)
        {
            DataTable dt = db.getDatatable(sql);
            dgvThuoc.DataSource = dt;
        }

        private void load_cboNhomThuoc()
        {
            string sql = "select * from NHOMTHUOC";
            DataTable dt = db.getDatatable(sql);

            cboNhomThuoc.DataSource = dt;
            cboNhomThuoc.ValueMember = "MANHOMTHUOC";
            cboNhomThuoc.DisplayMember = "TENNHOMTHUOC";
            cboNhomThuoc.SelectedValue = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tenThuoc = txtTenThuoc.Text;
            string maThuoc = "";
            string daHetHan = "AND HanSuDung >= GETDATE()";

            if(string.IsNullOrEmpty(tenThuoc))
            {
                MessageBox.Show("Vui lòng nhập thuốc muốn tìm!", "Nhắc nhở");
                return;
            }

            if (cboNhomThuoc.SelectedIndex > -1)
            {
                 maThuoc = "%"+cboNhomThuoc.SelectedValue.ToString()+ "%";
            }
            if(chkHetHan.Checked == true)
            {
                daHetHan = "";
            }
            else
            {
                daHetHan = "AND HanSuDung >= GETDATE()";
            }
            
            

            string sql = "select * from THUOC where (MaThuoc LIKE '%" + tenThuoc + "%' OR MaNhomThuoc LIKE '"+maThuoc+ "' ) "+daHetHan+"";
            load_dgvThuoc(sql);
            
        }

        private void btnTaoPhieuKK_Click(object sender, EventArgs e)
        {
            frmKiemKe frm = new frmKiemKe();
            frm.Text = "Kiểm kê";
            frm.Show();
        }

    }
}
