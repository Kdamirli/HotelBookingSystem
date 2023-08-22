using HotelBookingSystem.addHotelDSTableAdapters;
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
    public partial class UCHotel : UserControl
    {
        addHotelViewTableAdapter addHotelView = new addHotelViewTableAdapter();
        public UCHotel()
        {
            InitializeComponent();
        }

        private void UCHotel_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = addHotelView.GetData();
        }
    }
}
