using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{

    public interface Ilogger
    {

        void Info(string msg);
        void Debug(string msg);
        void ErrorLog(string path, Exception ex);

    }
    public class Logger : Ilogger
    {
        public void Debug(string msg)
        {
            throw new NotImplementedException();
        }

        public void ErrorLog(string msg, Exception ex)
        {
            throw new NotImplementedException();
        }

        public void Info(string msg)
        {
            throw new NotImplementedException();
        }
    }
}
