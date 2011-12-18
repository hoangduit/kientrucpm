using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLBSX_DAL_WS
{
    public class SoCho
    {
        private int _Ngoi;
        private int _Dung;
        private int _Nam;

        public int Ngoi
        {
            get { return _Ngoi; }
            set { _Ngoi = value; }
        }
        public int Dung
        {
            get { return _Dung; }
            set { _Dung = value; }
        }
        public int Nam
        {
            get { return _Nam; }
            set { _Nam = value; }
        }

        public SoCho()
        {
            _Ngoi = _Dung = _Nam = 0;
        }
        public SoCho(int ngoi, int dung, int nam)
        {
            _Ngoi = ngoi;
            _Dung = dung;
            _Nam = nam;
        }
        public SoCho(SoCho sc)
        {
            _Ngoi = sc.Ngoi;
            _Dung = sc.Dung;
            _Nam = sc.Nam;
        }        
    }
}