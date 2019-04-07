namespace StockMarket.WindowsUI
{
	partial class AnaForm
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.BtnRapor = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.BtnSatis = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(283, 438);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(231, 29);
			this.label2.TabIndex = 5;
			this.label2.Text = "Tedarikci Islemleri";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(64, 212);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(179, 29);
			this.label3.TabIndex = 0;
			this.label3.Text = "Satis Islemleri";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(309, 212);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(173, 29);
			this.label4.TabIndex = 7;
			this.label4.Text = "Stok Islemleri";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(46, 438);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(220, 29);
			this.label5.TabIndex = 8;
			this.label5.Text = "Kategori Islemleri";
			// 
			// BtnRapor
			// 
			this.BtnRapor.BackgroundImage = global::StockMarket.WindowsUI.Properties.Resources.IconRapor1;
			this.BtnRapor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.BtnRapor.Location = new System.Drawing.Point(520, 188);
			this.BtnRapor.Name = "BtnRapor";
			this.BtnRapor.Size = new System.Drawing.Size(134, 121);
			this.BtnRapor.TabIndex = 9;
			this.BtnRapor.UseVisualStyleBackColor = true;
			this.BtnRapor.Click += new System.EventHandler(this.BtnRapor_Click);
			// 
			// button3
			// 
			this.button3.BackgroundImage = global::StockMarket.WindowsUI.Properties.Resources.IconStockKamyon;
			this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button3.Location = new System.Drawing.Point(304, 263);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(190, 160);
			this.button3.TabIndex = 4;
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.BackgroundImage = global::StockMarket.WindowsUI.Properties.Resources.IconCategory2;
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.button2.ImageKey = "(none)";
			this.button2.Location = new System.Drawing.Point(60, 263);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(190, 160);
			this.button2.TabIndex = 3;
			this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.BackgroundImage = global::StockMarket.WindowsUI.Properties.Resources.IconSatisSonrasi;
			this.button1.Location = new System.Drawing.Point(304, 32);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(190, 160);
			this.button1.TabIndex = 2;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// BtnSatis
			// 
			this.BtnSatis.BackgroundImage = global::StockMarket.WindowsUI.Properties.Resources.IconAlisVeris;
			this.BtnSatis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.BtnSatis.Location = new System.Drawing.Point(60, 32);
			this.BtnSatis.Name = "BtnSatis";
			this.BtnSatis.Size = new System.Drawing.Size(190, 160);
			this.BtnSatis.TabIndex = 1;
			this.BtnSatis.UseVisualStyleBackColor = true;
			this.BtnSatis.Click += new System.EventHandler(this.BtnSatis_Click);
			// 
			// AnaForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(666, 522);
			this.Controls.Add(this.BtnRapor);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.BtnSatis);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AnaForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bakkal Huseyin Abi";
			this.Load += new System.EventHandler(this.AnaForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button BtnSatis;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button BtnRapor;
	}
}