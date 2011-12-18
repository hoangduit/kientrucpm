using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Presentation.Delegate
{
    public class FileLogger
    {
        FileStream fileStream;
        StreamWriter streamWriter;
                
        public FileLogger(string filename)
        {
            fileStream = new FileStream(filename, FileMode.Create);
            streamWriter = new StreamWriter(fileStream);
        }

        public void Logger(string s)
        {
            streamWriter.WriteLine(s);
        }

        public void Close()
        {
            streamWriter.Close();
            fileStream.Close();
        }
    }
}