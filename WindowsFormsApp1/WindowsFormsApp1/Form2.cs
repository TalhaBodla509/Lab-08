using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2(string C,string s, string h, string n, string g )
        {
            InitializeComponent();
            label1.Text = C;
            label1.Show();
            label2.Text = s;
            label2.Show();
            label3.Text = h;
            label3.Show();
            label4.Text = n;
            label4.Show();
            label5.Text = g;
            label5.Show();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
