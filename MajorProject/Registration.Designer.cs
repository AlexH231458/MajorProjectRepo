namespace MajorProject
{
    partial class Registration
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
            this.RegUsernameBox = new System.Windows.Forms.TextBox();
            this.RegPasswordBox = new System.Windows.Forms.TextBox();
            this.RegShowCheck = new System.Windows.Forms.CheckBox();
            this.RegUsernameLabel = new System.Windows.Forms.Label();
            this.RegPasswordLabel = new System.Windows.Forms.Label();
            this.RegDateLabel = new System.Windows.Forms.Label();
            this.RegDateBox = new System.Windows.Forms.DateTimePicker();
            this.RegEnterButton = new System.Windows.Forms.Button();
            this.RegReturnButton = new System.Windows.Forms.Button();
            this.RegErrorText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RegUsernameBox
            // 
            this.RegUsernameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegUsernameBox.Location = new System.Drawing.Point(250, 80);
            this.RegUsernameBox.Name = "RegUsernameBox";
            this.RegUsernameBox.Size = new System.Drawing.Size(200, 26);
            this.RegUsernameBox.TabIndex = 1;
            this.RegUsernameBox.TextChanged += new System.EventHandler(this.RegUsernameBox_TextChanged);
            // 
            // RegPasswordBox
            // 
            this.RegPasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegPasswordBox.Location = new System.Drawing.Point(250, 130);
            this.RegPasswordBox.Name = "RegPasswordBox";
            this.RegPasswordBox.Size = new System.Drawing.Size(200, 26);
            this.RegPasswordBox.TabIndex = 2;
            this.RegPasswordBox.UseSystemPasswordChar = true;
            this.RegPasswordBox.TextChanged += new System.EventHandler(this.RegPasswordBox_TextChanged);
            // 
            // RegShowCheck
            // 
            this.RegShowCheck.AutoSize = true;
            this.RegShowCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegShowCheck.Location = new System.Drawing.Point(470, 135);
            this.RegShowCheck.Name = "RegShowCheck";
            this.RegShowCheck.Size = new System.Drawing.Size(50, 17);
            this.RegShowCheck.TabIndex = 7;
            this.RegShowCheck.Text = "Show";
            this.RegShowCheck.UseVisualStyleBackColor = true;
            this.RegShowCheck.CheckedChanged += new System.EventHandler(this.RegShowCheck_CheckedChanged);
            // 
            // RegUsernameLabel
            // 
            this.RegUsernameLabel.AutoSize = true;
            this.RegUsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegUsernameLabel.Location = new System.Drawing.Point(100, 80);
            this.RegUsernameLabel.Name = "RegUsernameLabel";
            this.RegUsernameLabel.Size = new System.Drawing.Size(102, 24);
            this.RegUsernameLabel.TabIndex = 8;
            this.RegUsernameLabel.Text = "Username:";
            // 
            // RegPasswordLabel
            // 
            this.RegPasswordLabel.AutoSize = true;
            this.RegPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegPasswordLabel.Location = new System.Drawing.Point(100, 130);
            this.RegPasswordLabel.Name = "RegPasswordLabel";
            this.RegPasswordLabel.Size = new System.Drawing.Size(97, 24);
            this.RegPasswordLabel.TabIndex = 9;
            this.RegPasswordLabel.Text = "Password:";
            // 
            // RegDateLabel
            // 
            this.RegDateLabel.AutoSize = true;
            this.RegDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegDateLabel.Location = new System.Drawing.Point(100, 180);
            this.RegDateLabel.Name = "RegDateLabel";
            this.RegDateLabel.Size = new System.Drawing.Size(115, 24);
            this.RegDateLabel.TabIndex = 10;
            this.RegDateLabel.Text = "Date of Birth:";
            // 
            // RegDateBox
            // 
            this.RegDateBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.RegDateBox.Location = new System.Drawing.Point(250, 180);
            this.RegDateBox.Name = "RegDateBox";
            this.RegDateBox.Size = new System.Drawing.Size(200, 20);
            this.RegDateBox.TabIndex = 12;
            this.RegDateBox.ValueChanged += new System.EventHandler(this.RegDateBox_ValueChanged);
            // 
            // RegEnterButton
            // 
            this.RegEnterButton.BackColor = System.Drawing.Color.ForestGreen;
            this.RegEnterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegEnterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegEnterButton.Location = new System.Drawing.Point(355, 230);
            this.RegEnterButton.Name = "RegEnterButton";
            this.RegEnterButton.Size = new System.Drawing.Size(95, 50);
            this.RegEnterButton.TabIndex = 13;
            this.RegEnterButton.Text = "Enter";
            this.RegEnterButton.UseVisualStyleBackColor = false;
            this.RegEnterButton.Click += new System.EventHandler(this.RegEnterButton_Click);
            // 
            // RegReturnButton
            // 
            this.RegReturnButton.BackColor = System.Drawing.Color.DarkRed;
            this.RegReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegReturnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegReturnButton.Location = new System.Drawing.Point(250, 230);
            this.RegReturnButton.Name = "RegReturnButton";
            this.RegReturnButton.Size = new System.Drawing.Size(95, 50);
            this.RegReturnButton.TabIndex = 14;
            this.RegReturnButton.Text = "Return";
            this.RegReturnButton.UseVisualStyleBackColor = false;
            this.RegReturnButton.Click += new System.EventHandler(this.RegReturnButton_Click);
            // 
            // RegErrorText
            // 
            this.RegErrorText.AutoSize = true;
            this.RegErrorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegErrorText.ForeColor = System.Drawing.Color.Red;
            this.RegErrorText.Location = new System.Drawing.Point(250, 300);
            this.RegErrorText.Name = "RegErrorText";
            this.RegErrorText.Size = new System.Drawing.Size(15, 24);
            this.RegErrorText.TabIndex = 15;
            this.RegErrorText.Text = " ";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.RegErrorText);
            this.Controls.Add(this.RegReturnButton);
            this.Controls.Add(this.RegEnterButton);
            this.Controls.Add(this.RegDateBox);
            this.Controls.Add(this.RegDateLabel);
            this.Controls.Add(this.RegPasswordLabel);
            this.Controls.Add(this.RegUsernameLabel);
            this.Controls.Add(this.RegShowCheck);
            this.Controls.Add(this.RegPasswordBox);
            this.Controls.Add(this.RegUsernameBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RegUsernameBox;
        private System.Windows.Forms.TextBox RegPasswordBox;
        private System.Windows.Forms.CheckBox RegShowCheck;
        private System.Windows.Forms.Label RegUsernameLabel;
        private System.Windows.Forms.Label RegPasswordLabel;
        private System.Windows.Forms.Label RegDateLabel;
        private System.Windows.Forms.DateTimePicker RegDateBox;
        private System.Windows.Forms.Button RegEnterButton;
        private System.Windows.Forms.Button RegReturnButton;
        private System.Windows.Forms.Label RegErrorText;
    }
}