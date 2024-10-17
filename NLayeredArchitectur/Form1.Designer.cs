namespace NLayeredArchitectur
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.TxtId = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.TxtAd = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.TxtSoyad = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.TxtMaas = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.TxtGorev = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.TxtSehir = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.btnEkle = new System.Windows.Forms.Button();
			this.btnSil = new System.Windows.Forms.Button();
			this.btnguncelle = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(-1, 248);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(843, 247);
			this.dataGridView1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(69, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "ID:";
			// 
			// TxtId
			// 
			this.TxtId.Location = new System.Drawing.Point(114, 18);
			this.TxtId.Name = "TxtId";
			this.TxtId.Size = new System.Drawing.Size(230, 30);
			this.TxtId.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(74, 150);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(129, 42);
			this.button1.TabIndex = 3;
			this.button1.Text = "LİSTELE";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// TxtAd
			// 
			this.TxtAd.Location = new System.Drawing.Point(114, 59);
			this.TxtAd.Name = "TxtAd";
			this.TxtAd.Size = new System.Drawing.Size(230, 30);
			this.TxtAd.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(60, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 25);
			this.label2.TabIndex = 4;
			this.label2.Text = "AD:";
			// 
			// TxtSoyad
			// 
			this.TxtSoyad.Location = new System.Drawing.Point(114, 100);
			this.TxtSoyad.Name = "TxtSoyad";
			this.TxtSoyad.Size = new System.Drawing.Size(230, 30);
			this.TxtSoyad.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(17, 110);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 25);
			this.label3.TabIndex = 6;
			this.label3.Text = "SOYAD:";
			// 
			// TxtMaas
			// 
			this.TxtMaas.Location = new System.Drawing.Point(500, 20);
			this.TxtMaas.Name = "TxtMaas";
			this.TxtMaas.Size = new System.Drawing.Size(230, 30);
			this.TxtMaas.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(419, 18);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(77, 25);
			this.label4.TabIndex = 8;
			this.label4.Text = "MAAŞ:";
			// 
			// TxtGorev
			// 
			this.TxtGorev.Location = new System.Drawing.Point(500, 66);
			this.TxtGorev.Name = "TxtGorev";
			this.TxtGorev.Size = new System.Drawing.Size(230, 30);
			this.TxtGorev.TabIndex = 11;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(407, 66);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(89, 25);
			this.label5.TabIndex = 10;
			this.label5.Text = "GÖREV:";
			// 
			// TxtSehir
			// 
			this.TxtSehir.Location = new System.Drawing.Point(500, 105);
			this.TxtSehir.Name = "TxtSehir";
			this.TxtSehir.Size = new System.Drawing.Size(230, 30);
			this.TxtSehir.TabIndex = 13;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(419, 113);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(77, 25);
			this.label6.TabIndex = 12;
			this.label6.Text = "ŞEHİR:";
			// 
			// btnEkle
			// 
			this.btnEkle.Location = new System.Drawing.Point(248, 150);
			this.btnEkle.Name = "btnEkle";
			this.btnEkle.Size = new System.Drawing.Size(129, 42);
			this.btnEkle.TabIndex = 14;
			this.btnEkle.Text = "EKLE";
			this.btnEkle.UseVisualStyleBackColor = true;
			this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
			// 
			// btnSil
			// 
			this.btnSil.Location = new System.Drawing.Point(412, 150);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(129, 42);
			this.btnSil.TabIndex = 15;
			this.btnSil.Text = "SİL";
			this.btnSil.UseVisualStyleBackColor = true;
			this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
			// 
			// btnguncelle
			// 
			this.btnguncelle.Location = new System.Drawing.Point(571, 150);
			this.btnguncelle.Name = "btnguncelle";
			this.btnguncelle.Size = new System.Drawing.Size(129, 42);
			this.btnguncelle.TabIndex = 16;
			this.btnguncelle.Text = "GÜNCELLE";
			this.btnguncelle.UseVisualStyleBackColor = true;
			this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(838, 496);
			this.Controls.Add(this.btnguncelle);
			this.Controls.Add(this.btnSil);
			this.Controls.Add(this.btnEkle);
			this.Controls.Add(this.TxtSehir);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.TxtGorev);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.TxtMaas);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.TxtSoyad);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.TxtAd);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.TxtId);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TxtId;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox TxtAd;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox TxtSoyad;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox TxtMaas;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox TxtGorev;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox TxtSehir;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnEkle;
		private System.Windows.Forms.Button btnSil;
		private System.Windows.Forms.Button btnguncelle;
	}
}

