namespace Presentation
{
    partial class F_CapNhatXuPhat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_CapNhatXuPhat));
            this.cbb_BienSo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_TenHanhVi = new System.Windows.Forms.ComboBox();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.btn_BienSo = new System.Windows.Forms.Button();
            this.btn_HanhVi = new System.Windows.Forms.Button();
            this.dgv_DanhSachChiTiet = new System.Windows.Forms.DataGridView();
            this.TenHanhVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BienSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NguoiLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtp_ThoiGian = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bntThoat = new System.Windows.Forms.Button();
            this.cbbNguoiLap = new System.Windows.Forms.ComboBox();
            this.cbbTienPhat = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachChiTiet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbb_BienSo
            // 
            this.cbb_BienSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_BienSo.FormattingEnabled = true;
            this.cbb_BienSo.Location = new System.Drawing.Point(395, 134);
            this.cbb_BienSo.Name = "cbb_BienSo";
            this.cbb_BienSo.Size = new System.Drawing.Size(121, 21);
            this.cbb_BienSo.TabIndex = 4;
            this.cbb_BienSo.MouseHover += new System.EventHandler(this.cbb_BienSo_MouseHover);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tiền Phạt Cập Nhật:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Người Lập Biên Bản:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Thời Gian Cập Nhật:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Biển Số Cập Nhật:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Lỗi Cần Cập Nhật:";
            // 
            // cbb_TenHanhVi
            // 
            this.cbb_TenHanhVi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_TenHanhVi.FormattingEnabled = true;
            this.cbb_TenHanhVi.Location = new System.Drawing.Point(395, 75);
            this.cbb_TenHanhVi.Name = "cbb_TenHanhVi";
            this.cbb_TenHanhVi.Size = new System.Drawing.Size(121, 21);
            this.cbb_TenHanhVi.TabIndex = 3;
            this.cbb_TenHanhVi.MouseHover += new System.EventHandler(this.cbb_TenHanhVi_MouseHover);
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.Location = new System.Drawing.Point(245, 3);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(75, 23);
            this.btn_CapNhat.TabIndex = 0;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.UseVisualStyleBackColor = true;
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // btn_BienSo
            // 
            this.btn_BienSo.Location = new System.Drawing.Point(527, 113);
            this.btn_BienSo.Name = "btn_BienSo";
            this.btn_BienSo.Size = new System.Drawing.Size(119, 60);
            this.btn_BienSo.TabIndex = 6;
            this.btn_BienSo.Text = "Tìm Theo Biển Số Vi Phạm";
            this.btn_BienSo.UseVisualStyleBackColor = true;
            this.btn_BienSo.Click += new System.EventHandler(this.btn_BienSo_Click);
            // 
            // btn_HanhVi
            // 
            this.btn_HanhVi.Location = new System.Drawing.Point(527, 60);
            this.btn_HanhVi.Name = "btn_HanhVi";
            this.btn_HanhVi.Size = new System.Drawing.Size(119, 52);
            this.btn_HanhVi.TabIndex = 5;
            this.btn_HanhVi.Text = "Tìm Theo Lỗi Vi Phạm";
            this.btn_HanhVi.UseVisualStyleBackColor = true;
            this.btn_HanhVi.Click += new System.EventHandler(this.btn_HanhVi_Click);
            // 
            // dgv_DanhSachChiTiet
            // 
            this.dgv_DanhSachChiTiet.AllowUserToAddRows = false;
            this.dgv_DanhSachChiTiet.AllowUserToDeleteRows = false;
            this.dgv_DanhSachChiTiet.AllowUserToOrderColumns = true;
            this.dgv_DanhSachChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachChiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenHanhVi,
            this.BienSo,
            this.ThoiGian,
            this.NguoiLap,
            this.TienPhat});
            this.dgv_DanhSachChiTiet.Location = new System.Drawing.Point(59, 196);
            this.dgv_DanhSachChiTiet.Name = "dgv_DanhSachChiTiet";
            this.dgv_DanhSachChiTiet.ReadOnly = true;
            this.dgv_DanhSachChiTiet.RowHeadersVisible = false;
            this.dgv_DanhSachChiTiet.Size = new System.Drawing.Size(501, 161);
            this.dgv_DanhSachChiTiet.TabIndex = 22;
            this.dgv_DanhSachChiTiet.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachChiTiet_CellEnter);
            // 
            // TenHanhVi
            // 
            this.TenHanhVi.HeaderText = "Lỗi Vi Phạm";
            this.TenHanhVi.Name = "TenHanhVi";
            this.TenHanhVi.ReadOnly = true;
            // 
            // BienSo
            // 
            this.BienSo.HeaderText = "Biển số";
            this.BienSo.Name = "BienSo";
            this.BienSo.ReadOnly = true;
            // 
            // ThoiGian
            // 
            this.ThoiGian.HeaderText = "Thời gian";
            this.ThoiGian.Name = "ThoiGian";
            this.ThoiGian.ReadOnly = true;
            // 
            // NguoiLap
            // 
            this.NguoiLap.HeaderText = "Người lập";
            this.NguoiLap.Name = "NguoiLap";
            this.NguoiLap.ReadOnly = true;
            // 
            // TienPhat
            // 
            this.TienPhat.HeaderText = "Tiền phạt";
            this.TienPhat.Name = "TienPhat";
            this.TienPhat.ReadOnly = true;
            // 
            // dtp_ThoiGian
            // 
            this.dtp_ThoiGian.CustomFormat = "dd/MM/yyyy(hh:mm:ss)";
            this.dtp_ThoiGian.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ThoiGian.Location = new System.Drawing.Point(127, 60);
            this.dtp_ThoiGian.Name = "dtp_ThoiGian";
            this.dtp_ThoiGian.Size = new System.Drawing.Size(149, 20);
            this.dtp_ThoiGian.TabIndex = 0;
            this.dtp_ThoiGian.MouseHover += new System.EventHandler(this.dtp_ThoiGian_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 44);
            this.panel1.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(172, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(303, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "CẬP NHẬT VIỆC XỬ PHẠT";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bntThoat);
            this.panel2.Controls.Add(this.btn_CapNhat);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 376);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(646, 28);
            this.panel2.TabIndex = 7;
            // 
            // bntThoat
            // 
            this.bntThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bntThoat.Location = new System.Drawing.Point(326, 3);
            this.bntThoat.Name = "bntThoat";
            this.bntThoat.Size = new System.Drawing.Size(75, 23);
            this.bntThoat.TabIndex = 1;
            this.bntThoat.Text = "Thoát";
            this.bntThoat.UseVisualStyleBackColor = true;
            this.bntThoat.Click += new System.EventHandler(this.bntThoat_Click);
            // 
            // cbbNguoiLap
            // 
            this.cbbNguoiLap.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbNguoiLap.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbNguoiLap.FormattingEnabled = true;
            this.cbbNguoiLap.Location = new System.Drawing.Point(127, 106);
            this.cbbNguoiLap.Name = "cbbNguoiLap";
            this.cbbNguoiLap.Size = new System.Drawing.Size(149, 21);
            this.cbbNguoiLap.TabIndex = 1;
            this.cbbNguoiLap.MouseHover += new System.EventHandler(this.cbbNguoiLap_MouseHover);
            // 
            // cbbTienPhat
            // 
            this.cbbTienPhat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbTienPhat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbTienPhat.FormattingEnabled = true;
            this.cbbTienPhat.Location = new System.Drawing.Point(126, 148);
            this.cbbTienPhat.Name = "cbbTienPhat";
            this.cbbTienPhat.Size = new System.Drawing.Size(150, 21);
            this.cbbTienPhat.TabIndex = 2;
            this.cbbTienPhat.MouseHover += new System.EventHandler(this.cbbTienPhat_MouseHover);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.StripAmpersands = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Thông Báo";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Blue;
            this.panel3.Location = new System.Drawing.Point(0, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(646, 10);
            this.panel3.TabIndex = 26;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Blue;
            this.panel4.Location = new System.Drawing.Point(0, 365);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(646, 10);
            this.panel4.TabIndex = 27;
            // 
            // F_CapNhatXuPhat
            // 
            this.AcceptButton = this.btn_CapNhat;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bntThoat;
            this.ClientSize = new System.Drawing.Size(646, 404);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.cbbTienPhat);
            this.Controls.Add(this.cbbNguoiLap);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtp_ThoiGian);
            this.Controls.Add(this.dgv_DanhSachChiTiet);
            this.Controls.Add(this.btn_BienSo);
            this.Controls.Add(this.btn_HanhVi);
            this.Controls.Add(this.cbb_BienSo);
            this.Controls.Add(this.cbb_TenHanhVi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "F_CapNhatXuPhat";
            this.Text = "Cập Nhật Xử Phạt";
            this.Load += new System.EventHandler(this.F_CapNhatChiTietHanhVi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachChiTiet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbb_BienSo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_TenHanhVi;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.Button btn_BienSo;
        private System.Windows.Forms.Button btn_HanhVi;
        private System.Windows.Forms.DataGridView dgv_DanhSachChiTiet;
        private System.Windows.Forms.DateTimePicker dtp_ThoiGian;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbbNguoiLap;
        private System.Windows.Forms.ComboBox cbbTienPhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHanhVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn BienSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn NguoiLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienPhat;
        private System.Windows.Forms.Button bntThoat;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}