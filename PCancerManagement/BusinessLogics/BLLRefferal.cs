using DataObjects;
using PCancerDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogics
{
    public class BLLRefferal
    {
    
        /// <summary>
        /// Method to Insert Patient Refferal
        /// </summary>
        /// <param name="refferal"></param>
    
        public static void Insert(Refferal refferal)
        {
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@referreal_id", SqlDbType.NVarChar, 15);
            param[0].Direction = ParameterDirection.Output;
            param[1] = new SqlParameter("@reffered_by_name", refferal.Reffered_by);
            param[2] = new SqlParameter("@details", refferal.Details);
            

            try
            {
               refferal.Refferal_id = DBHelper.ExecuteReturnIDStoredProcedure("insert_refferal", param);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}
