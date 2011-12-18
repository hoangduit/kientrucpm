using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QLBSX_BUS_WS.QLBSX_DAL_WebService;

namespace QLBSX_BUS_WS
{
    public class DataProviderBUS
    {
        private QLBSX_DAL_WebServiceSoapClient ws = new QLBSX_DAL_WebServiceSoapClient();

        public void Connect()
        {
            ws.Connect();
        }

        public void Disconnect()
        {
            ws.Disconnect();
        }
    }
}