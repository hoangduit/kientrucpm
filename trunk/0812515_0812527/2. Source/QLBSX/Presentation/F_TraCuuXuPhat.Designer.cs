namespace Presentation
{
    partial class F_TraCuuXuPhat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_TraCuuXuPhat));
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.bntTrCBS = new System.Windows.Forms.Button();
            this.btn_TraCuu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_DanhSachChiTiet = new System.Windows.Forms.DataGridView();
            this.TenHanhVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BienSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NguoiLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbb_BienSo = new System.Windows.Forms.ComboBox();
            this.cbb_TenHanhVi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachChiTiet)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.bntTrCBS);
            this.panel2.Controls.Add(this.btn_TraCuu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 374);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(646, 31);
            this.panel2.TabIndex = 41;
            // 
            // button4
            // 
            this.button4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button4.Location = new System.Drawing.Point(408, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Thoát";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(327, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bntTrCBS
            // 
            this.bntTrCBS.Location = new System.Drawing.Point(244, 3);
            this.bntTrCBS.Name = "bntTrCBS";
            this.bntTrCBS.Size = new System.Drawing.Size(75, 23);
            this.bntTrCBS.TabIndex = 1;
            this.bntTrCBS.Text = "Tra Cứu BS";
            this.bntTrCBS.UseVisualStyleBackColor = true;
            this.bntTrCBS.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_TraCuu
            // 
            this.btn_TraCuu.Location = new System.Drawing.Point(163, 3);
            this.btn_TraCuu.Name = "btn_TraCuu";
            this.btn_TraCuu.Size = new System.Drawing.Size(75, 23);
            this.btn_TraCuu.TabIndex = 0;
            this.btn_TraCuu.Text = "Tra Cứu Lỗi";
            this.btn_TraCuu.UseVisualStyleBackColor = true;
            this.btn_TraCuu.Click += new System.EventHandler(this.btn_TraCuu_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 44);
            this.panel1.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(172, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "TRA CỨU XỬ PHẠT";
            // 
            // dgv_DanhSachChiTiet
            // 
            this.dgv_DanhSachChiTiet.AllowUserToAddRows = false;
            this.dgv_DanhSachChiTiet.AllowUserToDeleteRows = false;
            this.dgv_DanhSachChiTiet.AllowUserToOrderColumns = true;
            this.dgv_DanhSachChiTiet.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_DanhSachChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachChiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenHanhVi,
            this.BienSo,
            this.ThoiGian,
            this.NguoiLap,
            this.TienPhat});
            this.dgv_DanhSachChiTiet.Location = new System.Drawing.Point(66, 152);
            this.dgv_DanhSachChiTiet.Name = "dgv_DanhSachChiTiet";
            this.dgv_DanhSachChiTiet.ReadOnly = true;
            this.dgv_DanhSachChiTiet.RowHeadersVisible = false;
            this.dgv_DanhSachChiTiet.Size = new System.Drawing.Size(504, 161);
            this.dgv_DanhSachChiTiet.TabIndex = 38;
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.cbb_BienSo);
            this.panel3.Controls.Add(this.cbb_TenHanhVi);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(646, 66);
            this.panel3.TabIndex = 44;
            // 
            // cbb_BienSo
            // 
            this.cbb_BienSo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbb_BienSo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbb_BienSo.BackColor = System.Drawing.Color.White;
            this.cbb_BienSo.ForeColor = System.Drawing.Color.Red;
            this.cbb_BienSo.FormattingEnabled = true;
            this.cbb_BienSo.Location = new System.Drawing.Point(284, 36);
            this.cbb_BienSo.Name = "cbb_BienSo";
            this.cbb_BienSo.Size = new System.Drawing.Size(188, 21);
            this.cbb_BienSo.TabIndex = 1;
            // 
            // cbb_TenHanhVi
            // 
            this.cbb_TenHanhVi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbb_TenHanhVi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbb_TenHanhVi.BackColor = System.Drawing.Color.White;
            this.cbb_TenHanhVi.ForeColor = System.Drawing.Color.Red;
            this.cbb_TenHanhVi.FormattingEnabled = true;
            this.cbb_TenHanhVi.Location = new System.Drawing.Point(284, 9);
            this.cbb_TenHanhVi.Name = "cbb_TenHanhVi";
            this.cbb_TenHanhVi.Size = new System.Drawing.Size(188, 21);
            this.cbb_TenHanhVi.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(175, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Biển Số Vi Phạm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(175, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Lỗi Vi Phạm:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Blue;
            this.panel4.Location = new System.Drawing.Point(0, 41);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(647, 10);
            this.panel4.TabIndex = 45;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Blue;
            this.panel5.Location = new System.Drawing.Point(0, 364);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(647, 10);
            this.panel5.TabIndex = 46;
            // 
            // F_TraCuuXuPhat
            // 
            this.AcceptButton = this.btn_TraCuu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button4;
            this.ClientSize = new System.Drawing.Size(646, 405);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_DanhSachChiTiet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "F_TraCuuXuPhat";
            this.Text = "Tra Cứu Xử Phạt";
            this.Load += new System.EventHandler(this.F_TraCuuLoi_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachChiTiet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_TraCuu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_DanhSachChiTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHanhVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn BienSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn NguoiLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienPhat;
        private System.Windows.Forms.Button bntTrCBS;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbb_BienSo;
        private System.Windows.Forms.ComboBox cbb_TenHanhVi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}