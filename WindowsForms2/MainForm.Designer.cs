namespace WindowsForms2
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioNu = new System.Windows.Forms.RadioButton();
            this.radioNam = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioXanh = new System.Windows.Forms.RadioButton();
            this.radioDo = new System.Windows.Forms.RadioButton();
            this.buttonToMau = new System.Windows.Forms.Button();
            this.txtBangMau = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioNu);
            this.groupBox1.Controls.Add(this.radioNam);
            this.groupBox1.Location = new System.Drawing.Point(255, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn giới tính";
            // 
            // radioNu
            // 
            this.radioNu.AutoSize = true;
            this.radioNu.Location = new System.Drawing.Point(41, 63);
            this.radioNu.Name = "radioNu";
            this.radioNu.Size = new System.Drawing.Size(39, 17);
            this.radioNu.TabIndex = 0;
            this.radioNu.Text = "Nữ";
            this.radioNu.UseVisualStyleBackColor = true;
            this.radioNu.CheckedChanged += new System.EventHandler(this.radioNu_CheckedChanged);
            // 
            // radioNam
            // 
            this.radioNam.AutoSize = true;
            this.radioNam.Checked = true;
            this.radioNam.Location = new System.Drawing.Point(41, 31);
            this.radioNam.Name = "radioNam";
            this.radioNam.Size = new System.Drawing.Size(47, 17);
            this.radioNam.TabIndex = 0;
            this.radioNam.TabStop = true;
            this.radioNam.Text = "Nam";
            this.radioNam.UseVisualStyleBackColor = true;
            this.radioNam.CheckedChanged += new System.EventHandler(this.radioNam_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonToMau);
            this.groupBox2.Controls.Add(this.radioXanh);
            this.groupBox2.Controls.Add(this.radioDo);
            this.groupBox2.Location = new System.Drawing.Point(255, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 136);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn màu";
            // 
            // radioXanh
            // 
            this.radioXanh.AutoSize = true;
            this.radioXanh.Location = new System.Drawing.Point(41, 63);
            this.radioXanh.Name = "radioXanh";
            this.radioXanh.Size = new System.Drawing.Size(72, 17);
            this.radioXanh.TabIndex = 0;
            this.radioXanh.Text = "Màu xanh";
            this.radioXanh.UseVisualStyleBackColor = true;
            // 
            // radioDo
            // 
            this.radioDo.AutoSize = true;
            this.radioDo.Checked = true;
            this.radioDo.Location = new System.Drawing.Point(41, 31);
            this.radioDo.Name = "radioDo";
            this.radioDo.Size = new System.Drawing.Size(62, 17);
            this.radioDo.TabIndex = 0;
            this.radioDo.TabStop = true;
            this.radioDo.Text = "Màu đỏ";
            this.radioDo.UseVisualStyleBackColor = true;
            // 
            // buttonToMau
            // 
            this.buttonToMau.Location = new System.Drawing.Point(192, 31);
            this.buttonToMau.Name = "buttonToMau";
            this.buttonToMau.Size = new System.Drawing.Size(96, 49);
            this.buttonToMau.TabIndex = 1;
            this.buttonToMau.Text = "Tô màu";
            this.buttonToMau.UseVisualStyleBackColor = true;
            this.buttonToMau.Click += new System.EventHandler(this.buttonToMau_Click);
            // 
            // txtBangMau
            // 
            this.txtBangMau.Location = new System.Drawing.Point(608, 185);
            this.txtBangMau.Multiline = true;
            this.txtBangMau.Name = "txtBangMau";
            this.txtBangMau.ReadOnly = true;
            this.txtBangMau.Size = new System.Drawing.Size(155, 135);
            this.txtBangMau.TabIndex = 2;
            this.txtBangMau.Text = "Bảng màu";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBangMau);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Bai2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioNu;
        private System.Windows.Forms.RadioButton radioNam;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonToMau;
        private System.Windows.Forms.RadioButton radioXanh;
        private System.Windows.Forms.RadioButton radioDo;
        private System.Windows.Forms.TextBox txtBangMau;
    }
}

