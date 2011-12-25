using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QLBSX_DAL_WS.Memento;
namespace QLBSX_DAL_WS
{
    public class KichThuocBao
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

        public KichThuocBao()
        {
            _dai = _rong = _cao = 0;
        }
        public KichThuocBao(float dai, float rong, float cao)
        {
            _dai = dai;
            _rong = rong;
            _cao = cao;
        }
        public KichThuocBao(KichThuocBao ktb)
        {
            _dai = ktb.Dai;
            _rong = ktb.Rong;
            _cao = ktb.Cao;
        }

        /// <summary>
        /// Save memento
        /// </summary>
        /// <returns></returns>
        public MementoKTB SaveMemento()
        {
            return new MementoKTB(_dai, _rong, _cao);
        }

        /// <summary>
        /// Restore memento
        /// </summary>
        /// <param name="memento"></param>
        public void RestoreMemento(MementoKTB memento)
        {
            this.Dai = memento.Dai;
            this.Rong = memento.Cao;
            this.Cao = memento.Cao;
        }
    }
}