using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    public class DiseaseType
    {
        private string disease_type_id;
        private string disease_type_name;
        private string disease_type_description;

        public string Disease_type_id
        {
            get { return disease_type_id; }
            set { disease_type_id = value; }

        }

        public string Disease_type_name
        {
            get { return disease_type_name; }
            set { disease_type_name = value; }

        }

        public string Disease_type_description
        {
            get { return disease_type_description; }
            set { disease_type_description = value; }

        }
    }
}
