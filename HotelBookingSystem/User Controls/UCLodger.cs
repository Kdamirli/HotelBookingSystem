using HotelBookingSystem.addLodgerDSTableAdapters;
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
    public partial class UCLodger : UserControl
    {
        addLodgerViewTableAdapter addLodgerView = new addLodgerViewTableAdapter();
        public UCLodger()
        {
            InitializeComponent();
        }

        private void UCLodger_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = addLodgerView.GetData();
        }
    }
}
