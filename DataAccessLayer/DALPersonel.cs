﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;


namespace DataAccessLayer
{
	public class DALPersonel
	{
		public static List<EntityPersonel> PersonelListesi()
		//bu metodun türü entity katmanındaki sınıf olur(EntityPersonel).Ancak entity katmanını using directive tanımlamamız
		// gerekir.bunun için öncelikle dataccesslayer katmanının içerisine referans olarak entityLayerı eklememiz gerekir.
		{
			List<EntityPersonel> degerler = new List<EntityPersonel>();
			SqlCommand komut1 = new SqlCommand("Select * from TBLBILGI", Baglanti.bgl); //TBLBILGI Baglanti sınıfının içeriisinde ki bgl nin içinde


			if (komut1.Connection.State != ConnectionState.Open)
			{
				komut1.Connection.Open();
			}
			SqlDataReader dr = komut1.ExecuteReader();
			while (dr.Read())
			{
				EntityPersonel ent = new EntityPersonel();
				ent.Id = int.Parse(dr["ID"].ToString());
				ent.Ad = dr["AD"].ToString();
				ent.Soyad = dr["SOYAD"].ToString();
				ent.Sehir = dr["SEHİR"].ToString();
				ent.Gorev = dr["GOREV"].ToString();
				ent.Maas = short.Parse(dr["MAAS"].ToString());
				degerler.Add(ent);



			}
			dr.Close();
			return degerler;
		}
		public static int PersonelEkle(EntityPersonel p) //p EntityPersonel sınıfı içeriisndeki propertylere ulaşmayı sağlar
		{
			SqlCommand komut2 = new SqlCommand("insert into TBLBILGI (AD,SOYAD,GOREV,SEHİR,MAAS) " +
												  "VALUES (@P1,@P2,@P3,@P4,@P5)", Baglanti.bgl);

			if (komut2.Connection.State != ConnectionState.Open)
			{
				komut2.Connection.Open();
			}

			komut2.Parameters.AddWithValue("P1", p.Ad);
			komut2.Parameters.AddWithValue("P2", p.Soyad);
			komut2.Parameters.AddWithValue("P3", p.Gorev);
			komut2.Parameters.AddWithValue("P4", p.Sehir);
			komut2.Parameters.AddWithValue("P5", p.Maas);

			return komut2.ExecuteNonQuery();


		}


		public static bool PersonelSil(int p)  //int olursa geriye silinen kayıt sayısı döner,
											   //boolda ise silindi mi silinmedi mi diye kontrolü
											   //dönüşü sağlandı .Voidde kullanılabilirdi
		{
			SqlCommand komut3 = new SqlCommand("delete from TBLBILGI where ID=@P1", Baglanti.bgl);

			if (komut3.Connection.State != ConnectionState.Open)
			{
				komut3.Connection.Open();
			}
			komut3.Parameters.AddWithValue("@P1", p);
			return komut3.ExecuteNonQuery() > 0;
		}

		public static bool PersonelGuncelle(EntityPersonel ent) //birden fazla parametre göndereceğimiz
		{                                                       //için EntityPersonelden ent nesnesi türetildi.

			SqlCommand komut4 = new SqlCommand("Update TBLBILGI Set" +
					   " AD=@P1,SOYAD=@P2,MAAS=@P3,SEHİR=@P4,GOREV=@P5 WHERE ID=@P6", Baglanti.bgl);

			if (komut4.Connection.State != ConnectionState.Open)
			{
				komut4.Connection.Open();
			}
			komut4.Parameters.AddWithValue("@P1", ent.Ad);
			komut4.Parameters.AddWithValue("@P2", ent.Soyad);
			komut4.Parameters.AddWithValue("@P3", ent.Maas);
			komut4.Parameters.AddWithValue("@P4", ent.Sehir);
			komut4.Parameters.AddWithValue("@P5", ent.Gorev);
			komut4.Parameters.AddWithValue("@P6", ent.Id);

			return komut4.ExecuteNonQuery() > 0;
		}
	}
}
