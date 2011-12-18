namespace Presentation
{
    partial class F_ThongKeXe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_ThongKeXe));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ThongKeNam = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_Nam = new System.Windows.Forms.TextBox();
            this.tb_Thang = new System.Windows.Forms.TextBox();
            this.dgv_ThongKeBienSo = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiPhuongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TyLe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel10 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbelConut = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bntThoat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongKeBienSo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_ThongKeNam);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tb_Nam);
            this.panel1.Controls.Add(this.tb_Thang);
            this.panel1.Controls.Add(this.dgv_ThongKeBienSo);
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbelConut);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.bntThoat);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 527);
            this.panel1.TabIndex = 0;
            // 
            // btn_ThongKeNam
            // 
            this.btn_ThongKeNam.Location = new System.Drawing.Point(256, 499);
            this.btn_ThongKeNam.Name = "btn_ThongKeNam";
            this.btn_ThongKeNam.Size = new System.Drawing.Size(113, 23);
            this.btn_ThongKeNam.TabIndex = 37;
            this.btn_ThongKeNam.Text = "Thống kê theo năm";
            this.btn_ThongKeNam.UseVisualStyleBackColor = true;
            this.btn_ThongKeNam.Click += new System.EventHandler(this.btn_ThongKeNam_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(298, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Năm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(215, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Tháng";
            // 
            // tb_Nam
            // 
            this.tb_Nam.Location = new System.Drawing.Point(336, 141);
            this.tb_Nam.Name = "tb_Nam";
            this.tb_Nam.Size = new System.Drawing.Size(37, 20);
            this.tb_Nam.TabIndex = 34;
            this.tb_Nam.Text = "2010";
            // 
            // tb_Thang
            // 
            this.tb_Thang.Location = new System.Drawing.Point(259, 141);
            this.tb_Thang.Name = "tb_Thang";
            this.tb_Thang.Size = new System.Drawing.Size(29, 20);
            this.tb_Thang.TabIndex = 33;
            this.tb_Thang.Text = "11";
            // 
            // dgv_ThongKeBienSo
            // 
            this.dgv_ThongKeBienSo.AllowUserToAddRows = false;
            this.dgv_ThongKeBienSo.AllowUserToDeleteRows = false;
            this.dgv_ThongKeBienSo.AllowUserToOrderColumns = true;
            this.dgv_ThongKeBienSo.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ThongKeBienSo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ThongKeBienSo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ThongKeBienSo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.LoaiPhuongTien,
            this.SoLuong,
            this.TyLe});
            this.dgv_ThongKeBienSo.Location = new System.Drawing.Point(128, 215);
            this.dgv_ThongKeBienSo.Name = "dgv_ThongKeBienSo";
            this.dgv_ThongKeBienSo.ReadOnly = true;
            this.dgv_ThongKeBienSo.RowHeadersVisible = false;
            this.dgv_ThongKeBienSo.Size = new System.Drawing.Size(344, 110);
            this.dgv_ThongKeBienSo.TabIndex = 32;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 50;
            // 
            // LoaiPhuongTien
            // 
            this.LoaiPhuongTien.HeaderText = "Loại phương tiện";
            this.LoaiPhuongTien.Name = "LoaiPhuongTien";
            this.LoaiPhuongTien.ReadOnly = true;
            this.LoaiPhuongTien.Width = 130;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Width = 80;
            // 
            // TyLe
            // 
            this.TyLe.HeaderText = "Tỷ lệ";
            this.TyLe.Name = "TyLe";
            this.TyLe.ReadOnly = true;
            this.TyLe.Width = 80;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Blue;
            this.panel10.Location = new System.Drawing.Point(-2, 487);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(590, 10);
            this.panel10.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/mm/yyyy (hh:mm:ss)";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(359, 444);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 447);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ngày, tháng, giờ thống kê:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 447);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "(biển số)";
            // 
            // lbelConut
            // 
            this.lbelConut.AutoSize = true;
            this.lbelConut.Location = new System.Drawing.Point(72, 447);
            this.lbelConut.Name = "lbelConut";
            this.lbelConut.Size = new System.Drawing.Size(34, 13);
            this.lbelConut.TabIndex = 12;
            this.lbelConut.Text = "         ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 447);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tổng:";
            // 
            // bntThoat
            // 
            this.bntThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bntThoat.Location = new System.Drawing.Point(422, 499);
            this.bntThoat.Name = "bntThoat";
            this.bntThoat.Size = new System.Drawing.Size(75, 23);
            this.bntThoat.TabIndex = 1;
            this.bntThoat.Text = "Thoát";
            this.bntThoat.UseVisualStyleBackColor = true;
            this.bntThoat.Click += new System.EventHandler(this.bntThoat_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 499);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thống kê theo tháng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Location = new System.Drawing.Point(0, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(590, 26);
            this.panel2.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Blue;
            this.panel9.Location = new System.Drawing.Point(1, 1);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(668, 10);
            this.panel9.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ XE";
            // 
            // F_ThongKeXe
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bntThoat;
            this.ClientSize = new System.Drawing.Size(589, 527);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "F_ThongKeXe";
            this.Text = "Thống Kê Xe";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongKeBienSo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bntThoat;
        private System.Windows.Forms.Label lbelConut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_ThongKeBienSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiPhuongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TyLe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_Nam;
        private System.Windows.Forms.TextBox tb_Thang;
        private System.Windows.Forms.Button btn_ThongKeNam;
    }
}