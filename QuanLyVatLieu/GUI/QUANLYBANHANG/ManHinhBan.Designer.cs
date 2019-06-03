namespace QuanLyVatLieu.GUI.QUANLYBANHANG
{
	partial class ManHinhBan
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManHinhBan));
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnThanhToan = new System.Windows.Forms.Button();
			this.btnThemVaoGio = new System.Windows.Forms.Button();
			this.nbsoluong = new System.Windows.Forms.NumericUpDown();
			this.label8 = new System.Windows.Forms.Label();
			this.pndata = new System.Windows.Forms.Panel();
			this.pcSearch = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btLamMoi = new System.Windows.Forms.Button();
			this.tbTimKiem = new System.Windows.Forms.TextBox();
			this.gvdata = new System.Windows.Forms.DataGridView();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.btnThongKeBanHang = new System.Windows.Forms.Button();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nbsoluong)).BeginInit();
			this.pndata.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pcSearch)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvdata)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Controls.Add(this.btnThanhToan);
			this.panel2.Controls.Add(this.btnThemVaoGio);
			this.panel2.Controls.Add(this.nbsoluong);
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(this.pndata);
			this.panel2.Controls.Add(this.gvdata);
			this.panel2.Location = new System.Drawing.Point(-4, 12);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(903, 540);
			this.panel2.TabIndex = 46;
			// 
			// btnThanhToan
			// 
			this.btnThanhToan.BackColor = System.Drawing.Color.OrangeRed;
			this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThanhToan.ForeColor = System.Drawing.Color.White;
			this.btnThanhToan.Location = new System.Drawing.Point(738, 16);
			this.btnThanhToan.Name = "btnThanhToan";
			this.btnThanhToan.Size = new System.Drawing.Size(146, 45);
			this.btnThanhToan.TabIndex = 45;
			this.btnThanhToan.Text = "Thanh Toán";
			this.btnThanhToan.UseVisualStyleBackColor = false;
			this.btnThanhToan.Click += new System.EventHandler(this.BtnThanhToan_Click);
			// 
			// btnThemVaoGio
			// 
			this.btnThemVaoGio.BackColor = System.Drawing.Color.OrangeRed;
			this.btnThemVaoGio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThemVaoGio.ForeColor = System.Drawing.Color.White;
			this.btnThemVaoGio.Location = new System.Drawing.Point(586, 16);
			this.btnThemVaoGio.Name = "btnThemVaoGio";
			this.btnThemVaoGio.Size = new System.Drawing.Size(146, 45);
			this.btnThemVaoGio.TabIndex = 44;
			this.btnThemVaoGio.Text = "Thêm Vào Giỏ";
			this.btnThemVaoGio.UseVisualStyleBackColor = false;
			this.btnThemVaoGio.Click += new System.EventHandler(this.BtnThemVaoGio_Click);
			// 
			// nbsoluong
			// 
			this.nbsoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nbsoluong.Location = new System.Drawing.Point(496, 29);
			this.nbsoluong.Name = "nbsoluong";
			this.nbsoluong.Size = new System.Drawing.Size(84, 26);
			this.nbsoluong.TabIndex = 43;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(399, 31);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(91, 20);
			this.label8.TabIndex = 42;
			this.label8.Text = "Số Lượng:";
			// 
			// pndata
			// 
			this.pndata.BackColor = System.Drawing.Color.White;
			this.pndata.Controls.Add(this.pcSearch);
			this.pndata.Controls.Add(this.label2);
			this.pndata.Controls.Add(this.btLamMoi);
			this.pndata.Controls.Add(this.tbTimKiem);
			this.pndata.Location = new System.Drawing.Point(6, 16);
			this.pndata.Name = "pndata";
			this.pndata.Size = new System.Drawing.Size(387, 58);
			this.pndata.TabIndex = 25;
			// 
			// pcSearch
			// 
			this.pcSearch.Image = ((System.Drawing.Image)(resources.GetObject("pcSearch.Image")));
			this.pcSearch.Location = new System.Drawing.Point(228, 15);
			this.pcSearch.Name = "pcSearch";
			this.pcSearch.Size = new System.Drawing.Size(32, 26);
			this.pcSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pcSearch.TabIndex = 14;
			this.pcSearch.TabStop = false;
			this.pcSearch.Click += new System.EventHandler(this.PcSearch_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(41, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 13);
			this.label2.TabIndex = 13;
			this.label2.Text = "Tìm kiếm";
			// 
			// btLamMoi
			// 
			this.btLamMoi.BackColor = System.Drawing.Color.OrangeRed;
			this.btLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btLamMoi.ForeColor = System.Drawing.Color.White;
			this.btLamMoi.Location = new System.Drawing.Point(266, 3);
			this.btLamMoi.Name = "btLamMoi";
			this.btLamMoi.Size = new System.Drawing.Size(104, 48);
			this.btLamMoi.TabIndex = 12;
			this.btLamMoi.Text = "Làm Mới";
			this.btLamMoi.UseVisualStyleBackColor = false;
			this.btLamMoi.Click += new System.EventHandler(this.BtLamMoi_Click);
			// 
			// tbTimKiem
			// 
			this.tbTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbTimKiem.Location = new System.Drawing.Point(18, 15);
			this.tbTimKiem.Name = "tbTimKiem";
			this.tbTimKiem.Size = new System.Drawing.Size(203, 26);
			this.tbTimKiem.TabIndex = 11;
			// 
			// gvdata
			// 
			this.gvdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvdata.Location = new System.Drawing.Point(6, 80);
			this.gvdata.Name = "gvdata";
			this.gvdata.ReadOnly = true;
			this.gvdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gvdata.Size = new System.Drawing.Size(897, 457);
			this.gvdata.TabIndex = 14;
			// 
			// btnThongKeBanHang
			// 
			this.btnThongKeBanHang.BackColor = System.Drawing.Color.OrangeRed;
			this.btnThongKeBanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThongKeBanHang.ForeColor = System.Drawing.Color.White;
			this.btnThongKeBanHang.Location = new System.Drawing.Point(715, 555);
			this.btnThongKeBanHang.Name = "btnThongKeBanHang";
			this.btnThongKeBanHang.Size = new System.Drawing.Size(184, 48);
			this.btnThongKeBanHang.TabIndex = 46;
			this.btnThongKeBanHang.Text = "Thống Kê Bán Hàng";
			this.btnThongKeBanHang.UseVisualStyleBackColor = false;
			this.btnThongKeBanHang.Click += new System.EventHandler(this.BtnThongKeBanHang_Click);
			// 
			// ManHinhBan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(911, 610);
			this.Controls.Add(this.btnThongKeBanHang);
			this.Controls.Add(this.panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ManHinhBan";
			this.Text = "ManHinhBan";
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nbsoluong)).EndInit();
			this.pndata.ResumeLayout(false);
			this.pndata.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pcSearch)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvdata)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel pndata;
		private System.Windows.Forms.PictureBox pcSearch;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btLamMoi;
		private System.Windows.Forms.TextBox tbTimKiem;
		private System.Windows.Forms.DataGridView gvdata;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Button btnThanhToan;
		private System.Windows.Forms.Button btnThemVaoGio;
		private System.Windows.Forms.NumericUpDown nbsoluong;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnThongKeBanHang;
	}
}