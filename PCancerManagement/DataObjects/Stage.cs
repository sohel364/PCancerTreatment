using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    public class Stage
    {
        private string stage_id;
        private string stage_name;
        private string stage_description;
        private string stage_tumor_size;
        private string stage_disease_id;

        public string Stage_id
        {
            get { return stage_id; }
            set { stage_id = value; }
        }


        public string Stage_name
        {
            get { return stage_name; }
            set { stage_name = value; }
        }


        public string Stage_description
        {
            get { return stage_description; }
            set { stage_description = value; }
        }


        public string Stage_tumor_size
        {
            get { return stage_tumor_size; }
            set { stage_tumor_size = value; }
        }


        public string Stage_disease_id
        {
            get { return stage_disease_id; }
            set { stage_disease_id = value; }
        }

    }
}
