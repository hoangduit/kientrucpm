using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLBSX_DAL_WS.SubInfo
{
    public class Calculator : ICalculator
    {
        public double Eval(double a, double b, double c)
        {
            return a * b * c;
        }
    }
}