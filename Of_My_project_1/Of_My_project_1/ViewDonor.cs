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
    public partial class ViewDonor : Form
    {
        public ViewDonor()
        {
            InitializeComponent();
            populate();
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
        private void ViewDonor_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Donor D = new Donor();
            D.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Patient P = new Patient();
            P.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

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

        private void reset()
        {
            txt_cinds.Text = "";
            txt_fnds.Text = "";
            txt_lnds.Text = "";
            txt_phds.Text = "";
            txt_addds.Text = "";
            cb_Dgender.SelectedItem = "";
            nup_ageds.Value = 0;
            cb_bgds.SelectedItem = 0;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("Delete from Donorblood where Dcin=@cin2; ", cn);
            cmd.Parameters.AddWithValue("@cin2", txt_cinds.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Patient successfully Deleted");
            reset();
            populate();
        }
       
        private void donordgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txt_cinds.Text = donordgv.SelectedRows[0].Cells[0].Value.ToString();
                txt_fnds.Text = donordgv.SelectedRows[0].Cells[1].Value.ToString();
                txt_lnds.Text = donordgv.SelectedRows[0].Cells[2].Value.ToString();
                nup_ageds.Value = (int)donordgv.SelectedRows[0].Cells[3].Value;
                cb_Dgender.SelectedItem = donordgv.SelectedRows[0].Cells[4].Value.ToString();
                txt_phds.Text = donordgv.SelectedRows[0].Cells[5].Value.ToString();
                txt_addds.Text = donordgv.SelectedRows[0].Cells[6].Value.ToString();
                cb_bgds.SelectedItem = donordgv.SelectedRows[0].Cells[7].Value.ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("update Patient set Dcin=@dcin,Dfname=@pfn,Dlname=@pln,Dage=@page,Dgender=@pgen,Dphone=@pph,Dad=@padr,Dbt=@pblt; ", cn);
            cmd.Parameters.AddWithValue("@pcin", txt_cinds.Text);
            cmd.Parameters.AddWithValue("@pfn", txt_fnds.Text);
            cmd.Parameters.AddWithValue("@pln", txt_lnds.Text);
            cmd.Parameters.AddWithValue("@page", nup_ageds.Text);
            cmd.Parameters.AddWithValue("@pgen", cb_Dgender.SelectedItem);
            cmd.Parameters.AddWithValue("@pph", txt_phds.Text);
            cmd.Parameters.AddWithValue("@padr", txt_addds.Text);
            cmd.Parameters.AddWithValue("@pblt", cb_bgds.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Donor successfully Edited");
            reset();
            populate();
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

        private void label4_Click_1(object sender, EventArgs e)
        {
            Patient P = new Patient();
            P.Show();
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
