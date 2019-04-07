using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockMarket.Business.Abstract;
using StockMarket.Business.DependencyResolvers.Ninject;
using StockMarket.Entities.Concrete;

namespace StockMarket.WindowsUI
{
	public partial class SatisForm : Form
	{
		public SatisForm()
		{
			InitializeComponent();
			_productService = InstanceFactory.GetInstance<IProductService>();
			_orderDetailService = InstanceFactory.GetInstance<IOrderDetailService>();
			_orderService = InstanceFactory.GetInstance<IOrderService>();
		}


		private IProductService _productService;
		private IOrderDetailService _orderDetailService;
		private IOrderService _orderService;

		private void SatisForm_Load(object sender, EventArgs e)
		{
			DataGridViewProduct.DataSource = _productService.GetProducts();
			SetDataGridViewHeaders();
			RdbYok.Checked = true;
			TxtProductDiscount.Enabled = false;
			DataGridViewBasket.Columns.Add("UrunIsmi", "Urun Adi");
			DataGridViewBasket.Columns.Add("UrunFiyati", "Urun Fiyati");
			DataGridViewBasket.Columns.Add("UrunAdedi", "Urun Adedi");
			DataGridViewBasket.Columns.Add("UrunIndirimi", "Urun Indirimi");
			DataGridViewBasket.Columns.Add("ProductId", "Urun Id");
			DataGridViewBasket.Columns["ProductId"].Visible = false;

		}

		private void SetDataGridViewHeaders()
		{
			DataGridViewProduct.Columns["ProductName"].HeaderText = "Urun Adi";
			DataGridViewProduct.Columns["UnitPrice"].HeaderText = "Urun Fiyati";
			DataGridViewProduct.Columns["QuantityPerUnit"].HeaderText = "Satis Turu";
			DataGridViewProduct.Columns["UnitsInStock"].HeaderText = "Stok Adedi";
			DataGridViewProduct.Columns[0].Visible = false;
			DataGridViewProduct.Columns[1].Visible = false;
			DataGridViewProduct.Columns[2].Visible = false;

		}

		private int _productId;
		private Int16 _stockCount;
		private void DataGridViewProduct_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				TxtProductName.Text = DataGridViewProduct.SelectedRows[0].Cells["ProductName"].Value.ToString();
				TxtProductPrice.Text = DataGridViewProduct.SelectedRows[0].Cells["UnitPrice"].Value.ToString();
				_stockCount = (Int16)DataGridViewProduct.SelectedRows[0].Cells["UnitsInStock"].Value;
				_productId = Convert.ToInt32(DataGridViewProduct.SelectedRows[0].Cells["ProductId"].Value);
				NupProductCount.Value = 1;
			}
			catch { }

		}

		private void RdbVar_Click(object sender, EventArgs e)
		{
			TxtProductDiscount.Enabled = true;
		}

		private void RdbYok_Click(object sender, EventArgs e)
		{
			TxtProductDiscount.Enabled = false;
		}

		private void BtnProductCountZero_Click(object sender, EventArgs e)
		{
			NupProductCount.Value = 0;
		}

		private decimal PriceToPay = 0;
		private int RowsCount = 0;
		private void BtnAddProductToBasket_Click(object sender, EventArgs e)
		{
			try
			{
				if (!String.IsNullOrEmpty(TxtProductName.Text))
				{
					decimal price = Convert.ToDecimal(TxtProductPrice.Text);
					decimal count = (NupProductCount.Value);
					decimal discount = Convert.ToDecimal(TxtProductDiscount.Text);
					decimal totalPrice = price * count;

					if (NupProductCount.Value > _stockCount)
					{
						MessageBox.Show("Stok ta Olandan Fazla Urun Girdiniz Lutfen Kontrol Ediniz...");
					}
					else
					{
						//decimal Sum = (NupProductCount.Value * Convert.ToDecimal(TxtProductPrice.Text));
						decimal Sum;
						Sum = discount != 0 ? (totalPrice -= ((totalPrice * discount) / 100)) : totalPrice;
						DataGridViewBasket.Rows.Insert(RowsCount, 1);
						DataGridViewBasket.Rows[RowsCount].Cells[0].Value = TxtProductName.Text;
						DataGridViewBasket.Rows[RowsCount].Cells[1].Value = TxtProductPrice.Text;
						DataGridViewBasket.Rows[RowsCount].Cells[2].Value = NupProductCount.Value;
						DataGridViewBasket.Rows[RowsCount].Cells[3].Value = TxtProductDiscount.Text;
						DataGridViewBasket.Rows[RowsCount].Cells["ProductId"].Value = _productId;

						_stockCount -= (Int16)NupProductCount.Value;
						DataGridViewProduct.SelectedRows[0].Cells["UnitsInStock"].Value = _stockCount;
						if (DataGridViewBasket.Rows.Count > 0)
						{
							PriceToPay += (Convert.ToDecimal(DataGridViewBasket.Rows[0].Cells[1].Value) * Convert.ToDecimal(DataGridViewBasket.Rows[0].Cells[2].Value));
							BtnPriceTopay.Text = PriceToPay.ToString();
						}
					}
				}

			}
			catch
			{
				MessageBox.Show("Ups Bir Hata Daha.");
			}



		}




		private string iptalProductName;
		private decimal iptalProductPrice;
		private Int16 iptalUnitsInStock;
		// Cikarilacak Olan Urunleri Seciyoruz Once.
		private void DataGridViewBasket_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				iptalProductName = DataGridViewBasket.SelectedRows[0].Cells["UrunIsmi"].Value.ToString();
				iptalProductPrice = Convert.ToDecimal(DataGridViewBasket.SelectedRows[0].Cells["UrunFiyati"].Value);
				iptalUnitsInStock = Convert.ToInt16(DataGridViewBasket.SelectedRows[0].Cells["UrunAdedi"].Value);

			}
			catch { }
		}

		// Kullanici Eger Bir Urunu Cikarmak Isterse Sepetinden Burada yapiyoruz O islemi.
		private void BtnProductCancel_Click(object sender, EventArgs e)
		{
			// DataGridView in Rows larind donerek Benim Sectigim Isimle Ayni Olan Urunu Buluyorum. Sonra Bu urune Iptal Edilen Stock Miktarini Ekleyip
			// DataGridViewBasket ten Bu Satiri Siliyorum.
			try
			{
				foreach (DataGridViewRow row in DataGridViewProduct.Rows)
				{
					if (row.Cells["ProductName"].Value.ToString().Equals(iptalProductName))
					{
						Int16 Degisken = Convert.ToInt16(row.Cells["UnitsInStock"].Value);
						Degisken += iptalUnitsInStock;
						row.Cells["UnitsInStock"].Value = Degisken;
						int rowIndex = DataGridViewBasket.CurrentCell.RowIndex;
						DataGridViewBasket.Rows.RemoveAt(rowIndex);
						iptalProductName = "";

						BtnPriceTopay.Text = (Convert.ToDecimal(BtnPriceTopay.Text) - (iptalProductPrice * Convert.ToDecimal(iptalUnitsInStock))).ToString();
						iptalProductPrice = 0;
						iptalUnitsInStock = 0;
					}
				}
				DataGridViewBasket.ClearSelection();
			}
			catch { MessageBox.Show("Lutfen Once Secim Yapiniz"); }
		}

		private void TxtSearchByProductName_TextChanged(object sender, EventArgs e)
		{
			DataGridViewProduct.DataSource = _productService.GetProductByProductName(TxtSearchByProductName.Text);
		}

		private int _orderDetailsIcinOrderId;
		private void BtnPayThePrice_Click(object sender, EventArgs e)
		{
			try
			{
				if (!String.IsNullOrEmpty(BtnPriceTopay.Text))
				{
					// Product Tablosuna Guncelleme Islemi Yaptiriyorum.
					for (int i = 0; i < DataGridViewProduct.RowCount; i++)
					{
						string productName = DataGridViewProduct.Rows[i].Cells["ProductName"].Value.ToString();
						decimal unitPrice = Convert.ToDecimal(DataGridViewProduct.Rows[i].Cells["UnitPrice"].Value);
						Int16 unitsInStock = (Int16)DataGridViewProduct.Rows[i].Cells["UnitsInStock"].Value;
						_productId = Convert.ToInt32(DataGridViewProduct.Rows[i].Cells["ProductId"].Value);
						int _categoryId = Convert.ToInt32(DataGridViewProduct.Rows[i].Cells["CategoryId"].Value);
						int _supplierId = Convert.ToInt32(DataGridViewProduct.Rows[i].Cells["SupplierId"].Value);
						string _quantityPerUnit = DataGridViewProduct.Rows[i].Cells["QuantityPerUnit"].Value.ToString();
						_productService.Update(new Product
						{
							ProductId = _productId,
							CategoryId = _categoryId,
							SupplierId = _supplierId,
							ProductName = productName,
							UnitPrice = unitPrice,
							UnitsInStock = unitsInStock,
							QuantityPerUnit = _quantityPerUnit
						});
					}

					DateTime rightDateTime = DateTime.Now;
					_orderService.Add(new Order
					{
						OrderDate = rightDateTime,
						TotalPrice = Convert.ToDecimal(BtnPriceTopay.Text)

					});
					Order order = _orderService.GetOrderId(rightDateTime);
					_orderDetailsIcinOrderId = order.OrderId;

					// Simdide OrderDetails Tablosuna Yapalim.
					for (int i = 0; i < DataGridViewBasket.RowCount - 1; i++)
					{

						decimal _orderUnitPrice = Convert.ToDecimal(DataGridViewBasket.Rows[i].Cells["UrunFiyati"].Value);
						Int16 _orderStock = Convert.ToInt16(DataGridViewBasket.Rows[i].Cells["UrunAdedi"].Value);
						int _orderDiscount = Convert.ToInt32(DataGridViewBasket.Rows[i].Cells["UrunIndirimi"].Value);
						int forOrderNeedsProductId = Convert.ToInt32(DataGridViewBasket.Rows[i].Cells["ProductId"].Value);

						_orderDetailService.Add(new OrderDetail
						{
							OrderId = _orderDetailsIcinOrderId,
							ProductId = forOrderNeedsProductId,
							UnitPrice = _orderUnitPrice,
							Discount = _orderDiscount,
							Quantity = _orderStock
						});

					}

					MessageBox.Show("Odeme Tamamlandi...");
				}
			}
			catch {}
			
		}

		private void BtnCikisYap_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}

}
