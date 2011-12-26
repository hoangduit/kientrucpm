using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLBSX_DAL_WS.SubInfo
{
    public class KichThuocBaoTong : KichThuocBao
    {
        public override void Display()
        {
            base.Display();
            Calculator c = new Calculator();
            double sum = c.Eval(_dai, _rong, _cao);
            Console.WriteLine("\nTong kich thuoc: {0} ------ ", sum);
        }
    }
}