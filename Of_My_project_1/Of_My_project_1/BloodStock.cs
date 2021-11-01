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
    public partial class BloodStock : Form
    {
        public BloodStock()
        {
            InitializeComponent();
            populate_blst();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-CP58I16\SQLEXPRESS;Initial Catalog=Bloodbank;Integrated Security=True");
     
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

        private void lbl_vd_Click(object sender, EventArgs e)
        {
            ViewDonor VD = new ViewDonor();
            VD.Show();
            this.Hide();
        }

        private void lbl_patient_Click(object sender, EventArgs e)
        {
            Patient P = new Patient();
            P.Show();
            this.Hide();
        }

        private void lbl_vp_Click(object sender, EventArgs e)
        {
            Viewpatient VP = new Viewpatient();
            VP.Show();
            this.Hide();
        }

        private void lbl_bt_Click(object sender, EventArgs e)
        {
            BloodTransfert BT = new BloodTransfert();
            BT.Show();
            this.Hide();
        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void lbl_db_Click(object sender, EventArgs e)
        {
            Dashboard DB = new Dashboard();
            DB.Show();
            this.Hide();
        }

        private void BloodStock_Load(object sender, EventArgs e)
        {

        }

        private void cb_dbg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvbs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
