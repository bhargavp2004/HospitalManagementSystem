namespace HMSClient
{
    partial class LogForm
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
            this.passwordText = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.usernameText = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
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
            this.panel1.Controls.Add(this.passwordText);
            this.panel1.Controls.Add(this.usernameText);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 681);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // loginBtnUC
            // 
            this.loginBtnUC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginBtnUC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.loginBtnUC.FlatAppearance.BorderSize = 0;
            this.loginBtnUC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.loginBtnUC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginBtnUC.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtnUC.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loginBtnUC.Location = new System.Drawing.Point(299, 339);
            this.loginBtnUC.Name = "loginBtnUC";
            this.loginBtnUC.Size = new System.Drawing.Size(208, 42);
            this.loginBtnUC.TabIndex = 9;
            this.loginBtnUC.Text = "Login";
            this.loginBtnUC.UseVisualStyleBackColor = false;
            this.loginBtnUC.Click += new System.EventHandler(this.loginBtnUC_Click);
            // 
            // registerBtnUC
            // 
            this.registerBtnUC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.registerBtnUC.BackColor = System.Drawing.Color.Transparent;
            this.registerBtnUC.FlatAppearance.BorderSize = 0;
            this.registerBtnUC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerBtnUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtnUC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.registerBtnUC.Location = new System.Drawing.Point(238, 400);
            this.registerBtnUC.Name = "registerBtnUC";
            this.registerBtnUC.Size = new System.Drawing.Size(337, 51);
            this.registerBtnUC.TabIndex = 8;
            this.registerBtnUC.Text = "Don\'t Have An Account ? Register Here";
            this.registerBtnUC.UseVisualStyleBackColor = false;
            // 
            // passwordText
            // 
            this.passwordText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordText.Location = new System.Drawing.Point(261, 235);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(314, 45);
            this.passwordText.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.passwordText.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.passwordText.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.passwordText.StateCommon.Border.Rounding = 20;
            this.passwordText.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordText.TabIndex = 6;
            // 
            // usernameText
            // 
            this.usernameText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameText.Location = new System.Drawing.Point(261, 142);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(314, 45);
            this.usernameText.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.usernameText.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.usernameText.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.usernameText.StateCommon.Border.Rounding = 20;
            this.usernameText.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameText.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(117, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(329, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 47);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "LogForm";
            this.Size = new System.Drawing.Size(778, 701);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button loginBtnUC;
        private System.Windows.Forms.Button registerBtnUC;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox passwordText;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox usernameText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
