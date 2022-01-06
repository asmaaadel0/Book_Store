namespace BookStore
{
    partial class AuthorInfo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Information = new System.Windows.Forms.TextBox();
            this.CityOfBirth = new System.Windows.Forms.TextBox();
            this.Nationality = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DateOfBirth = new System.Windows.Forms.TextBox();
            this.AuthorName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.Information);
            this.panel1.Controls.Add(this.CityOfBirth);
            this.panel1.Controls.Add(this.Nationality);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.DateOfBirth);
            this.panel1.Controls.Add(this.AuthorName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 339);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Information
            // 
            this.Information.BackColor = System.Drawing.Color.Silver;
            this.Information.Enabled = false;
            this.Information.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.Information.Location = new System.Drawing.Point(39, 217);
            this.Information.MaxLength = 10000;
            this.Information.Multiline = true;
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(726, 110);
            this.Information.TabIndex = 26;
            this.Information.Text = "Information";
            this.Information.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CityOfBirth
            // 
            this.CityOfBirth.BackColor = System.Drawing.Color.Silver;
            this.CityOfBirth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CityOfBirth.Enabled = false;
            this.CityOfBirth.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.CityOfBirth.Location = new System.Drawing.Point(432, 45);
            this.CityOfBirth.Name = "CityOfBirth";
            this.CityOfBirth.Size = new System.Drawing.Size(150, 22);
            this.CityOfBirth.TabIndex = 16;
            this.CityOfBirth.Text = "city";
            this.CityOfBirth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Nationality
            // 
            this.Nationality.BackColor = System.Drawing.Color.Silver;
            this.Nationality.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Nationality.Enabled = false;
            this.Nationality.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.Nationality.Location = new System.Drawing.Point(432, 127);
            this.Nationality.Name = "Nationality";
            this.Nationality.Size = new System.Drawing.Size(150, 22);
            this.Nationality.TabIndex = 15;
            this.Nationality.Text = "Nationality";
            this.Nationality.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label4.Location = new System.Drawing.Point(312, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "CityOfBirth:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label2.Location = new System.Drawing.Point(312, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nationality:";
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.BackColor = System.Drawing.Color.Silver;
            this.DateOfBirth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DateOfBirth.Enabled = false;
            this.DateOfBirth.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.DateOfBirth.Location = new System.Drawing.Point(133, 126);
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Size = new System.Drawing.Size(150, 22);
            this.DateOfBirth.TabIndex = 12;
            this.DateOfBirth.Text = "DateOfBirth";
            this.DateOfBirth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AuthorName
            // 
            this.AuthorName.BackColor = System.Drawing.Color.Silver;
            this.AuthorName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AuthorName.Enabled = false;
            this.AuthorName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.AuthorName.Location = new System.Drawing.Point(133, 44);
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.Size = new System.Drawing.Size(150, 22);
            this.AuthorName.TabIndex = 11;
            this.AuthorName.Text = "Name";
            this.AuthorName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label1.Location = new System.Drawing.Point(35, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "DateOfBirth:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label3.Location = new System.Drawing.Point(35, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "NAME:";
            // 
            // AuthorInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 339);
            this.Controls.Add(this.panel1);
            this.Name = "AuthorInfo";
            this.Text = "AuthorInfo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AuthorName;
        private System.Windows.Forms.TextBox CityOfBirth;
        private System.Windows.Forms.TextBox Nationality;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DateOfBirth;
        private System.Windows.Forms.TextBox Information;
    }
}