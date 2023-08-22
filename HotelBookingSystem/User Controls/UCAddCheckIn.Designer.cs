namespace HotelBookingSystem.User_Controls
{
    partial class UCAddCheckIn
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.фиоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерКомнатыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отельDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаЗаездаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаОтъездаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.общаяСтоимостьПроживанияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addCheckInViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addCheckInDS = new HotelBookingSystem.addCheckInDS();
            this.label1 = new System.Windows.Forms.Label();
            this.cbLodger = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btAdd = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbHotel = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbRoomNo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtCheckIn = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtCheckOut = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cbRoomType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addCheckInViewTableAdapter = new HotelBookingSystem.addCheckInDSTableAdapters.addCheckInViewTableAdapter();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addCheckInViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addCheckInDS)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            this.guna2DataGridView1.AllowUserToResizeColumns = false;
            this.guna2DataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.guna2DataGridView1.AutoGenerateColumns = false;
            this.guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.guna2DataGridView1.ColumnHeadersHeight = 25;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фиоDataGridViewTextBoxColumn,
            this.номерКомнатыDataGridViewTextBoxColumn,
            this.отельDataGridViewTextBoxColumn,
            this.датаЗаездаDataGridViewTextBoxColumn,
            this.датаОтъездаDataGridViewTextBoxColumn,
            this.общаяСтоимостьПроживанияDataGridViewTextBoxColumn});
            this.guna2DataGridView1.DataSource = this.addCheckInViewBindingSource;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle15;
            this.guna2DataGridView1.EnableHeadersVisualStyles = false;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(9, 60);
            this.guna2DataGridView1.MultiSelect = false;
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView1.Size = new System.Drawing.Size(801, 542);
            this.guna2DataGridView1.TabIndex = 16;
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
            // фиоDataGridViewTextBoxColumn
            // 
            this.фиоDataGridViewTextBoxColumn.DataPropertyName = "Фио";
            this.фиоDataGridViewTextBoxColumn.HeaderText = "Фио";
            this.фиоDataGridViewTextBoxColumn.Name = "фиоDataGridViewTextBoxColumn";
            this.фиоDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // номерКомнатыDataGridViewTextBoxColumn
            // 
            this.номерКомнатыDataGridViewTextBoxColumn.DataPropertyName = "Номер комнаты";
            this.номерКомнатыDataGridViewTextBoxColumn.HeaderText = "Номер комнаты";
            this.номерКомнатыDataGridViewTextBoxColumn.Name = "номерКомнатыDataGridViewTextBoxColumn";
            this.номерКомнатыDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // отельDataGridViewTextBoxColumn
            // 
            this.отельDataGridViewTextBoxColumn.DataPropertyName = "Отель";
            this.отельDataGridViewTextBoxColumn.HeaderText = "Отель";
            this.отельDataGridViewTextBoxColumn.Name = "отельDataGridViewTextBoxColumn";
            this.отельDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаЗаездаDataGridViewTextBoxColumn
            // 
            this.датаЗаездаDataGridViewTextBoxColumn.DataPropertyName = "Дата заезда";
            this.датаЗаездаDataGridViewTextBoxColumn.HeaderText = "Дата заезда";
            this.датаЗаездаDataGridViewTextBoxColumn.Name = "датаЗаездаDataGridViewTextBoxColumn";
            this.датаЗаездаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаОтъездаDataGridViewTextBoxColumn
            // 
            this.датаОтъездаDataGridViewTextBoxColumn.DataPropertyName = "Дата отъезда";
            this.датаОтъездаDataGridViewTextBoxColumn.HeaderText = "Дата отъезда";
            this.датаОтъездаDataGridViewTextBoxColumn.Name = "датаОтъездаDataGridViewTextBoxColumn";
            this.датаОтъездаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // общаяСтоимостьПроживанияDataGridViewTextBoxColumn
            // 
            this.общаяСтоимостьПроживанияDataGridViewTextBoxColumn.DataPropertyName = "Общая стоимость проживания";
            this.общаяСтоимостьПроживанияDataGridViewTextBoxColumn.HeaderText = "Общая стоимость проживания";
            this.общаяСтоимостьПроживанияDataGridViewTextBoxColumn.Name = "общаяСтоимостьПроживанияDataGridViewTextBoxColumn";
            this.общаяСтоимостьПроживанияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addCheckInViewBindingSource
            // 
            this.addCheckInViewBindingSource.DataMember = "addCheckInView";
            this.addCheckInViewBindingSource.DataSource = this.addCheckInDS;
            // 
            // addCheckInDS
            // 
            this.addCheckInDS.DataSetName = "addCheckInDS";
            this.addCheckInDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 33);
            this.label1.TabIndex = 17;
            this.label1.Text = "Заселение";
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
            this.cbLodger.Location = new System.Drawing.Point(816, 46);
            this.cbLodger.Name = "cbLodger";
            this.cbLodger.ShadowDecoration.Parent = this.cbLodger;
            this.cbLodger.Size = new System.Drawing.Size(236, 36);
            this.cbLodger.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbLodger.TabIndex = 33;
            // 
            // btAdd
            // 
            this.btAdd.Animated = true;
            this.btAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.btAdd.BorderColor = System.Drawing.Color.White;
            this.btAdd.BorderRadius = 23;
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
            this.btAdd.Location = new System.Drawing.Point(880, 557);
            this.btAdd.Name = "btAdd";
            this.btAdd.ShadowDecoration.Parent = this.btAdd;
            this.btAdd.Size = new System.Drawing.Size(172, 45);
            this.btAdd.TabIndex = 32;
            this.btAdd.Text = "Заселить";
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(812, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Посетитель";
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
            this.cbHotel.Location = new System.Drawing.Point(816, 126);
            this.cbHotel.Name = "cbHotel";
            this.cbHotel.ShadowDecoration.Parent = this.cbHotel;
            this.cbHotel.Size = new System.Drawing.Size(236, 36);
            this.cbHotel.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbHotel.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(812, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Отель";
            // 
            // cbRoomNo
            // 
            this.cbRoomNo.Animated = true;
            this.cbRoomNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.cbRoomNo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbRoomNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoomNo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.cbRoomNo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbRoomNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbRoomNo.FocusedState.Parent = this.cbRoomNo;
            this.cbRoomNo.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.cbRoomNo.ForeColor = System.Drawing.Color.White;
            this.cbRoomNo.HoverState.Parent = this.cbRoomNo;
            this.cbRoomNo.ItemHeight = 30;
            this.cbRoomNo.ItemsAppearance.Parent = this.cbRoomNo;
            this.cbRoomNo.Location = new System.Drawing.Point(816, 291);
            this.cbRoomNo.Name = "cbRoomNo";
            this.cbRoomNo.ShadowDecoration.Parent = this.cbRoomNo;
            this.cbRoomNo.Size = new System.Drawing.Size(236, 36);
            this.cbRoomNo.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbRoomNo.TabIndex = 37;
            this.cbRoomNo.SelectedIndexChanged += new System.EventHandler(this.cbRoomNo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(812, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Номер комнаты";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(812, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "Дата заезда";
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
            this.dtCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtCheckIn.HoverState.Parent = this.dtCheckIn;
            this.dtCheckIn.Location = new System.Drawing.Point(816, 431);
            this.dtCheckIn.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtCheckIn.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtCheckIn.Name = "dtCheckIn";
            this.dtCheckIn.ShadowDecoration.Parent = this.dtCheckIn;
            this.dtCheckIn.Size = new System.Drawing.Size(236, 36);
            this.dtCheckIn.TabIndex = 39;
            this.dtCheckIn.Value = new System.DateTime(2023, 3, 22, 0, 0, 0, 0);
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
            this.dtCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtCheckOut.HoverState.Parent = this.dtCheckOut;
            this.dtCheckOut.Location = new System.Drawing.Point(816, 502);
            this.dtCheckOut.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtCheckOut.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtCheckOut.Name = "dtCheckOut";
            this.dtCheckOut.ShadowDecoration.Parent = this.dtCheckOut;
            this.dtCheckOut.Size = new System.Drawing.Size(236, 36);
            this.dtCheckOut.TabIndex = 41;
            this.dtCheckOut.Value = new System.DateTime(2023, 3, 22, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(812, 479);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 40;
            this.label6.Text = "Дата отъезда";
            // 
            // cbRoomType
            // 
            this.cbRoomType.Animated = true;
            this.cbRoomType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.cbRoomType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoomType.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.cbRoomType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbRoomType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbRoomType.FocusedState.Parent = this.cbRoomType;
            this.cbRoomType.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.cbRoomType.ForeColor = System.Drawing.Color.White;
            this.cbRoomType.HoverState.Parent = this.cbRoomType;
            this.cbRoomType.ItemHeight = 30;
            this.cbRoomType.ItemsAppearance.Parent = this.cbRoomType;
            this.cbRoomType.Location = new System.Drawing.Point(816, 209);
            this.cbRoomType.Name = "cbRoomType";
            this.cbRoomType.ShadowDecoration.Parent = this.cbRoomType;
            this.cbRoomType.Size = new System.Drawing.Size(236, 36);
            this.cbRoomType.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbRoomType.TabIndex = 43;
            this.cbRoomType.SelectedIndexChanged += new System.EventHandler(this.cbRoomType_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(812, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 20);
            this.label7.TabIndex = 42;
            this.label7.Text = "Тип комнаты";
            // 
            // addCheckInViewTableAdapter
            // 
            this.addCheckInViewTableAdapter.ClearBeforeFill = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(812, 361);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 20);
            this.label13.TabIndex = 53;
            this.label13.Text = "Цена: ";
            // 
            // UCAddCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbRoomType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtCheckOut);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtCheckIn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbRoomNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbHotel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbLodger);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2DataGridView1);
            this.Name = "UCAddCheckIn";
            this.Size = new System.Drawing.Size(1081, 619);
            this.Load += new System.EventHandler(this.UCAddCheckIn_Load);
            this.Enter += new System.EventHandler(this.UCAddCheckIn_Enter);
            this.Leave += new System.EventHandler(this.UCAddCheckIn_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addCheckInViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addCheckInDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbLodger;
        private Guna.UI2.WinForms.Guna2Button btAdd;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cbHotel;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtCheckIn;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox cbRoomNo;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtCheckOut;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox cbRoomType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn фиоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерКомнатыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отельDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаЗаездаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаОтъездаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn общаяСтоимостьПроживанияDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource addCheckInViewBindingSource;
        private addCheckInDS addCheckInDS;
        private addCheckInDSTableAdapters.addCheckInViewTableAdapter addCheckInViewTableAdapter;
        private System.Windows.Forms.Label label13;
    }
}
