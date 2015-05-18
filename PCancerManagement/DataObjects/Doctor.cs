using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    public class Doctor
    {
        private string _doctor_id;
        private string _doctor_name;
        private string _doctor_details;

        public string Doctor_id
        {
            get { return _doctor_id; }
            set { _doctor_id = value; }
        }

        public string Doctor_name
        {
            get { return _doctor_name; }
            set { _doctor_name = value; }
        }

        public string Doctor_details
        {
            get { return _doctor_details; }
            set { _doctor_details = value; }
        }

        public Doctor() { 

        }
    }
}
