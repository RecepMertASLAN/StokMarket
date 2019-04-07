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
using StockMarket.DataAccess.Concrete.EntityFramework;
using StockMarket.Entities.Concrete;

namespace StockMarket.WindowsUI
{
	public partial class StockForm : Form
	{
		public StockForm()
		{
			InitializeComponent();
			_productService = InstanceFactory.GetInstance<IProductService>();
			_categoryService = InstanceFactory.GetInstance<ICategoryService>();
			_supplierService = InstanceFactory.GetInstance<ISupplierService>();
			var getProducts = _productService.GetProducts();
			_productsList.AddRange(getProducts);
			if (getProducts.Count > 0)
			{
				PanelDataGridViewProducts.Visible = true;
				DataGridViewProduct.DataSource = getProducts;
				PanelSearch.Visible = true;
			}
			else
			{
				this.Size = new Size(1024, 500);
				PanelProductOperations.Dock = DockStyle.Fill;
			}
		}

		private ISupplierService _supplierService;
		private ICategoryService _categoryService;
		private IProductService _productService;
		private List<Product> _productsList = new List<Product>();

		private void StockForm_Load(object sender, EventArgs e)
		{
			LoadCategories();
			LoadSuppliers();
		}

		private void LoadSuppliers()
		{
			CmbSupplierName.DataSource = _supplierService.GetSuppliers();
			CmbSupplierName.DisplayMember = "CompanyName";
			CmbSupplierName.ValueMember = "SupplierId";

			CmbSupplierSearch.DataSource = _supplierService.GetSuppliers();
			CmbSupplierSearch.DisplayMember = "CompanyName";
			CmbSupplierSearch.ValueMember = "SupplierId";

		}

		private void LoadCategories()
		{
			CmbCategoryName.DataSource = _categoryService.GetCategories();
			CmbCategoryName.DisplayMember = "CategoryName";
			CmbCategoryName.ValueMember = "CategoryId";

			CmbCagetorySearch.DataSource = _categoryService.GetCategories();
			CmbCagetorySearch.DisplayMember = "CategoryName";
			CmbCagetorySearch.ValueMember = "CategoryId";
		}

		private void CmbCagetorySearch_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				DataGridViewProduct.DataSource =
					_productService.GeProductsByCategory((int)CmbCagetorySearch.SelectedValue);
			}
			catch
			{

			}


		}

		private void CmbSupplierSearch_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				DataGridViewProduct.DataSource =
					_productService.GetProductsBySupplierId((int)CmbSupplierSearch.SelectedValue);
			}
			catch
			{

			}
		}

		private int _productId;
		private int _supplierId;
		private int _categoryId;

		private void BtnProductAdd_Click(object sender, EventArgs e)
		{
			try
			{
				if (_productsList.Exists(p => p.ProductId == _productId))
				{
					MessageBox.Show("Kayitli Bir Urun Eklemeye Calisiyorsunuz...");
				}
				else
				{
					_productService.Add(new Product
					{
						CategoryId = (int)CmbCategoryName.SelectedValue,
						ProductName = TxtProductName.Text,
						QuantityPerUnit = TxtQuantityPerUnit.Text,
						SupplierId = (int)CmbSupplierName.SelectedValue,
						UnitPrice = Convert.ToDecimal(TxtUnitPrice.Text),
						UnitsInStock = Convert.ToInt16(TxtUnitsInStock.Text)

					});
					DataGridViewProduct.DataSource = _productService.GetProducts();
					if (PanelDataGridViewProducts.Visible == false)
					{
						PanelDataGridViewProducts.Visible = true;
					}

				}
			}
			catch
			{
				MessageBox.Show("Lutfen Gecerli Degerler Giriniz...");
			}
			

		}

		private void DataGridViewProduct_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				_productId = (int)DataGridViewProduct.SelectedRows[0].Cells["ProductId"].Value;
				_supplierId = (int)DataGridViewProduct.SelectedRows[0].Cells["SupplierId"].Value;
				_categoryId = (int)DataGridViewProduct.SelectedRows[0].Cells["CategoryId"].Value;
				TxtProductName.Text = DataGridViewProduct.SelectedRows[0].Cells["ProductName"].Value.ToString();
				TxtQuantityPerUnit.Text = DataGridViewProduct.SelectedRows[0].Cells["QuantityPerUnit"].Value.ToString();
				TxtUnitPrice.Text = DataGridViewProduct.SelectedRows[0].Cells["UnitPrice"].Value.ToString();
				TxtUnitsInStock.Text = DataGridViewProduct.SelectedRows[0].Cells["UnitsInStock"].Value.ToString();
				

			}
			catch
			{
				MessageBox.Show("Ups Bir Hata...");
			}
		}

		private void BtnProductUpdate_Click(object sender, EventArgs e)
		{
			_productService.Update(new Product
			{
				ProductId = _productId,
				CategoryId = (int)CmbCategoryName.SelectedValue,
				ProductName = TxtProductName.Text,
				QuantityPerUnit = TxtQuantityPerUnit.Text,
				SupplierId = (int)CmbSupplierName.SelectedValue,
				UnitPrice = Convert.ToDecimal(TxtUnitPrice.Text),
				UnitsInStock = Convert.ToInt16(TxtUnitsInStock.Text)
			});
			DataGridViewProduct.DataSource = _productService.GetProducts();
		}

		private void TxtUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
		{

			if (e.KeyChar == 46)
			{
				e.Handled = true;
			}


		}

		private void BtnCikis_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
