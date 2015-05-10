using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PCancerDataAccess;

namespace BusinessLogics
{
    public class SetDataBaseConnectionString
    {
        public static void SetDataBaseConnection() {
            try
            {
                DBHelper.SetConnectionString();
            }

            catch (Exception ex) {
                throw ex;
            }
        }
    }
}
