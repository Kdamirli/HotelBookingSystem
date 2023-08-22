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
    public partial class TurAgentLog : Form
    {
        Func func = new Func();
        String query;
        public TurAgentLog()
        {
            InitializeComponent();
            tbPassword.UseSystemPasswordChar = true;
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text != "" && tbLogin.Text != "")
            {
                query = "select * from UsersAc";
                string log = func.getUserInfo(query, 1, 2).Item1;
                string pass = func.getUserInfo(query, 1, 2).Item2;
                if (log == tbLogin.Text && pass == tbPassword.Text)
                {
                    TurAgentForm mf = new TurAgentForm();
                    this.Hide();
                    mf.Show();
                }
                else
                {
                    MessageBox.Show("Пользователя не существует!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Не все поля заполнены", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch1.Checked)
            {
                tbPassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbPassword.UseSystemPasswordChar = true;
            }
        }

        private void loginLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TurAgentReg reg = new TurAgentReg();
            this.Hide();
            reg.Show();
        }
    }
}
