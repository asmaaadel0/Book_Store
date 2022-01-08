namespace BookStore
{
    partial class publiherInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Information = new System.Windows.Forms.TextBox();
            this.PublisherName = new System.Windows.Forms.TextBox();
            this.EmailPublisher = new System.Windows.Forms.TextBox();
            this.FaxtextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Publisher Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label1.Location = new System.Drawing.Point(12, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Fax:";
            // 
            // Information
            // 
            this.Information.BackColor = System.Drawing.Color.Silver;
            this.Information.Enabled = false;
            this.Information.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.Information.Location = new System.Drawing.Point(12, 207);
            this.Information.MaxLength = 10000;
            this.Information.Multiline = true;
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(528, 110);
            this.Information.TabIndex = 27;
            this.Information.Text = "Information";
            this.Information.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PublisherName
            // 
            this.PublisherName.BackColor = System.Drawing.Color.Silver;
            this.PublisherName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PublisherName.Enabled = false;
            this.PublisherName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.PublisherName.Location = new System.Drawing.Point(146, 33);
            this.PublisherName.Name = "PublisherName";
            this.PublisherName.Size = new System.Drawing.Size(150, 22);
            this.PublisherName.TabIndex = 29;
            this.PublisherName.Text = "Name";
            this.PublisherName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EmailPublisher
            // 
            this.EmailPublisher.BackColor = System.Drawing.Color.Silver;
            this.EmailPublisher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailPublisher.Enabled = false;
            this.EmailPublisher.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.EmailPublisher.Location = new System.Drawing.Point(105, 149);
            this.EmailPublisher.Name = "EmailPublisher";
            this.EmailPublisher.Size = new System.Drawing.Size(223, 22);
            this.EmailPublisher.TabIndex = 30;
            this.EmailPublisher.Text = "Email";
            this.EmailPublisher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FaxtextBox
            // 
            this.FaxtextBox.BackColor = System.Drawing.Color.Silver;
            this.FaxtextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FaxtextBox.Enabled = false;
            this.FaxtextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.FaxtextBox.Location = new System.Drawing.Point(105, 87);
            this.FaxtextBox.Name = "FaxtextBox";
            this.FaxtextBox.Size = new System.Drawing.Size(150, 22);
            this.FaxtextBox.TabIndex = 31;
            this.FaxtextBox.Text = "Fax";
            this.FaxtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FaxtextBox.TextChanged += new System.EventHandler(this.FaxtextBox_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(578, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(369, 138);
            this.dataGridView1.TabIndex = 32;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(334, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 118);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(578, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(369, 138);
            this.dataGridView2.TabIndex = 33;
            // 
            // publiherInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(974, 314);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.FaxtextBox);
            this.Controls.Add(this.EmailPublisher);
            this.Controls.Add(this.PublisherName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Information);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "publiherInfo";
            this.Text = "publiherInfo";
            this.Load += new System.EventHandler(this.publiherInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Information;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox PublisherName;
        private System.Windows.Forms.TextBox EmailPublisher;
        private System.Windows.Forms.TextBox FaxtextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}