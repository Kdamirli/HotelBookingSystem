using HotelBookingSystem.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBookingSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2ImageButton7_Click(object sender, EventArgs e)
        {
            if (!guna2Panel2.Visible) guna2Transition1.ShowSync(guna2Panel2);
            else guna2Transition1.HideSync(guna2Panel2);
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            ucAddRoom1.Visible = true;
            ucAddHotel1.Visible = false;
            ucAddLodger1.Visible = false;
            ucAddRoomType1.Visible = false;
            ucAddCheckIn1.Visible = false;
            ucSearch1.Visible = false;
            BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ucAddRoom1.Visible = false;
            ucAddHotel1.Visible = false;
            ucAddLodger1.Visible = false;
            ucAddRoomType1.Visible = false;
            ucAddCheckIn1.Visible = false;
            ucSearch1.Visible = false;
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            ucAddHotel1.Visible = true;
            ucAddRoom1.Visible = false;
            ucAddLodger1.Visible = false;
            ucAddRoomType1.Visible = false;
            ucAddCheckIn1.Visible = false;
            ucSearch1.Visible = false;
            BringToFront();
        }

        private void guna2ImageButton6_Click(object sender, EventArgs e)
        {
            ucAddHotel1.Visible = false;
            ucAddRoom1.Visible = false;
            ucAddLodger1.Visible = true;
            ucAddRoomType1.Visible = false;
            ucAddCheckIn1.Visible = false;
            ucSearch1.Visible = false;
            BringToFront();
        }

        private void guna2ImageButton5_Click(object sender, EventArgs e)
        {
            ucAddHotel1.Visible = false;
            ucAddRoom1.Visible = false;
            ucAddLodger1.Visible = false;
            ucAddRoomType1.Visible = true;
            ucAddCheckIn1.Visible = false;
            ucSearch1.Visible = false;
            BringToFront();
        }

        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {
            ucAddCheckIn1.Visible=true;
            ucAddHotel1.Visible = false;
            ucAddRoom1.Visible = false;
            ucAddLodger1.Visible = false;
            ucAddRoomType1.Visible = false;
            ucSearch1.Visible = false;
            this.BringToFront();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            ucAddCheckIn1.Visible = false;
            ucAddHotel1.Visible = false;
            ucAddRoom1.Visible = false;
            ucAddLodger1.Visible = false;
            ucAddRoomType1.Visible = false;
            ucSearch1.Visible = true;
            this.BringToFront();
        }

        private void guna2ImageButton8_Click(object sender, EventArgs e)
        {
            MakeAChoice make = new MakeAChoice();
            this.Hide();
            make.Show();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}