using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    public class Stage_M
    {
        private string stage_m_id;
        private string stage_m_name;
        private string stage_m_desc;
        private string stage_m_disease_id;

        public string Stage_m_id
        {
            get { return stage_m_id; }
            set { stage_m_id = value; }
        }


        public string Stage_m_name
        {
            get { return stage_m_name; }
            set { stage_m_name = value; }
        }


        public string Stage_m_desc
        {
            get { return stage_m_desc; }
            set { stage_m_desc = value; }
        }


        public string Stage_m_disease_id
        {
            get { return stage_m_disease_id; }
            set { stage_m_disease_id = value; }
        }

    }
}
