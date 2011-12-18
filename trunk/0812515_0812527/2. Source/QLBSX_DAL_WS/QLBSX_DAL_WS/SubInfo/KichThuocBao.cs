using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLBSX_DAL_WS
{
    public class KichThuocBao
    {
        private float _Dai;
        private float _Rong;
        private float _Cao;

        public float Dai
        {
            get { return _Dai; }
            set { _Dai = value; }
        }
        public float Rong
        {
            get { return _Rong; }
            set { _Rong = value; }
        }
        public float Cao
        {
            get { return _Cao; }
            set { _Cao = value; }
        }

        public KichThuocBao()
        {
            _Dai = _Rong = _Cao = 0;
        }
        public KichThuocBao(float dai, float rong, float cao)
        {
            _Dai = dai;
            _Rong = rong;
            _Cao = cao;
        }
        public KichThuocBao(KichThuocBao ktb)
        {
            _Dai = ktb.Dai;
            _Rong = ktb.Rong;
            _Cao = ktb.Cao;
        }        
    }
}