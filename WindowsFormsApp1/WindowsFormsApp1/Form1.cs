using System;
using System.Data.Sql;
using System.Data.SqlClient;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] country = { "America", "Pakistan", "Syberia" };
            foreach(string s in country)
            {
                comboBox1.Items.Add(s);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Gender, Hobby, Status , Name , Country;
            if (checkBox1.Checked)
            {
                Gender = checkBox1.Text;
            }
            else
            {
                Gender = checkBox2.Text;

            }

            if(checkBox3.Checked)
            {
                Status = checkBox3.Text;

            }
            else
            {
                Status = checkBox4.Text;
            }
            if (checkBox5.Checked)
            {
                Hobby = checkBox5.Text;
            }
            else
            {
                Hobby = checkBox6.Text;
            }
            Country = comboBox1.SelectedItem.ToString();
            Name = textBox1.Text;

            Validate obj1 = new Validate();
            obj1.checkName(Name);
            Form2 obj = new Form2(Name, Gender, Country, Hobby, Status);    
            obj.ShowDialog();
         

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadCustomer();
        }
        private void loadCustomer()
        {
           
            string strConnection = "Data Source=AUMC-LAB3-33\\SQLEXPRESS;Initial Catalog=Lab9;Integrated Security=True";
            SqlConnection objConnection = new SqlConnection(strConnection);
            objConnection.Open();
            
            string strCommand = "Select * From Customer";
            SqlCommand objCommand = new SqlCommand(strCommand, objConnection);
           
            DataSet objDataSet = new DataSet();
            SqlDataAdapter objAdapter = new SqlDataAdapter(objCommand);
            objAdapter.Fill(objDataSet);

            dataGridView1.DataSource = objDataSet.Tables[0];
         
            objConnection.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
