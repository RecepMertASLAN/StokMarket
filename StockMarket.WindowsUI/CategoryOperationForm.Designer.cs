namespace StockMarket.WindowsUI
{
	partial class CategoryOperationForm
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
			this.PanelDataGridCategoryOperation = new System.Windows.Forms.Panel();
			this.DataGridCategoryOperations = new System.Windows.Forms.DataGridView();
			this.PanelSupplierOperations = new System.Windows.Forms.Panel();
			this.BtnTxtClean = new System.Windows.Forms.Button();
			this.BtnCategoryUpdate = new System.Windows.Forms.Button();
			this.BtnCategoryAdd = new System.Windows.Forms.Button();
			this.GroupBoxSupplier = new System.Windows.Forms.GroupBox();
			this.TxtCategoryImage = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.TxtCategoryDescription = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.TxtCategpryName = new System.Windows.Forms.TextBox();
			this.BtnCikis = new System.Windows.Forms.Button();
			this.PanelDataGridCategoryOperation.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridCategoryOperations)).BeginInit();
			this.PanelSupplierOperations.SuspendLayout();
			this.GroupBoxSupplier.SuspendLayout();
			this.SuspendLayout();
			// 
			// PanelDataGridCategoryOperation
			// 
			this.PanelDataGridCategoryOperation.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.PanelDataGridCategoryOperation.Controls.Add(this.DataGridCategoryOperations);
			this.PanelDataGridCategoryOperation.Dock = System.Windows.Forms.DockStyle.Top;
			this.PanelDataGridCategoryOperation.Location = new System.Drawing.Point(0, 0);
			this.PanelDataGridCategoryOperation.Name = "PanelDataGridCategoryOperation";
			this.PanelDataGridCategoryOperation.Size = new System.Drawing.Size(1024, 308);
			this.PanelDataGridCategoryOperation.TabIndex = 1;
			this.PanelDataGridCategoryOperation.Visible = false;
			// 
			// DataGridCategoryOperations
			// 
			this.DataGridCategoryOperations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.DataGridCategoryOperations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridCategoryOperations.Location = new System.Drawing.Point(12, 12);
			this.DataGridCategoryOperations.Name = "DataGridCategoryOperations";
			this.DataGridCategoryOperations.ReadOnly = true;
			this.DataGridCategoryOperations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DataGridCategoryOperations.Size = new System.Drawing.Size(984, 290);
			this.DataGridCategoryOperations.TabIndex = 0;
			this.DataGridCategoryOperations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridCategoryOperations_CellClick);
			// 
			// PanelSupplierOperations
			// 
			this.PanelSupplierOperations.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.PanelSupplierOperations.Controls.Add(this.BtnCikis);
			this.PanelSupplierOperations.Controls.Add(this.BtnTxtClean);
			this.PanelSupplierOperations.Controls.Add(this.BtnCategoryUpdate);
			this.PanelSupplierOperations.Controls.Add(this.BtnCategoryAdd);
			this.PanelSupplierOperations.Controls.Add(this.GroupBoxSupplier);
			this.PanelSupplierOperations.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PanelSupplierOperations.Location = new System.Drawing.Point(0, 308);
			this.PanelSupplierOperations.Name = "PanelSupplierOperations";
			this.PanelSupplierOperations.Size = new System.Drawing.Size(1024, 460);
			this.PanelSupplierOperations.TabIndex = 2;
			// 
			// BtnTxtClean
			// 
			this.BtnTxtClean.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.BtnTxtClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnTxtClean.ForeColor = System.Drawing.Color.DarkOliveGreen;
			this.BtnTxtClean.Location = new System.Drawing.Point(296, 255);
			this.BtnTxtClean.Name = "BtnTxtClean";
			this.BtnTxtClean.Size = new System.Drawing.Size(163, 47);
			this.BtnTxtClean.TabIndex = 11;
			this.BtnTxtClean.Text = "Ekrani Temizle";
			this.BtnTxtClean.UseVisualStyleBackColor = false;
			this.BtnTxtClean.Click += new System.EventHandler(this.BtnTxtClean_Click);
			// 
			// BtnCategoryUpdate
			// 
			this.BtnCategoryUpdate.BackColor = System.Drawing.Color.MediumPurple;
			this.BtnCategoryUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnCategoryUpdate.Location = new System.Drawing.Point(579, 255);
			this.BtnCategoryUpdate.Name = "BtnCategoryUpdate";
			this.BtnCategoryUpdate.Size = new System.Drawing.Size(115, 47);
			this.BtnCategoryUpdate.TabIndex = 10;
			this.BtnCategoryUpdate.Text = "Guncelle";
			this.BtnCategoryUpdate.UseVisualStyleBackColor = false;
			this.BtnCategoryUpdate.Click += new System.EventHandler(this.BtnCategoryUpdate_Click);
			// 
			// BtnCategoryAdd
			// 
			this.BtnCategoryAdd.BackColor = System.Drawing.Color.LemonChiffon;
			this.BtnCategoryAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnCategoryAdd.Location = new System.Drawing.Point(37, 255);
			this.BtnCategoryAdd.Name = "BtnCategoryAdd";
			this.BtnCategoryAdd.Size = new System.Drawing.Size(115, 47);
			this.BtnCategoryAdd.TabIndex = 8;
			this.BtnCategoryAdd.Text = "Ekle";
			this.BtnCategoryAdd.UseVisualStyleBackColor = false;
			this.BtnCategoryAdd.Click += new System.EventHandler(this.BtnCategoryAdd_Click);
			// 
			// GroupBoxSupplier
			// 
			this.GroupBoxSupplier.Controls.Add(this.TxtCategoryImage);
			this.GroupBoxSupplier.Controls.Add(this.label4);
			this.GroupBoxSupplier.Controls.Add(this.label2);
			this.GroupBoxSupplier.Controls.Add(this.TxtCategoryDescription);
			this.GroupBoxSupplier.Controls.Add(this.label1);
			this.GroupBoxSupplier.Controls.Add(this.TxtCategpryName);
			this.GroupBoxSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.GroupBoxSupplier.Location = new System.Drawing.Point(12, 26);
			this.GroupBoxSupplier.Name = "GroupBoxSupplier";
			this.GroupBoxSupplier.Size = new System.Drawing.Size(984, 158);
			this.GroupBoxSupplier.TabIndex = 7;
			this.GroupBoxSupplier.TabStop = false;
			this.GroupBoxSupplier.Text = "Kategori Islemleri";
			// 
			// TxtCategoryImage
			// 
			this.TxtCategoryImage.Location = new System.Drawing.Point(778, 93);
			this.TxtCategoryImage.Name = "TxtCategoryImage";
			this.TxtCategoryImage.Size = new System.Drawing.Size(177, 24);
			this.TxtCategoryImage.TabIndex = 4;
			this.TxtCategoryImage.Tag = "3";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(795, 39);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(123, 18);
			this.label4.TabIndex = 2;
			this.label4.Text = "KategoryResmi";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(385, 39);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(161, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "Kategory Aciklamasi";
			// 
			// TxtCategoryDescription
			// 
			this.TxtCategoryDescription.Location = new System.Drawing.Point(301, 93);
			this.TxtCategoryDescription.Multiline = true;
			this.TxtCategoryDescription.Name = "TxtCategoryDescription";
			this.TxtCategoryDescription.Size = new System.Drawing.Size(349, 24);
			this.TxtCategoryDescription.TabIndex = 1;
			this.TxtCategoryDescription.Tag = "2";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(67, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(99, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Kategori Adi";
			// 
			// TxtCategpryName
			// 
			this.TxtCategpryName.Location = new System.Drawing.Point(25, 93);
			this.TxtCategpryName.Name = "TxtCategpryName";
			this.TxtCategpryName.Size = new System.Drawing.Size(167, 24);
			this.TxtCategpryName.TabIndex = 0;
			this.TxtCategpryName.Tag = "1";
			// 
			// BtnCikis
			// 
			this.BtnCikis.BackColor = System.Drawing.Color.Red;
			this.BtnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnCikis.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.BtnCikis.Location = new System.Drawing.Point(850, 255);
			this.BtnCikis.Name = "BtnCikis";
			this.BtnCikis.Size = new System.Drawing.Size(115, 47);
			this.BtnCikis.TabIndex = 12;
			this.BtnCikis.Text = "Cikis Yap";
			this.BtnCikis.UseVisualStyleBackColor = false;
			this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
			// 
			// CategoryOperationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1024, 768);
			this.Controls.Add(this.PanelSupplierOperations);
			this.Controls.Add(this.PanelDataGridCategoryOperation);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "CategoryOperationForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CategoryOperationForm";
			this.PanelDataGridCategoryOperation.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DataGridCategoryOperations)).EndInit();
			this.PanelSupplierOperations.ResumeLayout(false);
			this.GroupBoxSupplier.ResumeLayout(false);
			this.GroupBoxSupplier.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel PanelDataGridCategoryOperation;
		private System.Windows.Forms.DataGridView DataGridCategoryOperations;
		private System.Windows.Forms.Panel PanelSupplierOperations;
		private System.Windows.Forms.Button BtnTxtClean;
		private System.Windows.Forms.Button BtnCategoryUpdate;
		private System.Windows.Forms.Button BtnCategoryAdd;
		private System.Windows.Forms.GroupBox GroupBoxSupplier;
		private System.Windows.Forms.TextBox TxtCategoryImage;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox TxtCategoryDescription;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TxtCategpryName;
		private System.Windows.Forms.Button BtnCikis;
	}
}