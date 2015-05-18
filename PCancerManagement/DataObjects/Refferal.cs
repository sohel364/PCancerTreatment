using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    public class Refferal
    {
        private string _refferal_id;
        private string _details;
        private string _reffered_by;

        public string Refferal_id
        {
            get { return _refferal_id; }
            set { _refferal_id = value; }
        }


        public string Reffered_by
        {
            get { return _reffered_by; }
            set { _reffered_by = value; }
        }


        public string Details
        {
            get { return _details; }
            set { _details = value; }
        }
    }
}
