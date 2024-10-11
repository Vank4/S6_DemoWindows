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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Khu Vực";
            // 
            // txtTenKhuVuc
            // 
            this.txtTenKhuVuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhuVuc.Location = new System.Drawing.Point(322, 117);
            this.txtTenKhuVuc.Name = "txtTenKhuVuc";
            this.txtTenKhuVuc.Size = new System.Drawing.Size(377, 41);
            this.txtTenKhuVuc.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Định Danh";
            // 
            // txtMaDinhDanh
            // 
            this.txtMaDinhDanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDinhDanh.Location = new System.Drawing.Point(322, 197);
            this.txtMaDinhDanh.Name = "txtMaDinhDanh";
            this.txtMaDinhDanh.Size = new System.Drawing.Size(377, 41);
            this.txtMaDinhDanh.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(322, 267);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(189, 53);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(517, 267);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(182, 53);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(299, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "QUẢN LÝ KHU VỰC";
            // 
            // lblKhuVuc
            // 
            this.lblKhuVuc.AutoSize = true;
            this.lblKhuVuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhuVuc.Location = new System.Drawing.Point(43, 336);
            this.lblKhuVuc.Name = "lblKhuVuc";
            this.lblKhuVuc.Size = new System.Drawing.Size(339, 36);
            this.lblKhuVuc.TabIndex = 0;
            this.lblKhuVuc.Text = "CÁC KHU VỰC ĐÃ CÓ";
            // 
            // FrmThemKhuVuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 398);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtMaDinhDanh);
            this.Controls.Add(this.lblKhuVuc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenKhuVuc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FrmThemKhuVuc";
            this.Text = "FrmThemKhuVuc";
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
    }
}