using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCancerManagement.DataObjects
{
    class Patient
    {
        private string _patient_id;
        private string _fathers_name;
        private string _religion;
        private string _sex;
        private string _age;
        private string _height;
        private string _address;
        private string _contact_no;
        private string _reffered_id;
        private string _dtype;
        private string _disese_id;
        private string _name;
        private string _weight;


        public string Patient_id
        {
            get { return _patient_id; }
            set { _patient_id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Fathers_name
        {
            get { return _fathers_name; }
            set { _fathers_name = value; }
        }
        public string Religion
        {
            get { return _religion; }
            set { _religion = value; }
        }
        public string Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }
        public string Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        public string Contact_no
        {
            get { return _contact_no; }
            set { _contact_no = value; }
        }
        public string Reffered_id
        {
            get { return _reffered_id; }
            set { _reffered_id = value; }
        }
        public string Dtype
        {
            get { return _dtype; }
            set { _dtype = value; }
        }
        public string Height
        {
            get { return _height; }
            set { _height = value; }
        }
        public string Disese_id
        {
            get { return _disese_id; }
            set { _disese_id = value; }
        }
        public string Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
        
    }
}
