namespace HMSClient
{
    partial class BookApt
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.bookBtn = new System.Windows.Forms.Button();
            this.slotListBox = new System.Windows.Forms.ListBox();
            this.doctListBox = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.getDeptBtn = new System.Windows.Forms.Button();
            this.deptListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.bookBtn);
            this.panel1.Controls.Add(this.slotListBox);
            this.panel1.Controls.Add(this.doctListBox);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.getDeptBtn);
            this.panel1.Controls.Add(this.deptListBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 972);
            this.panel1.TabIndex = 0;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.monthCalendar1.Location = new System.Drawing.Point(385, 419);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 33;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(141, 701);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 32);
            this.label4.TabIndex = 32;
            this.label4.Text = "Select Time Slot";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(184, 466);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 32);
            this.label3.TabIndex = 32;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(184, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 32);
            this.label2.TabIndex = 31;
            this.label2.Text = "Doctor";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(412, 1275);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 55);
            this.button2.TabIndex = 30;
            this.button2.Text = "Book";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // bookBtn
            // 
            this.bookBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bookBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bookBtn.FlatAppearance.BorderSize = 0;
            this.bookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bookBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookBtn.ForeColor = System.Drawing.Color.White;
            this.bookBtn.Location = new System.Drawing.Point(412, 864);
            this.bookBtn.Name = "bookBtn";
            this.bookBtn.Size = new System.Drawing.Size(171, 55);
            this.bookBtn.TabIndex = 30;
            this.bookBtn.Text = "Book";
            this.bookBtn.UseVisualStyleBackColor = false;
            this.bookBtn.Click += new System.EventHandler(this.bookBtn_Click);
            // 
            // slotListBox
            // 
            this.slotListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.slotListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.slotListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slotListBox.FormattingEnabled = true;
            this.slotListBox.ItemHeight = 21;
            this.slotListBox.Location = new System.Drawing.Point(350, 649);
            this.slotListBox.Name = "slotListBox";
            this.slotListBox.Size = new System.Drawing.Size(295, 126);
            this.slotListBox.TabIndex = 29;
            // 
            // doctListBox
            // 
            this.doctListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.doctListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.doctListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctListBox.FormattingEnabled = true;
            this.doctListBox.ItemHeight = 21;
            this.doctListBox.Location = new System.Drawing.Point(350, 243);
            this.doctListBox.Name = "doctListBox";
            this.doctListBox.Size = new System.Drawing.Size(295, 126);
            this.doctListBox.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(184, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 32);
            this.label9.TabIndex = 28;
            this.label9.Text = "Department";
            // 
            // getDeptBtn
            // 
            this.getDeptBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.getDeptBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.getDeptBtn.FlatAppearance.BorderSize = 0;
            this.getDeptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.getDeptBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getDeptBtn.ForeColor = System.Drawing.Color.White;
            this.getDeptBtn.Location = new System.Drawing.Point(681, 115);
            this.getDeptBtn.Name = "getDeptBtn";
            this.getDeptBtn.Size = new System.Drawing.Size(171, 55);
            this.getDeptBtn.TabIndex = 27;
            this.getDeptBtn.Text = "Get Departments";
            this.getDeptBtn.UseVisualStyleBackColor = false;
            this.getDeptBtn.Click += new System.EventHandler(this.getDeptBtn_Click);
            // 
            // deptListBox
            // 
            this.deptListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deptListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.deptListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deptListBox.FormattingEnabled = true;
            this.deptListBox.ItemHeight = 21;
            this.deptListBox.Location = new System.Drawing.Point(350, 86);
            this.deptListBox.Name = "deptListBox";
            this.deptListBox.Size = new System.Drawing.Size(295, 126);
            this.deptListBox.TabIndex = 26;
            this.deptListBox.SelectedIndexChanged += new System.EventHandler(this.deptListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(342, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 47);
            this.label1.TabIndex = 5;
            this.label1.Text = "Book Appointment";
            // 
            // BookApt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "BookApt";
            this.Size = new System.Drawing.Size(1039, 972);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button getDeptBtn;
        private System.Windows.Forms.ListBox deptListBox;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox doctListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bookBtn;
        private System.Windows.Forms.ListBox slotListBox;
        private System.Windows.Forms.Button button2;
    }
}
