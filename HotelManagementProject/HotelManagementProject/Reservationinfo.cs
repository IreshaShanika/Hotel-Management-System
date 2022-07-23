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
    public partial class Reservationinfo : Form
    {
        public Reservationinfo()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\Hoteldb1.mdf;Integrated Security=True;Connect Timeout=30");
        DateTime today;
        public void populate()
        {
            Con.Open();
            string Myquery = "select * from dbo.Reservation_tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cduilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            RedGridView.DataSource = ds.Tables[0];
            Con.Close();
        }
        public void fillRoomcombo()
        {
            Con.Open();
            string roomstate = "free";
            SqlCommand cmd = new SqlCommand("select RoomId from dbo.Room_tbl where RoomFree = '"+roomstate+"'",Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("RoomId", typeof(int));
            dt.Load(rdr);
            RedRoom_txt.ValueMember = "RoomId";
            RedRoom_txt.DataSource = dt;
            Con.Close();
        }

        public void fillClientcombo()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select ClientName from dbo.Client_tbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ClientName", typeof(string));
            dt.Load(rdr);
            Redcliend_txt.ValueMember = "ClientName";
            Redcliend_txt.DataSource = dt;
            Con.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DateIn_lbl_Click(object sender, EventArgs e)
        {

        }

        private void Reservationinfo_Load(object sender, EventArgs e)
        {
            today = dateIn.Value;
            fillRoomcombo();
            fillClientcombo();
            populate();
        }

        private void dateTimePicker_red_ValueChanged(object sender, EventArgs e)
        {
            int res = DateTime.Compare(dateIn.Value, today);
            if (res < 0)
                MessageBox.Show("Wrong Data for Reservation");
        }

        private void Dateout_ValueChanged(object sender, EventArgs e)
        {
            int res = DateTime.Compare(Dateout.Value, dateIn.Value);
            if (res < 0)
                MessageBox.Show("Wrong Date. Check once more");
        }
        public void updateroomstate()
        {
            Con.Open();
            String newstate = "busy";
            string myquery = "UPDATE  dbo.Room_tbl set RoomFree = '" + newstate + "'where RoomId = " + Convert.ToInt32(Redcliend_txt.SelectedValue.ToString()) + ";";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.ExecuteNonQuery();
            //MessageBox.Show("Reservation Successfully Edited");
            Con.Close();
            fillRoomcombo();
        }

        public void updateroomondelete()
        {
            Con.Open();
            String newstate = "free";
            int roomid= Convert.ToInt32(RedGridView.SelectedRows[0].Cells[2].Value.ToString());
            string myquery = "UPDATE  dbo.Room_tbl set RoomFree = '" + newstate + "'where RoomId = " +roomid+ ";";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.ExecuteNonQuery();
            //MessageBox.Show("Reservation Successfully Edited");
            Con.Close();
            fillRoomcombo();
        }

        private void RedAdd_btn_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into dbo.Reservation_tbl values (" + RedId_txt.Text + ",'" + Redcliend_txt.SelectedValue.ToString() + "', '" + RedRoom_txt.SelectedValue.ToString() + "','" +dateIn.Value+ "','" + Dateout.Text + "') ", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Reservatioinfo Successfully Added");
            Con.Close();
            updateroomstate();
            populate();
            
        }

        private void RedId_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void RedEdit_btn_Click(object sender, EventArgs e)
        {
            if(RedId_txt.Text == "")
            {
                MessageBox.Show("Empty ResId,Enter The Reservation Id");
            }
            else { 
            Con.Open();
            string myquery = "UPDATE  dbo.Reservation_tbl set Client = '" + Redcliend_txt.SelectedValue.ToString() + "',Room = '" + RedRoom_txt.SelectedValue.ToString() + "',RoomIn = '" + dateIn.Value.ToString() + "',RoomOut = '" + Dateout.Value.ToString() + "'where RedId = " + RedId_txt.Text + ";";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Reservation Successfully Edited");
            Con.Close();
            populate();
        }
        }

        private void RedGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RedId_txt.Text = RedGridView.SelectedRows[0].Cells[0].Value.ToString();
            
        }

        private void RedRoom_txt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RedDelete_btn_Click(object sender, EventArgs e)
        {
            if (RedId_txt.Text == "")
            {
                MessageBox.Show("Enter the Reservation to be deleted");
            }
            else
            {


                Con.Open();
                String query = "delete from dbo.Reservation_tbl where RedId = " + RedId_txt.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Reservation Successfully Deleted");
                Con.Close();
                updateroomondelete();
                populate();
            }
        }

        private void Redsearch_btn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "select * from dbo.Reservation_tbl where RedId ='" + RedSearch_txt.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cduilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            RedGridView.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void RedPic_Click(object sender, EventArgs e)
        {
         
            populate();
        }

        private void DateClient_lbl_Click(object sender, EventArgs e)
        {
            today = dateIn.Value;
            fillRoomcombo();
            fillClientcombo();
            populate();
            DateClient_lbl.Text = DateTime.Today.Day.ToString()+"."+DateTime.Today.Month.ToString()+"."+DateTime.Today.Year.ToString();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void backward_btn_Click(object sender, EventArgs e)
        {
            MainForm Relogin = new MainForm();
            Relogin.Show();
            this.Hide();
        }

        private void Redcliend_txt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
