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
            this.FriendSearchCombo = new System.Windows.Forms.ComboBox();
            this.FriendTitleLabel = new System.Windows.Forms.Label();
            this.FriendSearchLabel = new System.Windows.Forms.Label();
            this.FriendRequestButton = new System.Windows.Forms.Button();
            this.FriendsRequestsPanel = new System.Windows.Forms.Panel();
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
            // FriendSearchCombo
            // 
            this.FriendSearchCombo.FormattingEnabled = true;
            this.FriendSearchCombo.Location = new System.Drawing.Point(205, 100);
            this.FriendSearchCombo.Name = "FriendSearchCombo";
            this.FriendSearchCombo.Size = new System.Drawing.Size(150, 21);
            this.FriendSearchCombo.TabIndex = 16;
            this.FriendSearchCombo.SelectedIndexChanged += new System.EventHandler(this.FriendSearchCombo_SelectedIndexChanged);
            // 
            // FriendTitleLabel
            // 
            this.FriendTitleLabel.AutoSize = true;
            this.FriendTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FriendTitleLabel.Location = new System.Drawing.Point(200, 25);
            this.FriendTitleLabel.Name = "FriendTitleLabel";
            this.FriendTitleLabel.Size = new System.Drawing.Size(95, 29);
            this.FriendTitleLabel.TabIndex = 17;
            this.FriendTitleLabel.Text = "Friends";
            // 
            // FriendSearchLabel
            // 
            this.FriendSearchLabel.AutoSize = true;
            this.FriendSearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FriendSearchLabel.Location = new System.Drawing.Point(15, 100);
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
            this.FriendRequestButton.Location = new System.Drawing.Point(390, 87);
            this.FriendRequestButton.Name = "FriendRequestButton";
            this.FriendRequestButton.Size = new System.Drawing.Size(94, 50);
            this.FriendRequestButton.TabIndex = 19;
            this.FriendRequestButton.Text = "Request";
            this.FriendRequestButton.UseVisualStyleBackColor = false;
            this.FriendRequestButton.Click += new System.EventHandler(this.FriendRequestButton_Click);
            // 
            // FriendsRequestsPanel
            // 
            this.FriendsRequestsPanel.AutoScroll = true;
            this.FriendsRequestsPanel.Location = new System.Drawing.Point(39, 181);
            this.FriendsRequestsPanel.Name = "FriendsRequestsPanel";
            this.FriendsRequestsPanel.Size = new System.Drawing.Size(471, 146);
            this.FriendsRequestsPanel.TabIndex = 20;
            // 
            // Friends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 761);
            this.Controls.Add(this.FriendsRequestsPanel);
            this.Controls.Add(this.FriendRequestButton);
            this.Controls.Add(this.FriendSearchLabel);
            this.Controls.Add(this.FriendTitleLabel);
            this.Controls.Add(this.FriendSearchCombo);
            this.Controls.Add(this.FriendReturnButton);
            this.Name = "Friends";
            this.Text = "Friends";
            this.Load += new System.EventHandler(this.Friends_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FriendReturnButton;
        private System.Windows.Forms.ComboBox FriendSearchCombo;
        private System.Windows.Forms.Label FriendTitleLabel;
        private System.Windows.Forms.Label FriendSearchLabel;
        private System.Windows.Forms.Button FriendRequestButton;
        private System.Windows.Forms.Panel FriendsRequestsPanel;
    }
}