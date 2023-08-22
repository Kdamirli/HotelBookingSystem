using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace HotelBookingSystem.User_Controls
{
    public partial class UCAddRoomType : UserControl
    {
        HotelBookingSystemEntities db;
        roomType roomTp = new roomType();

        public UCAddRoomType()
        {
            InitializeComponent();
        }

        public void clearAll()
        {
            tbCharacteristics.Clear();
            tbType.Clear();
        }

        private void UCAddRoomType_Load(object sender, EventArgs e)
        {
            db = new HotelBookingSystemEntities();
            this.addRoomTypeViewTableAdapter.Fill(this.addRoomTypeDS.addRoomTypeView);
        }

        private void UCAddRoomType_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void UCAddRoomType_Enter(object sender, EventArgs e)
        {
            UCAddRoomType_Load(this, null);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if(tbType.Text != "" && tbCharacteristics.Text != "")
            {
                roomTp.type_title = tbType.Text.Trim();
                roomTp.characteristics = tbCharacteristics.Text.Trim();
                db.roomType.Add(roomTp);
                db.SaveChanges();
                MessageBox.Show("Тип комнаты добавлен!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UCAddRoomType_Load(this, null);
            }
            else
            {
                MessageBox.Show("Заполните все поля", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (tbType.Text != "" && tbCharacteristics.Text != "")
            {
                roomTp.type_title = tbType.Text.Trim();
                roomTp.characteristics = tbCharacteristics.Text.Trim();
                db.Entry(roomTp).State = EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show("Данные изменены!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UCAddRoomType_Load(this, null);
            }
            else
            {
                MessageBox.Show("Выберите поле которое хотите изменить!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbType.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbCharacteristics.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
