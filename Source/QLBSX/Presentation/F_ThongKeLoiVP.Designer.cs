namespace Presentation
{
    partial class F_ThongKeLoiVP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_ThongKeLoiVP));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Nam = new System.Windows.Forms.TextBox();
            this.tb_Thang = new System.Windows.Forms.TextBox();
            this.btn_ThongKe = new System.Windows.Forms.Button();
            this.dgv_ThongKeLoi = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoiViPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLanViPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TyLe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbelCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bntThoat = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ThongKeTheoNam = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongKeLoi)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.btn_ThongKeTheoNam);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_Nam);
            this.panel1.Controls.Add(this.tb_Thang);
            this.panel1.Controls.Add(this.btn_ThongKe);
            this.panel1.Controls.Add(this.dgv_ThongKeLoi);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbelCount);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.bntThoat);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 528);
            this.panel1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(338, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Năm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tháng";
            // 
            // tb_Nam
            // 
            this.tb_Nam.Location = new System.Drawing.Point(376, 116);
            this.tb_Nam.Name = "tb_Nam";
            this.tb_Nam.Size = new System.Drawing.Size(37, 20);
            this.tb_Nam.TabIndex = 23;
            this.tb_Nam.Text = "2010";
            // 
            // tb_Thang
            // 
            this.tb_Thang.Location = new System.Drawing.Point(299, 116);
            this.tb_Thang.Name = "tb_Thang";
            this.tb_Thang.Size = new System.Drawing.Size(29, 20);
            this.tb_Thang.TabIndex = 22;
            this.tb_Thang.Text = "12";
            // 
            // btn_ThongKe
            // 
            this.btn_ThongKe.Location = new System.Drawing.Point(133, 501);
            this.btn_ThongKe.Name = "btn_ThongKe";
            this.btn_ThongKe.Size = new System.Drawing.Size(119, 23);
            this.btn_ThongKe.TabIndex = 21;
            this.btn_ThongKe.Text = "Thống kê theo tháng";
            this.btn_ThongKe.UseVisualStyleBackColor = true;
            this.btn_ThongKe.Click += new System.EventHandler(this.btn_ThongKe_Click);
            // 
            // dgv_ThongKeLoi
            // 
            this.dgv_ThongKeLoi.AllowUserToAddRows = false;
            this.dgv_ThongKeLoi.AllowUserToDeleteRows = false;
            this.dgv_ThongKeLoi.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ThongKeLoi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ThongKeLoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ThongKeLoi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.LoiViPham,
            this.SoLanViPham,
            this.TyLe});
            this.dgv_ThongKeLoi.Location = new System.Drawing.Point(28, 189);
            this.dgv_ThongKeLoi.Name = "dgv_ThongKeLoi";
            this.dgv_ThongKeLoi.ReadOnly = true;
            this.dgv_ThongKeLoi.RowHeadersVisible = false;
            this.dgv_ThongKeLoi.Size = new System.Drawing.Size(612, 238);
            this.dgv_ThongKeLoi.TabIndex = 20;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 50;
            // 
            // LoiViPham
            // 
            this.LoiViPham.HeaderText = "Lỗi vi phạm";
            this.LoiViPham.Name = "LoiViPham";
            this.LoiViPham.ReadOnly = true;
            this.LoiViPham.Width = 400;
            // 
            // SoLanViPham
            // 
            this.SoLanViPham.HeaderText = "Số lần vi phạm";
            this.SoLanViPham.Name = "SoLanViPham";
            this.SoLanViPham.ReadOnly = true;
            // 
            // TyLe
            // 
            this.TyLe.HeaderText = "Tỷ lệ";
            this.TyLe.Name = "TyLe";
            this.TyLe.ReadOnly = true;
            this.TyLe.Width = 60;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/mm/yyyy (hh:mm:ss)";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(399, 446);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 449);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ngày, tháng, giờ thống kê:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 449);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "(lỗi)";
            // 
            // lbelCount
            // 
            this.lbelCount.AutoSize = true;
            this.lbelCount.Location = new System.Drawing.Point(120, 449);
            this.lbelCount.Name = "lbelCount";
            this.lbelCount.Size = new System.Drawing.Size(34, 13);
            this.lbelCount.TabIndex = 12;
            this.lbelCount.Text = "         ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 449);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tổng:";
            // 
            // bntThoat
            // 
            this.bntThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bntThoat.Location = new System.Drawing.Point(472, 501);
            this.bntThoat.Name = "bntThoat";
            this.bntThoat.Size = new System.Drawing.Size(63, 23);
            this.bntThoat.TabIndex = 2;
            this.bntThoat.Text = "Thoát";
            this.bntThoat.UseVisualStyleBackColor = true;
            this.bntThoat.Click += new System.EventHandler(this.bntThoat_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.panel13);
            this.panel2.Location = new System.Drawing.Point(0, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(670, 26);
            this.panel2.TabIndex = 1;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.Blue;
            this.panel13.Location = new System.Drawing.Point(0, -1);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(669, 10);
            this.panel13.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ XE VI PHẠM GIAO THÔNG";
            // 
            // btn_ThongKeTheoNam
            // 
            this.btn_ThongKeTheoNam.Location = new System.Drawing.Point(302, 501);
            this.btn_ThongKeTheoNam.Name = "btn_ThongKeTheoNam";
            this.btn_ThongKeTheoNam.Size = new System.Drawing.Size(114, 23);
            this.btn_ThongKeTheoNam.TabIndex = 26;
            this.btn_ThongKeTheoNam.Text = "Thống kê theo năm";
            this.btn_ThongKeTheoNam.UseVisualStyleBackColor = true;
            this.btn_ThongKeTheoNam.Click += new System.EventHandler(this.btn_ThongKeTheoNam_Click);
            // 
            // F_ThongKeLoiVP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bntThoat;
            this.ClientSize = new System.Drawing.Size(669, 528);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "F_ThongKeLoiVP";
            this.Text = "Thống Kê Lỗi";
            this.Load += new System.EventHandler(this.F_ThongKeLoiVP_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongKeLoi)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbelCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bntThoat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button btn_ThongKe;
        private System.Windows.Forms.DataGridView dgv_ThongKeLoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoiViPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLanViPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn TyLe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Nam;
        private System.Windows.Forms.TextBox tb_Thang;
        private System.Windows.Forms.Button btn_ThongKeTheoNam;
    }
}