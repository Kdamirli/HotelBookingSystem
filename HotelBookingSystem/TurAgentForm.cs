using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HotelBookingSystem
{
    public partial class TurAgentForm : Form
    {
        
        public TurAgentForm()
        {
            InitializeComponent();
        }

        private void ibSearch_Click(object sender, EventArgs e)
        {
            ucRoom1.Visible = false;
            ucHotel1.Visible = false;
            ucLodger1.Visible = false;
            ucRoomType1.Visible = false;
            ucSearch1.Visible = true;
            ucCheckIn1.Visible = false;
            BringToFront();
        }

        private void ibAddRoom_Click(object sender, EventArgs e)
        {
            ucRoom1.Visible = true;
            ucHotel1.Visible = false;
            ucLodger1.Visible = false;
            ucRoomType1.Visible = false;
            ucSearch1.Visible = false;
            ucCheckIn1.Visible = false;
            BringToFront();
        }

        private void ibHotel_Click(object sender, EventArgs e)
        {
            ucRoom1.Visible = false;
            ucHotel1.Visible = true;
            ucLodger1.Visible = false;
            ucRoomType1.Visible = false;
            ucSearch1.Visible = false;
            ucCheckIn1.Visible = false;
            BringToFront();
        }

        private void ibLodger_Click(object sender, EventArgs e)
        {
            ucRoom1.Visible = false;
            ucHotel1.Visible = false;
            ucLodger1.Visible = true;
            ucRoomType1.Visible = false;
            ucSearch1.Visible = false;
            ucCheckIn1.Visible = false;
            BringToFront();
        }

        private void ibRoomType_Click(object sender, EventArgs e)
        {
            ucRoom1.Visible = false;
            ucHotel1.Visible = false;
            ucLodger1.Visible = false;
            ucRoomType1.Visible = true;
            ucSearch1.Visible = false;
            ucCheckIn1.Visible = false;
            BringToFront();
        }

        private void ibCheckIn_Click(object sender, EventArgs e)
        {
            ucRoom1.Visible = false;
            ucHotel1.Visible = false;
            ucLodger1.Visible = false;
            ucRoomType1.Visible = false;
            ucSearch1.Visible = false;
            ucCheckIn1.Visible = true;
            BringToFront();
        }

        private void ibLogOut_Click(object sender, EventArgs e)
        {
            MakeAChoice make = new MakeAChoice();
            this.Hide();
            make.Show();
        }

        private void guna2ImageButton7_Click(object sender, EventArgs e)
        {
            if (!guna2Panel2.Visible) guna2Transition1.ShowSync(guna2Panel2);
            else guna2Transition1.HideSync(guna2Panel2);
        }

        private void TurAgentForm_Load(object sender, EventArgs e)
        {
            ucRoom1.Visible = false;
            ucHotel1.Visible = false;
            ucLodger1.Visible = false;
            ucRoomType1.Visible = false;
            ucSearch1.Visible = false;
            ucCheckIn1.Visible = false;
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
