using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    public class Stage_T
    {
        private string stage_t_id;
        private string stage_t_name;
        private string stage_t_desc;
        private string stage_t_disease_id;
        private string stage_type;


        public string Stage_t_id
        {
            get { return stage_t_id; }
            set { stage_t_id = value; }
        }


        public string Stage_t_name
        {
            get { return stage_t_name; }
            set { stage_t_name = value; }
        }


        public string Stage_t_desc
        {
            get { return stage_t_desc; }
            set { stage_t_desc = value; }
        }


        public string Stage_t_disease_id
        {
            get { return stage_t_disease_id; }
            set { stage_t_disease_id = value; }
        }

        public string Stage_Type
        {
            get { return stage_type; }
            set { stage_type = value; }
        }
    }
}
