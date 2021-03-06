using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace coiltech
{
    class sqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-7T6V6AG\\SQLEXPRESS;Initial Catalog=coiltechDB;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
