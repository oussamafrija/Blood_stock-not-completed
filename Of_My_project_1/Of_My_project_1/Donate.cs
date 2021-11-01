using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Of_My_project_1
{
    public partial class Donate : Form
    {
        public Donate()
        {
            InitializeComponent();
            populate();
            populate_blst();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-CP58I16\SQLEXPRESS;Initial Catalog=Bloodbank;Integrated Security=True");
        private void populate()
        {

            string query = "select * from Donorblood ";
            SqlDataAdapter sda = new SqlDataAdapter(query, cn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            donordgv.DataSource = ds.Tables[0];
            cn.Close();
        }
        private void populate_blst()
        {

            string query = "select * from Bldgroupe ";
            SqlDataAdapter sda = new SqlDataAdapter(query, cn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgvbs.DataSource = ds.Tables[0];
            cn.Close();
        }

        private void Donate_Load(object sender, EventArgs e)
        {

        }

        int oldstock;
        private void getstock(object selectedItem)
        {
            cn.Open();
            string query = "Select * from Bldgroupe where Bgroupe ='" + cb_dbg.SelectedItem + "'";
            SqlCommand cmd = new SqlCommand(query, cn);
            DataTable DT = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter(cmd);
            SDA.Fill(DT);
            foreach (DataRow DR in DT.Rows)
            {
                oldstock = Convert.ToInt32(DR["Bstock"].ToString());
            }
            cn.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ViewDonor VD = new ViewDonor();
            VD.Show();
            this.Hide();
        }

        private void label19_Click(object sender, EventArgs e)
        {
          
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Patient P = new Patient();
            P.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Viewpatient VP = new Viewpatient();
            VP.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            BloodStock BS = new BloodStock();
            BS.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            BloodTransfert BT = new BloodTransfert();
            BT.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Dashboard DB = new Dashboard();
            DB.Show();
            this.Hide();
        }

        private void donordgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txt_cin.Text = donordgv.SelectedRows[0].Cells[0].Value.ToString();
                cb_dbg.SelectedItem = donordgv.SelectedRows[0].Cells[7].Value.ToString();
                getstock(cb_dbg.SelectedItem);

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Donor D = new Donor();
            D.Show();
            this.Hide();
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            Patient P = new Patient();
            P.Show();
            this.Hide();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

            ViewDonor VD = new ViewDonor();
            VD.Show();
            this.Hide();
        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            BloodStock BS = new BloodStock();
            BS.Show();
            this.Hide();
        }

        private void label7_Click_1(object sender, EventArgs e)
        {
            BloodTransfert BT = new BloodTransfert();
            BT.Show();
            this.Hide();
        }

        private void label8_Click_1(object sender, EventArgs e)
        {
            Dashboard DB = new Dashboard();
            DB.Show();
            this.Hide();
        }

        private void reset()
        {
            txt_cin.Text = "";
            cb_dbg.SelectedItem = "";
        }
          
        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_cin.Text==""||cb_dbg.SelectedItem=="")
            {
                MessageBox.Show("Please enter a Donor");
            }
            else
            {
                int stock = oldstock+1;
                cn.Open();
                SqlCommand cmd = new SqlCommand("update Bldgroupe set Bstock='"+stock+"' where Bgroupe='"+cb_dbg.Text+"'", cn);
                
                cmd.ExecuteNonQuery();
                MessageBox.Show("Donnation success");
                reset();
                populate_blst();
            }
        }
    }
}
