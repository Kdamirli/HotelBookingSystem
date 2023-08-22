using HotelBookingSystem.addRoomDSTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HotelBookingSystem.User_Controls
{
    public partial class UCRoom : UserControl
    {
        addRoomViewTableAdapter addRoomView = new addRoomViewTableAdapter();
        public UCRoom()
        {
            InitializeComponent();
        }

        private void UCRoom_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = addRoomView.GetData();
        }
    }
}
