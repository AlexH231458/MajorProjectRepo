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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.MenuSettingsButton = new System.Windows.Forms.Button();
            this.MenuFriendsButton = new System.Windows.Forms.Button();
            this.MenuHeadingLabel = new System.Windows.Forms.Label();
            this.MenuAllPanel = new System.Windows.Forms.Panel();
            this.MenuPinnedPanel = new System.Windows.Forms.Panel();
            this.MenuPinnedLabel = new System.Windows.Forms.Label();
            this.MenuAllLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MenuSettingsButton
            // 
            this.MenuSettingsButton.BackColor = System.Drawing.Color.Silver;
            this.MenuSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuSettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuSettingsButton.Location = new System.Drawing.Point(15, 15);
            this.MenuSettingsButton.Name = "MenuSettingsButton";
            this.MenuSettingsButton.Size = new System.Drawing.Size(95, 50);
            this.MenuSettingsButton.TabIndex = 0;
            this.MenuSettingsButton.Text = "Settings";
            this.MenuSettingsButton.UseVisualStyleBackColor = false;
            this.MenuSettingsButton.Click += new System.EventHandler(this.MenuSettingsButton_Click);
            // 
            // MenuFriendsButton
            // 
            this.MenuFriendsButton.BackColor = System.Drawing.Color.Silver;
            this.MenuFriendsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuFriendsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuFriendsButton.Location = new System.Drawing.Point(420, 15);
            this.MenuFriendsButton.Name = "MenuFriendsButton";
            this.MenuFriendsButton.Size = new System.Drawing.Size(95, 50);
            this.MenuFriendsButton.TabIndex = 1;
            this.MenuFriendsButton.Text = "Friends";
            this.MenuFriendsButton.UseVisualStyleBackColor = false;
            this.MenuFriendsButton.Click += new System.EventHandler(this.MenuFriendsButton_Click);
            // 
            // MenuHeadingLabel
            // 
            this.MenuHeadingLabel.AutoSize = true;
            this.MenuHeadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuHeadingLabel.Location = new System.Drawing.Point(220, 30);
            this.MenuHeadingLabel.Name = "MenuHeadingLabel";
            this.MenuHeadingLabel.Size = new System.Drawing.Size(86, 31);
            this.MenuHeadingLabel.TabIndex = 2;
            this.MenuHeadingLabel.Text = "Chats";
            this.MenuHeadingLabel.Click += new System.EventHandler(this.MenuHeadingLabel_Click);
            // 
            // MenuAllPanel
            // 
            this.MenuAllPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuAllPanel.Location = new System.Drawing.Point(15, 185);
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
            this.MenuPinnedPanel.Size = new System.Drawing.Size(500, 55);
            this.MenuPinnedPanel.TabIndex = 4;
            this.MenuPinnedPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuPinnedPanel_Paint);
            // 
            // MenuPinnedLabel
            // 
            this.MenuPinnedLabel.AutoSize = true;
            this.MenuPinnedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuPinnedLabel.Location = new System.Drawing.Point(15, 85);
            this.MenuPinnedLabel.Name = "MenuPinnedLabel";
            this.MenuPinnedLabel.Size = new System.Drawing.Size(96, 20);
            this.MenuPinnedLabel.TabIndex = 5;
            this.MenuPinnedLabel.Text = "Pinned Chat";
            this.MenuPinnedLabel.Click += new System.EventHandler(this.MenuPinnedLabel_Click);
            // 
            // MenuAllLabel
            // 
            this.MenuAllLabel.AutoSize = true;
            this.MenuAllLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuAllLabel.Location = new System.Drawing.Point(15, 165);
            this.MenuAllLabel.Name = "MenuAllLabel";
            this.MenuAllLabel.Size = new System.Drawing.Size(72, 20);
            this.MenuAllLabel.TabIndex = 6;
            this.MenuAllLabel.Text = "All Chats";
            this.MenuAllLabel.Click += new System.EventHandler(this.MenuAllLabel_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 661);
            this.Controls.Add(this.MenuAllLabel);
            this.Controls.Add(this.MenuPinnedLabel);
            this.Controls.Add(this.MenuPinnedPanel);
            this.Controls.Add(this.MenuAllPanel);
            this.Controls.Add(this.MenuHeadingLabel);
            this.Controls.Add(this.MenuFriendsButton);
            this.Controls.Add(this.MenuSettingsButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Label MenuPinnedLabel;
        private System.Windows.Forms.Label MenuAllLabel;
    }
}