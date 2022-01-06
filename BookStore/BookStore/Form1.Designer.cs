namespace BookStore
{
    partial class Form1
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.TakeBtn = new System.Windows.Forms.Button();
            this.BorrowBtn = new System.Windows.Forms.Button();
            this.BuyBtn = new System.Windows.Forms.Button();
            this.OrderBtn = new System.Windows.Forms.Button();
            this.DonateBtn = new System.Windows.Forms.Button();
            this.LendBtn = new System.Windows.Forms.Button();
            this.SellBtn = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.orderedbooksbutton = new System.Windows.Forms.Button();
            this.mybooksbutton = new System.Windows.Forms.Button();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.TakeBtn);
            this.panelMenu.Controls.Add(this.BorrowBtn);
            this.panelMenu.Controls.Add(this.BuyBtn);
            this.panelMenu.Controls.Add(this.OrderBtn);
            this.panelMenu.Controls.Add(this.DonateBtn);
            this.panelMenu.Controls.Add(this.LendBtn);
            this.panelMenu.Controls.Add(this.SellBtn);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 446);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // TakeBtn
            // 
            this.TakeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.TakeBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.TakeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.TakeBtn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.TakeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TakeBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.TakeBtn.Location = new System.Drawing.Point(0, 315);
            this.TakeBtn.Name = "TakeBtn";
            this.TakeBtn.Size = new System.Drawing.Size(220, 40);
            this.TakeBtn.TabIndex = 8;
            this.TakeBtn.Text = "Free Books";
            this.TakeBtn.UseVisualStyleBackColor = false;
            this.TakeBtn.Click += new System.EventHandler(this.TakeBtn_Click);
            // 
            // BorrowBtn
            // 
            this.BorrowBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.BorrowBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.BorrowBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.BorrowBtn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BorrowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BorrowBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.BorrowBtn.Location = new System.Drawing.Point(0, 275);
            this.BorrowBtn.Name = "BorrowBtn";
            this.BorrowBtn.Size = new System.Drawing.Size(220, 40);
            this.BorrowBtn.TabIndex = 7;
            this.BorrowBtn.Text = "Borrow a Book";
            this.BorrowBtn.UseVisualStyleBackColor = false;
            this.BorrowBtn.Click += new System.EventHandler(this.BorrowBtn_Click);
            // 
            // BuyBtn
            // 
            this.BuyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.BuyBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.BuyBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.BuyBtn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BuyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuyBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.BuyBtn.Location = new System.Drawing.Point(0, 235);
            this.BuyBtn.Name = "BuyBtn";
            this.BuyBtn.Size = new System.Drawing.Size(220, 40);
            this.BuyBtn.TabIndex = 6;
            this.BuyBtn.Text = "Buy a Book";
            this.BuyBtn.UseVisualStyleBackColor = false;
            this.BuyBtn.Click += new System.EventHandler(this.BuyBtn_Click);
            // 
            // OrderBtn
            // 
            this.OrderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.OrderBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.OrderBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.OrderBtn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.OrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.OrderBtn.Location = new System.Drawing.Point(0, 195);
            this.OrderBtn.Name = "OrderBtn";
            this.OrderBtn.Size = new System.Drawing.Size(220, 40);
            this.OrderBtn.TabIndex = 5;
            this.OrderBtn.Text = "Order Unavailble Book";
            this.OrderBtn.UseVisualStyleBackColor = false;
            this.OrderBtn.Click += new System.EventHandler(this.OrderBtn_Click);
            // 
            // DonateBtn
            // 
            this.DonateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.DonateBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.DonateBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.DonateBtn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.DonateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DonateBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.DonateBtn.Location = new System.Drawing.Point(0, 155);
            this.DonateBtn.Name = "DonateBtn";
            this.DonateBtn.Size = new System.Drawing.Size(220, 40);
            this.DonateBtn.TabIndex = 4;
            this.DonateBtn.Text = "Donate a Book";
            this.DonateBtn.UseVisualStyleBackColor = false;
            this.DonateBtn.Click += new System.EventHandler(this.DonateBtn_Click);
            // 
            // LendBtn
            // 
            this.LendBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.LendBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.LendBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.LendBtn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.LendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LendBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.LendBtn.Location = new System.Drawing.Point(0, 115);
            this.LendBtn.Name = "LendBtn";
            this.LendBtn.Size = new System.Drawing.Size(220, 40);
            this.LendBtn.TabIndex = 3;
            this.LendBtn.Text = "Lend a Book";
            this.LendBtn.UseVisualStyleBackColor = false;
            this.LendBtn.Click += new System.EventHandler(this.LendBtn_Click);
            // 
            // SellBtn
            // 
            this.SellBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.SellBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.SellBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.SellBtn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.SellBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SellBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.SellBtn.Location = new System.Drawing.Point(0, 75);
            this.SellBtn.Name = "SellBtn";
            this.SellBtn.Size = new System.Drawing.Size(220, 40);
            this.SellBtn.TabIndex = 1;
            this.SellBtn.Text = "Sell a Book";
            this.SellBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.SellBtn.UseVisualStyleBackColor = false;
            this.SellBtn.Click += new System.EventHandler(this.SellBtn_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 75);
            this.panelLogo.TabIndex = 1;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.Controls.Add(this.orderedbooksbutton);
            this.panelTitleBar.Controls.Add(this.mybooksbutton);
            this.panelTitleBar.Controls.Add(this.btnCloseChildForm);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(681, 75);
            this.panelTitleBar.TabIndex = 1;
            // 
            // orderedbooksbutton
            // 
            this.orderedbooksbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.orderedbooksbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.orderedbooksbutton.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.orderedbooksbutton.FlatAppearance.BorderSize = 2;
            this.orderedbooksbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.orderedbooksbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderedbooksbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderedbooksbutton.ForeColor = System.Drawing.Color.Cyan;
            this.orderedbooksbutton.Location = new System.Drawing.Point(535, 34);
            this.orderedbooksbutton.Name = "orderedbooksbutton";
            this.orderedbooksbutton.Size = new System.Drawing.Size(141, 31);
            this.orderedbooksbutton.TabIndex = 37;
            this.orderedbooksbutton.Text = "My Ordered Books";
            this.orderedbooksbutton.UseVisualStyleBackColor = false;
            this.orderedbooksbutton.Click += new System.EventHandler(this.signupbutton_Click);
            // 
            // mybooksbutton
            // 
            this.mybooksbutton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mybooksbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.mybooksbutton.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.mybooksbutton.FlatAppearance.BorderSize = 2;
            this.mybooksbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.mybooksbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mybooksbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mybooksbutton.ForeColor = System.Drawing.Color.Cyan;
            this.mybooksbutton.Location = new System.Drawing.Point(429, 34);
            this.mybooksbutton.Name = "mybooksbutton";
            this.mybooksbutton.Size = new System.Drawing.Size(100, 31);
            this.mybooksbutton.TabIndex = 36;
            this.mybooksbutton.Text = "My Books";
            this.mybooksbutton.UseVisualStyleBackColor = false;
            this.mybooksbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCloseChildForm.Location = new System.Drawing.Point(16, 38);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(40, 26);
            this.btnCloseChildForm.TabIndex = 1;
            this.btnCloseChildForm.Text = "X";
            this.btnCloseChildForm.UseVisualStyleBackColor = false;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(190, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(119, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Home";
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.Controls.Add(this.pictureBox1);
            this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanel.Location = new System.Drawing.Point(220, 75);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(681, 371);
            this.panelDesktopPanel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2000, 1334);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(0, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "LogOut";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 446);
            this.Controls.Add(this.panelDesktopPanel);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelDesktopPanel.ResumeLayout(false);
            this.panelDesktopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button SellBtn;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button TakeBtn;
        private System.Windows.Forms.Button BorrowBtn;
        private System.Windows.Forms.Button BuyBtn;
        private System.Windows.Forms.Button OrderBtn;
        private System.Windows.Forms.Button DonateBtn;
        private System.Windows.Forms.Button LendBtn;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelDesktopPanel;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button orderedbooksbutton;
        private System.Windows.Forms.Button mybooksbutton;
        private System.Windows.Forms.Button button1;
    }
}

