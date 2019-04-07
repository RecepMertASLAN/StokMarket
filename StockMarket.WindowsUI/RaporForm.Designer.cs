namespace StockMarket.WindowsUI
{
	partial class RaporForm
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
			this.CmbSearch = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.DgvSearch = new System.Windows.Forms.DataGridView();
			this.BtnAll = new System.Windows.Forms.Button();
			this.BtnCikisYap = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.DgvSearch)).BeginInit();
			this.SuspendLayout();
			// 
			// CmbSearch
			// 
			this.CmbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.CmbSearch.FormattingEnabled = true;
			this.CmbSearch.Location = new System.Drawing.Point(231, 19);
			this.CmbSearch.Name = "CmbSearch";
			this.CmbSearch.Size = new System.Drawing.Size(121, 28);
			this.CmbSearch.TabIndex = 0;
			this.CmbSearch.SelectedIndexChanged += new System.EventHandler(this.CmbSearch_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(12, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(197, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Fiyata Gore Arama Yap";
			// 
			// DgvSearch
			// 
			this.DgvSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.DgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DgvSearch.Location = new System.Drawing.Point(14, 64);
			this.DgvSearch.Name = "DgvSearch";
			this.DgvSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DgvSearch.Size = new System.Drawing.Size(982, 529);
			this.DgvSearch.TabIndex = 2;
			// 
			// BtnAll
			// 
			this.BtnAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.BtnAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnAll.Location = new System.Drawing.Point(437, 11);
			this.BtnAll.Name = "BtnAll";
			this.BtnAll.Size = new System.Drawing.Size(189, 39);
			this.BtnAll.TabIndex = 3;
			this.BtnAll.Text = "Tumunu Goster";
			this.BtnAll.UseVisualStyleBackColor = false;
			this.BtnAll.Click += new System.EventHandler(this.BtnAll_Click);
			// 
			// BtnCikisYap
			// 
			this.BtnCikisYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.BtnCikisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnCikisYap.ForeColor = System.Drawing.Color.Snow;
			this.BtnCikisYap.Location = new System.Drawing.Point(854, 637);
			this.BtnCikisYap.Name = "BtnCikisYap";
			this.BtnCikisYap.Size = new System.Drawing.Size(142, 43);
			this.BtnCikisYap.TabIndex = 17;
			this.BtnCikisYap.Text = "CikisYap";
			this.BtnCikisYap.UseVisualStyleBackColor = false;
			this.BtnCikisYap.Click += new System.EventHandler(this.BtnCikisYap_Click);
			// 
			// RaporForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightYellow;
			this.ClientSize = new System.Drawing.Size(1024, 768);
			this.Controls.Add(this.BtnCikisYap);
			this.Controls.Add(this.BtnAll);
			this.Controls.Add(this.DgvSearch);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.CmbSearch);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "RaporForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "RaporForm";
			this.Load += new System.EventHandler(this.RaporForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.DgvSearch)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox CmbSearch;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView DgvSearch;
		private System.Windows.Forms.Button BtnAll;
		private System.Windows.Forms.Button BtnCikisYap;
	}
}