using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCancerManagement.DataObjects
{
    class Visit
    {
        private string _visit_id;
        private string _visit_date;
        private string _visit_next_date;
        private string _visit_bsa;
        private string _visit_rx_planning;
        private string _visit_refering_physician;
        private string _visit_patient_id;
        private string _visit_rx;
        private string _visit_advice;

        public string Visit_advice
        {
            get { return _visit_advice; }
            set { _visit_advice = value; }
        }

        public string Visit_rx
        {
            get { return _visit_rx; }
            set { _visit_rx = value; }
        }


        public string Visit_patient_id
        {
            get { return _visit_patient_id; }
            set { _visit_patient_id = value; }
        }


        public string Visit_refering_physician
        {
            get { return _visit_refering_physician; }
            set { _visit_refering_physician = value; }
        }


        public string Visit_rx_planning
        {
            get { return _visit_rx_planning; }
            set { _visit_rx_planning = value; }
        }


        public string Visit_bsa
        {
            get { return _visit_bsa; }
            set { _visit_bsa = value; }
        }


        public string Visit_next_date
        {
            get { return _visit_next_date; }
            set { _visit_next_date = value; }
        }


        public string Visit_date
        {
            get { return _visit_date; }
            set { _visit_date = value; }
        }


        public string Visit_id
        {
            get { return _visit_id; }
            set { _visit_id = value; }
        }

    }

}
