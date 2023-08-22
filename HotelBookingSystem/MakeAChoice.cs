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
    public partial class MakeAChoice : Form
    {
        public MakeAChoice()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            AdminReg reg = new AdminReg();
            this.Hide();
            reg.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            TurAgentReg reg = new TurAgentReg();
            this.Hide();
            reg.Show();
        }
    }
}
