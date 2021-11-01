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
    public partial class Donor : Form
    {
        public Donor()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-CP58I16\SQLEXPRESS;Initial Catalog=Bloodbank;Integrated Security=True");
        private void reset()
        {
            txt_dofn.Text = "";
            txt_doln.Text = "";
            txt_dp.Text = "";
            txt_dad.Text = "";
            cb_Dgender.SelectedItem="";
            nud_doage.Value = 0;
            cb_dbg.SelectedIndex = 0;
            txt_cin.Text = "";
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn.Open();
            if (txt_cin.Text == "" || txt_dofn.Text == "" || txt_doln.Text == "" || nud_doage.Value == 0 || cb_Dgender.SelectedItem=="" || txt_dp.Text == "" || txt_dad.Text == ""||cb_dbg.SelectedIndex==0)
            {
                MessageBox.Show("Missing information");
            }
            else
            {

                SqlCommand cmd = new SqlCommand ("insert into Donorblood values (@dcin,@dfn,@dln,@dag,@dg,@dp,@dad,@dbt)", cn);
                cmd.Parameters.AddWithValue("@dcin", txt_cin.Text);
                cmd.Parameters.AddWithValue("@dfn", txt_dofn.Text);
                cmd.Parameters.AddWithValue("@dln", txt_doln.Text);
                cmd.Parameters.AddWithValue("@dag", nud_doage.Value);
                cmd.Parameters.AddWithValue("@dg", cb_Dgender.SelectedItem);
                cmd.Parameters.AddWithValue("@dp",txt_dp.Text );
                cmd.Parameters.AddWithValue("@dad", txt_dad.Text);
                cmd.Parameters.AddWithValue("@dbt", cb_dbg.SelectedItem);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Donor successfully added");

            }
            cn.Close();
            reset();
        }

        private void Donor_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            ViewDonor VD = new ViewDonor();
            VD.Show();
            this.Hide();
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

        private void label2_Click(object sender, EventArgs e)
        {
         
        }

        private void label19_Click(object sender, EventArgs e)
        {
            Donate DO = new Donate();
            DO.Show();
            this.Hide();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            ViewDonor VD = new ViewDonor();
            VD.Show();
            this.Hide();
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            Patient P = new Patient();
            P.Show();
            this.Hide();
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            Viewpatient VP = new Viewpatient();
            VP.Show();
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
            Dashboard DS = new Dashboard();
            DS.Show();
            this.Hide();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
