using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelManagementProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reservationinfo Resinfo = new Reservationinfo();
            Resinfo.Show();
            this.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void X_lbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void Client_btn_Click(object sender, EventArgs e)
        {
            ClientInfo clinfo = new ClientInfo();
            clinfo.Show();
            this.Hide();
        }

        private void Staff_btn_Click(object sender, EventArgs e)
        {
            Staffinfo Stinfo = new Staffinfo();
            Stinfo.Show();
            this.Hide();
        }

        private void Room_btn_Click(object sender, EventArgs e)
        {
            RoomInfo Roinfo = new RoomInfo();
            Roinfo.Show();
            this.Hide();
        }

        private void Main_Form_lbl_Click(object sender, EventArgs e)
        {

        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }
    }
}
