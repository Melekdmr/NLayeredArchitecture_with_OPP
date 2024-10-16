using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DataAccessLayer
{
	public class Baglanti
	{
		//Bazı durumlarda yeni bir nesne türetmeden kullanmamız gereken komutlar vardır.
		//Bu komutlar statik olarak karşımaıza çıkar.
		public static SqlConnection bgl = new SqlConnection(@"Data 
                                         Source=MELEKDMR\\SQLEXPRESS;Initial 
                                         Catalog=DbPersonel;Integrated Security=True;");

	}
}
