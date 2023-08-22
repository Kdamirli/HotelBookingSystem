namespace HotelBookingSystem
{
    partial class MakeAChoice
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
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnReg = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.guna2Button1.BorderColor = System.Drawing.Color.White;
            this.guna2Button1.BorderRadius = 15;
            this.guna2Button1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.guna2Button1.CheckedState.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(126, 116);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(197, 45);
            this.guna2Button1.TabIndex = 66;
            this.guna2Button1.Text = "Пользователь";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
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
            this.btnReg.Location = new System.Drawing.Point(126, 55);
            this.btnReg.Name = "btnReg";
            this.btnReg.ShadowDecoration.Parent = this.btnReg;
            this.btnReg.Size = new System.Drawing.Size(197, 45);
            this.btnReg.TabIndex = 65;
            this.btnReg.Text = "Администратор";
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 33);
            this.label1.TabIndex = 64;
            this.label1.Text = "Администратор/руоковдитель";
            // 
            // MakeAChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(445, 170);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MakeAChoice";
            this.Text = "MakeAChoice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnReg;
        private System.Windows.Forms.Label label1;
    }
}