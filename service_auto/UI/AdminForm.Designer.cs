namespace service_auto
{
    partial class AdminForm
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
            this.createAgentButton = new System.Windows.Forms.Button();
            this.showReportBbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createAgentButton
            // 
            this.createAgentButton.Location = new System.Drawing.Point(268, 111);
            this.createAgentButton.Name = "createAgentButton";
            this.createAgentButton.Size = new System.Drawing.Size(240, 64);
            this.createAgentButton.TabIndex = 0;
            this.createAgentButton.Text = "Create new agent account";
            this.createAgentButton.UseVisualStyleBackColor = true;
            this.createAgentButton.Click += new System.EventHandler(this.createAgentButton_Click);
            // 
            // showReportBbutton
            // 
            this.showReportBbutton.Location = new System.Drawing.Point(268, 211);
            this.showReportBbutton.Name = "showReportBbutton";
            this.showReportBbutton.Size = new System.Drawing.Size(240, 64);
            this.showReportBbutton.TabIndex = 1;
            this.showReportBbutton.Text = "Show Report";
            this.showReportBbutton.UseVisualStyleBackColor = true;
            this.showReportBbutton.Click += new System.EventHandler(this.showReportBbutton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showReportBbutton);
            this.Controls.Add(this.createAgentButton);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createAgentButton;
        private System.Windows.Forms.Button showReportBbutton;
    }
}