namespace MajorProject
{
    partial class FriendControl
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
            this.FCPinButton = new System.Windows.Forms.Button();
            this.FCNameLabel = new System.Windows.Forms.Label();
            this.FCNicknameLabel = new System.Windows.Forms.Label();
            this.FCNicknameBox = new System.Windows.Forms.TextBox();
            this.FCRemoveButton = new System.Windows.Forms.Button();
            this.FCChangeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FCPinButton
            // 
            this.FCPinButton.BackColor = System.Drawing.Color.Gold;
            this.FCPinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FCPinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FCPinButton.Location = new System.Drawing.Point(410, 10);
            this.FCPinButton.Name = "FCPinButton";
            this.FCPinButton.Size = new System.Drawing.Size(30, 30);
            this.FCPinButton.TabIndex = 0;
            this.FCPinButton.Text = "📌";
            this.FCPinButton.UseVisualStyleBackColor = false;
            this.FCPinButton.Click += new System.EventHandler(this.FCPinButton_Click);
            // 
            // FCNameLabel
            // 
            this.FCNameLabel.AutoSize = true;
            this.FCNameLabel.Location = new System.Drawing.Point(30, 20);
            this.FCNameLabel.Name = "FCNameLabel";
            this.FCNameLabel.Size = new System.Drawing.Size(0, 13);
            this.FCNameLabel.TabIndex = 2;
            this.FCNameLabel.Click += new System.EventHandler(this.FCNameLabel_Click);
            // 
            // FCNicknameLabel
            // 
            this.FCNicknameLabel.AutoSize = true;
            this.FCNicknameLabel.Location = new System.Drawing.Point(230, 5);
            this.FCNicknameLabel.Name = "FCNicknameLabel";
            this.FCNicknameLabel.Size = new System.Drawing.Size(58, 13);
            this.FCNicknameLabel.TabIndex = 3;
            this.FCNicknameLabel.Text = "Nickname:";
            this.FCNicknameLabel.Click += new System.EventHandler(this.FCNicknameLabel_Click);
            // 
            // FCNicknameBox
            // 
            this.FCNicknameBox.Location = new System.Drawing.Point(230, 20);
            this.FCNicknameBox.Name = "FCNicknameBox";
            this.FCNicknameBox.Size = new System.Drawing.Size(100, 20);
            this.FCNicknameBox.TabIndex = 4;
            this.FCNicknameBox.TextChanged += new System.EventHandler(this.FCNicknameBox_TextChanged);
            // 
            // FCRemoveButton
            // 
            this.FCRemoveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FCRemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FCRemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FCRemoveButton.Location = new System.Drawing.Point(445, 10);
            this.FCRemoveButton.Name = "FCRemoveButton";
            this.FCRemoveButton.Size = new System.Drawing.Size(30, 30);
            this.FCRemoveButton.TabIndex = 5;
            this.FCRemoveButton.Text = "X";
            this.FCRemoveButton.UseVisualStyleBackColor = false;
            this.FCRemoveButton.Click += new System.EventHandler(this.FCRemoveButton_Click);
            // 
            // FCChangeButton
            // 
            this.FCChangeButton.BackColor = System.Drawing.Color.LimeGreen;
            this.FCChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FCChangeButton.Location = new System.Drawing.Point(335, 10);
            this.FCChangeButton.Name = "FCChangeButton";
            this.FCChangeButton.Size = new System.Drawing.Size(70, 30);
            this.FCChangeButton.TabIndex = 6;
            this.FCChangeButton.Text = "Change";
            this.FCChangeButton.UseVisualStyleBackColor = false;
            this.FCChangeButton.Click += new System.EventHandler(this.FCChangeButton_Click);
            // 
            // FriendControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FCChangeButton);
            this.Controls.Add(this.FCRemoveButton);
            this.Controls.Add(this.FCNicknameBox);
            this.Controls.Add(this.FCNicknameLabel);
            this.Controls.Add(this.FCNameLabel);
            this.Controls.Add(this.FCPinButton);
            this.Name = "FriendControl";
            this.Size = new System.Drawing.Size(480, 50);
            this.Load += new System.EventHandler(this.FriendControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FCPinButton;
        private System.Windows.Forms.Label FCNameLabel;
        private System.Windows.Forms.Label FCNicknameLabel;
        private System.Windows.Forms.TextBox FCNicknameBox;
        private System.Windows.Forms.Button FCRemoveButton;
        private System.Windows.Forms.Button FCChangeButton;
    }
}
