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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\muham\Documents\produktetDB.mdf;Integrated Security=True;Connect Timeout=30");


        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("select * from SoldProducts", con);//> '" + DateTime.Parse(textBox1.Text) + "'", con);// + "' AND soldDate < '" + DateTime.Parse(textBox2.Text) + "'", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            SqlDataReader datareader = command.ExecuteReader();

            DataTable tableUsername = new DataTable();
            DataColumn tableUsernameFirstColumn = new DataColumn();
            tableUsernameFirstColumn.ColumnName = "ProductID";
            tableUsernameFirstColumn.DataType = Type.GetType("System.Int32");

            DataColumn tableUsernameSecondColumn = new DataColumn();
            tableUsernameSecondColumn.ColumnName = "itemBarcode";
            tableUsernameSecondColumn.DataType = Type.GetType("System.String");

            DataColumn tableUsernameThirdColumn = new DataColumn();
            tableUsernameThirdColumn.ColumnName = "itemName";
            tableUsernameThirdColumn.DataType = Type.GetType("System.String");

            DataColumn tableUsernameFourthColumn = new DataColumn();
            tableUsernameFourthColumn.ColumnName = "itemPrice";
            tableUsernameFourthColumn.DataType = Type.GetType("System.Double");
            
            DataColumn tableUsernameFifthColumn = new DataColumn();
            tableUsernameFifthColumn.ColumnName = "insertDate";
            tableUsernameFifthColumn.DataType = Type.GetType("System.DateTime");

            DataColumn tableUsernameSixthColumn = new DataColumn();
            tableUsernameSixthColumn.ColumnName = "soldDate";
            tableUsernameSixthColumn.DataType = Type.GetType("System.DateTime");

            tableUsername.Columns.Add(tableUsernameFirstColumn);
            tableUsername.Columns.Add(tableUsernameSecondColumn);
            tableUsername.Columns.Add(tableUsernameThirdColumn);
            tableUsername.Columns.Add(tableUsernameFourthColumn);
            tableUsername.Columns.Add(tableUsernameFifthColumn);
            tableUsername.Columns.Add(tableUsernameSixthColumn);

            while (datareader.Read())
            {
                DateTime dd = (DateTime)datareader["soldDate"];
                DateTime d1 = DateTime.Parse(textBox1.Text + " 12:00 am");
                DateTime d2 = DateTime.Parse(textBox2.Text + " 11:59 pm");
                if (dd>=d1 && dd<=d2) {
                    DataRow dr1 = tableUsername.NewRow();
                    dr1[0] = (Int32)datareader["ProductID"];
                    dr1[1] = (String)datareader["itemBarcode"];
                    dr1[2] = (String)datareader["itemName"];
                    dr1[3] = (Double)datareader["itemPrice"];
                    dr1[4] = (DateTime)datareader["insertDate"];
                    dr1[5] = (DateTime)datareader["soldDate"];
                    tableUsername.Rows.Add(dr1);
                }
                
            }
            dataGridView1.DataSource = tableUsername;
            con.Close();
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "DD/MM/YYYY") {
                textBox2.Text = "";
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "DD/MM/YYYY";
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "DD/MM/YYYY")
            {
                textBox1.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "DD/MM/YYYY";
            }
        }
    }
}
