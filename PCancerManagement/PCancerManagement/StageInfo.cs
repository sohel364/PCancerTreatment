using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCancerManagement
{
    class StageInfo
    {
        private string stage_t;
        private string stage_m;
        private string stage_n;

        public string Stage_n
        {
            get { return stage_n; }
            set { stage_n = value; }
        }

        public string Stage_m
        {
            get { return stage_m; }
            set { stage_m = value; }
        }

        public string Stage_t
        {
            get { return stage_t; }
            set { stage_t = value; }
        }
    }
}
