using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    class Cytology
    {
        private string _cytology_id;
        private string _cytology_description;

        public string Cytology_id
        {
            get { return _cytology_id; }
            set { _cytology_id = value; }
        }

        public string Cytology_description
        {
            get { return _cytology_description; }
            set { _cytology_description = value; }
        }

    }
}
