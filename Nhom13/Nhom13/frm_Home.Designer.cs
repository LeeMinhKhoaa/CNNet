namespace Nhom13
{
    partial class frm_Home
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.chkHetHan = new System.Windows.Forms.CheckBox();
            this.btnTaoPhieuKK = new System.Windows.Forms.Button();
            this.cboNhomThuoc = new System.Windows.Forms.ComboBox();
            this.txtTenThuoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvThuoc = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1125, 529);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1117, 500);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1117, 500);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tạo hóa đơn";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1117, 500);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tạo phiếu nhập";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1117, 500);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Thống kê";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.button2);
            this.tabPage5.Controls.Add(this.label2);
            this.tabPage5.Controls.Add(this.chkHetHan);
            this.tabPage5.Controls.Add(this.btnTaoPhieuKK);
            this.tabPage5.Controls.Add(this.cboNhomThuoc);
            this.tabPage5.Controls.Add(this.txtTenThuoc);
            this.tabPage5.Controls.Add(this.label1);
            this.tabPage5.Controls.Add(this.dgvThuoc);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1117, 500);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Kiểm kê kho";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(341, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 25);
            this.button2.TabIndex = 7;
            this.button2.Text = "Tìm ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nhóm thuốc";
            // 
            // chkHetHan
            // 
            this.chkHetHan.AutoSize = true;
            this.chkHetHan.Location = new System.Drawing.Point(117, 70);
            this.chkHetHan.Name = "chkHetHan";
            this.chkHetHan.Size = new System.Drawing.Size(154, 20);
            this.chkHetHan.TabIndex = 5;
            this.chkHetHan.Text = "Hiển thị thuốc hết hạn";
            this.chkHetHan.UseVisualStyleBackColor = true;
            // 
            // btnTaoPhieuKK
            // 
            this.btnTaoPhieuKK.Location = new System.Drawing.Point(502, 13);
            this.btnTaoPhieuKK.Name = "btnTaoPhieuKK";
            this.btnTaoPhieuKK.Size = new System.Drawing.Size(137, 76);
            this.btnTaoPhieuKK.TabIndex = 4;
            this.btnTaoPhieuKK.Text = "Tạo phiếu kiểm kê";
            this.btnTaoPhieuKK.UseVisualStyleBackColor = true;
            this.btnTaoPhieuKK.Click += new System.EventHandler(this.btnTaoPhieuKK_Click);
            // 
            // cboNhomThuoc
            // 
            this.cboNhomThuoc.FormattingEnabled = true;
            this.cboNhomThuoc.Items.AddRange(new object[] {
            ""});
            this.cboNhomThuoc.Location = new System.Drawing.Point(117, 39);
            this.cboNhomThuoc.Name = "cboNhomThuoc";
            this.cboNhomThuoc.Size = new System.Drawing.Size(358, 24);
            this.cboNhomThuoc.TabIndex = 3;
            // 
            // txtTenThuoc
            // 
            this.txtTenThuoc.Location = new System.Drawing.Point(117, 10);
            this.txtTenThuoc.Name = "txtTenThuoc";
            this.txtTenThuoc.Size = new System.Drawing.Size(358, 22);
            this.txtTenThuoc.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên thuốc";
            // 
            // dgvThuoc
            // 
            this.dgvThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuoc.Location = new System.Drawing.Point(6, 98);
            this.dgvThuoc.Name = "dgvThuoc";
            this.dgvThuoc.RowHeadersWidth = 51;
            this.dgvThuoc.RowTemplate.Height = 24;
            this.dgvThuoc.Size = new System.Drawing.Size(1100, 379);
            this.dgvThuoc.TabIndex = 0;
            // 
            // frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 529);
            this.Controls.Add(this.tabControl1);
            this.IsMdiContainer = true;
            this.Name = "frm_Home";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_Home_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.CheckBox chkHetHan;
        private System.Windows.Forms.Button btnTaoPhieuKK;
        private System.Windows.Forms.ComboBox cboNhomThuoc;
        private System.Windows.Forms.TextBox txtTenThuoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvThuoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}

