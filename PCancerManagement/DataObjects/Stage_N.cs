using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    public class Stage_N
    {
        private string stage_n_id;
        private string stage_n_name;
        private string stage_n_desc;
        private string stage_n_disease_id;

        public string Stage_n_id
        {
            get { return stage_n_id; }
            set { stage_n_id = value; }
        }


        public string Stage_n_name
        {
            get { return stage_n_name; }
            set { stage_n_name = value; }
        }


        public string Stage_n_desc
        {
            get { return stage_n_desc; }
            set { stage_n_desc = value; }
        }


        public string Stage_n_disease_id
        {
            get { return stage_n_disease_id; }
            set { stage_n_disease_id = value; }
        }

    }
}
