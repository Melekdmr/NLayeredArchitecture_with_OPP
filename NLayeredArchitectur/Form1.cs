using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using DataAccessLayer;
using LogicLayer;
namespace NLayeredArchitectur
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			List<EntityPersonel> PerList = LogicPersonel.LLPersonelListesi();
			dataGridView1.DataSource = PerList;

		}

		private void btnEkle_Click(object sender, EventArgs e)
		{
			EntityPersonel ent = new EntityPersonel();
			ent.Ad = TxtAd.Text;
			ent.Soyad = TxtSoyad.Text;
			ent.Gorev = TxtGorev.Text;
			ent.Sehir = TxtSehir.Text;
			ent.Maas = short.Parse(TxtMaas.Text);

			LogicPersonel.LLPersonelEkle(ent);


		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			EntityPersonel ent = new EntityPersonel();
			ent.Id = Convert.ToInt32(TxtId.Text);
			LogicPersonel.LLPersonelSil(ent.Id);
		}

		private void btnguncelle_Click(object sender, EventArgs e)
		{
			EntityPersonel ent = new EntityPersonel();
			ent.Id = int.Parse(TxtId.Text);
			ent.Ad = TxtAd.Text;
			ent.Soyad = TxtSoyad.Text;
			ent.Maas = short.Parse(TxtMaas.Text);
			ent.Gorev = TxtGorev.Text;
			ent.Sehir = TxtSehir.Text;

			LogicPersonel.LLPersonelGuncelle(ent);
		}
	}
}
