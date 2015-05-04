using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    class ChemoTherapy
    {
        private string _chemo_id;
        private string _chemo_name;
        private string _chemo_description;

        public string Chemo_id
        {
            get { return _chemo_id; }
            set { _chemo_id = value; }
        }

        public string Chemo_name
        {
            get { return _chemo_name; }
            set { _chemo_name = value; }
        }

        public string Chemo_description
        {
            get { return _chemo_description; }
            set { _chemo_description = value; }
        }

    }
}
