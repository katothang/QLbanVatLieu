namespace QuanLyVatLieu.GUI.QUANLYNHAPHANG
{
	partial class ThongKeNhapHang
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
			this.btnXemThongKe = new System.Windows.Forms.Button();
			this.gvdata = new System.Windows.Forms.DataGridView();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btLamMoi = new System.Windows.Forms.Button();
			this.pnmenu = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.dtDenNgay = new System.Windows.Forms.DateTimePicker();
			this.dtTuNgay = new System.Windows.Forms.DateTimePicker();
			this.inBaoCao = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.gvdata)).BeginInit();
			this.panel2.SuspendLayout();
			this.pnmenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnXemThongKe
			// 
			this.btnXemThongKe.BackColor = System.Drawing.Color.OrangeRed;
			this.btnXemThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXemThongKe.ForeColor = System.Drawing.Color.White;
			this.btnXemThongKe.Location = new System.Drawing.Point(590, 105);
			this.btnXemThongKe.Name = "btnXemThongKe";
			this.btnXemThongKe.Size = new System.Drawing.Size(152, 48);
			this.btnXemThongKe.TabIndex = 5;
			this.btnXemThongKe.Text = "Xem Thống Kê";
			this.btnXemThongKe.UseVisualStyleBackColor = false;
			this.btnXemThongKe.Click += new System.EventHandler(this.BtnXemThongKe_Click);
			// 
			// gvdata
			// 
			this.gvdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvdata.Location = new System.Drawing.Point(12, 166);
			this.gvdata.Name = "gvdata";
			this.gvdata.ReadOnly = true;
			this.gvdata.Size = new System.Drawing.Size(896, 419);
			this.gvdata.TabIndex = 14;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Controls.Add(this.inBaoCao);
			this.panel2.Controls.Add(this.btnXemThongKe);
			this.panel2.Controls.Add(this.btLamMoi);
			this.panel2.Controls.Add(this.gvdata);
			this.panel2.Controls.Add(this.pnmenu);
			this.panel2.Location = new System.Drawing.Point(4, 12);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(920, 588);
			this.panel2.TabIndex = 9;
			// 
			// btLamMoi
			// 
			this.btLamMoi.BackColor = System.Drawing.Color.OrangeRed;
			this.btLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btLamMoi.ForeColor = System.Drawing.Color.White;
			this.btLamMoi.Location = new System.Drawing.Point(764, 105);
			this.btLamMoi.Name = "btLamMoi";
			this.btLamMoi.Size = new System.Drawing.Size(144, 48);
			this.btLamMoi.TabIndex = 5;
			this.btLamMoi.Text = "Làm Mới";
			this.btLamMoi.UseVisualStyleBackColor = false;
			this.btLamMoi.Click += new System.EventHandler(this.BtLamMoi_Click);
			// 
			// pnmenu
			// 
			this.pnmenu.BackColor = System.Drawing.Color.White;
			this.pnmenu.Controls.Add(this.label1);
			this.pnmenu.Controls.Add(this.label6);
			this.pnmenu.Controls.Add(this.dtDenNgay);
			this.pnmenu.Controls.Add(this.dtTuNgay);
			this.pnmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pnmenu.ForeColor = System.Drawing.Color.Black;
			this.pnmenu.Location = new System.Drawing.Point(12, 11);
			this.pnmenu.Name = "pnmenu";
			this.pnmenu.Size = new System.Drawing.Size(896, 88);
			this.pnmenu.TabIndex = 9;
			this.pnmenu.TabStop = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(442, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 20);
			this.label1.TabIndex = 35;
			this.label1.Text = "Đến ngày";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(3, 15);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(72, 20);
			this.label6.TabIndex = 35;
			this.label6.Text = "Từ ngày";
			// 
			// dtDenNgay
			// 
			this.dtDenNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtDenNgay.Location = new System.Drawing.Point(599, 15);
			this.dtDenNgay.Name = "dtDenNgay";
			this.dtDenNgay.Size = new System.Drawing.Size(221, 26);
			this.dtDenNgay.TabIndex = 2;
			// 
			// dtTuNgay
			// 
			this.dtTuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtTuNgay.Location = new System.Drawing.Point(139, 15);
			this.dtTuNgay.Name = "dtTuNgay";
			this.dtTuNgay.Size = new System.Drawing.Size(227, 26);
			this.dtTuNgay.TabIndex = 1;
			// 
			// inBaoCao
			// 
			this.inBaoCao.BackColor = System.Drawing.Color.OrangeRed;
			this.inBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inBaoCao.ForeColor = System.Drawing.Color.White;
			this.inBaoCao.Location = new System.Drawing.Point(430, 105);
			this.inBaoCao.Name = "inBaoCao";
			this.inBaoCao.Size = new System.Drawing.Size(144, 48);
			this.inBaoCao.TabIndex = 15;
			this.inBaoCao.Text = "In Báo Cáo";
			this.inBaoCao.UseVisualStyleBackColor = false;
			this.inBaoCao.Click += new System.EventHandler(this.InBaoCao_Click);
			// 
			// ThongKeNhapHang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(923, 606);
			this.Controls.Add(this.panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ThongKeNhapHang";
			this.Text = "ThongKeNhapHang";
			((System.ComponentModel.ISupportInitialize)(this.gvdata)).EndInit();
			this.panel2.ResumeLayout(false);
			this.pnmenu.ResumeLayout(false);
			this.pnmenu.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnXemThongKe;
		private System.Windows.Forms.DataGridView gvdata;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btLamMoi;
		private System.Windows.Forms.Panel pnmenu;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker dtDenNgay;
		private System.Windows.Forms.DateTimePicker dtTuNgay;
		private System.Windows.Forms.Button inBaoCao;
	}
}