using HotelBookingSystem.addLodgerDSTableAdapters;
using HotelBookingSystem.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HotelBookingSystem.User_Controls
{
    public partial class UCSearch : UserControl
    {
        HotelBookingSystemEntities db = new HotelBookingSystemEntities();
        zap1TableAdapter zap1 = new zap1TableAdapter();
        zap2TableAdapter zap2 = new zap2TableAdapter();
        zap3TableAdapter zap3 = new zap3TableAdapter();
        zap4TableAdapter zap4 = new zap4TableAdapter();
        zap5TableAdapter zap5 = new zap5TableAdapter();
        zap6TableAdapter zap6 = new zap6TableAdapter();
        zap7TableAdapter zap7 = new zap7TableAdapter();
        agent_hotel_room_availabilityTableAdapter agent_Hotel_Room_Availability = new agent_hotel_room_availabilityTableAdapter();
        ownerIncomeTableAdapter owner = new ownerIncomeTableAdapter();
        Func func = new Func();
        addLodgerViewTableAdapter addLodger = new addLodgerViewTableAdapter();
        search2TableAdapter search2 = new search2TableAdapter();
        SqlConnection con = new SqlConnection("data source = DESKTOP-70L43IK\\MSSQLSERVER03; database=HotelBookingSystem; integrated security = True");

        public UCSearch()
        {
            InitializeComponent();
        }

        public void setComboBox(String query, ComboBox combo)
        {
            SqlDataReader sdr = func.getForCombo(query);
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
        }

        private void cbQuery_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView.Visible = true;
            switch (cbQuery.SelectedIndex)
            {
                case 0:
                    dataGridView.DataSource = zap1.GetData();
                    MessageBox.Show("Описание запроса:\nСписок всех 2-комнатных номеров отелей, с ценой менее 200 тыс.руб. упорядоченные в порядке уменьшения стоимости", cbQuery.Text, MessageBoxButtons.OK);
                    break;
                case 1:
                    dataGridView.DataSource = zap2.GetData();
                    MessageBox.Show("Описание запроса:\nВсе записи регистрации постояльцев, которые выехали из отелей в течение двух последних недель", cbQuery.Text, MessageBoxButtons.OK);
                    break;
                case 2:
                    dataGridView.DataSource = zap3.GetData();
                    MessageBox.Show("Описание запроса:\nВывод средней стоимости номера в каждом из отелей", cbQuery.Text, MessageBoxButtons.OK);
                    break;
                case 3:
                    dataGridView.DataSource = zap4.GetData();
                    MessageBox.Show("Описание запроса:\nВывод общего суточного дохода от всех заселенных номеров каждого типа", cbQuery.Text, MessageBoxButtons.OK);
                    break;
                case 4:
                    dataGridView.DataSource = zap5.GetData();
                    MessageBox.Show("Описание запроса:\nСписок свободных номеров одного из отелей", cbQuery.Text, MessageBoxButtons.OK);
                    break;
                case 5:
                    dataGridView.DataSource = zap6.GetData();
                    MessageBox.Show("Описание запроса:\nВывод общих потерь от наличия в данном отеле свободных номеров за текущий день", cbQuery.Text, MessageBoxButtons.OK);
                    break;
                case 6:
                    dataGridView.DataSource = zap7.GetData();
                    MessageBox.Show("Описание запроса:\nКоличество номеров в каждом из отелей", cbQuery.Text, MessageBoxButtons.OK);
                    break;
                case 7:
                    dataGridView.DataSource = agent_Hotel_Room_Availability.GetData();
                    MessageBox.Show("Описание запроса:\nСписок свободных номеров в каждом отеле", cbQuery.Text, MessageBoxButtons.OK);
                    break;
                case 8:
                    dataGridView.DataSource = owner.GetData();
                    MessageBox.Show("Описание запроса:\nИнформация о доходах по каждому отелю", cbQuery.Text, MessageBoxButtons.OK);
                    break;
                case 9:
                    uCupdate_room_prices1.Visible = true;
                    uCupdate_room_prices1.BringToFront();
                    break;
                case 10:
                    ucGetAvailableRooms1.Visible = true;
                    ucGetAvailableRooms1.BringToFront();
                    break;
                case 11:
                    ucBookRoom1.Visible = true;
                    ucBookRoom1.BringToFront();
                    break;
            }
        }

        private void closeProcedures_Click(object sender, EventArgs e)
        {
            dataGridView.Visible = false;
            cbQuery.SelectedIndex = -1;
            uCupdate_room_prices1.Visible = false;
            ucGetAvailableRooms1.Visible = false;
            ucBookRoom1.Visible = false;
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            uCupdate_room_prices1.Visible = false;
            ucBookRoom1.Visible = false;
            ucGetAvailableRooms1.Visible = false;
        }

        private void cbSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbSearchBy.SelectedIndex) 
            {
                case 0:
                    guna2DataGridView1.DataSource = addLodger.GetData();
                    break;
                case 1:
                    guna2DataGridView1.DataSource = search2.GetData();
                    break;
            }
        }

        private void getRecord(String query1)
        {
            DataSet ds = func.getData(query1);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT TOP 10 room.roomNo, COUNT(checkIn.id) as num_checkins FROM room INNER JOIN checkIn ON room.id = checkIn.room_id WHERE room.hotel_id = " + (guna2ComboBox1.SelectedIndex + 1) + " GROUP BY room.roomNo ORDER BY num_checkins DESC", con);
            da.Fill(dt);
            chart1.DataSource = dt;
            con.Close();
            chart1.Series["roomTop"].XValueMember = "roomNo";
            chart1.Series["roomTop"].YValueMembers = "num_checkins";
            chart1.Titles.Add("Statistics");
        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            guna2ComboBox1.Items.Clear();
            setComboBox("select title from hotel" ,guna2ComboBox1);
        }
    }
}
