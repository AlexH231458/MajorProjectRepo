namespace MajorProject
{
    partial class Settings
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
            this.SettingsAutoshiftLabel = new System.Windows.Forms.Label();
            this.SettingsFontLabel = new System.Windows.Forms.Label();
            this.SettingsColourLabel = new System.Windows.Forms.Label();
            this.SettingsAutoshiftBox = new System.Windows.Forms.ComboBox();
            this.SettingsFontBox = new System.Windows.Forms.ComboBox();
            this.SettingsColourButton = new System.Windows.Forms.Button();
            this.SettingsColourDialog = new System.Windows.Forms.ColorDialog();
            this.SettingsReturnButton = new System.Windows.Forms.Button();
            this.SettingsExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SettingsAutoshiftLabel
            // 
            this.SettingsAutoshiftLabel.AutoSize = true;
            this.SettingsAutoshiftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsAutoshiftLabel.Location = new System.Drawing.Point(100, 80);
            this.SettingsAutoshiftLabel.Name = "SettingsAutoshiftLabel";
            this.SettingsAutoshiftLabel.Size = new System.Drawing.Size(86, 24);
            this.SettingsAutoshiftLabel.TabIndex = 3;
            this.SettingsAutoshiftLabel.Text = "Autoshift:";
            // 
            // SettingsFontLabel
            // 
            this.SettingsFontLabel.AutoSize = true;
            this.SettingsFontLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsFontLabel.Location = new System.Drawing.Point(100, 130);
            this.SettingsFontLabel.Name = "SettingsFontLabel";
            this.SettingsFontLabel.Size = new System.Drawing.Size(53, 24);
            this.SettingsFontLabel.TabIndex = 4;
            this.SettingsFontLabel.Text = "Font:";
            // 
            // SettingsColourLabel
            // 
            this.SettingsColourLabel.AutoSize = true;
            this.SettingsColourLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsColourLabel.Location = new System.Drawing.Point(100, 180);
            this.SettingsColourLabel.Name = "SettingsColourLabel";
            this.SettingsColourLabel.Size = new System.Drawing.Size(117, 24);
            this.SettingsColourLabel.TabIndex = 5;
            this.SettingsColourLabel.Text = "Background:";
            // 
            // SettingsAutoshiftBox
            // 
            this.SettingsAutoshiftBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsAutoshiftBox.FormattingEnabled = true;
            this.SettingsAutoshiftBox.Location = new System.Drawing.Point(250, 80);
            this.SettingsAutoshiftBox.Name = "SettingsAutoshiftBox";
            this.SettingsAutoshiftBox.Size = new System.Drawing.Size(200, 28);
            this.SettingsAutoshiftBox.TabIndex = 6;
            // 
            // SettingsFontBox
            // 
            this.SettingsFontBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsFontBox.FormattingEnabled = true;
            this.SettingsFontBox.Location = new System.Drawing.Point(250, 130);
            this.SettingsFontBox.Name = "SettingsFontBox";
            this.SettingsFontBox.Size = new System.Drawing.Size(200, 28);
            this.SettingsFontBox.TabIndex = 7;
            // 
            // SettingsColourButton
            // 
            this.SettingsColourButton.BackColor = System.Drawing.Color.Silver;
            this.SettingsColourButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsColourButton.Location = new System.Drawing.Point(250, 180);
            this.SettingsColourButton.Name = "SettingsColourButton";
            this.SettingsColourButton.Size = new System.Drawing.Size(200, 28);
            this.SettingsColourButton.TabIndex = 8;
            this.SettingsColourButton.Text = "Colours";
            this.SettingsColourButton.UseVisualStyleBackColor = false;
            this.SettingsColourButton.Click += new System.EventHandler(this.SettingsColourButton_Click);
            // 
            // SettingsReturnButton
            // 
            this.SettingsReturnButton.BackColor = System.Drawing.Color.DarkRed;
            this.SettingsReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsReturnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsReturnButton.Location = new System.Drawing.Point(250, 230);
            this.SettingsReturnButton.Name = "SettingsReturnButton";
            this.SettingsReturnButton.Size = new System.Drawing.Size(95, 50);
            this.SettingsReturnButton.TabIndex = 15;
            this.SettingsReturnButton.Text = "Return";
            this.SettingsReturnButton.UseVisualStyleBackColor = false;
            this.SettingsReturnButton.Click += new System.EventHandler(this.SettingsReturnButton_Click);
            // 
            // SettingsExitButton
            // 
            this.SettingsExitButton.BackColor = System.Drawing.Color.Silver;
            this.SettingsExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsExitButton.Location = new System.Drawing.Point(355, 230);
            this.SettingsExitButton.Name = "SettingsExitButton";
            this.SettingsExitButton.Size = new System.Drawing.Size(95, 50);
            this.SettingsExitButton.TabIndex = 16;
            this.SettingsExitButton.Text = "Log Out";
            this.SettingsExitButton.UseVisualStyleBackColor = false;
            this.SettingsExitButton.Click += new System.EventHandler(this.SettingsExitButton_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.SettingsExitButton);
            this.Controls.Add(this.SettingsReturnButton);
            this.Controls.Add(this.SettingsColourButton);
            this.Controls.Add(this.SettingsFontBox);
            this.Controls.Add(this.SettingsAutoshiftBox);
            this.Controls.Add(this.SettingsColourLabel);
            this.Controls.Add(this.SettingsFontLabel);
            this.Controls.Add(this.SettingsAutoshiftLabel);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SettingsAutoshiftLabel;
        private System.Windows.Forms.Label SettingsFontLabel;
        private System.Windows.Forms.Label SettingsColourLabel;
        private System.Windows.Forms.ComboBox SettingsAutoshiftBox;
        private System.Windows.Forms.ComboBox SettingsFontBox;
        private System.Windows.Forms.Button SettingsColourButton;
        private System.Windows.Forms.ColorDialog SettingsColourDialog;
        private System.Windows.Forms.Button SettingsReturnButton;
        private System.Windows.Forms.Button SettingsExitButton;
    }
}