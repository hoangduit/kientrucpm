using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using DTO;
using DAO;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Utils;

namespace District4_SearchService
{
    public partial class frmTimKiem : Form
    {
        public Form parent = null;
        private bool arrow_down = true;

       
        public frmTimKiem()
        {
            InitializeComponent();
            SetLocation();
        }

        private void LB_CapNhatDuLieu_MouseEnter(object sender, EventArgs e)
        {
            Panel_CapNhatDuLieu_MouseEnter(sender, e);
        }

        private void LB_CapNhatDuLieu_MouseLeave(object sender, EventArgs e)
        {
            Panel_CapNhatDuLieu_MouseLeave(sender, e);
        }

        private void Panel_CapNhatDuLieu_MouseEnter(object sender, EventArgs e)
        {
            Panel_CapNhatDuLieu.BackgroundImage = District4_SearchService.Properties.Resources.staticbutton2_hover;
        }

        private void Panel_CapNhatDuLieu_MouseLeave(object sender, EventArgs e)
        {
            Panel_CapNhatDuLieu.BackgroundImage = District4_SearchService.Properties.Resources.staticbutton2;
        }

        private void PB_CapNhatDuLieu_MouseEnter(object sender, EventArgs e)
        {
            Panel_CapNhatDuLieu_MouseEnter(sender, e);
        }

        private void PB_CapNhatDuLieu_MouseLeave(object sender, EventArgs e)
        {
            Panel_CapNhatDuLieu_MouseLeave(sender, e);
        }

        private int maDichVuMacDinh = 0;
        public int MaDichVuMacDinh
        {
            get { return maDichVuMacDinh; }
            set { maDichVuMacDinh = value; }
        }

        private void InitCBDichVu()
        {
            List<DichVuDTO> dichVus = DichVuDAO.layDSDichVu();
            dichVus.Add(new DichVuDTO { MaDichVu = 0, TenDichVu = "Tất cả các dịch vụ" });
            CB_DichVu.DataSource = dichVus;
            CB_DichVu.DisplayMember = "TenDichVu";
            CB_DichVu.ValueMember = "MaDichVu";
            CB_DichVu.SelectedValue = maDichVuMacDinh;
        }

        private void Form_TimKiem_Load(object sender, EventArgs e)
        {
            UtilSearchServices.LoadToolTip();
            UtilSearchServices.SetToolTip(this.TB_Input);


            //TB_Input.AutoSize = false;
            //TB_Input.Height = 28;
            //DGV_KetQua.Font = new System.Drawing.Font("Calibri", 9, FontStyle.Bold);
            InitCBDichVu();

            //for (int y = 0; y < DGV_KetQua.Rows[0].Cells.Count; y++)
            //{
            //    DGV_KetQua.Rows[0].Cells[y].Style.BackColor =
            //    System.Drawing.Color.Transparent;
            //}
        }

        private void Panel_TimKiem_MouseEnter(object sender, EventArgs e)
        {
            //Panel_TimKiem.BackgroundImage = District4_SearchService.Properties.Resources.staticbutton4_hover;
        }

        private void Panel_TimKiem_MouseLeave(object sender, EventArgs e)
        {
            Panel_TimKiem.BackgroundImage = District4_SearchService.Properties.Resources.staticbutton4;
        }

        private void PB_TimKiem_MouseEnter(object sender, EventArgs e)
        {
            Panel_TimKiem_MouseEnter(sender, e);
        }

        private void PB_TimKiem_MouseLeave(object sender, EventArgs e)
        {
            Panel_TimKiem_MouseLeave(sender, e);
        }

        private void Form_TimKiem_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.parent.Location = this.Location;
            //this.parent.Visible = true;
            this.parent.Close(); 
        }

        private void Panel_TimKiem_Click(object sender, EventArgs e)
        {
            this.parent.Location = this.Location;
            this.Dispose();
            this.parent.Visible = true;
        }

        private void Button_Tim_MouseEnter(object sender, EventArgs e)
        {
            Panel_Tim.BackgroundImage = District4_SearchService.Properties.Resources.staticbutton6_hover;
        }

        private void Button_Tim_MouseLeave(object sender, EventArgs e)
        {
            Panel_Tim.BackgroundImage = District4_SearchService.Properties.Resources.staticbutton6;
        }

        private void Button_QuayLai_MouseEnter(object sender, EventArgs e)
        {
            Panel_QuayLai.BackgroundImage = District4_SearchService.Properties.Resources.staticbutton6_hover;
        }

        private void Button_QuayLai_MouseLeave(object sender, EventArgs e)
        {
            Panel_QuayLai.BackgroundImage = District4_SearchService.Properties.Resources.staticbutton6;
        }

        private void Button_InKetQua_MouseEnter(object sender, EventArgs e)
        {
            Panel_InKetQua.BackgroundImage = District4_SearchService.Properties.Resources.staticbutton6_hover;
        }

        private void Button_InKetQua_MouseLeave(object sender, EventArgs e)
        {
            Panel_InKetQua.BackgroundImage = District4_SearchService.Properties.Resources.staticbutton6;
        }

        private void Button_GoogleMap_MouseEnter(object sender, EventArgs e)
        {
            Panel_GoogleMap.BackgroundImage = District4_SearchService.Properties.Resources.staticbutton6_hover;
        }

        private void Button_GoogleMap_MouseLeave(object sender, EventArgs e)
        {
            Panel_GoogleMap.BackgroundImage = District4_SearchService.Properties.Resources.staticbutton6;
        }

        private void PB_QuayLai_Click(object sender, EventArgs e)
        {
            Panel_TimKiem_Click(sender, e);
        }

        private void ShowPopup(Panel popup)
        {
            int step = 3;
            Size old = popup.Size;
            popup.Size = new Size(old.Width, 0);

            while (popup.Size.Height < old.Height)
            {
                popup.Size = new Size(old.Width, popup.Size.Height + step);
                popup.Refresh();
            }

            popup.Size = old;
        }

        private void HidePopup(Panel popup)
        {
            int step = 3;
            Size old = popup.Size;

            while (popup.Size.Height > 0)
            {
                popup.Size = new Size(old.Width, popup.Size.Height - step);
                popup.Refresh();
            }

            popup.Size = old;
        }
        private void SetLocation()
        {
            int x = (int)(this.Width * (.25 + .03));
            int j = (this.Height - 40) / 7;
            int y2 = j * 3;
            Point topLeftTinhTrang = new Point();
            topLeftTinhTrang.X = x;
            topLeftTinhTrang.Y = 40;
            pnTinhTrangDuLieu.Location = topLeftTinhTrang;
            pnTinhTrangDuLieu.Height = j - 5;

            Point topLeftDSDichVu = new Point();
            topLeftDSDichVu.X = x;
            topLeftDSDichVu.Y = j + 55;
            pnNoiDung.Location = topLeftDSDichVu;
            pnNoiDung.Height = j * 5;

            pnNoiDung.Width = (int)(x * (3 - .5));
            pnTinhTrangDuLieu.Width = pnNoiDung.Width;
        }
        private void AddItems(Panel popup, List<string> items)
        {
            Font myFont = new Font("Calibri", 9, FontStyle.Bold);
            String plaintext = "";
            List<Label> myLabels = new List<Label>();
            Point hook = new Point(popup.Location.X + popup.Width, popup.Location.Y);
            Point curLocation = new Point();

            for (int i = 0; i < items.Count; i++)
            {
                plaintext += items[i] + "\n\n";

                Label myLabel = new Label();

                myLabel.Text = items[i];
                myLabel.Visible = true;
                myLabel.Font = myFont;
            }

            popup.Size = TextRenderer.MeasureText(plaintext, myFont);
            popup.Location = new Point(hook.X - popup.Width, hook.Y);

            foreach (Label myLabel in myLabels)
            {
                myLabel.Location = curLocation;
                popup.Controls.Add(myLabel);

                curLocation = new Point(curLocation.X + popup.Size.Height / myLabels.Count, curLocation.Y);
            }
        }

        private void PB_Arrow_Click(object sender, EventArgs e)
        {
            if (arrow_down)
            {
                PB_Arrow.BackgroundImage = District4_SearchService.Properties.Resources.arrow_up;
                arrow_down = false;

                List<string> items = new List<string>();

                items.Add("Tìm kiếm theo hướng khác 1 abcdefghi");
                items.Add("Tìm kiếm theo hướng khác 2 abc");
                items.Add("Tìm kiếm theo hướng khác 3 a");
                items.Add("Tìm kiếm theo hướng khác 4 abcdefghijklmn");

                AddItems(Panel_Popup_HuongTimKhac, items);
                Panel_Popup_HuongTimKhac.Visible = true;
                ShowPopup(Panel_Popup_HuongTimKhac);
            }
            else
            {
                PB_Arrow.BackgroundImage = District4_SearchService.Properties.Resources.arrow_down;
                arrow_down = true;

                HidePopup(Panel_Popup_HuongTimKhac);
                Panel_Popup_HuongTimKhac.Visible = false;
            }
        }

        private void PB_Tim_Click(object sender, EventArgs e)
        {
            //Kiểm tra đầu vào
            if (TB_Input.Text.Trim().CompareTo("") == 0)
            {
                MessageBox.Show("Vui lòng nhập nội dung tìm kiếm!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Chuan hóa chuỗi
            string strInput = ChuanHoaChuoi(TB_Input.Text);

            //Tạo danh sách các từ
            List<string> dsTu = TaoDanhSachTu(strInput);

            //Tạo danh sách các cụm từ
            List<string> dsCumTu = TaoDanhSachCumTu(dsTu);

            //Tạo tham số cho hàm TimKiemDiaDiem
            int maDichVu, maTenDiaDiem, maDuong, maPhuong, maQuanHuyen, maTinhThanh;
            maDichVu = maTenDiaDiem = maDuong = maPhuong = maQuanHuyen = maTinhThanh = 0;
            string soNha = "";
            if ((DichVuDTO)CB_DichVu.SelectedItem != null)
                maDichVu = ((DichVuDTO)CB_DichVu.SelectedItem).MaDichVu;
            maDuong = TuKhoaDuongDAO.TimDuong(dsCumTu);

            foreach(string word in dsTu)
            {
                if (KiemTraCoChuaSo(word) == true)
                {
                    soNha = word.ToUpper();
                    break;
                }
            }
            //......v..v..........
            //...Viet thêm các hàm để xác định các tham số còn lại như maTenDiaDiem, maDuong.....//

            //Tim kiếm
            List<DiaDiemDTO> diaDiems = new List<DiaDiemDTO>();
            diaDiems = DiaDiemDAO.TimKiemDiaDiem(maDichVu, maTenDiaDiem, soNha, maDuong, maPhuong, maQuanHuyen, maTinhThanh);
            DGV_KetQua.Rows.Clear();
            if (diaDiems != null)
            {
                if (diaDiems.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy dữ liệu! Vui lòng cập nhật dữ liệu mới nhất cho chương trình. Hoặc kiểm tra lại nội dung bạn đã nhập đã đúng hay chưa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                foreach (DiaDiemDTO diaDiem in diaDiems)
                {
                    DGV_KetQua.Rows.Add(diaDiem.TenDichVu, diaDiem.TenDiaDiem, diaDiem.SoNha, diaDiem.TenDuong, diaDiem.TenPhuong, diaDiem.TenQuanHuyen, diaDiem.KinhDo, diaDiem.ViDo, diaDiem.GhiChu);
                    DGV_KetQua.Rows[DGV_KetQua.RowCount - 1].Tag = diaDiem;
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy dữ liệu! Vui lòng cập nhật dữ liệu mới nhất cho chương trình. Hoặc kiểm tra lại nội dung bạn đã nhập đã đúng hay chưa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
      
        private void DGV_KetQua_DoubleClick(object sender, EventArgs e)
        {
            ServiceDetail frm = new ServiceDetail();

            if (DGV_KetQua.CurrentRow != null)
                if (DGV_KetQua.CurrentRow.Tag != null)
                {
                    DiaDiemDTO diaDiemDto = (DiaDiemDTO) DGV_KetQua.CurrentRow.Tag;
                    frm.DiaDiemDto = diaDiemDto;
                }
            if(frm.DiaDiemDto != null)
            {
                frm.Visible = true;
                frm.Location = new Point(this.Location.X+ 100,this.Location.Y+70);
                frm.Activate();
                frm.Focus();
            }
           
        }
     

        private void DGV_KetQua_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void TB_Input_MouseEnter(object sender, EventArgs e)
        {
            UtilSearchServices.RemoveToolTip();
            UtilSearchServices.LoadToolTip();
            UtilSearchServices.SetToolTip(this.TB_Input);
        }

        // Begin edit by Dũng-----------------
        private string ChuanHoaChuoi(string strInput)
        {
            string strResult = strInput.Trim();
            for (int i = 1; i < strResult.Length - 1; i++)
            {
                if (strResult[i].CompareTo(' ') == 0 && strResult[i + 1].CompareTo(' ') == 0)
                {
                    strResult = strResult.Remove(i, 1);
                    i--;
                }
            }

            strResult = ConvertToUnSign(strResult);
            strResult = strResult.ToLower();

            return strResult;
        }

        //Chưa xét đến trường hợp chuỗi có các kí tự đặc biệt như '!', ',', '.' .v.v.
        private List<string> TaoDanhSachTu(string strInput)
        {
            List<string> dsTu = new List<string>();

            int indexBegin = 0;
            for (int i = 1; i <= strInput.Length; i++)
            {
                if ((i < strInput.Length && strInput[i].CompareTo(' ') == 0) || i == strInput.Length)
                {
                    string word = strInput.Substring(indexBegin, i - indexBegin);
                    dsTu.Add(word);

                    indexBegin = i + 1;
                }
            }

            return dsTu;
        }

        private List<string> TaoDanhSachCumTu(List<string> dsTu)
        {
            List<string> dsCumTu = new List<string>();

            for (int i = 0; i < dsTu.Count; i++)
            {
                dsCumTu.Add(dsTu[i]);
                for (int j = i + 1; j < dsTu.Count; j++)
                {
                    string phrase = string.Concat(dsCumTu[dsCumTu.Count - 1], " ", dsTu[j]);
                    dsCumTu.Add(phrase);
                }
            }

            return dsCumTu;
        }

        private void frmTimKiem_SizeChanged(object sender, EventArgs e)
        {
            SetLocation();
        }

        private bool KiemTraCoChuaSo(string str)
        {
            bool ketQua = false;
            for (int i = 0; i < str.Length; i++)
            {
                try
                {
                    int.Parse(str.Substring(i,1));
                    ketQua = true;
                    break;
                }
                catch { }
            }

            return ketQua;
        }

        //Co tham khao code tren mang
        private string ConvertToUnSign(string text)
        {
            for (int i = 33; i < 48; i++)
            {
                text = text.Replace(((char)i).ToString(), "");
            }

            for (int i = 58; i < 65; i++)
            {
                text = text.Replace(((char)i).ToString(), "");
            }

            for (int i = 91; i < 97; i++)
            {
                text = text.Replace(((char)i).ToString(), "");
            }

            for (int i = 123; i < 127; i++)
            {
                text = text.Replace(((char)i).ToString(), "");
            }

            Regex regex = new Regex(@"\p{IsCombiningDiacriticalMarks}+");

            string strFormD = text.Normalize(System.Text.NormalizationForm.FormD);

            return regex.Replace(strFormD, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }
        // End edit by Dũng-----------------
    }
}
