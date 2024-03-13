namespace HMSClient
{
    partial class AddDoctors
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
            this.gender = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.emailText = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.addressText = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.phoneText = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.nameText = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.passwordText = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.usernameText = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addDoctorBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.getDeptBtn = new System.Windows.Forms.Button();
            this.deptListBox = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.gender.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.gender);
            this.panel1.Controls.Add(this.emailText);
            this.panel1.Controls.Add(this.addressText);
            this.panel1.Controls.Add(this.phoneText);
            this.panel1.Controls.Add(this.nameText);
            this.panel1.Controls.Add(this.passwordText);
            this.panel1.Controls.Add(this.usernameText);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.addDoctorBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.getDeptBtn);
            this.panel1.Controls.Add(this.deptListBox);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(995, 964);
            this.panel1.TabIndex = 0;
            // 
            // gender
            // 
            this.gender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gender.Controls.Add(this.radioButton1);
            this.gender.Controls.Add(this.radioButton2);
            this.gender.Location = new System.Drawing.Point(383, 620);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(244, 100);
            this.gender.TabIndex = 36;
            this.gender.TabStop = false;
            this.gender.Text = "Gender";
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(27, 46);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(77, 34);
            this.radioButton1.TabIndex = 35;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Male";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(130, 46);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(97, 34);
            this.radioButton2.TabIndex = 35;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Female";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // emailText
            // 
            this.emailText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailText.Location = new System.Drawing.Point(383, 365);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(314, 45);
            this.emailText.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.emailText.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.emailText.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.emailText.StateCommon.Border.Rounding = 20;
            this.emailText.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailText.TabIndex = 32;
            // 
            // addressText
            // 
            this.addressText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addressText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addressText.Location = new System.Drawing.Point(383, 556);
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(314, 45);
            this.addressText.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.addressText.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.addressText.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.addressText.StateCommon.Border.Rounding = 20;
            this.addressText.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressText.TabIndex = 31;
            // 
            // phoneText
            // 
            this.phoneText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneText.Location = new System.Drawing.Point(383, 461);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(314, 45);
            this.phoneText.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.phoneText.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.phoneText.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.phoneText.StateCommon.Border.Rounding = 20;
            this.phoneText.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneText.TabIndex = 30;
            // 
            // nameText
            // 
            this.nameText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameText.Location = new System.Drawing.Point(383, 271);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(314, 45);
            this.nameText.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.nameText.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.nameText.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.nameText.StateCommon.Border.Rounding = 20;
            this.nameText.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameText.TabIndex = 29;
            // 
            // passwordText
            // 
            this.passwordText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordText.Location = new System.Drawing.Point(383, 176);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(314, 45);
            this.passwordText.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.passwordText.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.passwordText.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.passwordText.StateCommon.Border.Rounding = 20;
            this.passwordText.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordText.TabIndex = 34;
            // 
            // usernameText
            // 
            this.usernameText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameText.Location = new System.Drawing.Point(383, 83);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(314, 45);
            this.usernameText.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.usernameText.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.usernameText.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.usernameText.StateCommon.Border.Rounding = 20;
            this.usernameText.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameText.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(239, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 32);
            this.label5.TabIndex = 26;
            this.label5.Text = "Email";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(217, 778);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 32);
            this.label9.TabIndex = 25;
            this.label9.Text = "Department";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(239, 668);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 32);
            this.label8.TabIndex = 25;
            this.label8.Text = "Gender";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(239, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 32);
            this.label4.TabIndex = 24;
            this.label4.Text = "Name";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(240, 569);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 32);
            this.label7.TabIndex = 23;
            this.label7.Text = "Address";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(240, 474);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 32);
            this.label6.TabIndex = 22;
            this.label6.Text = "Phone";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(239, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 32);
            this.label3.TabIndex = 21;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(239, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 32);
            this.label2.TabIndex = 27;
            this.label2.Text = "Username";
            // 
            // addDoctorBtn
            // 
            this.addDoctorBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addDoctorBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.addDoctorBtn.FlatAppearance.BorderSize = 0;
            this.addDoctorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addDoctorBtn.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDoctorBtn.ForeColor = System.Drawing.Color.White;
            this.addDoctorBtn.Location = new System.Drawing.Point(383, 892);
            this.addDoctorBtn.Name = "addDoctorBtn";
            this.addDoctorBtn.Size = new System.Drawing.Size(280, 55);
            this.addDoctorBtn.TabIndex = 3;
            this.addDoctorBtn.Text = "Add Doctor";
            this.addDoctorBtn.UseVisualStyleBackColor = false;
            this.addDoctorBtn.Click += new System.EventHandler(this.addDoctorBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(403, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add Doctor";
            // 
            // getDeptBtn
            // 
            this.getDeptBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.getDeptBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.getDeptBtn.FlatAppearance.BorderSize = 0;
            this.getDeptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.getDeptBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getDeptBtn.ForeColor = System.Drawing.Color.White;
            this.getDeptBtn.Location = new System.Drawing.Point(714, 755);
            this.getDeptBtn.Name = "getDeptBtn";
            this.getDeptBtn.Size = new System.Drawing.Size(171, 55);
            this.getDeptBtn.TabIndex = 1;
            this.getDeptBtn.Text = "Get Departments";
            this.getDeptBtn.UseVisualStyleBackColor = false;
            this.getDeptBtn.Click += new System.EventHandler(this.getDeptBtn_Click);
            // 
            // deptListBox
            // 
            this.deptListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deptListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.deptListBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deptListBox.FormattingEnabled = true;
            this.deptListBox.ItemHeight = 15;
            this.deptListBox.Location = new System.Drawing.Point(383, 726);
            this.deptListBox.Name = "deptListBox";
            this.deptListBox.Size = new System.Drawing.Size(295, 135);
            this.deptListBox.TabIndex = 0;
            this.deptListBox.SelectedIndexChanged += new System.EventHandler(this.deptListBox_SelectedIndexChanged);
            // 
            // AddDoctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "AddDoctors";
            this.Size = new System.Drawing.Size(995, 964);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gender.ResumeLayout(false);
            this.gender.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox deptListBox;
        private System.Windows.Forms.Button getDeptBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addDoctorBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox emailText;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox addressText;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox phoneText;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox nameText;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox passwordText;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox usernameText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox gender;
    }
}
