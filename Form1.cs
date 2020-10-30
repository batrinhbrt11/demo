using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_nhapten_TextChanged(object sender, EventArgs e)
        {
            lbl_Laptrinh.Text = txt_nhapten.Text;
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lbl_Laptrinh.ForeColor = Color.Red;
        }

        private void bt_green_CheckedChanged(object sender, EventArgs e)
        {
            lbl_Laptrinh.ForeColor = Color.Green;
        }

        private void bt_blue_CheckedChanged(object sender, EventArgs e)
        {
            lbl_Laptrinh.ForeColor = Color.Blue;
        }

        private void bt_black_CheckedChanged(object sender, EventArgs e)
        {
            lbl_Laptrinh.ForeColor = Color.Black;
        }

        private void check_bold_CheckedChanged(object sender, EventArgs e)
        {
            lbl_Laptrinh.Font = new Font(lbl_Laptrinh.Font, lbl_Laptrinh.Font.Style | FontStyle.Bold);
        }
    }
}
