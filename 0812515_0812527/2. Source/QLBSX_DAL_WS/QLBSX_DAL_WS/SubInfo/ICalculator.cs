using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLBSX_DAL_WS.SubInfo
{
    public interface ICalculator
    {
        double Eval(double a, double b, double c);
    }
}