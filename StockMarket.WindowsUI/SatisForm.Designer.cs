namespace StockMarket.WindowsUI
{
	partial class SatisForm
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
			this.DataGridViewProduct = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.TxtSearchByProductName = new System.Windows.Forms.TextBox();
			this.DataGridViewBasket = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.TxtProductName = new System.Windows.Forms.TextBox();
			this.TxtProductPrice = new System.Windows.Forms.TextBox();
			this.TxtProductDiscount = new System.Windows.Forms.TextBox();
			this.BtnAddProductToBasket = new System.Windows.Forms.Button();
			this.NupProductCount = new System.Windows.Forms.NumericUpDown();
			this.BtnProductCountZero = new System.Windows.Forms.Button();
			this.RdbVar = new System.Windows.Forms.RadioButton();
			this.RdbYok = new System.Windows.Forms.RadioButton();
			this.label6 = new System.Windows.Forms.Label();
			this.BtnPriceTopay = new System.Windows.Forms.Button();
			this.BtnPayThePrice = new System.Windows.Forms.Button();
			this.BtnProductCancel = new System.Windows.Forms.Button();
			this.BtnCikisYap = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.DataGridViewProduct)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DataGridViewBasket)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NupProductCount)).BeginInit();
			this.SuspendLayout();
			// 
			// DataGridViewProduct
			// 
			this.DataGridViewProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.DataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridViewProduct.Location = new System.Drawing.Point(12, 35);
			this.DataGridViewProduct.Name = "DataGridViewProduct";
			this.DataGridViewProduct.ReadOnly = true;
			this.DataGridViewProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DataGridViewProduct.Size = new System.Drawing.Size(495, 362);
			this.DataGridViewProduct.TabIndex = 0;
			this.DataGridViewProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewProduct_CellClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(8, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(180, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Isme Gore Urun Ara :";
			// 
			// TxtSearchByProductName
			// 
			this.TxtSearchByProductName.Location = new System.Drawing.Point(196, 9);
			this.TxtSearchByProductName.Name = "TxtSearchByProductName";
			this.TxtSearchByProductName.Size = new System.Drawing.Size(117, 20);
			this.TxtSearchByProductName.TabIndex = 2;
			this.TxtSearchByProductName.TextChanged += new System.EventHandler(this.TxtSearchByProductName_TextChanged);
			// 
			// DataGridViewBasket
			// 
			this.DataGridViewBasket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.DataGridViewBasket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridViewBasket.Location = new System.Drawing.Point(513, 35);
			this.DataGridViewBasket.Name = "DataGridViewBasket";
			this.DataGridViewBasket.ReadOnly = true;
			this.DataGridViewBasket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DataGridViewBasket.Size = new System.Drawing.Size(495, 362);
			this.DataGridViewBasket.TabIndex = 3;
			this.DataGridViewBasket.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewBasket_CellClick);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(37, 415);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "Urun Ismi";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(27, 469);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "Urun Fiyati";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(24, 523);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(99, 20);
			this.label4.TabIndex = 6;
			this.label4.Text = "Urun Adedi";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(12, 577);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(111, 20);
			this.label5.TabIndex = 7;
			this.label5.Text = "Urun Indirimi";
			// 
			// TxtProductName
			// 
			this.TxtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.TxtProductName.Location = new System.Drawing.Point(150, 415);
			this.TxtProductName.Name = "TxtProductName";
			this.TxtProductName.ReadOnly = true;
			this.TxtProductName.Size = new System.Drawing.Size(135, 26);
			this.TxtProductName.TabIndex = 1;
			// 
			// TxtProductPrice
			// 
			this.TxtProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.TxtProductPrice.Location = new System.Drawing.Point(150, 469);
			this.TxtProductPrice.Name = "TxtProductPrice";
			this.TxtProductPrice.ReadOnly = true;
			this.TxtProductPrice.Size = new System.Drawing.Size(135, 26);
			this.TxtProductPrice.TabIndex = 2;
			// 
			// TxtProductDiscount
			// 
			this.TxtProductDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.TxtProductDiscount.Location = new System.Drawing.Point(150, 577);
			this.TxtProductDiscount.Name = "TxtProductDiscount";
			this.TxtProductDiscount.Size = new System.Drawing.Size(135, 26);
			this.TxtProductDiscount.TabIndex = 4;
			this.TxtProductDiscount.Text = "0";
			// 
			// BtnAddProductToBasket
			// 
			this.BtnAddProductToBasket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.BtnAddProductToBasket.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnAddProductToBasket.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.BtnAddProductToBasket.Location = new System.Drawing.Point(75, 638);
			this.BtnAddProductToBasket.Name = "BtnAddProductToBasket";
			this.BtnAddProductToBasket.Size = new System.Drawing.Size(210, 43);
			this.BtnAddProductToBasket.TabIndex = 5;
			this.BtnAddProductToBasket.Text = "Sepete Ekle";
			this.BtnAddProductToBasket.UseVisualStyleBackColor = false;
			this.BtnAddProductToBasket.Click += new System.EventHandler(this.BtnAddProductToBasket_Click);
			// 
			// NupProductCount
			// 
			this.NupProductCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.NupProductCount.Location = new System.Drawing.Point(150, 523);
			this.NupProductCount.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
			this.NupProductCount.Name = "NupProductCount";
			this.NupProductCount.Size = new System.Drawing.Size(135, 29);
			this.NupProductCount.TabIndex = 3;
			// 
			// BtnProductCountZero
			// 
			this.BtnProductCountZero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.BtnProductCountZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnProductCountZero.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.BtnProductCountZero.Location = new System.Drawing.Point(303, 523);
			this.BtnProductCountZero.Name = "BtnProductCountZero";
			this.BtnProductCountZero.Size = new System.Drawing.Size(71, 32);
			this.BtnProductCountZero.TabIndex = 8;
			this.BtnProductCountZero.Text = "Sifirla";
			this.BtnProductCountZero.UseVisualStyleBackColor = false;
			this.BtnProductCountZero.Click += new System.EventHandler(this.BtnProductCountZero_Click);
			// 
			// RdbVar
			// 
			this.RdbVar.AutoSize = true;
			this.RdbVar.Location = new System.Drawing.Point(303, 580);
			this.RdbVar.Name = "RdbVar";
			this.RdbVar.Size = new System.Drawing.Size(41, 17);
			this.RdbVar.TabIndex = 9;
			this.RdbVar.TabStop = true;
			this.RdbVar.Text = "Var";
			this.RdbVar.UseVisualStyleBackColor = true;
			this.RdbVar.Click += new System.EventHandler(this.RdbVar_Click);
			// 
			// RdbYok
			// 
			this.RdbYok.AutoSize = true;
			this.RdbYok.Location = new System.Drawing.Point(350, 580);
			this.RdbYok.Name = "RdbYok";
			this.RdbYok.Size = new System.Drawing.Size(44, 17);
			this.RdbYok.TabIndex = 10;
			this.RdbYok.TabStop = true;
			this.RdbYok.Text = "Yok";
			this.RdbYok.UseVisualStyleBackColor = true;
			this.RdbYok.Click += new System.EventHandler(this.RdbYok_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.Location = new System.Drawing.Point(617, 514);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(201, 29);
			this.label6.TabIndex = 12;
			this.label6.Text = "Odenecek Tutar";
			// 
			// BtnPriceTopay
			// 
			this.BtnPriceTopay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.BtnPriceTopay.Enabled = false;
			this.BtnPriceTopay.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnPriceTopay.ForeColor = System.Drawing.Color.Black;
			this.BtnPriceTopay.Location = new System.Drawing.Point(824, 490);
			this.BtnPriceTopay.Name = "BtnPriceTopay";
			this.BtnPriceTopay.Size = new System.Drawing.Size(172, 77);
			this.BtnPriceTopay.TabIndex = 13;
			this.BtnPriceTopay.UseVisualStyleBackColor = false;
			// 
			// BtnPayThePrice
			// 
			this.BtnPayThePrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.BtnPayThePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnPayThePrice.ForeColor = System.Drawing.Color.Black;
			this.BtnPayThePrice.Location = new System.Drawing.Point(786, 592);
			this.BtnPayThePrice.Name = "BtnPayThePrice";
			this.BtnPayThePrice.Size = new System.Drawing.Size(210, 43);
			this.BtnPayThePrice.TabIndex = 14;
			this.BtnPayThePrice.Text = "Odemeyi Yap";
			this.BtnPayThePrice.UseVisualStyleBackColor = false;
			this.BtnPayThePrice.Click += new System.EventHandler(this.BtnPayThePrice_Click);
			// 
			// BtnProductCancel
			// 
			this.BtnProductCancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.BtnProductCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnProductCancel.ForeColor = System.Drawing.Color.Crimson;
			this.BtnProductCancel.Location = new System.Drawing.Point(513, 415);
			this.BtnProductCancel.Name = "BtnProductCancel";
			this.BtnProductCancel.Size = new System.Drawing.Size(233, 41);
			this.BtnProductCancel.TabIndex = 15;
			this.BtnProductCancel.Text = "Secilen Urunu Iptal Et";
			this.BtnProductCancel.UseVisualStyleBackColor = false;
			this.BtnProductCancel.Click += new System.EventHandler(this.BtnProductCancel_Click);
			// 
			// BtnCikisYap
			// 
			this.BtnCikisYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.BtnCikisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnCikisYap.ForeColor = System.Drawing.Color.Snow;
			this.BtnCikisYap.Location = new System.Drawing.Point(870, 723);
			this.BtnCikisYap.Name = "BtnCikisYap";
			this.BtnCikisYap.Size = new System.Drawing.Size(142, 43);
			this.BtnCikisYap.TabIndex = 16;
			this.BtnCikisYap.Text = "CikisYap";
			this.BtnCikisYap.UseVisualStyleBackColor = false;
			this.BtnCikisYap.Click += new System.EventHandler(this.BtnCikisYap_Click);
			// 
			// SatisForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Khaki;
			this.ClientSize = new System.Drawing.Size(1024, 768);
			this.Controls.Add(this.BtnCikisYap);
			this.Controls.Add(this.BtnProductCancel);
			this.Controls.Add(this.BtnPayThePrice);
			this.Controls.Add(this.BtnPriceTopay);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.RdbYok);
			this.Controls.Add(this.RdbVar);
			this.Controls.Add(this.BtnProductCountZero);
			this.Controls.Add(this.NupProductCount);
			this.Controls.Add(this.BtnAddProductToBasket);
			this.Controls.Add(this.TxtProductDiscount);
			this.Controls.Add(this.TxtProductPrice);
			this.Controls.Add(this.TxtProductName);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.DataGridViewBasket);
			this.Controls.Add(this.TxtSearchByProductName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.DataGridViewProduct);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "SatisForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SatisForm";
			this.Load += new System.EventHandler(this.SatisForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.DataGridViewProduct)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DataGridViewBasket)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NupProductCount)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView DataGridViewProduct;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TxtSearchByProductName;
		private System.Windows.Forms.DataGridView DataGridViewBasket;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox TxtProductName;
		private System.Windows.Forms.TextBox TxtProductPrice;
		private System.Windows.Forms.TextBox TxtProductDiscount;
		private System.Windows.Forms.Button BtnAddProductToBasket;
		private System.Windows.Forms.NumericUpDown NupProductCount;
		private System.Windows.Forms.Button BtnProductCountZero;
		private System.Windows.Forms.RadioButton RdbVar;
		private System.Windows.Forms.RadioButton RdbYok;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button BtnPriceTopay;
		private System.Windows.Forms.Button BtnPayThePrice;
		private System.Windows.Forms.Button BtnProductCancel;
		private System.Windows.Forms.Button BtnCikisYap;
	}
}