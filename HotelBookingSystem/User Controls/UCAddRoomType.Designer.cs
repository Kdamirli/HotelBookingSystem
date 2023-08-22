namespace HotelBookingSystem.User_Controls
{
    partial class UCAddRoomType
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.типDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addRoomTypeViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addRoomTypeDS = new HotelBookingSystem.addRoomTypeDS();
            this.tbCharacteristics = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbType = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btAdd = new Guna.UI2.WinForms.Guna2Button();
            this.addRoomTypeViewTableAdapter = new HotelBookingSystem.addRoomTypeDSTableAdapters.addRoomTypeViewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addRoomTypeViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addRoomTypeDS)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 33);
            this.label1.TabIndex = 15;
            this.label1.Text = "Добавить тип комнаты";
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            this.guna2DataGridView1.AllowUserToResizeColumns = false;
            this.guna2DataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.AutoGenerateColumns = false;
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
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.типDataGridViewTextBoxColumn,
            this.описаниеDataGridViewTextBoxColumn});
            this.guna2DataGridView1.DataSource = this.addRoomTypeViewBindingSource;
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
            this.guna2DataGridView1.Location = new System.Drawing.Point(9, 60);
            this.guna2DataGridView1.MultiSelect = false;
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView1.Size = new System.Drawing.Size(666, 542);
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
            this.guna2DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            // 
            // типDataGridViewTextBoxColumn
            // 
            this.типDataGridViewTextBoxColumn.DataPropertyName = "Тип";
            this.типDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.типDataGridViewTextBoxColumn.Name = "типDataGridViewTextBoxColumn";
            this.типDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // описаниеDataGridViewTextBoxColumn
            // 
            this.описаниеDataGridViewTextBoxColumn.DataPropertyName = "Описание";
            this.описаниеDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.описаниеDataGridViewTextBoxColumn.Name = "описаниеDataGridViewTextBoxColumn";
            this.описаниеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addRoomTypeViewBindingSource
            // 
            this.addRoomTypeViewBindingSource.DataMember = "addRoomTypeView";
            this.addRoomTypeViewBindingSource.DataSource = this.addRoomTypeDS;
            // 
            // addRoomTypeDS
            // 
            this.addRoomTypeDS.DataSetName = "addRoomTypeDS";
            this.addRoomTypeDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbCharacteristics
            // 
            this.tbCharacteristics.Animated = true;
            this.tbCharacteristics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.tbCharacteristics.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCharacteristics.DefaultText = "";
            this.tbCharacteristics.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbCharacteristics.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbCharacteristics.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCharacteristics.DisabledState.Parent = this.tbCharacteristics;
            this.tbCharacteristics.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCharacteristics.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.tbCharacteristics.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCharacteristics.FocusedState.Parent = this.tbCharacteristics;
            this.tbCharacteristics.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.tbCharacteristics.ForeColor = System.Drawing.Color.White;
            this.tbCharacteristics.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCharacteristics.HoverState.Parent = this.tbCharacteristics;
            this.tbCharacteristics.Location = new System.Drawing.Point(682, 373);
            this.tbCharacteristics.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCharacteristics.Name = "tbCharacteristics";
            this.tbCharacteristics.PasswordChar = '\0';
            this.tbCharacteristics.PlaceholderText = "Введите описание";
            this.tbCharacteristics.SelectedText = "";
            this.tbCharacteristics.ShadowDecoration.Parent = this.tbCharacteristics;
            this.tbCharacteristics.Size = new System.Drawing.Size(331, 36);
            this.tbCharacteristics.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbCharacteristics.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(678, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Описание";
            // 
            // tbType
            // 
            this.tbType.Animated = true;
            this.tbType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.tbType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbType.DefaultText = "";
            this.tbType.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbType.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbType.DisabledState.Parent = this.tbType;
            this.tbType.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbType.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.tbType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbType.FocusedState.Parent = this.tbType;
            this.tbType.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.tbType.ForeColor = System.Drawing.Color.White;
            this.tbType.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbType.HoverState.Parent = this.tbType;
            this.tbType.Location = new System.Drawing.Point(682, 244);
            this.tbType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbType.Name = "tbType";
            this.tbType.PasswordChar = '\0';
            this.tbType.PlaceholderText = "Введите тип";
            this.tbType.SelectedText = "";
            this.tbType.ShadowDecoration.Parent = this.tbType;
            this.tbType.Size = new System.Drawing.Size(331, 36);
            this.tbType.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbType.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(678, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Тип";
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
            this.btAdd.Location = new System.Drawing.Point(768, 493);
            this.btAdd.Name = "btAdd";
            this.btAdd.ShadowDecoration.Parent = this.btAdd;
            this.btAdd.Size = new System.Drawing.Size(172, 45);
            this.btAdd.TabIndex = 34;
            this.btAdd.Text = "Добавить";
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // addRoomTypeViewTableAdapter
            // 
            this.addRoomTypeViewTableAdapter.ClearBeforeFill = true;
            // 
            // UCAddRoomType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.tbCharacteristics);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "UCAddRoomType";
            this.Size = new System.Drawing.Size(1081, 619);
            this.Load += new System.EventHandler(this.UCAddRoomType_Load);
            this.Enter += new System.EventHandler(this.UCAddRoomType_Enter);
            this.Leave += new System.EventHandler(this.UCAddRoomType_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addRoomTypeViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addRoomTypeDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2TextBox tbCharacteristics;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox tbType;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn типDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource addRoomTypeViewBindingSource;
        private addRoomTypeDS addRoomTypeDS;
        private addRoomTypeDSTableAdapters.addRoomTypeViewTableAdapter addRoomTypeViewTableAdapter;
    }
}
