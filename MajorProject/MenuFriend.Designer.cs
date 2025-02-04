namespace MajorProject
{
    partial class MenuFriend
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
            this.MFNameLabel = new System.Windows.Forms.Label();
            this.MFChatButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MFNameLabel
            // 
            this.MFNameLabel.AutoSize = true;
            this.MFNameLabel.Location = new System.Drawing.Point(31, 17);
            this.MFNameLabel.Name = "MFNameLabel";
            this.MFNameLabel.Size = new System.Drawing.Size(0, 13);
            this.MFNameLabel.TabIndex = 3;
            // 
            // MFChatButton
            // 
            this.MFChatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MFChatButton.Location = new System.Drawing.Point(392, 8);
            this.MFChatButton.Name = "MFChatButton";
            this.MFChatButton.Size = new System.Drawing.Size(75, 30);
            this.MFChatButton.TabIndex = 4;
            this.MFChatButton.Text = "Chat";
            this.MFChatButton.UseVisualStyleBackColor = true;
            // 
            // MenuFriend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MFChatButton);
            this.Controls.Add(this.MFNameLabel);
            this.Name = "MenuFriend";
            this.Size = new System.Drawing.Size(480, 50);
            this.Load += new System.EventHandler(this.MenuFriend_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MFNameLabel;
        private System.Windows.Forms.Button MFChatButton;
    }
}
