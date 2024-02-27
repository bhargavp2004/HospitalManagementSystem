namespace HMSClient
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.bookAptBtn = new System.Windows.Forms.Button();
            this.viewAptBtn = new System.Windows.Forms.Button();
            this.addDepartmentBtn = new System.Windows.Forms.Button();
            this.addDoctorsBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.registerBtn = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.addDepartment1 = new HMSClient.AddDepartment();
            this.homeMain1 = new HMSClient.HomeMain();
            this.regForm1 = new HMSClient.RegForm();
            this.logForm1 = new HMSClient.LogForm();
            this.addDoctors1 = new HMSClient.AddDoctors();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.bookAptBtn);
            this.panel4.Controls.Add(this.viewAptBtn);
            this.panel4.Controls.Add(this.addDepartmentBtn);
            this.panel4.Controls.Add(this.addDoctorsBtn);
            this.panel4.Controls.Add(this.logoutBtn);
            this.panel4.Controls.Add(this.loginBtn);
            this.panel4.Controls.Add(this.registerBtn);
            this.panel4.Controls.Add(this.homeBtn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(280, 1045);
            this.panel4.TabIndex = 2;
            // 
            // bookAptBtn
            // 
            this.bookAptBtn.FlatAppearance.BorderSize = 0;
            this.bookAptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookAptBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookAptBtn.ForeColor = System.Drawing.Color.White;
            this.bookAptBtn.Location = new System.Drawing.Point(12, 481);
            this.bookAptBtn.Name = "bookAptBtn";
            this.bookAptBtn.Size = new System.Drawing.Size(251, 63);
            this.bookAptBtn.TabIndex = 0;
            this.bookAptBtn.Text = "Book Appointment";
            this.bookAptBtn.UseVisualStyleBackColor = true;
            this.bookAptBtn.Click += new System.EventHandler(this.viewAptBtn_Click);
            // 
            // viewAptBtn
            // 
            this.viewAptBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.viewAptBtn.FlatAppearance.BorderSize = 0;
            this.viewAptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewAptBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAptBtn.ForeColor = System.Drawing.Color.White;
            this.viewAptBtn.Location = new System.Drawing.Point(12, 398);
            this.viewAptBtn.Name = "viewAptBtn";
            this.viewAptBtn.Size = new System.Drawing.Size(251, 63);
            this.viewAptBtn.TabIndex = 0;
            this.viewAptBtn.Text = "View Appointments";
            this.viewAptBtn.UseVisualStyleBackColor = true;
            this.viewAptBtn.Click += new System.EventHandler(this.viewAptBtn_Click);
            // 
            // addDepartmentBtn
            // 
            this.addDepartmentBtn.FlatAppearance.BorderSize = 0;
            this.addDepartmentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addDepartmentBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDepartmentBtn.ForeColor = System.Drawing.Color.White;
            this.addDepartmentBtn.Location = new System.Drawing.Point(22, 329);
            this.addDepartmentBtn.Name = "addDepartmentBtn";
            this.addDepartmentBtn.Size = new System.Drawing.Size(232, 63);
            this.addDepartmentBtn.TabIndex = 0;
            this.addDepartmentBtn.Text = "Add Department";
            this.addDepartmentBtn.UseVisualStyleBackColor = true;
            this.addDepartmentBtn.Click += new System.EventHandler(this.addDepartmentBtn_Click);
            // 
            // addDoctorsBtn
            // 
            this.addDoctorsBtn.FlatAppearance.BorderSize = 0;
            this.addDoctorsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addDoctorsBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDoctorsBtn.ForeColor = System.Drawing.Color.White;
            this.addDoctorsBtn.Location = new System.Drawing.Point(53, 251);
            this.addDoctorsBtn.Name = "addDoctorsBtn";
            this.addDoctorsBtn.Size = new System.Drawing.Size(162, 63);
            this.addDoctorsBtn.TabIndex = 0;
            this.addDoctorsBtn.Text = "Add Doctors";
            this.addDoctorsBtn.UseVisualStyleBackColor = true;
            this.addDoctorsBtn.Click += new System.EventHandler(this.addDoctorsBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.Location = new System.Drawing.Point(83, 165);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(103, 63);
            this.logoutBtn.TabIndex = 0;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(83, 251);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(103, 63);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // registerBtn
            // 
            this.registerBtn.FlatAppearance.BorderSize = 0;
            this.registerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.ForeColor = System.Drawing.Color.White;
            this.registerBtn.Location = new System.Drawing.Point(83, 165);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(103, 63);
            this.registerBtn.TabIndex = 0;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.ForeColor = System.Drawing.Color.White;
            this.homeBtn.Location = new System.Drawing.Point(83, 84);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(103, 63);
            this.homeBtn.TabIndex = 0;
            this.homeBtn.Text = "Home";
            this.homeBtn.UseVisualStyleBackColor = true;
            // 
            // addDepartment1
            // 
            this.addDepartment1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addDepartment1.Location = new System.Drawing.Point(280, 0);
            this.addDepartment1.Name = "addDepartment1";
            this.addDepartment1.Size = new System.Drawing.Size(1053, 1045);
            this.addDepartment1.TabIndex = 6;
            // 
            // homeMain1
            // 
            this.homeMain1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeMain1.Location = new System.Drawing.Point(280, 0);
            this.homeMain1.Name = "homeMain1";
            this.homeMain1.Size = new System.Drawing.Size(1053, 1045);
            this.homeMain1.TabIndex = 5;
            // 
            // regForm1
            // 
            this.regForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.regForm1.Location = new System.Drawing.Point(280, 0);
            this.regForm1.MinimumSize = new System.Drawing.Size(1066, 875);
            this.regForm1.Name = "regForm1";
            this.regForm1.Size = new System.Drawing.Size(1066, 1045);
            this.regForm1.TabIndex = 4;
            // 
            // logForm1
            // 
            this.logForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logForm1.Location = new System.Drawing.Point(280, 0);
            this.logForm1.Name = "logForm1";
            this.logForm1.Size = new System.Drawing.Size(1053, 1045);
            this.logForm1.TabIndex = 3;
            // 
            // addDoctors1
            // 
            this.addDoctors1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addDoctors1.Location = new System.Drawing.Point(280, 0);
            this.addDoctors1.Name = "addDoctors1";
            this.addDoctors1.Size = new System.Drawing.Size(1053, 1045);
            this.addDoctors1.TabIndex = 7;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1333, 1045);
            this.Controls.Add(this.addDoctors1);
            this.Controls.Add(this.addDepartment1);
            this.Controls.Add(this.homeMain1);
            this.Controls.Add(this.regForm1);
            this.Controls.Add(this.logForm1);
            this.Controls.Add(this.panel4);
            this.MinimumSize = new System.Drawing.Size(1166, 977);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;

        private System.Windows.Forms.Panel panel4;
        private LogForm logForm1;
        private RegForm regForm1;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Button viewAptBtn;
        private System.Windows.Forms.Button addDepartmentBtn;
        private System.Windows.Forms.Button addDoctorsBtn;
        private HomeMain homeMain1;
        private System.Windows.Forms.Button bookAptBtn;
        private AddDepartment addDepartment1;
        private AddDoctors addDoctors1;
    }
}

