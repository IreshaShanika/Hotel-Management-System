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
    public partial class RoomInfo : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\Hoteldb1.mdf;Integrated Security=True;Connect Timeout=30");
        public void populate()
        {
            Con.Open();
            string Myquery = "select * from dbo.Room_tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cduilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            RoomGridView.DataSource = ds.Tables[0];
            Con.Close();
        }
        public RoomInfo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void roomadd_btn_Click(object sender, EventArgs e)
        {
            string isfree;
            if (yes_rebtn.Checked == true)
                isfree = "free";
            else
                isfree = "busy";
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into dbo.Room_tbl values (" + RoomId_txt.Text + ",'" + RoomPhone_txt.Text + "', '" + isfree + "') ", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Room Successfully Added");
            Con.Close();
            populate();
        }
        private void Staffinfo_Load(object sender, EventArgs e)
        {
            DateClient_lbl.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            populate();
        }

        private void RoomGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RoomId_txt.Text = RoomGridView.SelectedRows[0].Cells[0].Value.ToString();
            RoomPhone_txt.Text = RoomGridView.SelectedRows[0].Cells[1].Value.ToString();
            
        }

        private void RoomDelete_btn_Click(object sender, EventArgs e)
        {
            Con.Open();
            String query = "delete from dbo.Room_tbl where StaffId = " + RoomId_txt.Text + ";";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Room Successfully Deleted");
            Con.Close();
            populate();
        }

        private void Roomedit_btn_Click(object sender, EventArgs e)
        {
            string isfree;
            if (yes_rebtn.Checked == true)
                isfree = "free";
            else
                isfree = "busy";
            Con.Open();
            string myquery = "UPDATE  dbo.Room_tbl set RoomPhone = '" + RoomPhone_txt.Text + "',RoomFree = '" + isfree + "'where RoomId = " + RoomId_txt.Text + ";";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Room Successfully Edited");
            Con.Close();
            populate();
        }

        private void roomsearch_btn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "select * from dbo.Room_tbl where RoomId ='" + RoomSearch_txt.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cduilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            RoomGridView.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void RoomInfo_Load(object sender, EventArgs e)
        {
            populate();
            DateClient_lbl.Text = DateTime.Today.Day.ToString() + "." + DateTime.Today.Month.ToString() + "." + DateTime.Today.Year.ToString();
        }

        private void backward_btn_Click(object sender, EventArgs e)
        {
            MainForm rlogin = new MainForm();
            rlogin.Show();
            this.Hide();

        }

        private void ref_btn_Click(object sender, EventArgs e)
        {
            populate();


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
