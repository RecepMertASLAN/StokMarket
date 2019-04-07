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
	public partial class RaporForm : Form
	{
		public RaporForm()
		{
			InitializeComponent();
			_orderDetailService = InstanceFactory.GetInstance<IOrderDetailService>();
			_orderService = InstanceFactory.GetInstance<IOrderService>();
		}

		private IOrderDetailService _orderDetailService;
		private IOrderService _orderService;
		private void RaporForm_Load(object sender, EventArgs e)
		{
			CmbSearch.DataSource = _orderService.GetOrders();
			CmbSearch.ValueMember = "OrderId";
			CmbSearch.DisplayMember = "TotalPrice";
			DgvSearch.DataSource = _orderDetailService.GetDetails();
			DgvSearch.Columns["ProductId"].HeaderText = "Urun Id";
			DgvSearch.Columns["OrderId"].HeaderText = "Siparis Id";
			DgvSearch.Columns["UnitPrice"].HeaderText = "Birim Fiyati";
			DgvSearch.Columns["Quantity"].HeaderText = "Satis Turu";
			DgvSearch.Columns["Discount"].HeaderText = "Indirim Tutari";

		}

		private void CmbSearch_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				DgvSearch.DataSource = _orderDetailService.GetDetailsByOrderId((int)CmbSearch.SelectedValue);
			}
			catch { }
			
		}

		private void BtnAll_Click(object sender, EventArgs e)
		{
			DgvSearch.DataSource = _orderDetailService.GetDetails();
		}

		private void BtnCikisYap_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
