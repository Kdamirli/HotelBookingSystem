namespace HotelBookingSystem.User_Controls
{
    partial class ucBookRoom
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucBookRoom));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btAdd = new Guna.UI2.WinForms.Guna2Button();
            this.dtCheckOut = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtCheckIn = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbLodger = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbHotel = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbRoom = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(947, 72);
            this.label1.TabIndex = 17;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // btAdd
            // 
            this.btAdd.Animated = true;
            this.btAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.btAdd.BorderColor = System.Drawing.Color.White;
            this.btAdd.BorderRadius = 15;
            this.btAdd.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btAdd.BorderThickness = 1;
            this.btAdd.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btAdd.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btAdd.CheckedState.Parent = this.btAdd;
            this.btAdd.CustomImages.Parent = this.btAdd;
            this.btAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.btAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btAdd.ForeColor = System.Drawing.Color.White;
            this.btAdd.HoverState.Parent = this.btAdd;
            this.btAdd.Location = new System.Drawing.Point(585, 107);
            this.btAdd.Name = "btAdd";
            this.btAdd.ShadowDecoration.Parent = this.btAdd;
            this.btAdd.Size = new System.Drawing.Size(97, 36);
            this.btAdd.TabIndex = 53;
            this.btAdd.Text = "Заселить";
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // dtCheckOut
            // 
            this.dtCheckOut.Animated = true;
            this.dtCheckOut.BorderColor = System.Drawing.Color.White;
            this.dtCheckOut.BorderThickness = 1;
            this.dtCheckOut.CheckedState.Parent = this.dtCheckOut;
            this.dtCheckOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.dtCheckOut.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.dtCheckOut.ForeColor = System.Drawing.Color.White;
            this.dtCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCheckOut.HoverState.Parent = this.dtCheckOut;
            this.dtCheckOut.Location = new System.Drawing.Point(430, 107);
            this.dtCheckOut.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtCheckOut.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtCheckOut.Name = "dtCheckOut";
            this.dtCheckOut.ShadowDecoration.Parent = this.dtCheckOut;
            this.dtCheckOut.Size = new System.Drawing.Size(140, 36);
            this.dtCheckOut.TabIndex = 52;
            this.dtCheckOut.Value = new System.DateTime(2023, 3, 22, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(426, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 51;
            this.label6.Text = "Дата отъезда";
            // 
            // dtCheckIn
            // 
            this.dtCheckIn.Animated = true;
            this.dtCheckIn.BorderColor = System.Drawing.Color.White;
            this.dtCheckIn.BorderThickness = 1;
            this.dtCheckIn.CheckedState.Parent = this.dtCheckIn;
            this.dtCheckIn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.dtCheckIn.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.dtCheckIn.ForeColor = System.Drawing.Color.White;
            this.dtCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCheckIn.HoverState.Parent = this.dtCheckIn;
            this.dtCheckIn.Location = new System.Drawing.Point(273, 107);
            this.dtCheckIn.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtCheckIn.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtCheckIn.Name = "dtCheckIn";
            this.dtCheckIn.ShadowDecoration.Parent = this.dtCheckIn;
            this.dtCheckIn.Size = new System.Drawing.Size(140, 36);
            this.dtCheckIn.TabIndex = 50;
            this.dtCheckIn.Value = new System.DateTime(2023, 3, 22, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(269, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 49;
            this.label5.Text = "Дата заезда";
            // 
            // cbLodger
            // 
            this.cbLodger.Animated = true;
            this.cbLodger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.cbLodger.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLodger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLodger.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.cbLodger.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLodger.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLodger.FocusedState.Parent = this.cbLodger;
            this.cbLodger.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.cbLodger.ForeColor = System.Drawing.Color.White;
            this.cbLodger.HoverState.Parent = this.cbLodger;
            this.cbLodger.ItemHeight = 30;
            this.cbLodger.ItemsAppearance.Parent = this.cbLodger;
            this.cbLodger.Location = new System.Drawing.Point(7, 107);
            this.cbLodger.Name = "cbLodger";
            this.cbLodger.ShadowDecoration.Parent = this.cbLodger;
            this.cbLodger.Size = new System.Drawing.Size(229, 36);
            this.cbLodger.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbLodger.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "Выберите посетителя";
            // 
            // cbHotel
            // 
            this.cbHotel.Animated = true;
            this.cbHotel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.cbHotel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbHotel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHotel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.cbHotel.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbHotel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbHotel.FocusedState.Parent = this.cbHotel;
            this.cbHotel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.cbHotel.ForeColor = System.Drawing.Color.White;
            this.cbHotel.HoverState.Parent = this.cbHotel;
            this.cbHotel.ItemHeight = 30;
            this.cbHotel.ItemsAppearance.Parent = this.cbHotel;
            this.cbHotel.Location = new System.Drawing.Point(273, 181);
            this.cbHotel.Name = "cbHotel";
            this.cbHotel.ShadowDecoration.Parent = this.cbHotel;
            this.cbHotel.Size = new System.Drawing.Size(177, 36);
            this.cbHotel.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbHotel.TabIndex = 55;
            this.cbHotel.SelectedIndexChanged += new System.EventHandler(this.cbHotel_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(269, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 54;
            this.label2.Text = "Выберите отель";
            // 
            // cbRoom
            // 
            this.cbRoom.Animated = true;
            this.cbRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.cbRoom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.cbRoom.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbRoom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbRoom.FocusedState.Parent = this.cbRoom;
            this.cbRoom.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.cbRoom.ForeColor = System.Drawing.Color.White;
            this.cbRoom.HoverState.Parent = this.cbRoom;
            this.cbRoom.ItemHeight = 30;
            this.cbRoom.ItemsAppearance.Parent = this.cbRoom;
            this.cbRoom.Location = new System.Drawing.Point(467, 181);
            this.cbRoom.Name = "cbRoom";
            this.cbRoom.ShadowDecoration.Parent = this.cbRoom;
            this.cbRoom.Size = new System.Drawing.Size(177, 36);
            this.cbRoom.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbRoom.TabIndex = 57;
            this.cbRoom.SelectedIndexChanged += new System.EventHandler(this.cbRoom_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(463, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 20);
            this.label4.TabIndex = 56;
            this.label4.Text = "Выберите комнату";
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            this.guna2DataGridView1.AllowUserToResizeColumns = false;
            this.guna2DataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 25;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.EnableHeadersVisualStyles = false;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(7, 232);
            this.guna2DataGridView1.MultiSelect = false;
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView1.Size = new System.Drawing.Size(696, 206);
            this.guna2DataGridView1.TabIndex = 58;
            this.guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 25;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // ucBookRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.cbRoom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbHotel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.dtCheckOut);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtCheckIn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbLodger);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "ucBookRoom";
            this.Size = new System.Drawing.Size(1052, 467);
            this.Load += new System.EventHandler(this.ucBookRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btAdd;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtCheckOut;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtCheckIn;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox cbLodger;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cbHotel;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cbRoom;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
    }
}
