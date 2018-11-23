using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManage.DAL
{
    public class ConnectionStringBuilder
    {
        public SqlConnection GetConnection()
        {
            return new SqlConnection("Server=mssql.fhict.local;Database=dbi387022;User Id=dbi387022;Password=wachtwoord");
        }
    }
}
