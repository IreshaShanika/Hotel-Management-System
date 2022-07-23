using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HotelManagementProject
{

    public partial class Staffinfo : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\Hoteldb1.mdf;Integrated Security=True;Connect Timeout=30");
        public void populate()
        {
            Con.Open();
            string Myquery = "select * from dbo.Staff_tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cduilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            StaffGridView.DataSource = ds.Tables[0];
            Con.Close();
        }
        public Staffinfo()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void StaffAdd_btn_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into dbo.Staff_tbl values (" + Staffid_txt.Text + ",'" + StaffName_txt.Text + "', '" + StaffPhone_txt.Text + "','" + Gender_com.SelectedItem.ToString() + "','"+ password_txt .Text+ "') ", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Staff Successfully Added");
            Con.Close();
            populate();
        }

        private void StaffGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Staffid_txt.Text = StaffGridView.SelectedRows[0].Cells[0].Value.ToString();
            StaffName_txt.Text = StaffGridView.SelectedRows[0].Cells[1].Value.ToString();
            StaffPhone_txt.Text = StaffGridView.SelectedRows[0].Cells[2].Value.ToString();
            password_txt.Text = StaffGridView.SelectedRows[0].Cells[4].Value.ToString();
        }
        private void Staffinfo_Load(object sender, EventArgs e)
        {
            
            populate();
            DateClient_lbl.Text = DateTime.Today.Day.ToString() + "." + DateTime.Today.Month.ToString() + "." + DateTime.Today.Year.ToString();

        }
       
        private void StaffEdit_btn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string myquery = "UPDATE  dbo.Staff_tbl set StaffName = '" + StaffName_txt.Text + "',StaffPhone = '" + StaffPhone_txt.Text + "',Gender = '" + Gender_com.SelectedItem.ToString() + "',Staffpassword = '" + password_txt.Text + "'where StaffId = " + Staffid_txt.Text + ";";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Staff Successfully Edited");
            Con.Close();
            populate();
        }

        private void StaffDelete_btn_Click(object sender, EventArgs e)
        {
            Con.Open();
            String query = "delete from dbo.Staff_tbl where StaffId = " + Staffid_txt.Text + ";";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Staff Successfully Deleted");
            Con.Close();
            populate();
        }

        private void StaffSearch_btn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "select * from dbo.Staff_tbl where StaffName ='" + staffSearch_txt.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cduilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            StaffGridView.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void DateClient_lbl_Click(object sender, EventArgs e)
        {

        }

        private void backward_btn_Click(object sender, EventArgs e)
        {
            MainForm Stlogin = new MainForm();
            Stlogin.Show();
            this.Hide();
        }

        private void ref_btn_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
