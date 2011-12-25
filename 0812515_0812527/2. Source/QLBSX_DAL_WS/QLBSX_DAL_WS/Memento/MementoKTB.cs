using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLBSX_DAL_WS.Memento
{
    public class MementoKTB
    {
        private float _dai;
        private float _rong;
        private float _cao;

        public float Dai
        {
            get { return _dai; }
            set { _dai = value; }
        }
        public float Rong
        {
            get { return _rong; }
            set { _rong = value; }
        }
        public float Cao
        {
            get { return _cao; }
            set { _cao = value; }
        }

        public MementoKTB(float dai, float rong, float cao)
        {
            this._dai = dai;
            this._rong = rong;
            this._cao = cao;
        }
    }
}