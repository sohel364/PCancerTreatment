using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    public class BodySurfaceArea
    {
        private string _body_surface_area_id;
        private string _body_surface_area;
        private string _body_surface_area_patient_id;

        public string Body_surface_area_id
        {
            get { return _body_surface_area_id; }
            set { _body_surface_area_id = value; }
        }

        public string Body_surface_area
        {
            get { return _body_surface_area; }
            set { _body_surface_area = value; }
        }

        public string Body_surface_area_patient_id
        {
            get { return _body_surface_area_patient_id; }
            set { _body_surface_area_patient_id = value; }
        }

    }
}
