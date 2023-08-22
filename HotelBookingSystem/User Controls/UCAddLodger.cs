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
    public partial class UCAddLodger : UserControl
    {
        HotelBookingSystemEntities db;
        lodger lodger = new lodger();

        public UCAddLodger()
        {
            InitializeComponent();
        }

        private void clearAll()
        {
            tbAddress.Clear();
            tbFio.Clear();
        }

        private void UCAddLodger_Load(object sender, EventArgs e)
        {
            db = new HotelBookingSystemEntities();
            this.addLodgerViewTableAdapter.Fill(this.addLodgerDS.addLodgerView);
        }

        private void UCAddLodger_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void UCAddLodger_Enter(object sender, EventArgs e)
        {
            UCAddLodger_Load(this, null);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if(tbFio.Text != "" && tbAddress.Text != "")
            {
                lodger.fio = tbFio.Text.Trim();
                lodger.address = tbAddress.Text.Trim();
                db.lodger.Add(lodger);
                db.SaveChanges();
                MessageBox.Show("Посетитель добавлен!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UCAddLodger_Load(this, null);
            }
            else
            {
                MessageBox.Show("Заполните все поля", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
