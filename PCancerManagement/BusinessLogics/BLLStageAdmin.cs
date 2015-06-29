using DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using PCancerDataAccess;

namespace BusinessLogics
{
    public class BLLStageAdmin
    {
        public static void Insert(Stage_M stage_m)
        {
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@stage_m_id", SqlDbType.NVarChar, 15);
            param[0].Direction = ParameterDirection.Output;
            param[1] = new SqlParameter("@stage_m_name", stage_m.Stage_m_name);
            param[2] = new SqlParameter("@stage_m_desc", stage_m.Stage_m_desc);
            param[3] = new SqlParameter("@stage_m_disease_id", stage_m.Stage_m_disease_id);
            param[4] = new SqlParameter("@stage_type", stage_m.Stage_Type);
            

            try
            {
                stage_m.Stage_m_id = DBHelper.ExecuteReturnIDStoredProcedure("insert_stage_m", param);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static void Insert(Stage_N stage_n)
        {
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@stage_n_id", SqlDbType.NVarChar, 15);
            param[0].Direction = ParameterDirection.Output;
            param[1] = new SqlParameter("@stage_n_name", stage_n.Stage_n_name);
            param[2] = new SqlParameter("@stage_n_desc", stage_n.Stage_n_desc);
            param[3] = new SqlParameter("@stage_n_disease_id", stage_n.Stage_n_disease_id);
            param[4] = new SqlParameter("@stage_type", stage_n.Stage_Type);

            try
            {
                stage_n.Stage_n_id = DBHelper.ExecuteReturnIDStoredProcedure("insert_stage_n", param);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static void Insert(Stage_T stage_t)
        {
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@stage_t_id", SqlDbType.NVarChar, 15);
            param[0].Direction = ParameterDirection.Output;
            param[1] = new SqlParameter("@stage_t_name", stage_t.Stage_t_name);
            param[2] = new SqlParameter("@stage_t_desc", stage_t.Stage_t_desc);
            param[3] = new SqlParameter("@stage_t_disease_id", stage_t.Stage_t_disease_id);
            param[4] = new SqlParameter("@stage_type", stage_t.Stage_Type);

            try
            {
                stage_t.Stage_t_id = DBHelper.ExecuteReturnIDStoredProcedure("insert_stage_t", param);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
