using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLBSX_DAL_WS.Memento
{
    public class MemoryKTB
    {
        private MementoKTB _memento;

        public MementoKTB Memento
        {
            get { return _memento; }
            set { _memento = value; }
        }
    }
}