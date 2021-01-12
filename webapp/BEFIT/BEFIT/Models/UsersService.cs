using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BEFIT.Models
{
    public class UsersService
    {
        string conn = "Server=app.fit.ba, 1432;Database=BEFIT;Trusted_Connection=false;MultipleActiveResultSets=true;User ID=BEFIT;Password=Mobitel!1";
        public DataTable GetUsersInfo()
        {
            var dt = new DataTable();
            using (SqlConnection sql=new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("BEFIT.proc_Users", sql);
                cmd.CommandType = CommandType.StoredProcedure;
                sql.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                sql.Close();
            }


            return dt;
        }
    }
}
