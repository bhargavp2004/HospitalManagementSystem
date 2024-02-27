namespace HMSClient
{
    partial class RegForm
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
            this.loginBtnUC = new System.Windows.Forms.Button();
            this.registerBtnUC = new System.Windows.Forms.Button();
            this.ageText = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.genderText = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.emailText = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.addressText = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.phoneText = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.nameText = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.passwordText = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.usernameText = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.loginBtnUC);
            this.panel1.Controls.Add(this.registerBtnUC);
            this.panel1.Controls.Add(this.ageText);
            this.panel1.Controls.Add(this.genderText);
            this.panel1.Controls.Add(this.emailText);
            this.panel1.Controls.Add(this.addressText);
            this.panel1.Controls.Add(this.phoneText);
            this.panel1.Controls.Add(this.nameText);
            this.panel1.Controls.Add(this.passwordText);
            this.panel1.Controls.Add(this.usernameText);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 875);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // loginBtnUC
            // 
            this.loginBtnUC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginBtnUC.BackColor = System.Drawing.Color.Transparent;
            this.loginBtnUC.FlatAppearance.BorderSize = 0;
            this.loginBtnUC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtnUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtnUC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.loginBtnUC.Location = new System.Drawing.Point(542, 806);
            this.loginBtnUC.Name = "loginBtnUC";
            this.loginBtnUC.Size = new System.Drawing.Size(337, 51);
            this.loginBtnUC.TabIndex = 22;
            this.loginBtnUC.Text = "Already Have An Account ?, Log In";
            this.loginBtnUC.UseVisualStyleBackColor = false;
            // 
            // registerBtnUC
            // 
            this.registerBtnUC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.registerBtnUC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.registerBtnUC.FlatAppearance.BorderSize = 0;
            this.registerBtnUC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.registerBtnUC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registerBtnUC.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtnUC.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.registerBtnUC.Location = new System.Drawing.Point(319, 807);
            this.registerBtnUC.Name = "registerBtnUC";
            this.registerBtnUC.Size = new System.Drawing.Size(208, 42);
            this.registerBtnUC.TabIndex = 21;
            this.registerBtnUC.Text = "Register";
            this.registerBtnUC.UseVisualStyleBackColor = false;
            this.registerBtnUC.Click += new System.EventHandler(this.registerBtnUC_Click);
            // 
            // ageText
            // 
            this.ageText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ageText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ageText.Location = new System.Drawing.Point(434, 731);
            this.ageText.Name = "ageText";
            this.ageText.Size = new System.Drawing.Size(314, 45);
            this.ageText.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.ageText.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ageText.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ageText.StateCommon.Border.Rounding = 20;
            this.ageText.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageText.TabIndex = 19;
            // 
            // genderText
            // 
            this.genderText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.genderText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.genderText.Location = new System.Drawing.Point(434, 641);
            this.genderText.Name = "genderText";
            this.genderText.Size = new System.Drawing.Size(314, 45);
            this.genderText.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.genderText.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.genderText.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.genderText.StateCommon.Border.Rounding = 20;
            this.genderText.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderText.TabIndex = 18;
            // 
            // emailText
            // 
            this.emailText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailText.Location = new System.Drawing.Point(434, 351);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(314, 45);
            this.emailText.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.emailText.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.emailText.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.emailText.StateCommon.Border.Rounding = 20;
            this.emailText.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailText.TabIndex = 17;
            // 
            // addressText
            // 
            this.addressText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addressText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addressText.Location = new System.Drawing.Point(434, 542);
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(314, 45);
            this.addressText.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.addressText.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.addressText.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.addressText.StateCommon.Border.Rounding = 20;
            this.addressText.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressText.TabIndex = 16;
            // 
            // phoneText
            // 
            this.phoneText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneText.Location = new System.Drawing.Point(434, 447);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(314, 45);
            this.phoneText.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.phoneText.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.phoneText.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.phoneText.StateCommon.Border.Rounding = 20;
            this.phoneText.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneText.TabIndex = 15;
            // 
            // nameText
            // 
            this.nameText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameText.Location = new System.Drawing.Point(434, 257);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(314, 45);
            this.nameText.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.nameText.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.nameText.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.nameText.StateCommon.Border.Rounding = 20;
            this.nameText.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameText.TabIndex = 14;
            // 
            // passwordText
            // 
            this.passwordText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordText.Location = new System.Drawing.Point(434, 162);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(314, 45);
            this.passwordText.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.passwordText.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.passwordText.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.passwordText.StateCommon.Border.Rounding = 20;
            this.passwordText.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordText.TabIndex = 20;
            // 
            // usernameText
            // 
            this.usernameText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameText.Location = new System.Drawing.Point(434, 69);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(314, 45);
            this.usernameText.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.usernameText.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.usernameText.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.usernameText.StateCommon.Border.Rounding = 20;
            this.usernameText.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameText.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(291, 744);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 32);
            this.label9.TabIndex = 11;
            this.label9.Text = "Age";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(290, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "Email";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(290, 654);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 32);
            this.label8.TabIndex = 9;
            this.label8.Text = "Gender";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(290, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Name";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(291, 555);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 32);
            this.label7.TabIndex = 7;
            this.label7.Text = "Address";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(291, 460);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 32);
            this.label6.TabIndex = 6;
            this.label6.Text = "Phone";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(290, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(290, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 32);
            this.label2.TabIndex = 12;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(426, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 47);
            this.label1.TabIndex = 4;
            this.label1.Text = "Register Yourself";
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1066, 875);
            this.Name = "RegForm";
            this.Size = new System.Drawing.Size(1066, 875);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button loginBtnUC;
        private System.Windows.Forms.Button registerBtnUC;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ageText;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox genderText;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox emailText;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox addressText;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox phoneText;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox nameText;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox passwordText;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox usernameText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
