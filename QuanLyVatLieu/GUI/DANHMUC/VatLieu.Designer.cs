namespace QuanLyVatLieu.GUI.DANHMUC
{
	partial class VatLieu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VatLieu));
			this.pcEdit = new System.Windows.Forms.PictureBox();
			this.pndata = new System.Windows.Forms.Panel();
			this.pcSearch = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btLamMoi = new System.Windows.Forms.Button();
			this.tbTimKiem = new System.Windows.Forms.TextBox();
			this.pcSave = new System.Windows.Forms.PictureBox();
			this.gvdata = new System.Windows.Forms.DataGridView();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pcDelete = new System.Windows.Forms.PictureBox();
			this.pnmenu = new System.Windows.Forms.Panel();
			this.lbsoluong = new System.Windows.Forms.Label();
			this.lbgianhap = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.tbgianhap = new System.Windows.Forms.TextBox();
			this.cbbmancc = new System.Windows.Forms.ComboBox();
			this.lbdongia = new System.Windows.Forms.Label();
			this.lbmalk = new System.Windows.Forms.Label();
			this.lbtenlk = new System.Windows.Forms.Label();
			this.lbmancc = new System.Windows.Forms.Label();
			this.lbloaihang = new System.Windows.Forms.Label();
			this.lbnhanhieu = new System.Windows.Forms.Label();
			this.rtbMoTa = new System.Windows.Forms.RichTextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tbNhanHieu = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tbLoaiHang = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.tbSoLuong = new System.Windows.Forms.TextBox();
			this.tbDonGia = new System.Windows.Forms.TextBox();
			this.tbTenVatLieu = new System.Windows.Forms.TextBox();
			this.tbMaVatLieu = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pcEdit)).BeginInit();
			this.pndata.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pcSearch)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pcSave)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvdata)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pcDelete)).BeginInit();
			this.pnmenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// pcEdit
			// 
			this.pcEdit.Image = ((System.Drawing.Image)(resources.GetObject("pcEdit.Image")));
			this.pcEdit.Location = new System.Drawing.Point(691, 261);
			this.pcEdit.Name = "pcEdit";
			this.pcEdit.Size = new System.Drawing.Size(73, 58);
			this.pcEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pcEdit.TabIndex = 27;
			this.pcEdit.TabStop = false;
			this.pcEdit.Click += new System.EventHandler(this.PcEdit_Click);
			// 
			// pndata
			// 
			this.pndata.BackColor = System.Drawing.Color.White;
			this.pndata.Controls.Add(this.pcSearch);
			this.pndata.Controls.Add(this.label2);
			this.pndata.Controls.Add(this.btLamMoi);
			this.pndata.Controls.Add(this.tbTimKiem);
			this.pndata.Location = new System.Drawing.Point(8, 261);
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
			// pcSave
			// 
			this.pcSave.Image = ((System.Drawing.Image)(resources.GetObject("pcSave.Image")));
			this.pcSave.Location = new System.Drawing.Point(607, 261);
			this.pcSave.Name = "pcSave";
			this.pcSave.Size = new System.Drawing.Size(64, 58);
			this.pcSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pcSave.TabIndex = 26;
			this.pcSave.TabStop = false;
			this.pcSave.Click += new System.EventHandler(this.PcSave_Click);
			// 
			// gvdata
			// 
			this.gvdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvdata.Location = new System.Drawing.Point(8, 325);
			this.gvdata.Name = "gvdata";
			this.gvdata.ReadOnly = true;
			this.gvdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gvdata.Size = new System.Drawing.Size(896, 253);
			this.gvdata.TabIndex = 14;
			this.gvdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gvdata_CellContentClick);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Controls.Add(this.pcDelete);
			this.panel2.Controls.Add(this.pcEdit);
			this.panel2.Controls.Add(this.pcSave);
			this.panel2.Controls.Add(this.pndata);
			this.panel2.Controls.Add(this.gvdata);
			this.panel2.Controls.Add(this.pnmenu);
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(909, 594);
			this.panel2.TabIndex = 45;
			// 
			// pcDelete
			// 
			this.pcDelete.Image = ((System.Drawing.Image)(resources.GetObject("pcDelete.Image")));
			this.pcDelete.Location = new System.Drawing.Point(781, 262);
			this.pcDelete.Name = "pcDelete";
			this.pcDelete.Size = new System.Drawing.Size(88, 57);
			this.pcDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pcDelete.TabIndex = 28;
			this.pcDelete.TabStop = false;
			this.pcDelete.Click += new System.EventHandler(this.PcDelete_Click);
			// 
			// pnmenu
			// 
			this.pnmenu.BackColor = System.Drawing.Color.White;
			this.pnmenu.Controls.Add(this.lbsoluong);
			this.pnmenu.Controls.Add(this.lbgianhap);
			this.pnmenu.Controls.Add(this.label9);
			this.pnmenu.Controls.Add(this.tbgianhap);
			this.pnmenu.Controls.Add(this.cbbmancc);
			this.pnmenu.Controls.Add(this.lbdongia);
			this.pnmenu.Controls.Add(this.lbmalk);
			this.pnmenu.Controls.Add(this.lbtenlk);
			this.pnmenu.Controls.Add(this.lbmancc);
			this.pnmenu.Controls.Add(this.lbloaihang);
			this.pnmenu.Controls.Add(this.lbnhanhieu);
			this.pnmenu.Controls.Add(this.rtbMoTa);
			this.pnmenu.Controls.Add(this.label8);
			this.pnmenu.Controls.Add(this.label1);
			this.pnmenu.Controls.Add(this.tbNhanHieu);
			this.pnmenu.Controls.Add(this.label6);
			this.pnmenu.Controls.Add(this.label3);
			this.pnmenu.Controls.Add(this.tbLoaiHang);
			this.pnmenu.Controls.Add(this.label4);
			this.pnmenu.Controls.Add(this.label5);
			this.pnmenu.Controls.Add(this.label7);
			this.pnmenu.Controls.Add(this.tbSoLuong);
			this.pnmenu.Controls.Add(this.tbDonGia);
			this.pnmenu.Controls.Add(this.tbTenVatLieu);
			this.pnmenu.Controls.Add(this.tbMaVatLieu);
			this.pnmenu.Controls.Add(this.label10);
			this.pnmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pnmenu.ForeColor = System.Drawing.Color.Black;
			this.pnmenu.Location = new System.Drawing.Point(8, 12);
			this.pnmenu.Name = "pnmenu";
			this.pnmenu.Size = new System.Drawing.Size(891, 243);
			this.pnmenu.TabIndex = 9;
			this.pnmenu.TabStop = true;
			// 
			// lbsoluong
			// 
			this.lbsoluong.AutoSize = true;
			this.lbsoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbsoluong.ForeColor = System.Drawing.Color.Red;
			this.lbsoluong.Location = new System.Drawing.Point(598, 129);
			this.lbsoluong.Name = "lbsoluong";
			this.lbsoluong.Size = new System.Drawing.Size(0, 13);
			this.lbsoluong.TabIndex = 54;
			// 
			// lbgianhap
			// 
			this.lbgianhap.AutoSize = true;
			this.lbgianhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbgianhap.ForeColor = System.Drawing.Color.Red;
			this.lbgianhap.Location = new System.Drawing.Point(598, 40);
			this.lbgianhap.Name = "lbgianhap";
			this.lbgianhap.Size = new System.Drawing.Size(0, 13);
			this.lbgianhap.TabIndex = 53;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(491, 16);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(89, 20);
			this.label9.TabIndex = 52;
			this.label9.Text = "Giá Nhập:";
			// 
			// tbgianhap
			// 
			this.tbgianhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbgianhap.Location = new System.Drawing.Point(601, 11);
			this.tbgianhap.Name = "tbgianhap";
			this.tbgianhap.Size = new System.Drawing.Size(267, 26);
			this.tbgianhap.TabIndex = 51;
			// 
			// cbbmancc
			// 
			this.cbbmancc.FormattingEnabled = true;
			this.cbbmancc.Location = new System.Drawing.Point(190, 104);
			this.cbbmancc.Name = "cbbmancc";
			this.cbbmancc.Size = new System.Drawing.Size(232, 28);
			this.cbbmancc.TabIndex = 50;
			// 
			// lbdongia
			// 
			this.lbdongia.AutoSize = true;
			this.lbdongia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbdongia.ForeColor = System.Drawing.Color.Red;
			this.lbdongia.Location = new System.Drawing.Point(598, 85);
			this.lbdongia.Name = "lbdongia";
			this.lbdongia.Size = new System.Drawing.Size(0, 13);
			this.lbdongia.TabIndex = 49;
			// 
			// lbmalk
			// 
			this.lbmalk.AutoSize = true;
			this.lbmalk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbmalk.ForeColor = System.Drawing.Color.Red;
			this.lbmalk.Location = new System.Drawing.Point(188, 39);
			this.lbmalk.Name = "lbmalk";
			this.lbmalk.Size = new System.Drawing.Size(0, 13);
			this.lbmalk.TabIndex = 48;
			// 
			// lbtenlk
			// 
			this.lbtenlk.AutoSize = true;
			this.lbtenlk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbtenlk.ForeColor = System.Drawing.Color.Red;
			this.lbtenlk.Location = new System.Drawing.Point(188, 84);
			this.lbtenlk.Name = "lbtenlk";
			this.lbtenlk.Size = new System.Drawing.Size(0, 13);
			this.lbtenlk.TabIndex = 47;
			// 
			// lbmancc
			// 
			this.lbmancc.AutoSize = true;
			this.lbmancc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbmancc.ForeColor = System.Drawing.Color.Red;
			this.lbmancc.Location = new System.Drawing.Point(188, 129);
			this.lbmancc.Name = "lbmancc";
			this.lbmancc.Size = new System.Drawing.Size(0, 13);
			this.lbmancc.TabIndex = 46;
			// 
			// lbloaihang
			// 
			this.lbloaihang.AutoSize = true;
			this.lbloaihang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbloaihang.ForeColor = System.Drawing.Color.Red;
			this.lbloaihang.Location = new System.Drawing.Point(188, 174);
			this.lbloaihang.Name = "lbloaihang";
			this.lbloaihang.Size = new System.Drawing.Size(0, 13);
			this.lbloaihang.TabIndex = 45;
			// 
			// lbnhanhieu
			// 
			this.lbnhanhieu.AutoSize = true;
			this.lbnhanhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbnhanhieu.ForeColor = System.Drawing.Color.Red;
			this.lbnhanhieu.Location = new System.Drawing.Point(188, 219);
			this.lbnhanhieu.Name = "lbnhanhieu";
			this.lbnhanhieu.Size = new System.Drawing.Size(0, 13);
			this.lbnhanhieu.TabIndex = 44;
			// 
			// rtbMoTa
			// 
			this.rtbMoTa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.rtbMoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rtbMoTa.Location = new System.Drawing.Point(601, 145);
			this.rtbMoTa.Name = "rtbMoTa";
			this.rtbMoTa.Size = new System.Drawing.Size(267, 71);
			this.rtbMoTa.TabIndex = 35;
			this.rtbMoTa.Text = "";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(491, 61);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(79, 20);
			this.label8.TabIndex = 42;
			this.label8.Text = "Giá Bán:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(23, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(110, 20);
			this.label1.TabIndex = 43;
			this.label1.Text = "Mã Vật Liệu:";
			// 
			// tbNhanHieu
			// 
			this.tbNhanHieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbNhanHieu.Location = new System.Drawing.Point(190, 190);
			this.tbNhanHieu.Name = "tbNhanHieu";
			this.tbNhanHieu.Size = new System.Drawing.Size(232, 26);
			this.tbNhanHieu.TabIndex = 34;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(491, 106);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(91, 20);
			this.label6.TabIndex = 41;
			this.label6.Text = "Số Lượng:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(23, 61);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(116, 20);
			this.label3.TabIndex = 40;
			this.label3.Text = "Tên Vật Liệu:";
			// 
			// tbLoaiHang
			// 
			this.tbLoaiHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbLoaiHang.Location = new System.Drawing.Point(190, 145);
			this.tbLoaiHang.Name = "tbLoaiHang";
			this.tbLoaiHang.Size = new System.Drawing.Size(232, 26);
			this.tbLoaiHang.TabIndex = 33;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(491, 174);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(59, 20);
			this.label4.TabIndex = 39;
			this.label4.Text = "Mô tả:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(23, 106);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(151, 20);
			this.label5.TabIndex = 38;
			this.label5.Text = "Mã nhà cung cấp:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(25, 151);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(96, 20);
			this.label7.TabIndex = 37;
			this.label7.Text = "Loại Hàng:";
			// 
			// tbSoLuong
			// 
			this.tbSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbSoLuong.Location = new System.Drawing.Point(601, 100);
			this.tbSoLuong.Name = "tbSoLuong";
			this.tbSoLuong.Size = new System.Drawing.Size(267, 26);
			this.tbSoLuong.TabIndex = 32;
			// 
			// tbDonGia
			// 
			this.tbDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbDonGia.Location = new System.Drawing.Point(601, 56);
			this.tbDonGia.Name = "tbDonGia";
			this.tbDonGia.Size = new System.Drawing.Size(267, 26);
			this.tbDonGia.TabIndex = 29;
			// 
			// tbTenVatLieu
			// 
			this.tbTenVatLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbTenVatLieu.Location = new System.Drawing.Point(191, 55);
			this.tbTenVatLieu.Name = "tbTenVatLieu";
			this.tbTenVatLieu.Size = new System.Drawing.Size(231, 26);
			this.tbTenVatLieu.TabIndex = 31;
			// 
			// tbMaVatLieu
			// 
			this.tbMaVatLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbMaVatLieu.Location = new System.Drawing.Point(191, 10);
			this.tbMaVatLieu.Name = "tbMaVatLieu";
			this.tbMaVatLieu.Size = new System.Drawing.Size(231, 26);
			this.tbMaVatLieu.TabIndex = 30;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(23, 196);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(98, 20);
			this.label10.TabIndex = 36;
			this.label10.Text = "Nhãn Hiệu:";
			// 
			// VatLieu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(909, 595);
			this.Controls.Add(this.panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "VatLieu";
			this.Text = "NhapHang";
			((System.ComponentModel.ISupportInitialize)(this.pcEdit)).EndInit();
			this.pndata.ResumeLayout(false);
			this.pndata.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pcSearch)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pcSave)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvdata)).EndInit();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pcDelete)).EndInit();
			this.pnmenu.ResumeLayout(false);
			this.pnmenu.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pcEdit;
		private System.Windows.Forms.Panel pndata;
		private System.Windows.Forms.PictureBox pcSearch;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btLamMoi;
		private System.Windows.Forms.TextBox tbTimKiem;
		private System.Windows.Forms.PictureBox pcSave;
		private System.Windows.Forms.DataGridView gvdata;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pcDelete;
		private System.Windows.Forms.Panel pnmenu;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Label lbsoluong;
		private System.Windows.Forms.Label lbgianhap;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox tbgianhap;
		private System.Windows.Forms.ComboBox cbbmancc;
		private System.Windows.Forms.Label lbdongia;
		private System.Windows.Forms.Label lbmalk;
		private System.Windows.Forms.Label lbtenlk;
		private System.Windows.Forms.Label lbmancc;
		private System.Windows.Forms.Label lbloaihang;
		private System.Windows.Forms.Label lbnhanhieu;
		private System.Windows.Forms.RichTextBox rtbMoTa;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbNhanHieu;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbLoaiHang;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox tbSoLuong;
		private System.Windows.Forms.TextBox tbDonGia;
		private System.Windows.Forms.TextBox tbTenVatLieu;
		private System.Windows.Forms.TextBox tbMaVatLieu;
		private System.Windows.Forms.Label label10;
	}
}