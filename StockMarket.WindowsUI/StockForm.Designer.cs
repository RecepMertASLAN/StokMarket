namespace StockMarket.WindowsUI
{
	partial class StockForm
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
			this.PanelDataGridViewProducts = new System.Windows.Forms.Panel();
			this.DataGridViewProduct = new System.Windows.Forms.DataGridView();
			this.PanelProductOperations = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.BtnProductUpdate = new System.Windows.Forms.Button();
			this.BtnProductAdd = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.CmbCategoryName = new System.Windows.Forms.ComboBox();
			this.CmbSupplierName = new System.Windows.Forms.ComboBox();
			this.TxtUnitsInStock = new System.Windows.Forms.TextBox();
			this.TxtUnitPrice = new System.Windows.Forms.TextBox();
			this.TxtQuantityPerUnit = new System.Windows.Forms.TextBox();
			this.TxtProductName = new System.Windows.Forms.TextBox();
			this.PanelSearch = new System.Windows.Forms.Panel();
			this.CmbSupplierSearch = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.CmbCagetorySearch = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.BtnCikis = new System.Windows.Forms.Button();
			this.PanelDataGridViewProducts.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridViewProduct)).BeginInit();
			this.PanelProductOperations.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.PanelSearch.SuspendLayout();
			this.SuspendLayout();
			// 
			// PanelDataGridViewProducts
			// 
			this.PanelDataGridViewProducts.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.PanelDataGridViewProducts.Controls.Add(this.DataGridViewProduct);
			this.PanelDataGridViewProducts.Location = new System.Drawing.Point(0, 73);
			this.PanelDataGridViewProducts.Name = "PanelDataGridViewProducts";
			this.PanelDataGridViewProducts.Size = new System.Drawing.Size(1008, 297);
			this.PanelDataGridViewProducts.TabIndex = 0;
			this.PanelDataGridViewProducts.Visible = false;
			// 
			// DataGridViewProduct
			// 
			this.DataGridViewProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.DataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridViewProduct.Location = new System.Drawing.Point(3, 4);
			this.DataGridViewProduct.Name = "DataGridViewProduct";
			this.DataGridViewProduct.ReadOnly = true;
			this.DataGridViewProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DataGridViewProduct.Size = new System.Drawing.Size(1002, 285);
			this.DataGridViewProduct.TabIndex = 0;
			this.DataGridViewProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewProduct_CellClick);
			// 
			// PanelProductOperations
			// 
			this.PanelProductOperations.Controls.Add(this.groupBox1);
			this.PanelProductOperations.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.PanelProductOperations.Location = new System.Drawing.Point(0, 430);
			this.PanelProductOperations.Name = "PanelProductOperations";
			this.PanelProductOperations.Size = new System.Drawing.Size(1024, 338);
			this.PanelProductOperations.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.BtnCikis);
			this.groupBox1.Controls.Add(this.BtnProductUpdate);
			this.groupBox1.Controls.Add(this.BtnProductAdd);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.CmbCategoryName);
			this.groupBox1.Controls.Add(this.CmbSupplierName);
			this.groupBox1.Controls.Add(this.TxtUnitsInStock);
			this.groupBox1.Controls.Add(this.TxtUnitPrice);
			this.groupBox1.Controls.Add(this.TxtQuantityPerUnit);
			this.groupBox1.Controls.Add(this.TxtProductName);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox1.Location = new System.Drawing.Point(12, 26);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(984, 239);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Urun Ekle";
			// 
			// BtnProductUpdate
			// 
			this.BtnProductUpdate.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.BtnProductUpdate.Location = new System.Drawing.Point(372, 184);
			this.BtnProductUpdate.Name = "BtnProductUpdate";
			this.BtnProductUpdate.Size = new System.Drawing.Size(159, 49);
			this.BtnProductUpdate.TabIndex = 29;
			this.BtnProductUpdate.Text = "Urun Guncelle";
			this.BtnProductUpdate.UseVisualStyleBackColor = true;
			this.BtnProductUpdate.Click += new System.EventHandler(this.BtnProductUpdate_Click);
			// 
			// BtnProductAdd
			// 
			this.BtnProductAdd.BackColor = System.Drawing.Color.LemonChiffon;
			this.BtnProductAdd.Location = new System.Drawing.Point(10, 184);
			this.BtnProductAdd.Name = "BtnProductAdd";
			this.BtnProductAdd.Size = new System.Drawing.Size(143, 49);
			this.BtnProductAdd.TabIndex = 28;
			this.BtnProductAdd.Text = "Urun Ekle";
			this.BtnProductAdd.UseVisualStyleBackColor = false;
			this.BtnProductAdd.Click += new System.EventHandler(this.BtnProductAdd_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.Location = new System.Drawing.Point(413, 57);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(107, 20);
			this.label6.TabIndex = 25;
			this.label6.Text = "Kategori Adi";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(217, 57);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(131, 20);
			this.label5.TabIndex = 24;
			this.label5.Text = "Tedarikci Firma";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(857, 57);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(97, 20);
			this.label3.TabIndex = 21;
			this.label3.Text = "Stok Adedi";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(725, 57);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(98, 20);
			this.label4.TabIndex = 13;
			this.label4.Text = "Satis Fiyati";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(544, 57);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(153, 20);
			this.label2.TabIndex = 10;
			this.label2.Text = "Birim Satis Miktari";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(38, 57);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(79, 20);
			this.label1.TabIndex = 8;
			this.label1.Text = "Urun Adi";
			// 
			// CmbCategoryName
			// 
			this.CmbCategoryName.FormattingEnabled = true;
			this.CmbCategoryName.Location = new System.Drawing.Point(372, 111);
			this.CmbCategoryName.Name = "CmbCategoryName";
			this.CmbCategoryName.Size = new System.Drawing.Size(145, 32);
			this.CmbCategoryName.TabIndex = 27;
			// 
			// CmbSupplierName
			// 
			this.CmbSupplierName.FormattingEnabled = true;
			this.CmbSupplierName.Location = new System.Drawing.Point(186, 111);
			this.CmbSupplierName.Name = "CmbSupplierName";
			this.CmbSupplierName.Size = new System.Drawing.Size(153, 32);
			this.CmbSupplierName.TabIndex = 26;
			// 
			// TxtUnitsInStock
			// 
			this.TxtUnitsInStock.Location = new System.Drawing.Point(847, 114);
			this.TxtUnitsInStock.Name = "TxtUnitsInStock";
			this.TxtUnitsInStock.Size = new System.Drawing.Size(132, 29);
			this.TxtUnitsInStock.TabIndex = 4;
			this.TxtUnitsInStock.Tag = "4";
			// 
			// TxtUnitPrice
			// 
			this.TxtUnitPrice.Location = new System.Drawing.Point(732, 114);
			this.TxtUnitPrice.Name = "TxtUnitPrice";
			this.TxtUnitPrice.Size = new System.Drawing.Size(82, 29);
			this.TxtUnitPrice.TabIndex = 3;
			this.TxtUnitPrice.Tag = "3";
			this.TxtUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUnitPrice_KeyPress);
			// 
			// TxtQuantityPerUnit
			// 
			this.TxtQuantityPerUnit.Location = new System.Drawing.Point(550, 114);
			this.TxtQuantityPerUnit.Name = "TxtQuantityPerUnit";
			this.TxtQuantityPerUnit.Size = new System.Drawing.Size(149, 29);
			this.TxtQuantityPerUnit.TabIndex = 2;
			this.TxtQuantityPerUnit.Tag = "2";
			// 
			// TxtProductName
			// 
			this.TxtProductName.AcceptsReturn = true;
			this.TxtProductName.Location = new System.Drawing.Point(6, 114);
			this.TxtProductName.Name = "TxtProductName";
			this.TxtProductName.Size = new System.Drawing.Size(147, 29);
			this.TxtProductName.TabIndex = 1;
			this.TxtProductName.Tag = "1";
			// 
			// PanelSearch
			// 
			this.PanelSearch.Controls.Add(this.CmbSupplierSearch);
			this.PanelSearch.Controls.Add(this.label8);
			this.PanelSearch.Controls.Add(this.CmbCagetorySearch);
			this.PanelSearch.Controls.Add(this.label7);
			this.PanelSearch.Dock = System.Windows.Forms.DockStyle.Top;
			this.PanelSearch.Location = new System.Drawing.Point(0, 0);
			this.PanelSearch.Name = "PanelSearch";
			this.PanelSearch.Size = new System.Drawing.Size(1024, 67);
			this.PanelSearch.TabIndex = 2;
			this.PanelSearch.Visible = false;
			// 
			// CmbSupplierSearch
			// 
			this.CmbSupplierSearch.FormattingEnabled = true;
			this.CmbSupplierSearch.Location = new System.Drawing.Point(742, 36);
			this.CmbSupplierSearch.Name = "CmbSupplierSearch";
			this.CmbSupplierSearch.Size = new System.Drawing.Size(249, 21);
			this.CmbSupplierSearch.TabIndex = 30;
			this.CmbSupplierSearch.SelectedIndexChanged += new System.EventHandler(this.CmbSupplierSearch_SelectedIndexChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label8.Location = new System.Drawing.Point(732, 9);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(259, 24);
			this.label8.TabIndex = 29;
			this.label8.Text = "Tedarikciye Gore Urun Ara";
			// 
			// CmbCagetorySearch
			// 
			this.CmbCagetorySearch.FormattingEnabled = true;
			this.CmbCagetorySearch.Location = new System.Drawing.Point(51, 36);
			this.CmbCagetorySearch.Name = "CmbCagetorySearch";
			this.CmbCagetorySearch.Size = new System.Drawing.Size(249, 21);
			this.CmbCagetorySearch.TabIndex = 28;
			this.CmbCagetorySearch.SelectedIndexChanged += new System.EventHandler(this.CmbCagetorySearch_SelectedIndexChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label7.Location = new System.Drawing.Point(50, 9);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(250, 24);
			this.label7.TabIndex = 1;
			this.label7.Text = "Kategoriye Gore Urun Ara";
			// 
			// BtnCikis
			// 
			this.BtnCikis.ForeColor = System.Drawing.Color.Maroon;
			this.BtnCikis.Location = new System.Drawing.Point(819, 184);
			this.BtnCikis.Name = "BtnCikis";
			this.BtnCikis.Size = new System.Drawing.Size(159, 49);
			this.BtnCikis.TabIndex = 30;
			this.BtnCikis.Text = "Cikis Yap";
			this.BtnCikis.UseVisualStyleBackColor = true;
			this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
			// 
			// StockForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(1024, 768);
			this.Controls.Add(this.PanelSearch);
			this.Controls.Add(this.PanelProductOperations);
			this.Controls.Add(this.PanelDataGridViewProducts);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "StockForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "StockForm";
			this.Load += new System.EventHandler(this.StockForm_Load);
			this.PanelDataGridViewProducts.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DataGridViewProduct)).EndInit();
			this.PanelProductOperations.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.PanelSearch.ResumeLayout(false);
			this.PanelSearch.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel PanelDataGridViewProducts;
		private System.Windows.Forms.DataGridView DataGridViewProduct;
		private System.Windows.Forms.Panel PanelProductOperations;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox TxtUnitsInStock;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox TxtUnitPrice;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox TxtQuantityPerUnit;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TxtProductName;
		private System.Windows.Forms.ComboBox CmbCategoryName;
		private System.Windows.Forms.ComboBox CmbSupplierName;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel PanelSearch;
		private System.Windows.Forms.ComboBox CmbSupplierSearch;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox CmbCagetorySearch;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button BtnProductUpdate;
		private System.Windows.Forms.Button BtnProductAdd;
		private System.Windows.Forms.Button BtnCikis;
	}
}