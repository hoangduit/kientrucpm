namespace Presentation
{
    partial class F_XoaBienSo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_XoaBienSo));
            this.cbb_BienSo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bnt_Xoa = new System.Windows.Forms.Button();
            this.bnt_Thoat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbb_BienSo
            // 
            this.cbb_BienSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_BienSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_BienSo.FormattingEnabled = true;
            this.cbb_BienSo.Location = new System.Drawing.Point(100, 84);
            this.cbb_BienSo.Name = "cbb_BienSo";
            this.cbb_BienSo.Size = new System.Drawing.Size(159, 21);
            this.cbb_BienSo.TabIndex = 0;            
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Biển Số Xe:";            
            // 
            // bnt_Xoa
            // 
            this.bnt_Xoa.Location = new System.Drawing.Point(92, 7);
            this.bnt_Xoa.Name = "bnt_Xoa";
            this.bnt_Xoa.Size = new System.Drawing.Size(75, 23);
            this.bnt_Xoa.TabIndex = 0;
            this.bnt_Xoa.Text = "Xóa";
            this.bnt_Xoa.UseVisualStyleBackColor = true;
            this.bnt_Xoa.Click += new System.EventHandler(this.bnt_Xoa_Click);
            // 
            // bnt_Thoat
            // 
            this.bnt_Thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bnt_Thoat.Location = new System.Drawing.Point(173, 7);
            this.bnt_Thoat.Name = "bnt_Thoat";
            this.bnt_Thoat.Size = new System.Drawing.Size(75, 23);
            this.bnt_Thoat.TabIndex = 1;
            this.bnt_Thoat.Text = "Thoát";
            this.bnt_Thoat.UseVisualStyleBackColor = true;
            this.bnt_Thoat.Click += new System.EventHandler(this.bnt_Thoat_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bnt_Xoa);
            this.panel1.Controls.Add(this.bnt_Thoat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 37);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(341, 48);
            this.panel2.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 26);
            this.label1.TabIndex = 24;
            this.label1.Text = "XÓA BIỂN SỐ XE";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Blue;
            this.panel3.Location = new System.Drawing.Point(0, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(341, 10);
            this.panel3.TabIndex = 24;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Blue;
            this.panel4.Location = new System.Drawing.Point(0, 137);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(341, 10);
            this.panel4.TabIndex = 25;
            // 
            // F_XoaBienSo
            // 
            this.AcceptButton = this.bnt_Xoa;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bnt_Thoat;
            this.ClientSize = new System.Drawing.Size(341, 183);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbb_BienSo);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "F_XoaBienSo";
            this.Text = "Xóa Biển Số";
            this.Load += new System.EventHandler(this.F_XoaBienSo_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbb_BienSo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bnt_Xoa;
        private System.Windows.Forms.Button bnt_Thoat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}