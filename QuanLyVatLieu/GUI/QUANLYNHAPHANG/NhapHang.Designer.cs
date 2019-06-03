namespace QuanLyVatLieu.GUI.QUANLYNHAPHANG
{
	partial class NhapHang
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
			this.gvdata = new System.Windows.Forms.DataGridView();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnThongKe = new System.Windows.Forms.Button();
			this.btnHuy = new System.Windows.Forms.Button();
			this.btnUpdateSL = new System.Windows.Forms.Button();
			this.txtTongTien = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.pnmenu = new System.Windows.Forms.Panel();
			this.lbsoluong = new System.Windows.Forms.Label();
			this.lbmahh = new System.Windows.Forms.Label();
			this.nbsoluong = new System.Windows.Forms.NumericUpDown();
			this.cbbmahang = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lbTenHang = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.gvdata)).BeginInit();
			this.panel2.SuspendLayout();
			this.pnmenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nbsoluong)).BeginInit();
			this.SuspendLayout();
			// 
			// gvdata
			// 
			this.gvdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvdata.Location = new System.Drawing.Point(12, 201);
			this.gvdata.Name = "gvdata";
			this.gvdata.ReadOnly = true;
			this.gvdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gvdata.Size = new System.Drawing.Size(896, 315);
			this.gvdata.TabIndex = 14;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Controls.Add(this.gvdata);
			this.panel2.Controls.Add(this.btnThongKe);
			this.panel2.Controls.Add(this.btnHuy);
			this.panel2.Controls.Add(this.btnUpdateSL);
			this.panel2.Controls.Add(this.txtTongTien);
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(this.pnmenu);
			this.panel2.Location = new System.Drawing.Point(4, 12);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(920, 589);
			this.panel2.TabIndex = 10;
			// 
			// btnThongKe
			// 
			this.btnThongKe.BackColor = System.Drawing.Color.OrangeRed;
			this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThongKe.ForeColor = System.Drawing.Color.White;
			this.btnThongKe.Location = new System.Drawing.Point(713, 520);
			this.btnThongKe.Name = "btnThongKe";
			this.btnThongKe.Size = new System.Drawing.Size(193, 48);
			this.btnThongKe.TabIndex = 51;
			this.btnThongKe.Text = "Thống Kê Nhập Hàng";
			this.btnThongKe.UseVisualStyleBackColor = false;
			this.btnThongKe.Click += new System.EventHandler(this.BtnThongKe_Click);
			// 
			// btnHuy
			// 
			this.btnHuy.BackColor = System.Drawing.Color.OrangeRed;
			this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHuy.ForeColor = System.Drawing.Color.White;
			this.btnHuy.Location = new System.Drawing.Point(803, 147);
			this.btnHuy.Name = "btnHuy";
			this.btnHuy.Size = new System.Drawing.Size(104, 48);
			this.btnHuy.TabIndex = 50;
			this.btnHuy.Text = "Hủy";
			this.btnHuy.UseVisualStyleBackColor = false;
			this.btnHuy.Click += new System.EventHandler(this.BtnHuy_Click);
			// 
			// btnUpdateSL
			// 
			this.btnUpdateSL.BackColor = System.Drawing.Color.OrangeRed;
			this.btnUpdateSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdateSL.ForeColor = System.Drawing.Color.White;
			this.btnUpdateSL.Location = new System.Drawing.Point(675, 147);
			this.btnUpdateSL.Name = "btnUpdateSL";
			this.btnUpdateSL.Size = new System.Drawing.Size(104, 48);
			this.btnUpdateSL.TabIndex = 49;
			this.btnUpdateSL.Text = "Update";
			this.btnUpdateSL.UseVisualStyleBackColor = false;
			this.btnUpdateSL.Click += new System.EventHandler(this.BtnNhapHang_Click);
			// 
			// txtTongTien
			// 
			this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTongTien.Location = new System.Drawing.Point(130, 531);
			this.txtTongTien.Name = "txtTongTien";
			this.txtTongTien.ReadOnly = true;
			this.txtTongTien.Size = new System.Drawing.Size(188, 26);
			this.txtTongTien.TabIndex = 41;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(35, 537);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(89, 20);
			this.label8.TabIndex = 40;
			this.label8.Text = "Tổng tiền:";
			// 
			// pnmenu
			// 
			this.pnmenu.BackColor = System.Drawing.Color.White;
			this.pnmenu.Controls.Add(this.lbTenHang);
			this.pnmenu.Controls.Add(this.label1);
			this.pnmenu.Controls.Add(this.lbsoluong);
			this.pnmenu.Controls.Add(this.lbmahh);
			this.pnmenu.Controls.Add(this.nbsoluong);
			this.pnmenu.Controls.Add(this.cbbmahang);
			this.pnmenu.Controls.Add(this.label4);
			this.pnmenu.Controls.Add(this.label5);
			this.pnmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pnmenu.ForeColor = System.Drawing.Color.Black;
			this.pnmenu.Location = new System.Drawing.Point(12, 13);
			this.pnmenu.Name = "pnmenu";
			this.pnmenu.Size = new System.Drawing.Size(896, 128);
			this.pnmenu.TabIndex = 9;
			this.pnmenu.TabStop = true;
			// 
			// lbsoluong
			// 
			this.lbsoluong.AutoSize = true;
			this.lbsoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbsoluong.ForeColor = System.Drawing.Color.Red;
			this.lbsoluong.Location = new System.Drawing.Point(635, 60);
			this.lbsoluong.Name = "lbsoluong";
			this.lbsoluong.Size = new System.Drawing.Size(0, 13);
			this.lbsoluong.TabIndex = 43;
			// 
			// lbmahh
			// 
			this.lbmahh.AutoSize = true;
			this.lbmahh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbmahh.ForeColor = System.Drawing.Color.Red;
			this.lbmahh.Location = new System.Drawing.Point(176, 60);
			this.lbmahh.Name = "lbmahh";
			this.lbmahh.Size = new System.Drawing.Size(0, 13);
			this.lbmahh.TabIndex = 41;
			// 
			// nbsoluong
			// 
			this.nbsoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nbsoluong.Location = new System.Drawing.Point(638, 26);
			this.nbsoluong.Name = "nbsoluong";
			this.nbsoluong.Size = new System.Drawing.Size(209, 26);
			this.nbsoluong.TabIndex = 7;
			// 
			// cbbmahang
			// 
			this.cbbmahang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbmahang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbbmahang.FormattingEnabled = true;
			this.cbbmahang.Location = new System.Drawing.Point(179, 29);
			this.cbbmahang.Name = "cbbmahang";
			this.cbbmahang.Size = new System.Drawing.Size(209, 28);
			this.cbbmahang.TabIndex = 5;
			this.cbbmahang.SelectedIndexChanged += new System.EventHandler(this.Cbbmahang_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(23, 36);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(118, 20);
			this.label4.TabIndex = 37;
			this.label4.Text = "Mã hàng hóa:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(518, 32);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(80, 20);
			this.label5.TabIndex = 36;
			this.label5.Text = "Số lượng";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(23, 84);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(124, 20);
			this.label1.TabIndex = 44;
			this.label1.Text = "Tên hàng hóa:";
			// 
			// lbTenHang
			// 
			this.lbTenHang.AutoSize = true;
			this.lbTenHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTenHang.Location = new System.Drawing.Point(182, 84);
			this.lbTenHang.Name = "lbTenHang";
			this.lbTenHang.Size = new System.Drawing.Size(92, 20);
			this.lbTenHang.TabIndex = 45;
			this.lbTenHang.Text = "Tên Hàng:";
			// 
			// NhapHang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(929, 608);
			this.Controls.Add(this.panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "NhapHang";
			this.Text = "NhapHang";
			((System.ComponentModel.ISupportInitialize)(this.gvdata)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.pnmenu.ResumeLayout(false);
			this.pnmenu.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nbsoluong)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView gvdata;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox txtTongTien;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Panel pnmenu;
		private System.Windows.Forms.Label lbsoluong;
		private System.Windows.Forms.Label lbmahh;
		private System.Windows.Forms.NumericUpDown nbsoluong;
		private System.Windows.Forms.ComboBox cbbmahang;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnThongKe;
		private System.Windows.Forms.Button btnHuy;
		private System.Windows.Forms.Button btnUpdateSL;
		private System.Windows.Forms.Label lbTenHang;
		private System.Windows.Forms.Label label1;
	}
}