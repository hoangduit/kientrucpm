namespace Presentation
{
    partial class F_ThemXuPhat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_ThemXuPhat));
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_TenHanhVi = new System.Windows.Forms.ComboBox();
            this.cbb_BienSo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_NguoiLap = new System.Windows.Forms.TextBox();
            this.tb_TienPhat = new System.Windows.Forms.TextBox();
            this.dtp_ThoiGian = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bntTL = new System.Windows.Forms.Button();
            this.bntThoat = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lỗi Vi Phạm:";
            // 
            // cbb_TenHanhVi
            // 
            this.cbb_TenHanhVi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_TenHanhVi.FormattingEnabled = true;
            this.cbb_TenHanhVi.Location = new System.Drawing.Point(141, 50);
            this.cbb_TenHanhVi.Name = "cbb_TenHanhVi";
            this.cbb_TenHanhVi.Size = new System.Drawing.Size(200, 21);
            this.cbb_TenHanhVi.TabIndex = 0;
            this.cbb_TenHanhVi.MouseHover += new System.EventHandler(this.cbb_TenHanhVi_MouseHover);
            // 
            // cbb_BienSo
            // 
            this.cbb_BienSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_BienSo.FormattingEnabled = true;
            this.cbb_BienSo.Location = new System.Drawing.Point(142, 83);
            this.cbb_BienSo.Name = "cbb_BienSo";
            this.cbb_BienSo.Size = new System.Drawing.Size(133, 21);
            this.cbb_BienSo.TabIndex = 1;
            this.cbb_BienSo.MouseHover += new System.EventHandler(this.cbb_BienSo_MouseHover);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_NguoiLap
            // 
            this.tb_NguoiLap.Location = new System.Drawing.Point(142, 152);
            this.tb_NguoiLap.Name = "tb_NguoiLap";
            this.tb_NguoiLap.Size = new System.Drawing.Size(199, 20);
            this.tb_NguoiLap.TabIndex = 3;
            this.tb_NguoiLap.MouseHover += new System.EventHandler(this.tb_NguoiLap_MouseHover);
            // 
            // tb_TienPhat
            // 
            this.tb_TienPhat.Location = new System.Drawing.Point(142, 186);
            this.tb_TienPhat.Name = "tb_TienPhat";
            this.tb_TienPhat.Size = new System.Drawing.Size(200, 20);
            this.tb_TienPhat.TabIndex = 4;
            this.tb_TienPhat.MouseHover += new System.EventHandler(this.tb_TienPhat_MouseHover);
            // 
            // dtp_ThoiGian
            // 
            this.dtp_ThoiGian.CustomFormat = "dd/MM/yyyy(hh:mm::ss)";
            this.dtp_ThoiGian.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ThoiGian.Location = new System.Drawing.Point(141, 119);
            this.dtp_ThoiGian.Name = "dtp_ThoiGian";
            this.dtp_ThoiGian.Size = new System.Drawing.Size(200, 20);
            this.dtp_ThoiGian.TabIndex = 2;
            this.dtp_ThoiGian.MouseHover += new System.EventHandler(this.dtp_ThoiGian_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Biển Số Vi Phạm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Thời Gian Phạt:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Người Lập Biên Bản:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tiền Phạt:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 39);
            this.panel1.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(133, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 26);
            this.label6.TabIndex = 8;
            this.label6.Text = "XỬ PHẠT XE";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bntTL);
            this.panel2.Controls.Add(this.bntThoat);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 225);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(418, 31);
            this.panel2.TabIndex = 8;
            // 
            // bntTL
            // 
            this.bntTL.Location = new System.Drawing.Point(172, 3);
            this.bntTL.Name = "bntTL";
            this.bntTL.Size = new System.Drawing.Size(75, 23);
            this.bntTL.TabIndex = 2;
            this.bntTL.Text = "Thêm Lỗi";
            this.bntTL.UseVisualStyleBackColor = true;
            this.bntTL.Click += new System.EventHandler(this.bntTL_Click);
            // 
            // bntThoat
            // 
            this.bntThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bntThoat.Location = new System.Drawing.Point(253, 4);
            this.bntThoat.Name = "bntThoat";
            this.bntThoat.Size = new System.Drawing.Size(75, 23);
            this.bntThoat.TabIndex = 1;
            this.bntThoat.Text = "Thoát";
            this.bntThoat.UseVisualStyleBackColor = true;
            this.bntThoat.Click += new System.EventHandler(this.bntThoat_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.StripAmpersands = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Thông Báo";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Blue;
            this.panel4.Location = new System.Drawing.Point(0, 37);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(418, 10);
            this.panel4.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Blue;
            this.panel3.Location = new System.Drawing.Point(2, 215);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(416, 10);
            this.panel3.TabIndex = 10;
            // 
            // F_ThemXuPhat
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bntThoat;
            this.ClientSize = new System.Drawing.Size(418, 256);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtp_ThoiGian);
            this.Controls.Add(this.tb_TienPhat);
            this.Controls.Add(this.tb_NguoiLap);
            this.Controls.Add(this.cbb_BienSo);
            this.Controls.Add(this.cbb_TenHanhVi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "F_ThemXuPhat";
            this.Text = "Xử Phạt Xe";
            this.Load += new System.EventHandler(this.F_ThemChiTietHanhVi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_TenHanhVi;
        private System.Windows.Forms.ComboBox cbb_BienSo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_NguoiLap;
        private System.Windows.Forms.TextBox tb_TienPhat;
        private System.Windows.Forms.DateTimePicker dtp_ThoiGian;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bntThoat;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bntTL;
    }
}