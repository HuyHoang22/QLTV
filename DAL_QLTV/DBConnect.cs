using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLTV
{
    public class DBConnect
    {
        protected SqlConnection _conn = new SqlConnection("Data Source= BOXER\\SQLEXPRESS;Initial Catalog=QLTV;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
    }
}
