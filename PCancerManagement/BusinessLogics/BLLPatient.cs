using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

using DataObjects;
using PCancerDataAccess;

namespace BusinessLogics
{
    public class BLLPatient
    {
        /// <summary>
        /// Method to insert Patient
        /// </summary>
        /// <param name="NewColor">Patient</param>
        public static void Insert(Patient NewPatient)
        {
            SqlParameter[] param = new SqlParameter[13];

            param[0] = new SqlParameter("@patient_id", SqlDbType.NVarChar, 15);
            param[0].Direction = ParameterDirection.Output;
            param[1] = new SqlParameter("@name", NewPatient.Name);
            param[2] = new SqlParameter("@fathers_name", NewPatient.Fathers_name);
            param[3] = new SqlParameter("@religion", NewPatient.Religion);
            param[4] = new SqlParameter("@sex", NewPatient.Sex);
            param[5] = new SqlParameter("@age", NewPatient.Age);
            param[6] = new SqlParameter("@height", NewPatient.Height);
            param[7] = new SqlParameter("@weight", NewPatient.Weight);
            param[8] = new SqlParameter("@address", NewPatient.Address);
            param[9] = new SqlParameter("@contact_no", NewPatient.Contact_no);
            param[10] = new SqlParameter("@reffered_id", NewPatient.Reffered_id);
            param[11] = new SqlParameter("@dtype", NewPatient.Dtype);
            param[12] = new SqlParameter("@disese_id", NewPatient.Disese_id);

            try
            {
                NewPatient.Patient_id = DBHelper.ExecuteReturnIDStoredProcedure("insert_patient", param);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
