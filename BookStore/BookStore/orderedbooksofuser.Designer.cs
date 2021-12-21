
namespace BookStore
{
    partial class orderedbooksofuser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BooktoSell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.approve = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cancel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.yourorderedbooks = new System.Windows.Forms.Label();
            this.done = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BooktoSell,
            this.approve,
            this.cancel});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.GridColor = System.Drawing.Color.SlateGray;
            this.dataGridView1.Location = new System.Drawing.Point(35, 37);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.SlateGray;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.Size = new System.Drawing.Size(432, 360);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.yourorderedbooks);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 467);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BooktoSell
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.SlateGray;
            this.BooktoSell.DefaultCellStyle = dataGridViewCellStyle7;
            this.BooktoSell.HeaderText = "Ordered Books";
            this.BooktoSell.Name = "BooktoSell";
            this.BooktoSell.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BooktoSell.Width = 129;
            // 
            // approve
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle8.NullValue = false;
            this.approve.DefaultCellStyle = dataGridViewCellStyle8;
            this.approve.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.approve.HeaderText = "Approve";
            this.approve.Name = "approve";
            this.approve.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.approve.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.approve.Width = 129;
            // 
            // cancel
            // 
            this.cancel.HeaderText = "Cancel";
            this.cancel.Name = "cancel";
            this.cancel.Width = 130;
            // 
            // yourorderedbooks
            // 
            this.yourorderedbooks.AutoSize = true;
            this.yourorderedbooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourorderedbooks.Location = new System.Drawing.Point(143, 9);
            this.yourorderedbooks.Name = "yourorderedbooks";
            this.yourorderedbooks.Size = new System.Drawing.Size(208, 25);
            this.yourorderedbooks.TabIndex = 2;
            this.yourorderedbooks.Text = "Your Ordered Books";
            // 
            // done
            // 
            this.done.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.done.FlatAppearance.BorderSize = 2;
            this.done.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.done.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.done.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.done.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.done.Location = new System.Drawing.Point(186, 3);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(85, 31);
            this.done.TabIndex = 35;
            this.done.Text = "Done";
            this.done.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.Controls.Add(this.done);
            this.panel2.Location = new System.Drawing.Point(35, 414);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(432, 40);
            this.panel2.TabIndex = 37;
            // 
            // orderedbooksofuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 467);
            this.Controls.Add(this.panel1);
            this.Name = "orderedbooksofuser";
            this.Text = "orderedbooksofuser";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BooktoSell;
        private System.Windows.Forms.DataGridViewCheckBoxColumn approve;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cancel;
        private System.Windows.Forms.Label yourorderedbooks;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button done;
    }
}