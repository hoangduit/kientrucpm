using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Presentation.Delegate
{
    public class DelegateLog
    {        
        public delegate void LogHandler(string message);        
        public event LogHandler Log;
        
        public void Process()
        {
            OnLog("Thoát chương trình. Hẹn gặp lại!");            
        }
        
        protected void OnLog(string message)
        {
            if (Log != null)
            {
                Log(message);
            }
        }
    }
}
