using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLBSX_DAL_WS.SubInfo
{
    public class CalculatorProxy : ICalculator
    {
        private Calculator _calculator = new Calculator();
        public double Eval(double a, double b, double c)
        {
            return _calculator.Eval(a, b, c);
        }
    }
}