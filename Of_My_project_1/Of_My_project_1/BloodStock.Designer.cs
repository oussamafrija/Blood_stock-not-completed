
namespace Of_My_project_1
{
    partial class BloodStock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_donate = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_db = new System.Windows.Forms.Label();
            this.lbl_bt = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_vp = new System.Windows.Forms.Label();
            this.lbl_patient = new System.Windows.Forms.Label();
            this.lbl_vd = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_donor = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvbs = new System.Windows.Forms.DataGridView();
            this.cb_dbg = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbs)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.lbl_donate);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lbl_db);
            this.panel1.Controls.Add(this.lbl_bt);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lbl_vp);
            this.panel1.Controls.Add(this.lbl_patient);
            this.panel1.Controls.Add(this.lbl_vd);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lbl_donor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(128, 447);
            this.panel1.TabIndex = 4;
            // 
            // lbl_donate
            // 
            this.lbl_donate.AutoSize = true;
            this.lbl_donate.BackColor = System.Drawing.Color.Red;
            this.lbl_donate.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_donate.ForeColor = System.Drawing.Color.Snow;
            this.lbl_donate.Location = new System.Drawing.Point(27, 162);
            this.lbl_donate.Name = "lbl_donate";
            this.lbl_donate.Size = new System.Drawing.Size(56, 19);
            this.lbl_donate.TabIndex = 29;
            this.lbl_donate.Text = "Donate";
            this.lbl_donate.Click += new System.EventHandler(this.label19_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Snow;
            this.label9.Location = new System.Drawing.Point(28, 423);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 21);
            this.label9.TabIndex = 23;
            this.label9.Text = "Logout";
            // 
            // lbl_db
            // 
            this.lbl_db.AutoSize = true;
            this.lbl_db.BackColor = System.Drawing.Color.Transparent;
            this.lbl_db.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_db.ForeColor = System.Drawing.Color.Snow;
            this.lbl_db.Location = new System.Drawing.Point(19, 340);
            this.lbl_db.Name = "lbl_db";
            this.lbl_db.Size = new System.Drawing.Size(80, 19);
            this.lbl_db.TabIndex = 28;
            this.lbl_db.Text = "Dashboard";
            this.lbl_db.Click += new System.EventHandler(this.lbl_db_Click);
            // 
            // lbl_bt
            // 
            this.lbl_bt.AutoSize = true;
            this.lbl_bt.BackColor = System.Drawing.Color.Red;
            this.lbl_bt.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_bt.ForeColor = System.Drawing.Color.Snow;
            this.lbl_bt.Location = new System.Drawing.Point(14, 306);
            this.lbl_bt.Name = "lbl_bt";
            this.lbl_bt.Size = new System.Drawing.Size(109, 19);
            this.lbl_bt.TabIndex = 27;
            this.lbl_bt.Text = "Blood Transfert";
            this.lbl_bt.Click += new System.EventHandler(this.lbl_bt_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Red;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(19, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 19);
            this.label6.TabIndex = 26;
            this.label6.Text = "Blood Stock";
            this.label6.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // lbl_vp
            // 
            this.lbl_vp.AutoSize = true;
            this.lbl_vp.BackColor = System.Drawing.Color.Red;
            this.lbl_vp.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_vp.ForeColor = System.Drawing.Color.Snow;
            this.lbl_vp.Location = new System.Drawing.Point(22, 229);
            this.lbl_vp.Name = "lbl_vp";
            this.lbl_vp.Size = new System.Drawing.Size(90, 19);
            this.lbl_vp.TabIndex = 25;
            this.lbl_vp.Text = "View Patient";
            this.lbl_vp.Click += new System.EventHandler(this.lbl_vp_Click);
            // 
            // lbl_patient
            // 
            this.lbl_patient.AutoSize = true;
            this.lbl_patient.BackColor = System.Drawing.Color.Red;
            this.lbl_patient.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_patient.ForeColor = System.Drawing.Color.Snow;
            this.lbl_patient.Location = new System.Drawing.Point(28, 195);
            this.lbl_patient.Name = "lbl_patient";
            this.lbl_patient.Size = new System.Drawing.Size(55, 19);
            this.lbl_patient.TabIndex = 24;
            this.lbl_patient.Text = "Patient";
            this.lbl_patient.Click += new System.EventHandler(this.lbl_patient_Click);
            // 
            // lbl_vd
            // 
            this.lbl_vd.AutoSize = true;
            this.lbl_vd.BackColor = System.Drawing.Color.Red;
            this.lbl_vd.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_vd.ForeColor = System.Drawing.Color.Snow;
            this.lbl_vd.Location = new System.Drawing.Point(22, 125);
            this.lbl_vd.Name = "lbl_vd";
            this.lbl_vd.Size = new System.Drawing.Size(91, 19);
            this.lbl_vd.TabIndex = 22;
            this.lbl_vd.Text = "View Donors";
            this.lbl_vd.Click += new System.EventHandler(this.lbl_vd_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel3.Location = new System.Drawing.Point(3, 267);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 22);
            this.panel3.TabIndex = 21;
            // 
            // lbl_donor
            // 
            this.lbl_donor.AutoSize = true;
            this.lbl_donor.BackColor = System.Drawing.Color.Red;
            this.lbl_donor.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_donor.ForeColor = System.Drawing.Color.Snow;
            this.lbl_donor.Location = new System.Drawing.Point(28, 87);
            this.lbl_donor.Name = "lbl_donor";
            this.lbl_donor.Size = new System.Drawing.Size(50, 19);
            this.lbl_donor.TabIndex = 20;
            this.lbl_donor.Text = "Donor";
            this.lbl_donor.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(128, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(517, 38);
            this.panel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(105, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Centre National de Transfusion Sanguine";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(320, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 25);
            this.label10.TabIndex = 70;
            this.label10.Text = "Blood Stock";
            // 
            // dgvbs
            // 
            this.dgvbs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbs.Location = new System.Drawing.Point(134, 205);
            this.dgvbs.Name = "dgvbs";
            this.dgvbs.RowTemplate.Height = 25;
            this.dgvbs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvbs.Size = new System.Drawing.Size(499, 230);
            this.dgvbs.TabIndex = 92;
            this.dgvbs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbs_CellContentClick);
            // 
            // cb_dbg
            // 
            this.cb_dbg.FormattingEnabled = true;
            this.cb_dbg.Items.AddRange(new object[] {
            "",
            "O+",
            "O-",
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-"});
            this.cb_dbg.Location = new System.Drawing.Point(343, 125);
            this.cb_dbg.Name = "cb_dbg";
            this.cb_dbg.Size = new System.Drawing.Size(121, 23);
            this.cb_dbg.TabIndex = 94;
            this.cb_dbg.SelectedIndexChanged += new System.EventHandler(this.cb_dbg_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.LightCoral;
            this.label15.Location = new System.Drawing.Point(280, 126);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 19);
            this.label15.TabIndex = 93;
            this.label15.Text = "Filter";
            // 
            // BloodStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(645, 447);
            this.Controls.Add(this.cb_dbg);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dgvbs);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BloodStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BloodStock";
            this.Load += new System.EventHandler(this.BloodStock_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_donate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_db;
        private System.Windows.Forms.Label lbl_bt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_vp;
        private System.Windows.Forms.Label lbl_patient;
        private System.Windows.Forms.Label lbl_vd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_donor;
        private System.Windows.Forms.DataGridView dgvbs;
        private System.Windows.Forms.ComboBox cb_dbg;
        private System.Windows.Forms.Label label15;
    }
}