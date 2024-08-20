namespace ThietKeForm
{
    partial class frmBai1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBai1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioVang = new System.Windows.Forms.RadioButton();
            this.radioHong = new System.Windows.Forms.RadioButton();
            this.radioXanh = new System.Windows.Forms.RadioButton();
            this.radioTim = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(461, 455);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioTim);
            this.groupBox1.Controls.Add(this.radioXanh);
            this.groupBox1.Controls.Add(this.radioHong);
            this.groupBox1.Controls.Add(this.radioVang);
            this.groupBox1.Location = new System.Drawing.Point(537, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 137);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn màu xe";
            // 
            // radioVang
            // 
            this.radioVang.AutoSize = true;
            this.radioVang.Checked = true;
            this.radioVang.Location = new System.Drawing.Point(19, 28);
            this.radioVang.Name = "radioVang";
            this.radioVang.Size = new System.Drawing.Size(50, 17);
            this.radioVang.TabIndex = 0;
            this.radioVang.TabStop = true;
            this.radioVang.Text = "Vàng";
            this.radioVang.UseVisualStyleBackColor = true;
            // 
            // radioHong
            // 
            this.radioHong.AutoSize = true;
            this.radioHong.Location = new System.Drawing.Point(19, 51);
            this.radioHong.Name = "radioHong";
            this.radioHong.Size = new System.Drawing.Size(51, 17);
            this.radioHong.TabIndex = 0;
            this.radioHong.Text = "Hồng";
            this.radioHong.UseVisualStyleBackColor = true;
            // 
            // radioXanh
            // 
            this.radioXanh.AutoSize = true;
            this.radioXanh.Location = new System.Drawing.Point(19, 74);
            this.radioXanh.Name = "radioXanh";
            this.radioXanh.Size = new System.Drawing.Size(50, 17);
            this.radioXanh.TabIndex = 0;
            this.radioXanh.Text = "Xanh";
            this.radioXanh.UseVisualStyleBackColor = true;
            this.radioXanh.CheckedChanged += new System.EventHandler(this.radioXanh_CheckedChanged);
            // 
            // radioTim
            // 
            this.radioTim.AutoSize = true;
            this.radioTim.Location = new System.Drawing.Point(19, 97);
            this.radioTim.Name = "radioTim";
            this.radioTim.Size = new System.Drawing.Size(44, 17);
            this.radioTim.TabIndex = 0;
            this.radioTim.Text = "Tím";
            this.radioTim.UseVisualStyleBackColor = true;
            this.radioTim.CheckedChanged += new System.EventHandler(this.radioXanh_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(534, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Đơn giá :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(534, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số lượng :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(709, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "$";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(605, 224);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(98, 23);
            this.txtDonGia.TabIndex = 3;
            this.txtDonGia.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(605, 262);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(98, 23);
            this.txtSoLuong.TabIndex = 3;
            // 
            // frmBai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmBai1";
            this.Text = "frmBai1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioXanh;
        private System.Windows.Forms.RadioButton radioHong;
        private System.Windows.Forms.RadioButton radioVang;
        private System.Windows.Forms.RadioButton radioTim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoLuong;
    }
}