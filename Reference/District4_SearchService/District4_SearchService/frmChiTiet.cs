using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;
using Utils;

namespace District4_SearchService
{
    public partial class ServiceDetail : Form
    {
        private bool mousePressed = false;
        private Point diff = new Point(0, 0);
        private DiaDiemDTO diaDiemDTO;

        public DiaDiemDTO DiaDiemDto
        {
            get { return diaDiemDTO; }
            set { diaDiemDTO = value; }
        }

        public ServiceDetail()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
        }

        private void Form_ChiTiet_Load(object sender, EventArgs e)
        {
            BitmapRegion.CreateControlRegion(this, new Bitmap(Properties.Resources.detail));

            if (diaDiemDTO != null)
            {
                lblDichVu.Text = diaDiemDTO.TenDichVu;
                lblDiaDiem.Text = diaDiemDTO.TenDiaDiem;
                lblDiaChi.Text = diaDiemDTO.SoNha + @" " + diaDiemDTO.TenDuong
                                 + @", " + diaDiemDTO.TenPhuong + @", " + diaDiemDTO.TenQuanHuyen;
                lblMieuTa.Text = diaDiemDTO.GhiChu;
                lblViTri.Text = diaDiemDTO.ViDo + @" - " + diaDiemDTO.KinhDo;
            }
        }

        private void Form_ChiTiet_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mousePressed = true;

                Point p = new Point(e.X, e.Y);
                p = PointToScreen(p);
                diff.X = p.X - DesktopLocation.X;
                diff.Y = p.Y - DesktopLocation.Y;
            }
        }

        private void Form_ChiTiet_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousePressed && (e.Button & MouseButtons.Left) != 0)
            {
                Point p = new Point(e.X, e.Y);
                p = PointToScreen(p);
                p.X -= diff.X;
                p.Y -= diff.Y;
                DesktopLocation = p;
            }  
        }

        private void Form_ChiTiet_MouseUp(object sender, MouseEventArgs e)
        {
            mousePressed = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            Panel_InKetQua.BackgroundImage = District4_SearchService.Properties.Resources.staticbutton6_hover;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            Panel_InKetQua.BackgroundImage = District4_SearchService.Properties.Resources.staticbutton6;
        }
    }
}
