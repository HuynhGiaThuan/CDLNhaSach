namespace QLySach
{
    partial class MainTinhTien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainTinhTien));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.daGV_HoaDon = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMaKHang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_return = new System.Windows.Forms.Button();
            this.ck_SvTr = new System.Windows.Forms.CheckBox();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Pay = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.btn_tim = new System.Windows.Forms.Button();
            this.btn_HeThong = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.daGV_HoaDon)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(140, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tính Tiền";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.daGV_HoaDon);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(2, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 195);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa Đơn";
            // 
            // daGV_HoaDon
            // 
            this.daGV_HoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.daGV_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.daGV_HoaDon.Location = new System.Drawing.Point(6, 28);
            this.daGV_HoaDon.Name = "daGV_HoaDon";
            this.daGV_HoaDon.Size = new System.Drawing.Size(747, 161);
            this.daGV_HoaDon.TabIndex = 2;
            this.daGV_HoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.daGV_HoaDon_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_them);
            this.groupBox2.Controls.Add(this.txtMaKHang);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtMaSP);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox2.Location = new System.Drawing.Point(14, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(521, 154);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sản Phẩm";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtMaKHang
            // 
            this.txtMaKHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKHang.Location = new System.Drawing.Point(167, 60);
            this.txtMaKHang.Name = "txtMaKHang";
            this.txtMaKHang.Size = new System.Drawing.Size(327, 26);
            this.txtMaKHang.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(19, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Khách Hàng ";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSP.Location = new System.Drawing.Point(167, 24);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(327, 26);
            this.txtMaSP.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(19, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Sản Phẩm";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_tim);
            this.groupBox3.Controls.Add(this.txtMaHoaDon);
            this.groupBox3.Controls.Add(this.btn_return);
            this.groupBox3.Controls.Add(this.ck_SvTr);
            this.groupBox3.Controls.Add(this.btn_Edit);
            this.groupBox3.Controls.Add(this.btn_Pay);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox3.Location = new System.Drawing.Point(555, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 240);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức Năng";
            // 
            // btn_return
            // 
            this.btn_return.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_return.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_return.Location = new System.Drawing.Point(17, 144);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(139, 39);
            this.btn_return.TabIndex = 2;
            this.btn_return.Text = "Trả Hàng";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Visible = false;
            // 
            // ck_SvTr
            // 
            this.ck_SvTr.AutoSize = true;
            this.ck_SvTr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ck_SvTr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ck_SvTr.Location = new System.Drawing.Point(6, 81);
            this.ck_SvTr.Name = "ck_SvTr";
            this.ck_SvTr.Size = new System.Drawing.Size(108, 22);
            this.ck_SvTr.TabIndex = 3;
            this.ck_SvTr.Text = "Sửa và Trả";
            this.ck_SvTr.UseVisualStyleBackColor = true;
            this.ck_SvTr.CheckedChanged += new System.EventHandler(this.ck_SvTr_CheckedChanged);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Edit.Location = new System.Drawing.Point(17, 186);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(139, 44);
            this.btn_Edit.TabIndex = 1;
            this.btn_Edit.Text = "Chỉnh Sửa";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Visible = false;
            // 
            // btn_Pay
            // 
            this.btn_Pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Pay.Location = new System.Drawing.Point(6, 28);
            this.btn_Pay.Name = "btn_Pay";
            this.btn_Pay.Size = new System.Drawing.Size(139, 47);
            this.btn_Pay.TabIndex = 0;
            this.btn_Pay.Text = "Thanh Toán";
            this.btn_Pay.UseVisualStyleBackColor = true;
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.Red;
            this.btn_them.Location = new System.Drawing.Point(201, 102);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(184, 36);
            this.btn_them.TabIndex = 4;
            this.btn_them.Text = "Thêm Sản Phẩm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHoaDon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMaHoaDon.Location = new System.Drawing.Point(17, 112);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(139, 24);
            this.txtMaHoaDon.TabIndex = 5;
            this.txtMaHoaDon.Visible = false;
            // 
            // btn_tim
            // 
            this.btn_tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tim.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_tim.Image = ((System.Drawing.Image)(resources.GetObject("btn_tim.Image")));
            this.btn_tim.Location = new System.Drawing.Point(160, 110);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(34, 30);
            this.btn_tim.TabIndex = 6;
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Visible = false;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // btn_HeThong
            // 
            this.btn_HeThong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HeThong.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_HeThong.Image = ((System.Drawing.Image)(resources.GetObject("btn_HeThong.Image")));
            this.btn_HeThong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_HeThong.Location = new System.Drawing.Point(410, 224);
            this.btn_HeThong.Name = "btn_HeThong";
            this.btn_HeThong.Size = new System.Drawing.Size(139, 39);
            this.btn_HeThong.TabIndex = 7;
            this.btn_HeThong.Text = "Hệ Thống";
            this.btn_HeThong.UseVisualStyleBackColor = true;
            this.btn_HeThong.Click += new System.EventHandler(this.btn_HeThong_Click);
            // 
            // MainTinhTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 450);
            this.Controls.Add(this.btn_HeThong);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "MainTinhTien";
            this.Text = "MainTinhTien";
            this.Load += new System.EventHandler(this.MainTinhTien_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.daGV_HoaDon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView daGV_HoaDon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtMaKHang;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.CheckBox ck_SvTr;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Pay;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.Button btn_HeThong;
    }
}