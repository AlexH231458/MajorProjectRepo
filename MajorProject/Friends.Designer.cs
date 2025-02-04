namespace MajorProject
{
    partial class Friends
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
            this.FriendReturnButton = new System.Windows.Forms.Button();
            this.FriendTitleLabel = new System.Windows.Forms.Label();
            this.FriendSearchLabel = new System.Windows.Forms.Label();
            this.FriendRequestButton = new System.Windows.Forms.Button();
            this.FriendsRequestsPanel = new System.Windows.Forms.Panel();
            this.FriendsFriendsPanel = new System.Windows.Forms.Panel();
            this.FriendsErrorLabel = new System.Windows.Forms.Label();
            this.FriendsSearchBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FriendReturnButton
            // 
            this.FriendReturnButton.BackColor = System.Drawing.Color.DarkRed;
            this.FriendReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FriendReturnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FriendReturnButton.Location = new System.Drawing.Point(15, 15);
            this.FriendReturnButton.Name = "FriendReturnButton";
            this.FriendReturnButton.Size = new System.Drawing.Size(95, 50);
            this.FriendReturnButton.TabIndex = 15;
            this.FriendReturnButton.Text = "Return";
            this.FriendReturnButton.UseVisualStyleBackColor = false;
            this.FriendReturnButton.Click += new System.EventHandler(this.FriendReturnButton_Click);
            // 
            // FriendTitleLabel
            // 
            this.FriendTitleLabel.AutoSize = true;
            this.FriendTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FriendTitleLabel.Location = new System.Drawing.Point(203, 24);
            this.FriendTitleLabel.Name = "FriendTitleLabel";
            this.FriendTitleLabel.Size = new System.Drawing.Size(95, 29);
            this.FriendTitleLabel.TabIndex = 17;
            this.FriendTitleLabel.Text = "Friends";
            // 
            // FriendSearchLabel
            // 
            this.FriendSearchLabel.AutoSize = true;
            this.FriendSearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FriendSearchLabel.Location = new System.Drawing.Point(35, 96);
            this.FriendSearchLabel.Name = "FriendSearchLabel";
            this.FriendSearchLabel.Size = new System.Drawing.Size(106, 24);
            this.FriendSearchLabel.TabIndex = 18;
            this.FriendSearchLabel.Text = "Add friends";
            // 
            // FriendRequestButton
            // 
            this.FriendRequestButton.BackColor = System.Drawing.Color.ForestGreen;
            this.FriendRequestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FriendRequestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FriendRequestButton.Location = new System.Drawing.Point(379, 82);
            this.FriendRequestButton.Name = "FriendRequestButton";
            this.FriendRequestButton.Size = new System.Drawing.Size(95, 50);
            this.FriendRequestButton.TabIndex = 19;
            this.FriendRequestButton.Text = "Request";
            this.FriendRequestButton.UseVisualStyleBackColor = false;
            this.FriendRequestButton.Click += new System.EventHandler(this.FriendRequestButton_Click);
            // 
            // FriendsRequestsPanel
            // 
            this.FriendsRequestsPanel.AutoScroll = true;
            this.FriendsRequestsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FriendsRequestsPanel.Location = new System.Drawing.Point(15, 159);
            this.FriendsRequestsPanel.Name = "FriendsRequestsPanel";
            this.FriendsRequestsPanel.Size = new System.Drawing.Size(500, 150);
            this.FriendsRequestsPanel.TabIndex = 20;
            this.FriendsRequestsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.FriendsRequestsPanel_Paint);
            // 
            // FriendsFriendsPanel
            // 
            this.FriendsFriendsPanel.AutoScroll = true;
            this.FriendsFriendsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FriendsFriendsPanel.Location = new System.Drawing.Point(15, 330);
            this.FriendsFriendsPanel.Name = "FriendsFriendsPanel";
            this.FriendsFriendsPanel.Size = new System.Drawing.Size(500, 150);
            this.FriendsFriendsPanel.TabIndex = 21;
            this.FriendsFriendsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.FriendsFriendsPanel_Paint);
            // 
            // FriendsErrorLabel
            // 
            this.FriendsErrorLabel.AutoSize = true;
            this.FriendsErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.FriendsErrorLabel.Location = new System.Drawing.Point(376, 40);
            this.FriendsErrorLabel.Name = "FriendsErrorLabel";
            this.FriendsErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.FriendsErrorLabel.TabIndex = 22;
            this.FriendsErrorLabel.Click += new System.EventHandler(this.FriendsErrorLabel_Click);
            // 
            // FriendsSearchBox
            // 
            this.FriendsSearchBox.Location = new System.Drawing.Point(185, 100);
            this.FriendsSearchBox.MaxLength = 29;
            this.FriendsSearchBox.Name = "FriendsSearchBox";
            this.FriendsSearchBox.Size = new System.Drawing.Size(150, 20);
            this.FriendsSearchBox.TabIndex = 23;
            this.FriendsSearchBox.TextChanged += new System.EventHandler(this.FriendsSearchBox_TextChanged);
            // 
            // Friends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 661);
            this.Controls.Add(this.FriendsSearchBox);
            this.Controls.Add(this.FriendsErrorLabel);
            this.Controls.Add(this.FriendsFriendsPanel);
            this.Controls.Add(this.FriendsRequestsPanel);
            this.Controls.Add(this.FriendRequestButton);
            this.Controls.Add(this.FriendSearchLabel);
            this.Controls.Add(this.FriendTitleLabel);
            this.Controls.Add(this.FriendReturnButton);
            this.MaximumSize = new System.Drawing.Size(550, 700);
            this.MinimumSize = new System.Drawing.Size(550, 700);
            this.Name = "Friends";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Friends";
            this.Load += new System.EventHandler(this.Friends_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FriendReturnButton;
        private System.Windows.Forms.Label FriendTitleLabel;
        private System.Windows.Forms.Label FriendSearchLabel;
        private System.Windows.Forms.Button FriendRequestButton;
        private System.Windows.Forms.Panel FriendsRequestsPanel;
        private System.Windows.Forms.Panel FriendsFriendsPanel;
        private System.Windows.Forms.Label FriendsErrorLabel;
        private System.Windows.Forms.TextBox FriendsSearchBox;
    }
}