namespace HotelBookingSystem
{
    partial class TurAgentReg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.guna2ToggleSwitch1 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.loginLabel = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReg = new Guna.UI2.WinForms.Guna2Button();
            this.tbLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(125, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 73;
            this.label2.Text = "Показать пароль";
            // 
            // guna2ToggleSwitch1
            // 
            this.guna2ToggleSwitch1.Animated = true;
            this.guna2ToggleSwitch1.AutoRoundedCorners = true;
            this.guna2ToggleSwitch1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.guna2ToggleSwitch1.CheckedState.BorderColor = System.Drawing.Color.LightCoral;
            this.guna2ToggleSwitch1.CheckedState.FillColor = System.Drawing.Color.LightCoral;
            this.guna2ToggleSwitch1.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.CheckedState.Parent = this.guna2ToggleSwitch1;
            this.guna2ToggleSwitch1.Location = new System.Drawing.Point(84, 273);
            this.guna2ToggleSwitch1.Name = "guna2ToggleSwitch1";
            this.guna2ToggleSwitch1.ShadowDecoration.Parent = this.guna2ToggleSwitch1;
            this.guna2ToggleSwitch1.Size = new System.Drawing.Size(35, 20);
            this.guna2ToggleSwitch1.TabIndex = 72;
            this.guna2ToggleSwitch1.UncheckedState.BorderColor = System.Drawing.Color.Thistle;
            this.guna2ToggleSwitch1.UncheckedState.BorderThickness = 2;
            this.guna2ToggleSwitch1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.guna2ToggleSwitch1.UncheckedState.InnerBorderColor = System.Drawing.Color.Transparent;
            this.guna2ToggleSwitch1.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.UncheckedState.Parent = this.guna2ToggleSwitch1;
            this.guna2ToggleSwitch1.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch1_CheckedChanged);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.LinkColor = System.Drawing.Color.Cyan;
            this.loginLabel.Location = new System.Drawing.Point(183, 313);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(37, 13);
            this.loginLabel.TabIndex = 71;
            this.loginLabel.TabStop = true;
            this.loginLabel.Text = "Войти";
            this.loginLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loginLabel_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(80, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 70;
            this.label3.Text = "Есть аккаунт?";
            // 
            // tbPassword
            // 
            this.tbPassword.Animated = true;
            this.tbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.DefaultText = "";
            this.tbPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPassword.DisabledState.Parent = this.tbPassword;
            this.tbPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.tbPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPassword.FocusedState.Parent = this.tbPassword;
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.tbPassword.ForeColor = System.Drawing.Color.White;
            this.tbPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPassword.HoverState.Parent = this.tbPassword;
            this.tbPassword.Location = new System.Drawing.Point(83, 231);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '\0';
            this.tbPassword.PlaceholderText = "Пароль";
            this.tbPassword.SelectedText = "";
            this.tbPassword.ShadowDecoration.Parent = this.tbPassword;
            this.tbPassword.Size = new System.Drawing.Size(284, 36);
            this.tbPassword.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbPassword.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 33);
            this.label1.TabIndex = 68;
            this.label1.Text = "Регистрация руководителя";
            // 
            // btnReg
            // 
            this.btnReg.Animated = true;
            this.btnReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.btnReg.BorderColor = System.Drawing.Color.White;
            this.btnReg.BorderRadius = 15;
            this.btnReg.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnReg.BorderThickness = 1;
            this.btnReg.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btnReg.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnReg.CheckedState.Parent = this.btnReg;
            this.btnReg.CustomImages.Parent = this.btnReg;
            this.btnReg.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.btnReg.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnReg.ForeColor = System.Drawing.Color.White;
            this.btnReg.HoverState.Parent = this.btnReg;
            this.btnReg.Location = new System.Drawing.Point(115, 366);
            this.btnReg.Name = "btnReg";
            this.btnReg.ShadowDecoration.Parent = this.btnReg;
            this.btnReg.Size = new System.Drawing.Size(197, 45);
            this.btnReg.TabIndex = 67;
            this.btnReg.Text = "Регистрация";
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // tbLogin
            // 
            this.tbLogin.Animated = true;
            this.tbLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.tbLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbLogin.DefaultText = "";
            this.tbLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbLogin.DisabledState.Parent = this.tbLogin;
            this.tbLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.tbLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbLogin.FocusedState.Parent = this.tbLogin;
            this.tbLogin.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.tbLogin.ForeColor = System.Drawing.Color.White;
            this.tbLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbLogin.HoverState.Parent = this.tbLogin;
            this.tbLogin.Location = new System.Drawing.Point(83, 149);
            this.tbLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.PasswordChar = '\0';
            this.tbLogin.PlaceholderText = "Логин";
            this.tbLogin.SelectedText = "";
            this.tbLogin.ShadowDecoration.Parent = this.tbLogin;
            this.tbLogin.Size = new System.Drawing.Size(284, 36);
            this.tbLogin.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbLogin.TabIndex = 66;
            // 
            // TurAgentReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(447, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2ToggleSwitch1);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.tbLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TurAgentReg";
            this.Text = "TurAgentReg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch1;
        private System.Windows.Forms.LinkLabel loginLabel;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox tbPassword;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnReg;
        private Guna.UI2.WinForms.Guna2TextBox tbLogin;
    }
}