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
    
    public partial class MainForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\muham\Documents\produktetDB.mdf;Integrated Security=True;Connect Timeout=30");
        DataTable dt = new DataTable();
        SqlCommand cmd;
        SqlDataAdapter sd;
        int i = 0;
        float result = 0;
        string value = "";
        float sum = 0;
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ImgCashBack.Hide();
           




        }

        private void FindProdukt(string input)
        {
            con.Open();
                cmd = new SqlCommand("select * from ProductTBL where itemBarcode='"+ input+ "'", con);
                sd = new SqlDataAdapter(cmd);             
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
            con.Close();      
        }

        private void txtBoxInput_KeyDown(object sender, KeyEventArgs e)
        {

            if(e.KeyData == Keys.Enter)
            {
                i = 0;
                int count =  dataGridView1.Rows.Count ;
                FindProdukt(txtBoxInput.Text);
                if (dataGridView1.Rows.Count != 1 && count!=dataGridView1.Rows.Count)
                {
                    value = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    i++;
                    result += float.Parse(value);
                    // txtBoxTotalPrice.Text =  result.ToString() + " €";
                    txtBoxInput.Clear();
                    txtBoxTotalPrice.Text = String.Format("{0:0.00}", result + " €");
                }
                else {
                    MessageBox.Show("Product not found");
                }
            }
            else if(e.KeyData == Keys.Escape)
            {
                txtBoxInput.Clear();
                dt.Clear();
                i = 0;
                value = "";
                txtBoxTotalPrice.Text = "00.00" + " €";  
                sum = 0;
                txtBoxCashBack.Clear();

                dt.Clear();
            }
        }

        private void txtBoxCash_KeyDown(object sender, KeyEventArgs e)
        {
            

            if (e.KeyData == Keys.Enter)
            {
                sum = (float.Parse(txtBoxCash.Text) - result);
                txtBoxCashBack.ForeColor = Color.LightGreen;
                txtBoxCashBack.BackColor = Color.Blue;
                txtBoxCashBack.Text = sum.ToString() + " €";
                ImgCashBack.Show();
                ImgCash.BackColor = Color.LightGreen;
                txtBoxCash.Text = "00.00";
                con.Open();

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Index+1 != dataGridView1.Rows.Count) {
                        SqlCommand command = new SqlCommand("insert into SoldProducts values('" + row.Cells[0].Value.ToString() + "','" + row.Cells[1].Value.ToString() + "','" + row.Cells[2].Value.ToString() + "','" + float.Parse(row.Cells[3].Value.ToString()) + "','" + row.Cells[4].Value.ToString() + "',getdate())", con);
                        command.ExecuteNonQuery();
                    }
                }
                con.Close();
                dataGridView1.DataSource = null;
                result = 0;
                txtBoxTotalPrice.Text = "00.00 €";
            }
            else if (e.KeyData == Keys.Escape)
            {
                txtBoxInput.Clear();
                dt.Clear();
                i = -1;
                value = "";
                txtBoxTotalPrice.Text = "00.00" + " €";
                sum = 0;
                txtBoxCashBack.Clear();
                txtBoxCash.Text.Clone();
                ImgCashBack.Hide();
                txtBoxCashBack.ForeColor = Color.Blue;
                txtBoxCashBack.BackColor = default(Color);
                ImgCash.BackColor = default(Color);
                dt.Clear();
            }

        }

        private void btnProductWindow_Click(object sender, EventArgs e)
        {
            var newWindow = new Form1();
            newWindow.Show();
        }
    }
}
