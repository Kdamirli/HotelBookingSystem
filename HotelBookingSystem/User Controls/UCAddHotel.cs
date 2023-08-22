using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HotelBookingSystem.User_Controls
{
    public partial class UCAddHotel : UserControl
    {
        HotelBookingSystemEntities db;
        hotel hotel1 = new hotel();

        public UCAddHotel()
        {
            InitializeComponent();
        }

        public void clearAll()
        {
            tbAddress.Clear();
            tbRoomCount.Clear();
            tbTitle.Clear();
        }

        private void UCAddHotel_Load(object sender, EventArgs e)
        {
            db = new HotelBookingSystemEntities();
            this.addHotelViewTableAdapter.Fill(this.addHotelDS.addHotelView);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if(tbAddress.Text != "" &&  tbRoomCount.Text != "" && tbTitle.Text != "")
            {
                hotel1.title = tbTitle.Text.Trim();
                hotel1.address = tbAddress.Text.Trim();
                hotel1.room_count = Convert.ToInt32(tbRoomCount.Text.Trim());
                db.hotel.Add(hotel1);
                db.SaveChanges();
                MessageBox.Show("Гостиница добавлена!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UCAddHotel_Load(this, null);
            }
            else
            {
                MessageBox.Show("Заполните все поля", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (tbAddress.Text != "" && tbRoomCount.Text != "" && tbTitle.Text != "")
            {
                hotel1.title = tbTitle.Text.Trim();
                hotel1.address = tbAddress.Text.Trim();
                hotel1.room_count = Convert.ToInt32(tbRoomCount.Text.Trim());
                db.Entry(hotel1).State = EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show("Данные изменены!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UCAddHotel_Load(this, null);
            }
            else
            {
                MessageBox.Show("Выберите поле которое хотите изменить!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbTitle.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbAddress.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbRoomCount.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void UCAddHotel_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void UCAddHotel_Enter(object sender, EventArgs e)
        {
            UCAddHotel_Load(this, null);
        }
    }
}
