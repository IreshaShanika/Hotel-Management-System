using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelManagementProject
{
    public partial class Splashfrom : Form
    {
        public Splashfrom()
        {
            InitializeComponent();
        }
        int startpoint = 0;
        private void timer1_Tict(object sender, EventArgs e)
        {
            startpoint += 1;
            BarHotl.Value = startpoint;
            if(BarHotl.Value == 100)
            {
                BarHotl.Value = 0;
                timer1.Stop();
                Form1 Login = new Form1();
                Login.Show();
                this.Hide();
            }
        }

        private void Splashfrom_Load(object sender, EventArgs e)
        {
            
        }

        private void BarHotl_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
        }
    }
}
