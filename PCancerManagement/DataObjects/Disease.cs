using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    public class Disease
    {
       private string disease_id;
       private string disease_name;
       private string clinical_description;
       private string historical_description;
       private DiseaseType diseaseType;
       
       public string Disease_id
       {
            get { return disease_id; }
            set { disease_id = value; }
       }

       public string Disease_name
       {
           get { return disease_name; }
           set { disease_name = value; }
       }

       public string Clinical_description
       {
           get { return clinical_description; }
           set { clinical_description = value; }
       }

       public string Historical_description
       {
           get { return historical_description; }
           set { historical_description = value; }
       }

       public DiseaseType DsiseaseType
       {
           get { return diseaseType; }
           set { diseaseType = value; }
       }

    }
}
