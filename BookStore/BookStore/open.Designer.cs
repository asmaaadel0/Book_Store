
namespace BookStore
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.loginlogo = new System.Windows.Forms.Panel();
            this.loginadmin = new System.Windows.Forms.Button();
            this.signupbutton = new System.Windows.Forms.Button();
            this.loginbutton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.loginlogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.logo.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginlogo
            // 
            this.loginlogo.Controls.Add(this.label1);
            this.loginlogo.Controls.Add(this.loginadmin);
            this.loginlogo.Controls.Add(this.signupbutton);
            this.loginlogo.Controls.Add(this.loginbutton);
            this.loginlogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginlogo.Location = new System.Drawing.Point(234, 35);
            this.loginlogo.Name = "loginlogo";
            this.loginlogo.Size = new System.Drawing.Size(533, 469);
            this.loginlogo.TabIndex = 16;
            // 
            // loginadmin
            // 
            this.loginadmin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.loginadmin.FlatAppearance.BorderSize = 2;
            this.loginadmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.loginadmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginadmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.loginadmin.Location = new System.Drawing.Point(399, 414);
            this.loginadmin.Name = "loginadmin";
            this.loginadmin.Size = new System.Drawing.Size(116, 31);
            this.loginadmin.TabIndex = 36;
            this.loginadmin.Text = "Login as admin";
            this.loginadmin.UseVisualStyleBackColor = true;
            this.loginadmin.Click += new System.EventHandler(this.loginadmin_Click);
            // 
            // signupbutton
            // 
            this.signupbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.signupbutton.FlatAppearance.BorderSize = 2;
            this.signupbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.signupbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.signupbutton.Location = new System.Drawing.Point(445, 6);
            this.signupbutton.Name = "signupbutton";
            this.signupbutton.Size = new System.Drawing.Size(85, 31);
            this.signupbutton.TabIndex = 35;
            this.signupbutton.Text = "Sign Up";
            this.signupbutton.UseVisualStyleBackColor = true;
            this.signupbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // loginbutton
            // 
            this.loginbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.loginbutton.FlatAppearance.BorderSize = 2;
            this.loginbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.loginbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.loginbutton.Location = new System.Drawing.Point(358, 6);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(85, 31);
            this.loginbutton.TabIndex = 34;
            this.loginbutton.Text = "Login";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.login_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(15, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 31);
            this.label6.TabIndex = 1;
            this.label6.Text = "BOOK STORE";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 114);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(234, 179);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Bisque;
            this.logo.Controls.Add(this.label6);
            this.logo.Controls.Add(this.pictureBox3);
            this.logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.logo.Location = new System.Drawing.Point(0, 35);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(234, 469);
            this.logo.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 35);
            this.panel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 31);
            this.label1.TabIndex = 37;
            this.label1.Text = "Welcome to Our Book Store";
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(767, 504);
            this.Controls.Add(this.loginlogo);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.panel1);
            this.Name = "home";
            this.Text = "BOOK STORE";
            this.Load += new System.EventHandler(this.home_Load);
            this.loginlogo.ResumeLayout(false);
            this.loginlogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.logo.ResumeLayout(false);
            this.logo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginlogo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button loginadmin;
        private System.Windows.Forms.Button signupbutton;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.Label label1;
    }
}

