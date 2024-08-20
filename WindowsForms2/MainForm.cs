using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void radioNam_CheckedChanged(object sender, EventArgs e)
        {
            if(radioNam.Checked)
            MessageBox.Show("Bạn chọn giới tính Nam", "Thông báo");
        }

        private void radioNu_CheckedChanged(object sender, EventArgs e)
        {
            if(radioNu.Checked)
            MessageBox.Show("Bạn chọn giới tính Nữ", "Thông báo");
        }

        private void buttonToMau_Click(object sender, EventArgs e)
        {
            if (radioDo.Checked)
                txtBangMau.BackColor = Color.Red;
            if (radioXanh.Checked)
                txtBangMau.BackColor = Color.Blue;
        }
    }
}
