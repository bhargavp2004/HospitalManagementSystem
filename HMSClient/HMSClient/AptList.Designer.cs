namespace HMSClient
{
    partial class AptList
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
            this.dataGridViewAppointments = new System.Windows.Forms.DataGridView();
            this.getAptBtn = new System.Windows.Forms.Button();
            this.AptdeleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAppointments
            // 
            this.dataGridViewAppointments.AllowUserToOrderColumns = true;
            this.dataGridViewAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAppointments.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewAppointments.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAppointments.Name = "dataGridViewAppointments";
            this.dataGridViewAppointments.Size = new System.Drawing.Size(972, 757);
            this.dataGridViewAppointments.TabIndex = 0;
            // 
            // getAptBtn
            // 
            this.getAptBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.getAptBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.getAptBtn.FlatAppearance.BorderSize = 0;
            this.getAptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.getAptBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getAptBtn.ForeColor = System.Drawing.Color.White;
            this.getAptBtn.Location = new System.Drawing.Point(255, 791);
            this.getAptBtn.Name = "getAptBtn";
            this.getAptBtn.Size = new System.Drawing.Size(171, 55);
            this.getAptBtn.TabIndex = 2;
            this.getAptBtn.Text = "Get Appointments";
            this.getAptBtn.UseVisualStyleBackColor = false;
            this.getAptBtn.Click += new System.EventHandler(this.getAptBtn_Click);
            // 
            // AptdeleteBtn
            // 
            this.AptdeleteBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AptdeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.AptdeleteBtn.FlatAppearance.BorderSize = 0;
            this.AptdeleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.AptdeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AptdeleteBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AptdeleteBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AptdeleteBtn.Location = new System.Drawing.Point(499, 792);
            this.AptdeleteBtn.Name = "AptdeleteBtn";
            this.AptdeleteBtn.Size = new System.Drawing.Size(208, 52);
            this.AptdeleteBtn.TabIndex = 10;
            this.AptdeleteBtn.Text = "Delete Appointment";
            this.AptdeleteBtn.UseVisualStyleBackColor = false;
            this.AptdeleteBtn.Click += new System.EventHandler(this.AptdeleteBtn_Click);
            // 
            // AptList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AptdeleteBtn);
            this.Controls.Add(this.getAptBtn);
            this.Controls.Add(this.dataGridViewAppointments);
            this.Name = "AptList";
            this.Size = new System.Drawing.Size(972, 889);
            this.Load += new System.EventHandler(this.AptList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAppointments;
        private System.Windows.Forms.Button getAptBtn;
        private System.Windows.Forms.Button AptdeleteBtn;
    }
}
