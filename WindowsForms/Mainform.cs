﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var tenDaNhap = txtTen.Text;

            MessageBox.Show($"Xin chào bạn {tenDaNhap}. Rất vui được gặp bạn", "Thông báo chào mừng");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSaoChep_Click(object sender, EventArgs e)
        {
             txtSaoChep.Text = txtTen.Text;
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            txtSaoChep.Text = txtTen.Text;
        }
        private void txtSaoChep_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
