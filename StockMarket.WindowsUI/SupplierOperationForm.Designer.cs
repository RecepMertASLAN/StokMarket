namespace StockMarket.WindowsUI
{
	partial class SupplierOperationForm
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
			this.PanelDataGridSupplierOperation = new System.Windows.Forms.Panel();
			this.DataGridSupplierOperations = new System.Windows.Forms.DataGridView();
			this.PanelSupplierOperations = new System.Windows.Forms.Panel();
			this.BtnCikis = new System.Windows.Forms.Button();
			this.BtnTxtClean = new System.Windows.Forms.Button();
			this.BtnCompanyUpdate = new System.Windows.Forms.Button();
			this.BtnCompanyAdd = new System.Windows.Forms.Button();
			this.GroupBoxSupplier = new System.Windows.Forms.GroupBox();
			this.TxtCompanyCity = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.TxtCompanyPhone = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.TxtCompanyDistrict = new System.Windows.Forms.TextBox();
			this.TxtCompanyAddress = new System.Windows.Forms.TextBox();
			this.TxtCompanyPostalCode = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.TxtContactName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.TxtCompanyName = new System.Windows.Forms.TextBox();
			this.PanelDataGridSupplierOperation.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridSupplierOperations)).BeginInit();
			this.PanelSupplierOperations.SuspendLayout();
			this.GroupBoxSupplier.SuspendLayout();
			this.SuspendLayout();
			// 
			// PanelDataGridSupplierOperation
			// 
			this.PanelDataGridSupplierOperation.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.PanelDataGridSupplierOperation.Controls.Add(this.DataGridSupplierOperations);
			this.PanelDataGridSupplierOperation.Dock = System.Windows.Forms.DockStyle.Top;
			this.PanelDataGridSupplierOperation.Location = new System.Drawing.Point(0, 0);
			this.PanelDataGridSupplierOperation.Name = "PanelDataGridSupplierOperation";
			this.PanelDataGridSupplierOperation.Size = new System.Drawing.Size(1024, 308);
			this.PanelDataGridSupplierOperation.TabIndex = 0;
			this.PanelDataGridSupplierOperation.Visible = false;
			// 
			// DataGridSupplierOperations
			// 
			this.DataGridSupplierOperations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.DataGridSupplierOperations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridSupplierOperations.Location = new System.Drawing.Point(12, 12);
			this.DataGridSupplierOperations.Name = "DataGridSupplierOperations";
			this.DataGridSupplierOperations.ReadOnly = true;
			this.DataGridSupplierOperations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DataGridSupplierOperations.Size = new System.Drawing.Size(984, 290);
			this.DataGridSupplierOperations.TabIndex = 0;
			this.DataGridSupplierOperations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridSupplierOperations_CellClick);
			// 
			// PanelSupplierOperations
			// 
			this.PanelSupplierOperations.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.PanelSupplierOperations.Controls.Add(this.BtnCikis);
			this.PanelSupplierOperations.Controls.Add(this.BtnTxtClean);
			this.PanelSupplierOperations.Controls.Add(this.BtnCompanyUpdate);
			this.PanelSupplierOperations.Controls.Add(this.BtnCompanyAdd);
			this.PanelSupplierOperations.Controls.Add(this.GroupBoxSupplier);
			this.PanelSupplierOperations.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PanelSupplierOperations.Location = new System.Drawing.Point(0, 308);
			this.PanelSupplierOperations.Name = "PanelSupplierOperations";
			this.PanelSupplierOperations.Size = new System.Drawing.Size(1024, 460);
			this.PanelSupplierOperations.TabIndex = 1;
			// 
			// BtnCikis
			// 
			this.BtnCikis.BackColor = System.Drawing.Color.Crimson;
			this.BtnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnCikis.ForeColor = System.Drawing.Color.Azure;
			this.BtnCikis.Location = new System.Drawing.Point(852, 214);
			this.BtnCikis.Name = "BtnCikis";
			this.BtnCikis.Size = new System.Drawing.Size(115, 47);
			this.BtnCikis.TabIndex = 12;
			this.BtnCikis.Text = "CikisYap";
			this.BtnCikis.UseVisualStyleBackColor = false;
			this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
			// 
			// BtnTxtClean
			// 
			this.BtnTxtClean.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.BtnTxtClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnTxtClean.ForeColor = System.Drawing.Color.DarkOliveGreen;
			this.BtnTxtClean.Location = new System.Drawing.Point(301, 214);
			this.BtnTxtClean.Name = "BtnTxtClean";
			this.BtnTxtClean.Size = new System.Drawing.Size(106, 56);
			this.BtnTxtClean.TabIndex = 11;
			this.BtnTxtClean.Text = "Ekrani Temizle";
			this.BtnTxtClean.UseVisualStyleBackColor = false;
			this.BtnTxtClean.Click += new System.EventHandler(this.BtnTxtClean_Click);
			// 
			// BtnCompanyUpdate
			// 
			this.BtnCompanyUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.BtnCompanyUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnCompanyUpdate.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.BtnCompanyUpdate.Location = new System.Drawing.Point(572, 214);
			this.BtnCompanyUpdate.Name = "BtnCompanyUpdate";
			this.BtnCompanyUpdate.Size = new System.Drawing.Size(115, 47);
			this.BtnCompanyUpdate.TabIndex = 10;
			this.BtnCompanyUpdate.Text = "Guncelle";
			this.BtnCompanyUpdate.UseVisualStyleBackColor = false;
			this.BtnCompanyUpdate.Click += new System.EventHandler(this.BtnCompanyUpdate_Click);
			// 
			// BtnCompanyAdd
			// 
			this.BtnCompanyAdd.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.BtnCompanyAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnCompanyAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.BtnCompanyAdd.Location = new System.Drawing.Point(21, 214);
			this.BtnCompanyAdd.Name = "BtnCompanyAdd";
			this.BtnCompanyAdd.Size = new System.Drawing.Size(115, 47);
			this.BtnCompanyAdd.TabIndex = 8;
			this.BtnCompanyAdd.Text = "Ekle";
			this.BtnCompanyAdd.UseVisualStyleBackColor = false;
			this.BtnCompanyAdd.Click += new System.EventHandler(this.BtnCompanyAdd_Click);
			// 
			// GroupBoxSupplier
			// 
			this.GroupBoxSupplier.Controls.Add(this.TxtCompanyCity);
			this.GroupBoxSupplier.Controls.Add(this.label3);
			this.GroupBoxSupplier.Controls.Add(this.label6);
			this.GroupBoxSupplier.Controls.Add(this.TxtCompanyPhone);
			this.GroupBoxSupplier.Controls.Add(this.label7);
			this.GroupBoxSupplier.Controls.Add(this.label8);
			this.GroupBoxSupplier.Controls.Add(this.TxtCompanyDistrict);
			this.GroupBoxSupplier.Controls.Add(this.TxtCompanyAddress);
			this.GroupBoxSupplier.Controls.Add(this.TxtCompanyPostalCode);
			this.GroupBoxSupplier.Controls.Add(this.label4);
			this.GroupBoxSupplier.Controls.Add(this.label2);
			this.GroupBoxSupplier.Controls.Add(this.TxtContactName);
			this.GroupBoxSupplier.Controls.Add(this.label1);
			this.GroupBoxSupplier.Controls.Add(this.TxtCompanyName);
			this.GroupBoxSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.GroupBoxSupplier.Location = new System.Drawing.Point(12, 26);
			this.GroupBoxSupplier.Name = "GroupBoxSupplier";
			this.GroupBoxSupplier.Size = new System.Drawing.Size(984, 158);
			this.GroupBoxSupplier.TabIndex = 7;
			this.GroupBoxSupplier.TabStop = false;
			this.GroupBoxSupplier.Text = "Tedarikc Islemleri";
			// 
			// TxtCompanyCity
			// 
			this.TxtCompanyCity.Location = new System.Drawing.Point(398, 93);
			this.TxtCompanyCity.Name = "TxtCompanyCity";
			this.TxtCompanyCity.Size = new System.Drawing.Size(132, 24);
			this.TxtCompanyCity.TabIndex = 3;
			this.TxtCompanyCity.Tag = "4";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(407, 39);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 18);
			this.label3.TabIndex = 7;
			this.label3.Text = "Sirket Sehri";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(842, 39);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(135, 18);
			this.label6.TabIndex = 6;
			this.label6.Text = "Sirketin Telefonu";
			// 
			// TxtCompanyPhone
			// 
			this.TxtCompanyPhone.Location = new System.Drawing.Point(842, 93);
			this.TxtCompanyPhone.Name = "TxtCompanyPhone";
			this.TxtCompanyPhone.Size = new System.Drawing.Size(132, 24);
			this.TxtCompanyPhone.TabIndex = 6;
			this.TxtCompanyPhone.Tag = "7";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(716, 39);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(96, 18);
			this.label7.TabIndex = 5;
			this.label7.Text = "Sirket Ilcesi";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(533, 39);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(153, 18);
			this.label8.TabIndex = 4;
			this.label8.Text = "Sirketin PostaKodu";
			// 
			// TxtCompanyDistrict
			// 
			this.TxtCompanyDistrict.Location = new System.Drawing.Point(694, 93);
			this.TxtCompanyDistrict.Name = "TxtCompanyDistrict";
			this.TxtCompanyDistrict.Size = new System.Drawing.Size(132, 24);
			this.TxtCompanyDistrict.TabIndex = 5;
			this.TxtCompanyDistrict.Tag = "6";
			// 
			// TxtCompanyAddress
			// 
			this.TxtCompanyAddress.Location = new System.Drawing.Point(261, 93);
			this.TxtCompanyAddress.Name = "TxtCompanyAddress";
			this.TxtCompanyAddress.Size = new System.Drawing.Size(121, 24);
			this.TxtCompanyAddress.TabIndex = 2;
			this.TxtCompanyAddress.Tag = "3";
			// 
			// TxtCompanyPostalCode
			// 
			this.TxtCompanyPostalCode.Location = new System.Drawing.Point(546, 93);
			this.TxtCompanyPostalCode.Name = "TxtCompanyPostalCode";
			this.TxtCompanyPostalCode.Size = new System.Drawing.Size(132, 24);
			this.TxtCompanyPostalCode.TabIndex = 4;
			this.TxtCompanyPostalCode.Tag = "5";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(273, 39);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(104, 18);
			this.label4.TabIndex = 2;
			this.label4.Text = "Sirket Adresi";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(126, 39);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(117, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "Sirket Elemani";
			// 
			// TxtContactName
			// 
			this.TxtContactName.Location = new System.Drawing.Point(122, 93);
			this.TxtContactName.Name = "TxtContactName";
			this.TxtContactName.Size = new System.Drawing.Size(123, 24);
			this.TxtContactName.TabIndex = 1;
			this.TxtContactName.Tag = "2";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Sirket Adi";
			// 
			// TxtCompanyName
			// 
			this.TxtCompanyName.Location = new System.Drawing.Point(9, 93);
			this.TxtCompanyName.Name = "TxtCompanyName";
			this.TxtCompanyName.Size = new System.Drawing.Size(97, 24);
			this.TxtCompanyName.TabIndex = 0;
			this.TxtCompanyName.Tag = "1";
			// 
			// SupplierOperationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1024, 768);
			this.Controls.Add(this.PanelSupplierOperations);
			this.Controls.Add(this.PanelDataGridSupplierOperation);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.KeyPreview = true;
			this.Name = "SupplierOperationForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SupplierOperation";
			this.PanelDataGridSupplierOperation.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DataGridSupplierOperations)).EndInit();
			this.PanelSupplierOperations.ResumeLayout(false);
			this.GroupBoxSupplier.ResumeLayout(false);
			this.GroupBoxSupplier.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel PanelDataGridSupplierOperation;
		private System.Windows.Forms.Panel PanelSupplierOperations;
		private System.Windows.Forms.TextBox TxtCompanyPhone;
		private System.Windows.Forms.TextBox TxtCompanyAddress;
		private System.Windows.Forms.TextBox TxtCompanyDistrict;
		private System.Windows.Forms.TextBox TxtCompanyPostalCode;
		private System.Windows.Forms.TextBox TxtContactName;
		private System.Windows.Forms.TextBox TxtCompanyName;
		private System.Windows.Forms.DataGridView DataGridSupplierOperations;
		private System.Windows.Forms.GroupBox GroupBoxSupplier;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button BtnCompanyUpdate;
		private System.Windows.Forms.Button BtnCompanyAdd;
		private System.Windows.Forms.TextBox TxtCompanyCity;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button BtnTxtClean;
		private System.Windows.Forms.Button BtnCikis;
	}
}