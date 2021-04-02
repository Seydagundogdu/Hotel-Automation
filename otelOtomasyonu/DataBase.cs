
/* Veri tabanı bağlantı sınıfı */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace otelOtomasyonu
{
    public class DataBase // bu sınıfa her yerden ulaşacağımız için public yaparız
    {
        public SqlConnection baglanti = new SqlConnection(@"Data Source=SEYDA;Initial Catalog=otel;Integrated Security=True;MultipleActiveResultSets=True");
    }
}
