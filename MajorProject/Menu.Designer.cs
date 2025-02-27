﻿namespace MajorProject
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
            this.MenuHeadingLabel = new System.Windows.Forms.Label();
            this.MenuAllPanel = new System.Windows.Forms.Panel();
            this.MenuPinnedPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // MenuSettingsButton
            // 
            this.MenuSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuSettingsButton.Location = new System.Drawing.Point(15, 12);
            this.MenuSettingsButton.Name = "MenuSettingsButton";
            this.MenuSettingsButton.Size = new System.Drawing.Size(95, 50);
            this.MenuSettingsButton.TabIndex = 0;
            this.MenuSettingsButton.Text = "Settings";
            this.MenuSettingsButton.UseVisualStyleBackColor = true;
            this.MenuSettingsButton.Click += new System.EventHandler(this.MenuSettingsButton_Click);
            // 
            // MenuFriendsButton
            // 
            this.MenuFriendsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuFriendsButton.Location = new System.Drawing.Point(420, 12);
            this.MenuFriendsButton.Name = "MenuFriendsButton";
            this.MenuFriendsButton.Size = new System.Drawing.Size(95, 50);
            this.MenuFriendsButton.TabIndex = 1;
            this.MenuFriendsButton.Text = "Friends";
            this.MenuFriendsButton.UseVisualStyleBackColor = true;
            this.MenuFriendsButton.Click += new System.EventHandler(this.MenuFriendsButton_Click);
            // 
            // MenuHeadingLabel
            // 
            this.MenuHeadingLabel.AutoSize = true;
            this.MenuHeadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuHeadingLabel.Location = new System.Drawing.Point(241, 23);
            this.MenuHeadingLabel.Name = "MenuHeadingLabel";
            this.MenuHeadingLabel.Size = new System.Drawing.Size(57, 24);
            this.MenuHeadingLabel.TabIndex = 2;
            this.MenuHeadingLabel.Text = "Chats";
            // 
            // MenuAllPanel
            // 
            this.MenuAllPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuAllPanel.Location = new System.Drawing.Point(15, 200);
            this.MenuAllPanel.Name = "MenuAllPanel";
            this.MenuAllPanel.Size = new System.Drawing.Size(500, 450);
            this.MenuAllPanel.TabIndex = 3;
            this.MenuAllPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuAllPanel_Paint);
            // 
            // MenuPinnedPanel
            // 
            this.MenuPinnedPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuPinnedPanel.Location = new System.Drawing.Point(17, 105);
            this.MenuPinnedPanel.Name = "MenuPinnedPanel";
            this.MenuPinnedPanel.Size = new System.Drawing.Size(500, 50);
            this.MenuPinnedPanel.TabIndex = 4;
            this.MenuPinnedPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuPinnedPanel_Paint);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 661);
            this.Controls.Add(this.MenuPinnedPanel);
            this.Controls.Add(this.MenuAllPanel);
            this.Controls.Add(this.MenuHeadingLabel);
            this.Controls.Add(this.MenuFriendsButton);
            this.Controls.Add(this.MenuSettingsButton);
            this.MaximumSize = new System.Drawing.Size(550, 700);
            this.MinimumSize = new System.Drawing.Size(550, 700);
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
        private System.Windows.Forms.Label MenuHeadingLabel;
        private System.Windows.Forms.Panel MenuAllPanel;
        private System.Windows.Forms.Panel MenuPinnedPanel;
    }
}