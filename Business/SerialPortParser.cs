using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class SerialPortParser
    {
        public int ParsePort(string port)
        {
            if (!port.StartsWith("COM"))
            {
                throw new FormatException("Port is not a correct format.");
            }
            else
            {
                const int lastIndexPrefix = 3;
                string portNumber = port.Substring(lastIndexPrefix);
                return int.Parse(portNumber);
            }
        }
    }
}
