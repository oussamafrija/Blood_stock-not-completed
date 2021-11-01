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
    public partial class Viewpatient : Form
    {
        public Viewpatient()
        {
            InitializeComponent();
            populate();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-CP58I16\SQLEXPRESS;Initial Catalog=Bloodbank;Integrated Security=True");
        private void populate()
        {
            
            string query = "select * from Patient ";
            SqlDataAdapter sda = new SqlDataAdapter(query, cn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgvpatient.DataSource = ds.Tables[0];
            cn.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                if (e.RowIndex >= 0)
                {
                    txt_cinps.Text = dgvpatient.SelectedRows[0].Cells[0].Value.ToString();
                    txt_fnps.Text = dgvpatient.SelectedRows[0].Cells[1].Value.ToString();
                    txt_lnps.Text = dgvpatient.SelectedRows[0].Cells[2].Value.ToString();
                    nud_ageps.Value = (int)dgvpatient.SelectedRows[0].Cells[3].Value;
                cb_Pgender.SelectedItem = dgvpatient.SelectedRows[0].Cells[4].Value.ToString();
                txt_phoneps.Text = dgvpatient.SelectedRows[0].Cells[5].Value.ToString();
                    txt_addps.Text = dgvpatient.SelectedRows[0].Cells[6].Value.ToString();
                    cb_btps.SelectedItem = dgvpatient.SelectedRows[0].Cells[7].Value.ToString();

                }
           
        }

        private void Viewpatient_Load(object sender, EventArgs e)
        {
            
        }
        private void reset()
        {
            txt_cinps.Text = "";
            txt_fnps.Text = "";
            txt_lnps.Text = "";
            txt_phoneps.Text = "";
            txt_addps.Text = "";
            cb_Pgender.SelectedItem = "";
            nud_ageps.Value = 0;
            cb_btps.SelectedItem = 0;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("Delete from Patient where Pcin=@cin1; ",cn);
            cmd.Parameters.AddWithValue("@cin1",txt_cinps.Text);
            cmd.ExecuteNonQuery(); 
            MessageBox.Show("Patient successfully Deleted");
            reset();
            populate();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Patient P = new Patient();
            P.Show();
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("update Patient set Pcin=@pcin,Pfname=@pfn,Plname=@pln,Paage=@page,Pgender=@pgen,Pphone=@pph,Pad=@padr,Pbt=@pblt; ", cn);
            cmd.Parameters.AddWithValue("@pcin", txt_cinps.Text);
            cmd.Parameters.AddWithValue("@pfn", txt_fnps.Text);
            cmd.Parameters.AddWithValue("@pln", txt_lnps.Text);
            cmd.Parameters.AddWithValue("@page", nud_ageps.Text);
            cmd.Parameters.AddWithValue("@pgen", cb_Pgender.SelectedItem);
            cmd.Parameters.AddWithValue("@pph", txt_phoneps.Text);
            cmd.Parameters.AddWithValue("@padr", txt_addps.Text);
            cmd.Parameters.AddWithValue("@pblt", cb_btps.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Patient successfully Edited");
            reset();
            populate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {
            Donate DO = new Donate();
            DO.Show();
            this.Hide();
        }
    }
}
