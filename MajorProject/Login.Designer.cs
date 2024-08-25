namespace MajorProject
{
    partial class Login
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
            this.LoginUsernameBox = new System.Windows.Forms.TextBox();
            this.LoginPasswordBox = new System.Windows.Forms.TextBox();
            this.LoginUsernameLabel = new System.Windows.Forms.Label();
            this.LoginPasswordLabel = new System.Windows.Forms.Label();
            this.LoginEnterButton = new System.Windows.Forms.Button();
            this.LoginNewButton = new System.Windows.Forms.Button();
            this.LoginShowCheck = new System.Windows.Forms.CheckBox();
            this.LoginErrorText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginUsernameBox
            // 
            this.LoginUsernameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginUsernameBox.Location = new System.Drawing.Point(250, 80);
            this.LoginUsernameBox.Name = "LoginUsernameBox";
            this.LoginUsernameBox.Size = new System.Drawing.Size(200, 26);
            this.LoginUsernameBox.TabIndex = 0;
            this.LoginUsernameBox.TextChanged += new System.EventHandler(this.LoginUsernameBox_TextChanged);
            // 
            // LoginPasswordBox
            // 
            this.LoginPasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPasswordBox.Location = new System.Drawing.Point(250, 130);
            this.LoginPasswordBox.Name = "LoginPasswordBox";
            this.LoginPasswordBox.Size = new System.Drawing.Size(200, 26);
            this.LoginPasswordBox.TabIndex = 1;
            this.LoginPasswordBox.UseSystemPasswordChar = true;
            this.LoginPasswordBox.TextChanged += new System.EventHandler(this.LoginPasswordBox_TextChanged);
            // 
            // LoginUsernameLabel
            // 
            this.LoginUsernameLabel.AutoSize = true;
            this.LoginUsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginUsernameLabel.Location = new System.Drawing.Point(100, 80);
            this.LoginUsernameLabel.Name = "LoginUsernameLabel";
            this.LoginUsernameLabel.Size = new System.Drawing.Size(102, 24);
            this.LoginUsernameLabel.TabIndex = 2;
            this.LoginUsernameLabel.Text = "Username:";
            // 
            // LoginPasswordLabel
            // 
            this.LoginPasswordLabel.AutoSize = true;
            this.LoginPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPasswordLabel.Location = new System.Drawing.Point(100, 130);
            this.LoginPasswordLabel.Name = "LoginPasswordLabel";
            this.LoginPasswordLabel.Size = new System.Drawing.Size(97, 24);
            this.LoginPasswordLabel.TabIndex = 3;
            this.LoginPasswordLabel.Text = "Password:";
            // 
            // LoginEnterButton
            // 
            this.LoginEnterButton.BackColor = System.Drawing.Color.ForestGreen;
            this.LoginEnterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginEnterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginEnterButton.Location = new System.Drawing.Point(355, 180);
            this.LoginEnterButton.Name = "LoginEnterButton";
            this.LoginEnterButton.Size = new System.Drawing.Size(95, 50);
            this.LoginEnterButton.TabIndex = 4;
            this.LoginEnterButton.Text = "Enter";
            this.LoginEnterButton.UseVisualStyleBackColor = false;
            this.LoginEnterButton.Click += new System.EventHandler(this.LoginEnterButton_Click);
            // 
            // LoginNewButton
            // 
            this.LoginNewButton.BackColor = System.Drawing.Color.Silver;
            this.LoginNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginNewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginNewButton.Location = new System.Drawing.Point(250, 180);
            this.LoginNewButton.Name = "LoginNewButton";
            this.LoginNewButton.Size = new System.Drawing.Size(95, 50);
            this.LoginNewButton.TabIndex = 5;
            this.LoginNewButton.Text = "New User?";
            this.LoginNewButton.UseVisualStyleBackColor = false;
            this.LoginNewButton.Click += new System.EventHandler(this.LoginNewButton_Click);
            // 
            // LoginShowCheck
            // 
            this.LoginShowCheck.AutoSize = true;
            this.LoginShowCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginShowCheck.Location = new System.Drawing.Point(470, 135);
            this.LoginShowCheck.Name = "LoginShowCheck";
            this.LoginShowCheck.Size = new System.Drawing.Size(50, 17);
            this.LoginShowCheck.TabIndex = 6;
            this.LoginShowCheck.Text = "Show";
            this.LoginShowCheck.UseVisualStyleBackColor = true;
            this.LoginShowCheck.CheckedChanged += new System.EventHandler(this.LoginShowCheck_CheckedChanged);
            // 
            // LoginErrorText
            // 
            this.LoginErrorText.AutoSize = true;
            this.LoginErrorText.ForeColor = System.Drawing.Color.Red;
            this.LoginErrorText.Location = new System.Drawing.Point(250, 250);
            this.LoginErrorText.Name = "LoginErrorText";
            this.LoginErrorText.Size = new System.Drawing.Size(10, 13);
            this.LoginErrorText.TabIndex = 7;
            this.LoginErrorText.Text = " ";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.LoginErrorText);
            this.Controls.Add(this.LoginShowCheck);
            this.Controls.Add(this.LoginNewButton);
            this.Controls.Add(this.LoginEnterButton);
            this.Controls.Add(this.LoginPasswordLabel);
            this.Controls.Add(this.LoginUsernameLabel);
            this.Controls.Add(this.LoginPasswordBox);
            this.Controls.Add(this.LoginUsernameBox);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginUsernameBox;
        private System.Windows.Forms.TextBox LoginPasswordBox;
        private System.Windows.Forms.Label LoginUsernameLabel;
        private System.Windows.Forms.Label LoginPasswordLabel;
        private System.Windows.Forms.Button LoginEnterButton;
        private System.Windows.Forms.Button LoginNewButton;
        private System.Windows.Forms.CheckBox LoginShowCheck;
        private System.Windows.Forms.Label LoginErrorText;
    }
}

