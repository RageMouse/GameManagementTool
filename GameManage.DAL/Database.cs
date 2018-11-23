using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManage.DAL
{
    public class Database
    {
        private static ConnectionStringBuilder connectionStringBuilder = new ConnectionStringBuilder();

        public static SqlConnection getConnection()
        {
            return connectionStringBuilder.GetConnection();
        }
    }
}
