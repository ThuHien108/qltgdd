using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKho.Bussiness;

namespace QuanLyKho
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            //dataGridView1.DataSource = sp.getDetaillists();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTest from2 = new frmTest();
            from2.ShowDialog();
        }
    }
}