using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Text;
using System.Threading.Tasks;

namespace ExtTaskLinqWin
{
	[Table(Name = "Tovar")]
	public class Tovar
	{
		[Column(IsPrimaryKey = true, IsDbGenerated = true)]
		public int codtovara { get; set; }
		[Column(Name = "ekzemplar")]
		public string ekz { get; set; }
	}

	internal class Program
	{
		public static string SqlConn = @"Data Source = DESKTOP-R2UPGH3\DR; Initial Catalog = Magazin_Productov_II; Integrated Security = True";

		static void Main(string[] args)
		{
			DataContext db = new DataContext(SqlConn);

			Table<Tovar> tovar = db.GetTable<Tovar>();
			
			foreach(var tv in tovar)
			{
				Console.WriteLine("{0} \t{1}", tv.codtovara, tv.ekz);
			}

			Console.Read();
		}
	}
}
