using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLBSX_DAL_WS
{
    public class SoCho
    {
        private int _ngoi;
        private int _dung;
        private int _nam;

        public int Ngoi
        {
            get { return _ngoi; }
            set { _ngoi = value; }
        }
        public int Dung
        {
            get { return _dung; }
            set { _dung = value; }
        }
        public int Nam
        {
            get { return _nam; }
            set { _nam = value; }
        }

        public SoCho()
        {
            _ngoi = _dung = _nam = 0;
        }
        public SoCho(int ngoi, int dung, int nam)
        {
            _ngoi = ngoi;
            _dung = dung;
            _nam = nam;
        }
        public SoCho(SoCho sc)
        {
            _ngoi = sc.Ngoi;
            _dung = sc.Dung;
            _nam = sc.Nam;
        }        
    }
}