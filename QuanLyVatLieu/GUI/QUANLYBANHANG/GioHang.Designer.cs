namespace QuanLyVatLieu.GUI.QUANLYBANHANG
{
	partial class GioHang
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
			this.btHuy = new System.Windows.Forms.Button();
			this.btThanhToan = new System.Windows.Forms.Button();
			this.btThoat = new System.Windows.Forms.Button();
			this.txtTongTien = new System.Windows.Forms.TextBox();
			this.gvdata = new System.Windows.Forms.DataGridView();
			this.pnNhapLieu = new System.Windows.Forms.Panel();
			this.lbsdt = new System.Windows.Forms.Label();
			this.lbdiachi = new System.Windows.Forms.Label();
			this.lbscm = new System.Windows.Forms.Label();
			this.lbtenkh = new System.Windows.Forms.Label();
			this.dtngaysinh = new System.Windows.Forms.DateTimePicker();
			this.cbbgioitinh = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbdiachi = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.tbSDT = new System.Windows.Forms.TextBox();
			this.tbSCM = new System.Windows.Forms.TextBox();
			this.tbtenkh = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.tbTinhTrang = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.gvdata)).BeginInit();
			this.pnNhapLieu.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btHuy
			// 
			this.btHuy.BackColor = System.Drawing.Color.OrangeRed;
			this.btHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btHuy.ForeColor = System.Drawing.Color.White;
			this.btHuy.Location = new System.Drawing.Point(416, 529);
			this.btHuy.Name = "btHuy";
			this.btHuy.Size = new System.Drawing.Size(156, 50);
			this.btHuy.TabIndex = 46;
			this.btHuy.Text = "            Hủy";
			this.btHuy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btHuy.UseVisualStyleBackColor = false;
			this.btHuy.Click += new System.EventHandler(this.BtHuy_Click);
			// 
			// btThanhToan
			// 
			this.btThanhToan.BackColor = System.Drawing.Color.OrangeRed;
			this.btThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btThanhToan.ForeColor = System.Drawing.Color.White;
			this.btThanhToan.Location = new System.Drawing.Point(578, 529);
			this.btThanhToan.Name = "btThanhToan";
			this.btThanhToan.Size = new System.Drawing.Size(156, 50);
			this.btThanhToan.TabIndex = 39;
			this.btThanhToan.Text = "        Thanh Toán";
			this.btThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btThanhToan.UseVisualStyleBackColor = false;
			this.btThanhToan.Click += new System.EventHandler(this.BtThanhToan_Click);
			// 
			// btThoat
			// 
			this.btThoat.BackColor = System.Drawing.Color.OrangeRed;
			this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btThoat.ForeColor = System.Drawing.Color.White;
			this.btThoat.Location = new System.Drawing.Point(743, 529);
			this.btThoat.Name = "btThoat";
			this.btThoat.Size = new System.Drawing.Size(156, 50);
			this.btThoat.TabIndex = 40;
			this.btThoat.Text = "           Thoát";
			this.btThoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btThoat.UseVisualStyleBackColor = false;
			// 
			// txtTongTien
			// 
			this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTongTien.Location = new System.Drawing.Point(121, 537);
			this.txtTongTien.Name = "txtTongTien";
			this.txtTongTien.ReadOnly = true;
			this.txtTongTien.Size = new System.Drawing.Size(188, 26);
			this.txtTongTien.TabIndex = 43;
			// 
			// gvdata
			// 
			this.gvdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvdata.Location = new System.Drawing.Point(1, 187);
			this.gvdata.Name = "gvdata";
			this.gvdata.ReadOnly = true;
			this.gvdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gvdata.Size = new System.Drawing.Size(896, 336);
			this.gvdata.TabIndex = 14;
			this.gvdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gvdata_CellContentClick);
			// 
			// pnNhapLieu
			// 
			this.pnNhapLieu.BackColor = System.Drawing.Color.White;
			this.pnNhapLieu.Controls.Add(this.label6);
			this.pnNhapLieu.Controls.Add(this.tbTinhTrang);
			this.pnNhapLieu.Controls.Add(this.lbsdt);
			this.pnNhapLieu.Controls.Add(this.lbdiachi);
			this.pnNhapLieu.Controls.Add(this.lbscm);
			this.pnNhapLieu.Controls.Add(this.lbtenkh);
			this.pnNhapLieu.Controls.Add(this.dtngaysinh);
			this.pnNhapLieu.Controls.Add(this.cbbgioitinh);
			this.pnNhapLieu.Controls.Add(this.label1);
			this.pnNhapLieu.Controls.Add(this.label2);
			this.pnNhapLieu.Controls.Add(this.tbdiachi);
			this.pnNhapLieu.Controls.Add(this.label3);
			this.pnNhapLieu.Controls.Add(this.label4);
			this.pnNhapLieu.Controls.Add(this.label5);
			this.pnNhapLieu.Controls.Add(this.tbSDT);
			this.pnNhapLieu.Controls.Add(this.tbSCM);
			this.pnNhapLieu.Controls.Add(this.tbtenkh);
			this.pnNhapLieu.Controls.Add(this.label7);
			this.pnNhapLieu.ForeColor = System.Drawing.Color.Black;
			this.pnNhapLieu.Location = new System.Drawing.Point(3, 3);
			this.pnNhapLieu.Name = "pnNhapLieu";
			this.pnNhapLieu.Size = new System.Drawing.Size(896, 178);
			this.pnNhapLieu.TabIndex = 48;
			this.pnNhapLieu.TabStop = true;
			// 
			// lbsdt
			// 
			this.lbsdt.AutoSize = true;
			this.lbsdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbsdt.ForeColor = System.Drawing.Color.Red;
			this.lbsdt.Location = new System.Drawing.Point(626, 43);
			this.lbsdt.Name = "lbsdt";
			this.lbsdt.Size = new System.Drawing.Size(0, 13);
			this.lbsdt.TabIndex = 36;
			// 
			// lbdiachi
			// 
			this.lbdiachi.AutoSize = true;
			this.lbdiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbdiachi.ForeColor = System.Drawing.Color.Red;
			this.lbdiachi.Location = new System.Drawing.Point(626, 127);
			this.lbdiachi.Name = "lbdiachi";
			this.lbdiachi.Size = new System.Drawing.Size(0, 13);
			this.lbdiachi.TabIndex = 35;
			// 
			// lbscm
			// 
			this.lbscm.AutoSize = true;
			this.lbscm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbscm.ForeColor = System.Drawing.Color.Red;
			this.lbscm.Location = new System.Drawing.Point(203, 85);
			this.lbscm.Name = "lbscm";
			this.lbscm.Size = new System.Drawing.Size(0, 13);
			this.lbscm.TabIndex = 34;
			// 
			// lbtenkh
			// 
			this.lbtenkh.AutoSize = true;
			this.lbtenkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbtenkh.ForeColor = System.Drawing.Color.Red;
			this.lbtenkh.Location = new System.Drawing.Point(203, 40);
			this.lbtenkh.Name = "lbtenkh";
			this.lbtenkh.Size = new System.Drawing.Size(0, 13);
			this.lbtenkh.TabIndex = 33;
			// 
			// dtngaysinh
			// 
			this.dtngaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtngaysinh.Location = new System.Drawing.Point(627, 57);
			this.dtngaysinh.Name = "dtngaysinh";
			this.dtngaysinh.Size = new System.Drawing.Size(231, 26);
			this.dtngaysinh.TabIndex = 32;
			// 
			// cbbgioitinh
			// 
			this.cbbgioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbbgioitinh.FormattingEnabled = true;
			this.cbbgioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
			this.cbbgioitinh.Location = new System.Drawing.Point(205, 101);
			this.cbbgioitinh.Name = "cbbgioitinh";
			this.cbbgioitinh.Size = new System.Drawing.Size(232, 28);
			this.cbbgioitinh.TabIndex = 31;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(461, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 20);
			this.label1.TabIndex = 29;
			this.label1.Text = "SĐT:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(38, 17);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 20);
			this.label2.TabIndex = 30;
			this.label2.Text = "Tên KH:";
			// 
			// tbdiachi
			// 
			this.tbdiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbdiachi.Location = new System.Drawing.Point(627, 98);
			this.tbdiachi.Name = "tbdiachi";
			this.tbdiachi.Size = new System.Drawing.Size(232, 26);
			this.tbdiachi.TabIndex = 24;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(38, 62);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(75, 20);
			this.label3.TabIndex = 28;
			this.label3.Text = "CMTND:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(38, 105);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(85, 20);
			this.label4.TabIndex = 27;
			this.label4.Text = "Giới Tính:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(461, 62);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(95, 20);
			this.label5.TabIndex = 26;
			this.label5.Text = "Ngày Sinh:";
			// 
			// tbSDT
			// 
			this.tbSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbSDT.Location = new System.Drawing.Point(628, 14);
			this.tbSDT.Name = "tbSDT";
			this.tbSDT.Size = new System.Drawing.Size(231, 26);
			this.tbSDT.TabIndex = 21;
			// 
			// tbSCM
			// 
			this.tbSCM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbSCM.Location = new System.Drawing.Point(205, 56);
			this.tbSCM.Name = "tbSCM";
			this.tbSCM.Size = new System.Drawing.Size(231, 26);
			this.tbSCM.TabIndex = 23;
			// 
			// tbtenkh
			// 
			this.tbtenkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbtenkh.Location = new System.Drawing.Point(206, 11);
			this.tbtenkh.Name = "tbtenkh";
			this.tbtenkh.Size = new System.Drawing.Size(231, 26);
			this.tbtenkh.TabIndex = 22;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(461, 105);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(72, 20);
			this.label7.TabIndex = 25;
			this.label7.Text = "Địa Chỉ:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(26, 543);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(89, 20);
			this.label8.TabIndex = 42;
			this.label8.Text = "Tổng tiền:";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Controls.Add(this.pnNhapLieu);
			this.panel2.Controls.Add(this.btHuy);
			this.panel2.Controls.Add(this.btThanhToan);
			this.panel2.Controls.Add(this.btThoat);
			this.panel2.Controls.Add(this.txtTongTien);
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(this.gvdata);
			this.panel2.Location = new System.Drawing.Point(12, 12);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(929, 593);
			this.panel2.TabIndex = 7;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(38, 146);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(99, 20);
			this.label6.TabIndex = 38;
			this.label6.Text = "Tình Trạng:";
			// 
			// tbTinhTrang
			// 
			this.tbTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbTinhTrang.Location = new System.Drawing.Point(206, 140);
			this.tbTinhTrang.Name = "tbTinhTrang";
			this.tbTinhTrang.Size = new System.Drawing.Size(231, 26);
			this.tbTinhTrang.TabIndex = 37;
			// 
			// GioHang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(945, 609);
			this.Controls.Add(this.panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "GioHang";
			this.Text = "GioHang";
			((System.ComponentModel.ISupportInitialize)(this.gvdata)).EndInit();
			this.pnNhapLieu.ResumeLayout(false);
			this.pnNhapLieu.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btHuy;
		private System.Windows.Forms.Button btThanhToan;
		private System.Windows.Forms.Button btThoat;
		private System.Windows.Forms.TextBox txtTongTien;
		private System.Windows.Forms.DataGridView gvdata;
		private System.Windows.Forms.Panel pnNhapLieu;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label lbsdt;
		private System.Windows.Forms.Label lbdiachi;
		private System.Windows.Forms.Label lbscm;
		private System.Windows.Forms.Label lbtenkh;
		private System.Windows.Forms.DateTimePicker dtngaysinh;
		private System.Windows.Forms.ComboBox cbbgioitinh;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbdiachi;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbSDT;
		private System.Windows.Forms.TextBox tbSCM;
		private System.Windows.Forms.TextBox tbtenkh;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tbTinhTrang;
	}
}