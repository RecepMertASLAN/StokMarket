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
	public partial class CategoryOperationForm : Form
	{
		public CategoryOperationForm()
		{
			InitializeComponent();
			_categoryService = InstanceFactory.GetInstance<ICategoryService>();

			if (AnaForm.countCategory > 0)
			{
				PanelDataGridCategoryOperation.Visible = true;
				var _categorysGetir = _categoryService.GetCategories();
				DataGridCategoryOperations.DataSource = _categorysGetir;
				_listCageCategories.AddRange(_categorysGetir);
			}
			else
			{
				this.Size = new Size(1024, 500); // Yeni Boyut veriyoruz en basta.
			}
		}

		int _categoryId;
		List<Category> _listCageCategories = new List<Category>();
		private ICategoryService _categoryService;

		private void BtnCategoryAdd_Click(object sender, EventArgs e)
		{
			if (_listCageCategories.Exists(a => a.CategoryId == _categoryId)) // Kullanici DataGrid ten kayit secip onu tekrardan eklemek isterse burada kontrol saglayip eger o kayit varsa ekletmiyoruz.
			{
				MessageBox.Show("Ayni Kayidi Eklemeye Calisiyorsunuz.");
			}
			else // Yeni Kayit Ekleme
			{
				_categoryService.Add(new Category
				{
					CategoryName = TxtCategpryName.Text,
					Description = TxtCategoryDescription.Text,

				});
				MessageBox.Show("KAYIT BASARILI BIR SEKILDE EKLENDI...");
				CleanTheTextBox();
				DataGridCategoryOperations.DataSource = _categoryService.GetCategories();
			}
		}

		private void CleanTheTextBox()
		{
			TxtCategoryDescription.Text = "";
			TxtCategoryImage.Text = "";
			TxtCategpryName.Text = "";
		}

		private void BtnCategoryUpdate_Click(object sender, EventArgs e)
		{
			try
			{
				_categoryService.Update(new Category
				{
					CategoryId = _categoryId,
					Picture = null,
					Description = TxtCategoryDescription.Text,
					CategoryName = TxtCategpryName.Text
				});
				DataGridCategoryOperations.DataSource = _categoryService.GetCategories();
			}
			catch
			{
				MessageBox.Show("Lutfen Gunceleme Yapmak Istediginiz Kaydi siliniz.");
			}

			
		}

		private void DataGridCategoryOperations_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				_categoryId = (int)DataGridCategoryOperations.SelectedRows[0].Cells["CategoryId"].Value;
				TxtCategpryName.Text = DataGridCategoryOperations.SelectedRows[0].Cells["CategoryName"].Value.ToString();
				TxtCategoryDescription.Text = DataGridCategoryOperations.SelectedRows[0].Cells["Description"].Value.ToString();
				
			}
			catch 
			{
				MessageBox.Show("Ups Bir hata var sanirim......");
			}

		}

		private void BtnTxtClean_Click(object sender, EventArgs e)
		{
			CleanTheTextBox();
		}

		private void BtnCikis_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
