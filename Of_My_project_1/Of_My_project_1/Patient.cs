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
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-CP58I16\SQLEXPRESS;Initial Catalog=Bloodbank;Integrated Security=True");
        private void reset()
        {
            txt_cinp.Text = "";
            txt_pfn.Text = "";
            txt_pln.Text = "";
            txt_padd.Text = "";
            txt_php.Text = "";
            cb_Pgender.SelectedItem="";
            nud_page.Value = 0;
            cb_pbt.SelectedIndex = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            cn.Open();
            if (txt_cinp.Text == "" || txt_pfn.Text == "" || txt_pln.Text == "" || nud_page.Value == 0 || cb_Pgender.SelectedItem=="" || txt_php.Text == "" || txt_padd.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {

                SqlCommand cmd = new SqlCommand("insert into Patient values (@pcin,@pfn,@pln,@pag,@pg,@pp,@pad,@pbt)", cn);
                cmd.Parameters.AddWithValue("@pcin", txt_cinp.Text);
                cmd.Parameters.AddWithValue("@pfn", txt_pfn.Text);
                cmd.Parameters.AddWithValue("@pln", txt_pln.Text);
                cmd.Parameters.AddWithValue("@pag", nud_page.Value);
                cmd.Parameters.AddWithValue("@pg", cb_Pgender.SelectedItem);
                cmd.Parameters.AddWithValue("@pp", txt_php.Text);
                cmd.Parameters.AddWithValue("@pad", txt_padd.Text);
                cmd.Parameters.AddWithValue("@pbt", cb_pbt.SelectedItem);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient successfully added");

            }
            cn.Close();
            reset();
        }

        private void Patient_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Viewpatient VP = new Viewpatient();
            VP.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Donor D = new Donor();
            D.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ViewDonor VD = new ViewDonor();
            VD.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void cb_Pgender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {
            Donate DO = new Donate();
            DO.Show();
            this.Hide();
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            Viewpatient VP = new Viewpatient();
            VP.Show();
            this.Hide();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            Donor D = new Donor();
            D.Show();
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
    }
}
