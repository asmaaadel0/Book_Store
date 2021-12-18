
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
            this.signup = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.loginadmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // signup
            // 
            this.signup.Location = new System.Drawing.Point(246, 33);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(75, 23);
            this.signup.TabIndex = 3;
            this.signup.Text = "Sign Up";
            this.signup.UseVisualStyleBackColor = true;
            this.signup.Click += new System.EventHandler(this.signup_Click);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(144, 33);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 23);
            this.login.TabIndex = 2;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // loginadmin
            // 
            this.loginadmin.Location = new System.Drawing.Point(237, 255);
            this.loginadmin.Name = "loginadmin";
            this.loginadmin.Size = new System.Drawing.Size(96, 23);
            this.loginadmin.TabIndex = 4;
            this.loginadmin.Text = "Login as admin";
            this.loginadmin.UseVisualStyleBackColor = true;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 290);
            this.Controls.Add(this.loginadmin);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.login);
            this.Name = "home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.home_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button signup;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button loginadmin;
    }
}

