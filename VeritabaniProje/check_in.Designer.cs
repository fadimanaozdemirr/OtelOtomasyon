
namespace VeritabaniProje
{
    partial class check_in
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
            this.btnCheckIn = new Guna.UI2.WinForms.Guna2Button();
            this.cbOda = new System.Windows.Forms.ComboBox();
            this.btnMusteriCekCheckIn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tbKimlikNoChechIn = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheckIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheckIn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCheckIn.ForeColor = System.Drawing.Color.White;
            this.btnCheckIn.Location = new System.Drawing.Point(228, 174);
            this.btnCheckIn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(135, 37);
            this.btnCheckIn.TabIndex = 1;
            this.btnCheckIn.Text = "Check-In";
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // cbOda
            // 
            this.cbOda.FormattingEnabled = true;
            this.cbOda.Location = new System.Drawing.Point(457, 50);
            this.cbOda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbOda.Name = "cbOda";
            this.cbOda.Size = new System.Drawing.Size(144, 21);
            this.cbOda.TabIndex = 2;
            // 
            // btnMusteriCekCheckIn
            // 
            this.btnMusteriCekCheckIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMusteriCekCheckIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMusteriCekCheckIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMusteriCekCheckIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMusteriCekCheckIn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMusteriCekCheckIn.ForeColor = System.Drawing.Color.White;
            this.btnMusteriCekCheckIn.Location = new System.Drawing.Point(181, 76);
            this.btnMusteriCekCheckIn.Name = "btnMusteriCekCheckIn";
            this.btnMusteriCekCheckIn.Size = new System.Drawing.Size(77, 23);
            this.btnMusteriCekCheckIn.TabIndex = 36;
            this.btnMusteriCekCheckIn.Text = "Müşteri";
            this.btnMusteriCekCheckIn.Click += new System.EventHandler(this.btnMusteriCekCheckIn_Click);
            // 
            // guna2HtmlLabel10
            // 
            this.guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel10.Location = new System.Drawing.Point(52, 54);
            this.guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            this.guna2HtmlLabel10.Size = new System.Drawing.Size(50, 15);
            this.guna2HtmlLabel10.TabIndex = 35;
            this.guna2HtmlLabel10.Text = "Kimlik No:";
            // 
            // tbKimlikNoChechIn
            // 
            this.tbKimlikNoChechIn.BorderRadius = 5;
            this.tbKimlikNoChechIn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbKimlikNoChechIn.DefaultText = "";
            this.tbKimlikNoChechIn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbKimlikNoChechIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbKimlikNoChechIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbKimlikNoChechIn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbKimlikNoChechIn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbKimlikNoChechIn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbKimlikNoChechIn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbKimlikNoChechIn.Location = new System.Drawing.Point(107, 46);
            this.tbKimlikNoChechIn.Name = "tbKimlikNoChechIn";
            this.tbKimlikNoChechIn.PasswordChar = '\0';
            this.tbKimlikNoChechIn.PlaceholderText = "";
            this.tbKimlikNoChechIn.SelectedText = "";
            this.tbKimlikNoChechIn.Size = new System.Drawing.Size(150, 24);
            this.tbKimlikNoChechIn.TabIndex = 34;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(409, 56);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(43, 15);
            this.guna2HtmlLabel1.TabIndex = 37;
            this.guna2HtmlLabel1.Text = "Oda No: ";
            // 
            // check_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 366);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.btnMusteriCekCheckIn);
            this.Controls.Add(this.guna2HtmlLabel10);
            this.Controls.Add(this.tbKimlikNoChechIn);
            this.Controls.Add(this.cbOda);
            this.Controls.Add(this.btnCheckIn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "check_in";
            this.Text = "check_in";
            this.Load += new System.EventHandler(this.check_in_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnCheckIn;
        private System.Windows.Forms.ComboBox cbOda;
        private Guna.UI2.WinForms.Guna2Button btnMusteriCekCheckIn;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
        private Guna.UI2.WinForms.Guna2TextBox tbKimlikNoChechIn;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}