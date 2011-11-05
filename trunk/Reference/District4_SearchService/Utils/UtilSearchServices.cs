using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Utils
{
    public class UtilSearchServices
    {
        private static ToolTip tooltipSearch;
        private static readonly string SEARCH 
            = "Nhập dịch vụ cần tìm kiếm:[DichVu] [DiaChi]\n Ví dụ: ATM Đông Á Nguyễn Văn Cừ";
        public static void LoadToolTip()
        {
            tooltipSearch = new ToolTip();
            tooltipSearch.Active = true;
            tooltipSearch.ShowAlways = true;
        }
        public static void SetToolTip(Control control)
        {
            tooltipSearch.IsBalloon = true;
            tooltipSearch.ToolTipTitle = "Hướng Dẫn";
            tooltipSearch.ToolTipIcon = ToolTipIcon.Info;
            tooltipSearch.SetToolTip(control, SEARCH);
        }

        public static void SetToolTip(Control control,string message)
        {
            tooltipSearch.IsBalloon = true;
            tooltipSearch.ToolTipIcon = ToolTipIcon.Info;
            tooltipSearch.SetToolTip(control,message );
        }

        public static void RemoveToolTip()
        {
            UtilSearchServices.tooltipSearch.Dispose();
        }
    }
}
