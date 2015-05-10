using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    public class ChemoProtocolName
    {
        private string _chemo_name;
        private string _protocol_name;

        public string Chemo_name
        {
            get { return _chemo_name; }
            set { _chemo_name = value; }
        }

        public string Protocol_name
        {
            get { return _protocol_name; }
            set { _protocol_name = value; }
        }
    }
}
