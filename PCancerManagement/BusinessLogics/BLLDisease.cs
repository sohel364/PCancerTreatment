using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataObjects;
using PCancerDataAccess;
using System.Data;

namespace BusinessLogics
{
    public class BLLDisease
    {
        DBHelper dbHelper = null;
        //select disease_id,disease_name,clinical_description,historical_description,disease_type_id from disease
        public static Disease GetDisease() {
            Disease diseaseObject = new Disease();
            String sql = "select disease_id,disease_name,clinical_description,historical_description,disease_type_id from disease";
            DataSet ds =   DBHelper.ExecuteDataSet(sql);            
            return diseaseObject;
        }
    }
}
