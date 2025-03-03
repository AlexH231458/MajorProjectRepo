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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.SettingsAutoshiftLabel = new System.Windows.Forms.Label();
            this.SettingsFontLabel = new System.Windows.Forms.Label();
            this.SettingsColourLabel = new System.Windows.Forms.Label();
            this.SettingsAutoshiftBox = new System.Windows.Forms.ComboBox();
            this.SettingsColourButton = new System.Windows.Forms.Button();
            this.SettingsColourDialog = new System.Windows.Forms.ColorDialog();
            this.SettingsReturnButton = new System.Windows.Forms.Button();
            this.SettingsExitButton = new System.Windows.Forms.Button();
            this.SettingsFontDialog = new System.Windows.Forms.FontDialog();
            this.SettingsFontButton = new System.Windows.Forms.Button();
            this.SettingsOldLabel = new System.Windows.Forms.Label();
            this.SettingsPassButton = new System.Windows.Forms.Button();
            this.SettingsOldBox = new System.Windows.Forms.TextBox();
            this.SettingsNewBox = new System.Windows.Forms.TextBox();
            this.SettingsNewLabel = new System.Windows.Forms.Label();
            this.SettingsPasswordLabel = new System.Windows.Forms.Label();
            this.SettingsShowCheck = new System.Windows.Forms.CheckBox();
            this.SettingsErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SettingsAutoshiftLabel
            // 
            this.SettingsAutoshiftLabel.AutoSize = true;
            this.SettingsAutoshiftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsAutoshiftLabel.Location = new System.Drawing.Point(100, 25);
            this.SettingsAutoshiftLabel.Name = "SettingsAutoshiftLabel";
            this.SettingsAutoshiftLabel.Size = new System.Drawing.Size(86, 24);
            this.SettingsAutoshiftLabel.TabIndex = 3;
            this.SettingsAutoshiftLabel.Text = "Autoshift:";
            // 
            // SettingsFontLabel
            // 
            this.SettingsFontLabel.AutoSize = true;
            this.SettingsFontLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsFontLabel.Location = new System.Drawing.Point(100, 75);
            this.SettingsFontLabel.Name = "SettingsFontLabel";
            this.SettingsFontLabel.Size = new System.Drawing.Size(53, 24);
            this.SettingsFontLabel.TabIndex = 4;
            this.SettingsFontLabel.Text = "Font:";
            // 
            // SettingsColourLabel
            // 
            this.SettingsColourLabel.AutoSize = true;
            this.SettingsColourLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsColourLabel.Location = new System.Drawing.Point(100, 125);
            this.SettingsColourLabel.Name = "SettingsColourLabel";
            this.SettingsColourLabel.Size = new System.Drawing.Size(117, 24);
            this.SettingsColourLabel.TabIndex = 5;
            this.SettingsColourLabel.Text = "Background:";
            // 
            // SettingsAutoshiftBox
            // 
            this.SettingsAutoshiftBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsAutoshiftBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsAutoshiftBox.FormattingEnabled = true;
            this.SettingsAutoshiftBox.Items.AddRange(new object[] {
            "On",
            "Off"});
            this.SettingsAutoshiftBox.Location = new System.Drawing.Point(250, 25);
            this.SettingsAutoshiftBox.Name = "SettingsAutoshiftBox";
            this.SettingsAutoshiftBox.Size = new System.Drawing.Size(200, 28);
            this.SettingsAutoshiftBox.TabIndex = 6;
            this.SettingsAutoshiftBox.Text = "On";
            this.SettingsAutoshiftBox.SelectedIndexChanged += new System.EventHandler(this.SettingsAutoshiftBox_SelectedIndexChanged);
            // 
            // SettingsColourButton
            // 
            this.SettingsColourButton.BackColor = System.Drawing.Color.Silver;
            this.SettingsColourButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsColourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsColourButton.Location = new System.Drawing.Point(250, 125);
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
            this.SettingsReturnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsReturnButton.Location = new System.Drawing.Point(250, 265);
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
            this.SettingsExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsExitButton.Location = new System.Drawing.Point(355, 265);
            this.SettingsExitButton.Name = "SettingsExitButton";
            this.SettingsExitButton.Size = new System.Drawing.Size(95, 50);
            this.SettingsExitButton.TabIndex = 16;
            this.SettingsExitButton.Text = "Log Out";
            this.SettingsExitButton.UseVisualStyleBackColor = false;
            this.SettingsExitButton.Click += new System.EventHandler(this.SettingsExitButton_Click);
            // 
            // SettingsFontDialog
            // 
            this.SettingsFontDialog.AllowScriptChange = false;
            this.SettingsFontDialog.AllowSimulations = false;
            this.SettingsFontDialog.FixedPitchOnly = true;
            this.SettingsFontDialog.FontMustExist = true;
            this.SettingsFontDialog.ShowEffects = false;
            // 
            // SettingsFontButton
            // 
            this.SettingsFontButton.BackColor = System.Drawing.Color.Silver;
            this.SettingsFontButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsFontButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsFontButton.Location = new System.Drawing.Point(250, 75);
            this.SettingsFontButton.Name = "SettingsFontButton";
            this.SettingsFontButton.Size = new System.Drawing.Size(200, 28);
            this.SettingsFontButton.TabIndex = 17;
            this.SettingsFontButton.Text = "Fonts";
            this.SettingsFontButton.UseVisualStyleBackColor = false;
            this.SettingsFontButton.Click += new System.EventHandler(this.SettingsFontButton_Click);
            // 
            // SettingsOldLabel
            // 
            this.SettingsOldLabel.AutoSize = true;
            this.SettingsOldLabel.Location = new System.Drawing.Point(250, 155);
            this.SettingsOldLabel.Name = "SettingsOldLabel";
            this.SettingsOldLabel.Size = new System.Drawing.Size(26, 13);
            this.SettingsOldLabel.TabIndex = 18;
            this.SettingsOldLabel.Text = "Old:";
            // 
            // SettingsPassButton
            // 
            this.SettingsPassButton.BackColor = System.Drawing.Color.ForestGreen;
            this.SettingsPassButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsPassButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsPassButton.Location = new System.Drawing.Point(465, 215);
            this.SettingsPassButton.Name = "SettingsPassButton";
            this.SettingsPassButton.Size = new System.Drawing.Size(90, 35);
            this.SettingsPassButton.TabIndex = 19;
            this.SettingsPassButton.Text = "Change";
            this.SettingsPassButton.UseVisualStyleBackColor = false;
            this.SettingsPassButton.Click += new System.EventHandler(this.SettingsPassButton_Click);
            // 
            // SettingsOldBox
            // 
            this.SettingsOldBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsOldBox.Location = new System.Drawing.Point(250, 170);
            this.SettingsOldBox.MaxLength = 19;
            this.SettingsOldBox.Name = "SettingsOldBox";
            this.SettingsOldBox.Size = new System.Drawing.Size(200, 26);
            this.SettingsOldBox.TabIndex = 20;
            this.SettingsOldBox.UseSystemPasswordChar = true;
            // 
            // SettingsNewBox
            // 
            this.SettingsNewBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsNewBox.Location = new System.Drawing.Point(250, 220);
            this.SettingsNewBox.MaxLength = 19;
            this.SettingsNewBox.Name = "SettingsNewBox";
            this.SettingsNewBox.Size = new System.Drawing.Size(200, 26);
            this.SettingsNewBox.TabIndex = 21;
            this.SettingsNewBox.UseSystemPasswordChar = true;
            // 
            // SettingsNewLabel
            // 
            this.SettingsNewLabel.AutoSize = true;
            this.SettingsNewLabel.Location = new System.Drawing.Point(250, 205);
            this.SettingsNewLabel.Name = "SettingsNewLabel";
            this.SettingsNewLabel.Size = new System.Drawing.Size(32, 13);
            this.SettingsNewLabel.TabIndex = 22;
            this.SettingsNewLabel.Text = "New:";
            // 
            // SettingsPasswordLabel
            // 
            this.SettingsPasswordLabel.AutoSize = true;
            this.SettingsPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsPasswordLabel.Location = new System.Drawing.Point(100, 185);
            this.SettingsPasswordLabel.Name = "SettingsPasswordLabel";
            this.SettingsPasswordLabel.Size = new System.Drawing.Size(96, 48);
            this.SettingsPasswordLabel.TabIndex = 23;
            this.SettingsPasswordLabel.Text = "Change\r\npassword:\r\n";
            // 
            // SettingsShowCheck
            // 
            this.SettingsShowCheck.AutoSize = true;
            this.SettingsShowCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsShowCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsShowCheck.Location = new System.Drawing.Point(465, 175);
            this.SettingsShowCheck.Name = "SettingsShowCheck";
            this.SettingsShowCheck.Size = new System.Drawing.Size(56, 20);
            this.SettingsShowCheck.TabIndex = 24;
            this.SettingsShowCheck.Text = "Show";
            this.SettingsShowCheck.UseVisualStyleBackColor = true;
            this.SettingsShowCheck.CheckedChanged += new System.EventHandler(this.SettingsShowCheck_CheckedChanged);
            // 
            // SettingsErrorLabel
            // 
            this.SettingsErrorLabel.AutoSize = true;
            this.SettingsErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsErrorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.SettingsErrorLabel.Location = new System.Drawing.Point(100, 325);
            this.SettingsErrorLabel.Name = "SettingsErrorLabel";
            this.SettingsErrorLabel.Size = new System.Drawing.Size(0, 24);
            this.SettingsErrorLabel.TabIndex = 25;
            this.SettingsErrorLabel.Click += new System.EventHandler(this.SettingsErrorLabel_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.SettingsErrorLabel);
            this.Controls.Add(this.SettingsShowCheck);
            this.Controls.Add(this.SettingsPasswordLabel);
            this.Controls.Add(this.SettingsNewLabel);
            this.Controls.Add(this.SettingsNewBox);
            this.Controls.Add(this.SettingsOldBox);
            this.Controls.Add(this.SettingsPassButton);
            this.Controls.Add(this.SettingsOldLabel);
            this.Controls.Add(this.SettingsFontButton);
            this.Controls.Add(this.SettingsExitButton);
            this.Controls.Add(this.SettingsReturnButton);
            this.Controls.Add(this.SettingsColourButton);
            this.Controls.Add(this.SettingsAutoshiftBox);
            this.Controls.Add(this.SettingsColourLabel);
            this.Controls.Add(this.SettingsFontLabel);
            this.Controls.Add(this.SettingsAutoshiftLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
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
        private System.Windows.Forms.Button SettingsColourButton;
        private System.Windows.Forms.ColorDialog SettingsColourDialog;
        private System.Windows.Forms.Button SettingsReturnButton;
        private System.Windows.Forms.Button SettingsExitButton;
        private System.Windows.Forms.FontDialog SettingsFontDialog;
        private System.Windows.Forms.Button SettingsFontButton;
        private System.Windows.Forms.Label SettingsOldLabel;
        private System.Windows.Forms.Button SettingsPassButton;
        private System.Windows.Forms.TextBox SettingsOldBox;
        private System.Windows.Forms.TextBox SettingsNewBox;
        private System.Windows.Forms.Label SettingsNewLabel;
        private System.Windows.Forms.Label SettingsPasswordLabel;
        private System.Windows.Forms.CheckBox SettingsShowCheck;
        private System.Windows.Forms.Label SettingsErrorLabel;
    }
}