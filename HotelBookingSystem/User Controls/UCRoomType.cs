using HotelBookingSystem.addRoomTypeDSTableAdapters;
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
    public partial class UCRoomType : UserControl
    {
        addRoomTypeViewTableAdapter addRoomTypeView = new addRoomTypeViewTableAdapter();
        public UCRoomType()
        {
            InitializeComponent();
        }

        private void UCRoomType_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = addRoomTypeView.GetData();
        }
    }
}
