namespace QuanLyBanVe
{
    partial class FrmThemKhuVuc
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenKhuVuc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaDinhDanh = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKhuVuc = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dgvKhuVuc = new System.Windows.Forms.DataGridView();
            this.MaDinhDanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhuVuc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Khu Vực";
            // 
            // txtTenKhuVuc
            // 
            this.txtTenKhuVuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhuVuc.Location = new System.Drawing.Point(215, 76);
            this.txtTenKhuVuc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenKhuVuc.Name = "txtTenKhuVuc";
            this.txtTenKhuVuc.Size = new System.Drawing.Size(253, 30);
            this.txtTenKhuVuc.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Định Danh";
            // 
            // txtMaDinhDanh
            // 
            this.txtMaDinhDanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDinhDanh.Location = new System.Drawing.Point(215, 128);
            this.txtMaDinhDanh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaDinhDanh.Name = "txtMaDinhDanh";
            this.txtMaDinhDanh.Size = new System.Drawing.Size(253, 30);
            this.txtMaDinhDanh.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(45, 174);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(92, 34);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(381, 174);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(87, 34);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(199, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "QUẢN LÝ KHU VỰC";
            // 
            // lblKhuVuc
            // 
            this.lblKhuVuc.AutoSize = true;
            this.lblKhuVuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhuVuc.Location = new System.Drawing.Point(11, 407);
            this.lblKhuVuc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKhuVuc.Name = "lblKhuVuc";
            this.lblKhuVuc.Size = new System.Drawing.Size(237, 25);
            this.lblKhuVuc.TabIndex = 0;
            this.lblKhuVuc.Text = "CÁC KHU VỰC ĐÃ CÓ";
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(156, 174);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(92, 34);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(269, 174);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(92, 34);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dgvKhuVuc
            // 
            this.dgvKhuVuc.AllowUserToAddRows = false;
            this.dgvKhuVuc.AllowUserToDeleteRows = false;
            this.dgvKhuVuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhuVuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDinhDanh,
            this.Ten});
            this.dgvKhuVuc.Location = new System.Drawing.Point(45, 238);
            this.dgvKhuVuc.Name = "dgvKhuVuc";
            this.dgvKhuVuc.ReadOnly = true;
            this.dgvKhuVuc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhuVuc.Size = new System.Drawing.Size(422, 147);
            this.dgvKhuVuc.TabIndex = 3;
            this.dgvKhuVuc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhuVuc_CellClick);
            // 
            // MaDinhDanh
            // 
            this.MaDinhDanh.HeaderText = "Ma Dinh Danh";
            this.MaDinhDanh.Name = "MaDinhDanh";
            this.MaDinhDanh.ReadOnly = true;
            // 
            // Ten
            // 
            this.Ten.HeaderText = "Ten Khu Vuc";
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            // 
            // FrmThemKhuVuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 441);
            this.Controls.Add(this.dgvKhuVuc);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtMaDinhDanh);
            this.Controls.Add(this.lblKhuVuc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenKhuVuc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmThemKhuVuc";
            this.Text = "FrmThemKhuVuc";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhuVuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenKhuVuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaDinhDanh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblKhuVuc;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dgvKhuVuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhuVuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDinhDanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
    }
}