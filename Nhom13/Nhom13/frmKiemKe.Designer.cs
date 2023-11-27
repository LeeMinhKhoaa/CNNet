namespace Nhom13
{
    partial class frmKiemKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvKiemKe = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenThuoc = new System.Windows.Forms.TextBox();
            this.cboNhomThuoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSLTon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaThuoc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSLThucTe = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtChenhLech = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTaoPhieuKK = new System.Windows.Forms.Button();
            this.btnNhapXuatHangHoa = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKiemKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKiemKe
            // 
            this.dgvKiemKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKiemKe.Location = new System.Drawing.Point(6, 47);
            this.dgvKiemKe.Name = "dgvKiemKe";
            this.dgvKiemKe.RowHeadersWidth = 51;
            this.dgvKiemKe.RowTemplate.Height = 24;
            this.dgvKiemKe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKiemKe.Size = new System.Drawing.Size(1101, 357);
            this.dgvKiemKe.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(471, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kiểm kê";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên thuốc";
            // 
            // txtTenThuoc
            // 
            this.txtTenThuoc.Location = new System.Drawing.Point(491, 54);
            this.txtTenThuoc.Name = "txtTenThuoc";
            this.txtTenThuoc.Size = new System.Drawing.Size(220, 22);
            this.txtTenThuoc.TabIndex = 6;
            // 
            // cboNhomThuoc
            // 
            this.cboNhomThuoc.FormattingEnabled = true;
            this.cboNhomThuoc.Location = new System.Drawing.Point(847, 53);
            this.cboNhomThuoc.Name = "cboNhomThuoc";
            this.cboNhomThuoc.Size = new System.Drawing.Size(220, 24);
            this.cboNhomThuoc.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(756, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nhóm thuốc";
            // 
            // txtSLTon
            // 
            this.txtSLTon.Location = new System.Drawing.Point(130, 97);
            this.txtSLTon.Name = "txtSLTon";
            this.txtSLTon.Size = new System.Drawing.Size(220, 22);
            this.txtSLTon.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Số lượng tồn";
            // 
            // txtMaThuoc
            // 
            this.txtMaThuoc.Location = new System.Drawing.Point(130, 54);
            this.txtMaThuoc.Name = "txtMaThuoc";
            this.txtMaThuoc.Size = new System.Drawing.Size(220, 22);
            this.txtMaThuoc.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mã thuốc";
            // 
            // txtSLThucTe
            // 
            this.txtSLThucTe.Location = new System.Drawing.Point(491, 97);
            this.txtSLThucTe.Name = "txtSLThucTe";
            this.txtSLThucTe.Size = new System.Drawing.Size(220, 22);
            this.txtSLThucTe.TabIndex = 14;
            this.txtSLThucTe.TextChanged += new System.EventHandler(this.txtSLThucTe_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(376, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Số lượng thực tế";
            // 
            // txtChenhLech
            // 
            this.txtChenhLech.Enabled = false;
            this.txtChenhLech.Location = new System.Drawing.Point(847, 97);
            this.txtChenhLech.Name = "txtChenhLech";
            this.txtChenhLech.Size = new System.Drawing.Size(220, 22);
            this.txtChenhLech.TabIndex = 16;
            this.txtChenhLech.TextChanged += new System.EventHandler(this.txtChenhLech_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(761, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Chênh lệch";
            // 
            // btnTaoPhieuKK
            // 
            this.btnTaoPhieuKK.Location = new System.Drawing.Point(958, 14);
            this.btnTaoPhieuKK.Name = "btnTaoPhieuKK";
            this.btnTaoPhieuKK.Size = new System.Drawing.Size(148, 27);
            this.btnTaoPhieuKK.TabIndex = 17;
            this.btnTaoPhieuKK.Text = "Tạo phiếu kiểm kê";
            this.btnTaoPhieuKK.UseVisualStyleBackColor = true;
            // 
            // btnNhapXuatHangHoa
            // 
            this.btnNhapXuatHangHoa.Location = new System.Drawing.Point(789, 14);
            this.btnNhapXuatHangHoa.Name = "btnNhapXuatHangHoa";
            this.btnNhapXuatHangHoa.Size = new System.Drawing.Size(163, 27);
            this.btnNhapXuatHangHoa.TabIndex = 18;
            this.btnNhapXuatHangHoa.Text = "Nhập - xuất hàng hóa";
            this.btnNhapXuatHangHoa.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvKiemKe);
            this.groupBox1.Controls.Add(this.btnTaoPhieuKK);
            this.groupBox1.Controls.Add(this.btnNhapXuatHangHoa);
            this.groupBox1.Location = new System.Drawing.Point(4, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1112, 413);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách thuốc";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(913, 128);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(154, 27);
            this.btnLuu.TabIndex = 20;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frmKiemKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 572);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtChenhLech);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSLThucTe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMaThuoc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSLTon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboNhomThuoc);
            this.Controls.Add(this.txtTenThuoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmKiemKe";
            this.Text = "frmKiemKe";
            this.Load += new System.EventHandler(this.frmKiemKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKiemKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKiemKe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenThuoc;
        private System.Windows.Forms.ComboBox cboNhomThuoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSLTon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaThuoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSLThucTe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtChenhLech;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTaoPhieuKK;
        private System.Windows.Forms.Button btnNhapXuatHangHoa;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLuu;
    }
}