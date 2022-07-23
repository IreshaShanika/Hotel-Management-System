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
    public partial class ClientInfo : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=Hoteldb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public void populate()
        {
            Con.Open();
            string Myquery = "select * from dbo.Client_tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cduilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            CliendGridView.DataSource = ds.Tables[0];
            Con.Close();
        }
            public ClientInfo()
        {
            InitializeComponent();
        }


        private void Clientid_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClientInfo_Load(object sender, EventArgs e)
        {
            //DateClient_lbl.Text = DateTime.Now.ToLongTimeString();
            //timer1.Start();
            DateClient_lbl.Text = DateTime.Today.Day.ToString() + "." + DateTime.Today.Month.ToString() + "." + DateTime.Today.Year.ToString();
            populate();
        }

        private void AddClient_btn_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into dbo.Client_tbl values ("+ Clientid_txt.Text+",'"+Clientidname_txt.Text+"', '"+ PhoneNumber_txt.Text+ "','"+clientcountry_com.SelectedItem.ToString()+"') ", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cliend Successfully Added");
            Con.Close();
            populate();
        }

        

        private void CliendGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Clientid_txt.Text = CliendGridView.SelectedRows[0].Cells[0].Value.ToString();
            Clientidname_txt.Text = CliendGridView.SelectedRows[0].Cells[1].Value.ToString();
            PhoneNumber_txt.Text = CliendGridView.SelectedRows[0].Cells[2].Value.ToString();



        }
        private void Editclient_btn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string myquery = "UPDATE  dbo.Client_tbl set ClientName = '" + Clientidname_txt.Text + "',ClientPhone = '" + PhoneNumber_txt.Text + "',ClientCountry = '" + clientcountry_com.SelectedItem.ToString() + "'where ClientId = "+Clientid_txt.Text+";";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cliend Successfully Edited");
            Con.Close();
            populate();

        }
        private void DeleteClient_btn_Click(object sender, EventArgs e)
        {
            Con.Open();
            String query = "delete from dbo.Client_tbl where ClientId = "+Clientid_txt.Text+";";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cliend Successfully Deleted");
            Con.Close();
            populate();
        }

        private void SearchClient_btn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "select * from dbo.Client_tbl where ClientName ='"+ Searchclient_txt.Text+"'";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cduilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            CliendGridView.DataSource = ds.Tables[0];
            Con.Close();

        }

        private void Searchclient_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void backward_btn_Click(object sender, EventArgs e)
        {
            MainForm Cllogin = new MainForm();
            Cllogin.Show();
            this.Hide();
        }
    }
}
