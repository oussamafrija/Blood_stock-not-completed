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
    public partial class BloodTransfert : Form
    {
        public BloodTransfert()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-CP58I16\SQLEXPRESS;Initial Catalog=Bloodbank;Integrated Security=True");
        private void fillpcb()
        {

        }
        private void BloodTransfert_Load(object sender, EventArgs e)
        {

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
          
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Dashboard DB = new Dashboard();
            DB.Show();
            this.Hide();
        }

        private void label19_Click(object sender, EventArgs e)
        {
            Donate DO = new Donate();
            DO.Show();
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

        private void label8_Click_1(object sender, EventArgs e)
        {
            Dashboard DB = new Dashboard();
            DB.Show();
            this.Hide();
        }

        private void cb_pbg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
