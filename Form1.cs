using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KatunSHOP
{
    public partial class Form1 : Form
    {

       
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\muham\Documents\produktetDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void btnInsert_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("insert into ProductTBL values('" + int.Parse(txtBoxId.Text) + "','" + txtBoxKodi.Text + "','" + txtBoxEmri.Text + "','" + float.Parse(txtBoxCmimi.Text) + "',getdate(),getdate())", con);
            command.ExecuteNonQuery();
            MessageBox.Show("Successfully Inserted");
            BindData();
            con.Close();
        }

        void BindData()
        {
            SqlCommand command = new SqlCommand("select * from ProductTBL", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("update ProductTBL set itemBarcode = '" + txtBoxKodi.Text + "',itemName = '" + txtBoxEmri.Text + "',itemPrice = '" + float.Parse(txtBoxCmimi.Text) + "',itemUpdateDate = getdate() where ProductID ='" + int.Parse(txtBoxId.Text) + "'", con);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated.");
            BindData();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtBoxId.Text != "")
            {
                if (MessageBox.Show("Are you sure to delete?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("delete ProductTBL where ProductID = '" + int.Parse(txtBoxId.Text) + "'", con);
                    command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfully Deleted.");
                    BindData();
                }
            }
            else
                MessageBox.Show("Product ID is needed to Delete Data.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBoxId.Text != "")
            {
                SqlCommand command = new SqlCommand("select * from ProductTBL where ProductID = '" + int.Parse(txtBoxId.Text) + "'", con);
                SqlDataAdapter sd = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else
                MessageBox.Show("We Need a Product ID to start Searching....");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtBoxKodi.Text != "")
            {
                SqlCommand command = new SqlCommand("select * from ProductTBL where itemBarcode = '" + txtBoxKodi.Text + "'", con);
                SqlDataAdapter sd = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else
                MessageBox.Show("We Need a Product Barcode to start Searching....");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtBoxEmri.Text != "")
            {
                SqlCommand command = new SqlCommand("select * from ProductTBL where ProductID = '" + txtBoxEmri.Text + "'", con);
                SqlDataAdapter sd = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else
                MessageBox.Show("We Need a Product Name to start Searching....");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtBoxCmimi.Text != "")
            {
                SqlCommand command = new SqlCommand("select * from ProductTBL where itemPrice = '" + float.Parse(txtBoxCmimi.Text) + "'", con);
                SqlDataAdapter sd = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else
                MessageBox.Show("We Need a Product Price to start Searching....");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
