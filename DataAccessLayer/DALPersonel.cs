﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data.SqlClient;

namespace DataAccessLayer
{
	class DALPersonel
	{
		public static List<EntityPersonel> PersonelListesi()
		{
			List<EntityPersonel> degerler = new List<EntityPersonel>();
			SqlCommand komut1 = new SqlCommand("Select * from TBLBILGI", Baglanti.bgl);

			if (komut1.Connection.State != System.Data.ConnectionState.Open)
			{
				komut1.Connection.Open();
			}
			SqlDataReader dr = komut1.ExecuteReader();
			while (dr.Read())
			{
				EntityPersonel ent = new EntityPersonel();
				ent.Id = int.Parse(dr["ID"].ToString());
				ent.Ad = dr["AD"].ToString();
				ent.Ad = dr["SOYAD"].ToString();
				ent.Ad = dr["GOREV"].ToString();
				ent.Maas = short.Parse(dr["MAAS"].ToString());
				degerler.Add(ent);



			}
			dr.Close();
			return degerler;
		}
	}
}
