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
	public partial class SupplierOperationForm : Form
	{
		public SupplierOperationForm()
		{
			InitializeComponent();
			_supplierService = InstanceFactory.GetInstance<ISupplierService>();// Bizden ISupplierService Istenirse Biz Ona SupplierManager vereegiz

			// Eger Ilk Basta Supplier hic eklenmemis ise kullanicinin ilk olarak bunlari eklemesini istiyoruz.
			if (AnaForm.countSuppliers > 0)
			{
				// Ilk basta supplier olmadigi icin datagrid i gostermiyorum.
				PanelDataGridSupplierOperation.Visible = true;

				var _suppliersGetir = _supplierService.GetSuppliers();
				DataGridSupplierOperations.DataSource = _suppliersGetir;
				_suppliersList.AddRange(_suppliersGetir);
			}
			else
			{
				this.Size = new Size(1024, 500); // Yeni Boyut veriyoruz en basta.
			}

		}

		List<Supplier> _suppliersList = new List<Supplier>(); // karsilastirma icin tutuyorum.
		private ISupplierService _supplierService;


		private void BtnCompanyAdd_Click(object sender, EventArgs e)
		{
			if (_suppliersList.Exists(a => a.SupplierId == _supplierId)) // Kullanici DataGrid ten kayit secip onu tekrardan eklemek isterse burada kontrol saglayip eger o kayit varsa ekletmiyoruz.
			{
				MessageBox.Show("Ayni Kayidi Eklemeye Calisiyorsunuz.");
			}
			else // Yeni Kayit Ekleme
			{
				_supplierService.Add(new Supplier
				{
					Address = TxtCompanyAddress.Text,
					City = TxtCompanyCity.Text,
					CompanyName = TxtCompanyName.Text,
					ContactName = TxtContactName.Text,
					District = TxtCompanyDistrict.Text,
					Phone = TxtCompanyPhone.Text,
					PostalCode = TxtCompanyPostalCode.Text
				});
				MessageBox.Show("KAYIT BASARILI BIR SEKILDE EKLENDI...");
				CleanTheTextBox();
				DataGridSupplierOperations.DataSource = _supplierService.GetSuppliers();
			}

		}


		private int _supplierId; // Eklenecek Kayit var mi diye kontrol ediyoruz. Onun icin bu degisken var
		private void DataGridSupplierOperations_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				_supplierId = (int)DataGridSupplierOperations.SelectedRows[0].Cells["SupplierId"].Value;
				TxtCompanyName.Text = DataGridSupplierOperations.SelectedRows[0].Cells["CompanyName"].Value.ToString();
				TxtContactName.Text = DataGridSupplierOperations.SelectedRows[0].Cells["ContactName"].Value.ToString();
				TxtCompanyAddress.Text = DataGridSupplierOperations.SelectedRows[0].Cells["Address"].Value.ToString();
				TxtCompanyCity.Text = DataGridSupplierOperations.SelectedRows[0].Cells["City"].Value.ToString();
				TxtCompanyPostalCode.Text = DataGridSupplierOperations.SelectedRows[0].Cells["PostalCode"].Value.ToString();
				TxtCompanyDistrict.Text = DataGridSupplierOperations.SelectedRows[0].Cells["District"].Value.ToString();
				TxtCompanyPhone.Text = DataGridSupplierOperations.SelectedRows[0].Cells["Phone"].Value.ToString();
			}
			catch
			{
				MessageBox.Show("Ups Bir hata var sanirim......");
			}

		}
		// Guncelleme Islemi.
		private void BtnCompanyUpdate_Click(object sender, EventArgs e)
		{
			try
			{
				_supplierService.Update(new Supplier
				{
					SupplierId = _supplierId,
					Address = TxtCompanyAddress.Text,
					City = TxtCompanyCity.Text,
					CompanyName = TxtCompanyName.Text,
					ContactName = TxtContactName.Text,
					District = TxtCompanyDistrict.Text,
					Phone = TxtCompanyPhone.Text,
					PostalCode = TxtCompanyPostalCode.Text
				});
				DataGridSupplierOperations.DataSource = _supplierService.GetSuppliers();
			}
			catch
			{
				MessageBox.Show("Lutfen Guncelleme Yapmak Istediginiz Kaydi Seciniz...");
			}


		}
		// textBoxlari temizliyoruz.
		private void BtnTxtClean_Click(object sender, EventArgs e)
		{
			CleanTheTextBox();
		}

		private void CleanTheTextBox()
		{
			TxtCompanyPhone.Text = "";
			TxtCompanyAddress.Text = "";
			TxtCompanyCity.Text = "";
			TxtCompanyDistrict.Text = "";
			TxtCompanyName.Text = "";
			TxtCompanyPostalCode.Text = "";
			TxtContactName.Text = "";
			_supplierId = 0;
		}

		private void BtnCikis_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
