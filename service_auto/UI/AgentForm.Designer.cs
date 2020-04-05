namespace service_auto
{
    partial class AgentForm
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
            this.createAppointmentButton = new System.Windows.Forms.Button();
            this.closeAppointmentButton = new System.Windows.Forms.Button();
            this.showAppointmentsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createAppointmentButton
            // 
            this.createAppointmentButton.Location = new System.Drawing.Point(272, 83);
            this.createAppointmentButton.Name = "createAppointmentButton";
            this.createAppointmentButton.Size = new System.Drawing.Size(240, 64);
            this.createAppointmentButton.TabIndex = 1;
            this.createAppointmentButton.Text = "Create new appointment";
            this.createAppointmentButton.UseVisualStyleBackColor = true;
            this.createAppointmentButton.Click += new System.EventHandler(this.createAppointmentButton_Click);
            // 
            // closeAppointmentButton
            // 
            this.closeAppointmentButton.Location = new System.Drawing.Point(272, 177);
            this.closeAppointmentButton.Name = "closeAppointmentButton";
            this.closeAppointmentButton.Size = new System.Drawing.Size(240, 64);
            this.closeAppointmentButton.TabIndex = 2;
            this.closeAppointmentButton.Text = "Close appointment";
            this.closeAppointmentButton.UseVisualStyleBackColor = true;
            this.closeAppointmentButton.Click += new System.EventHandler(this.closeAppointmentButton_Click);
            // 
            // showAppointmentsButton
            // 
            this.showAppointmentsButton.Location = new System.Drawing.Point(272, 273);
            this.showAppointmentsButton.Name = "showAppointmentsButton";
            this.showAppointmentsButton.Size = new System.Drawing.Size(240, 64);
            this.showAppointmentsButton.TabIndex = 3;
            this.showAppointmentsButton.Text = "List appointments";
            this.showAppointmentsButton.UseVisualStyleBackColor = true;
            this.showAppointmentsButton.Click += new System.EventHandler(this.showAppointmentsButton_Click);
            // 
            // AgentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showAppointmentsButton);
            this.Controls.Add(this.closeAppointmentButton);
            this.Controls.Add(this.createAppointmentButton);
            this.Name = "AgentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agent";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createAppointmentButton;
        private System.Windows.Forms.Button closeAppointmentButton;
        private System.Windows.Forms.Button showAppointmentsButton;
    }
}