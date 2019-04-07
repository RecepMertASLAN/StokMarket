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

namespace StockMarket.WindowsUI
{
	public partial class AnaForm : Form
	{
		public AnaForm()
		{
			InitializeComponent();
			_categoryService = InstanceFactory.GetInstance<ICategoryService>();
			_supplierService = InstanceFactory.GetInstance<ISupplierService>();
		}

		public static int countCategory;
		public static int countSuppliers;
		private ICategoryService _categoryService;
		private ISupplierService _supplierService;
		private void AnaForm_Load(object sender, EventArgs e)
		{
			countCategory = _categoryService.GetCategories().Count;
			countSuppliers = _supplierService.GetSuppliers().Count;
			if (countCategory <= 0)
				MessageBox.Show("Gorunuse Gore Ilk Defa Programi Aciyorsunuz. Lutfen Ilk Kategorinizi Giriniz.");
			{
				CategoryOperationForm categoryOperationForm = new CategoryOperationForm();
				categoryOperationForm.ShowDialog();
				countCategory++;
			}

			if (countSuppliers <= 0)
			{
				MessageBox.Show("Gorunuse Gore Ilk Defa Programi Aciyorsunuz. Lutfen Ilk Tedarikcinizi Giriniz.");
				SupplierOperationForm supplierOperationForm = new SupplierOperationForm();
				supplierOperationForm.ShowDialog();
				countSuppliers++;
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			CategoryOperationForm categoryOperationForm = new CategoryOperationForm();
			categoryOperationForm.ShowDialog();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			SupplierOperationForm supplierOperationForm = new SupplierOperationForm();
			supplierOperationForm.ShowDialog();
		}

		private void BtnSatis_Click(object sender, EventArgs e)
		{
			SatisForm satisForm = new SatisForm();
			satisForm.ShowDialog();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			StockForm stockForm = new StockForm();
			stockForm.ShowDialog();
		}

		private void BtnRapor_Click(object sender, EventArgs e)
		{
			RaporForm form = new RaporForm();
			form.ShowDialog();
		}
	}
}
