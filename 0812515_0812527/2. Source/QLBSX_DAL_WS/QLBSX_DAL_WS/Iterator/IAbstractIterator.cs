using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLBSX_DAL_WS.Iterator
{
    public interface IAbstractIterator
    {
        BienSoXe First();
        BienSoXe Next();
        bool IsDone { get; }
        BienSoXe CurrentItem { get; }
    }
}