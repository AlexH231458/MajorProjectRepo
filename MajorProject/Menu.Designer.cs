namespace MajorProject
{
    partial class Menu
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
            this.MenuSettingsButton = new System.Windows.Forms.Button();
            this.MenuFriendsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MenuSettingsButton
            // 
            this.MenuSettingsButton.Location = new System.Drawing.Point(12, 12);
            this.MenuSettingsButton.Name = "MenuSettingsButton";
            this.MenuSettingsButton.Size = new System.Drawing.Size(75, 23);
            this.MenuSettingsButton.TabIndex = 0;
            this.MenuSettingsButton.Text = "Settings";
            this.MenuSettingsButton.UseVisualStyleBackColor = true;
            this.MenuSettingsButton.Click += new System.EventHandler(this.MenuSettingsButton_Click);
            // 
            // MenuFriendsButton
            // 
            this.MenuFriendsButton.Location = new System.Drawing.Point(118, 12);
            this.MenuFriendsButton.Name = "MenuFriendsButton";
            this.MenuFriendsButton.Size = new System.Drawing.Size(75, 23);
            this.MenuFriendsButton.TabIndex = 1;
            this.MenuFriendsButton.Text = "Friends";
            this.MenuFriendsButton.UseVisualStyleBackColor = true;
            this.MenuFriendsButton.Click += new System.EventHandler(this.MenuFriendsButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MenuFriendsButton);
            this.Controls.Add(this.MenuSettingsButton);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MenuSettingsButton;
        private System.Windows.Forms.Button MenuFriendsButton;
        private System.Windows.Forms.Label label1;
    }
}