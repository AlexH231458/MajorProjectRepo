namespace MajorProject
{
    partial class Chat
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ChatSendButton = new System.Windows.Forms.Button();
            this.ChatReturnButton = new System.Windows.Forms.Button();
            this.ChatNameLabel = new System.Windows.Forms.Label();
            this.ChatMessageBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(22, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 500);
            this.panel1.TabIndex = 0;
            // 
            // ChatSendButton
            // 
            this.ChatSendButton.BackColor = System.Drawing.Color.Green;
            this.ChatSendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChatSendButton.Location = new System.Drawing.Point(452, 590);
            this.ChatSendButton.Name = "ChatSendButton";
            this.ChatSendButton.Size = new System.Drawing.Size(70, 26);
            this.ChatSendButton.TabIndex = 1;
            this.ChatSendButton.Text = "Send";
            this.ChatSendButton.UseVisualStyleBackColor = false;
            // 
            // ChatReturnButton
            // 
            this.ChatReturnButton.BackColor = System.Drawing.Color.Red;
            this.ChatReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChatReturnButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ChatReturnButton.Location = new System.Drawing.Point(22, 12);
            this.ChatReturnButton.Name = "ChatReturnButton";
            this.ChatReturnButton.Size = new System.Drawing.Size(75, 23);
            this.ChatReturnButton.TabIndex = 2;
            this.ChatReturnButton.Text = "Return";
            this.ChatReturnButton.UseVisualStyleBackColor = false;
            // 
            // ChatNameLabel
            // 
            this.ChatNameLabel.AutoSize = true;
            this.ChatNameLabel.Location = new System.Drawing.Point(212, 24);
            this.ChatNameLabel.Name = "ChatNameLabel";
            this.ChatNameLabel.Size = new System.Drawing.Size(55, 13);
            this.ChatNameLabel.TabIndex = 3;
            this.ChatNameLabel.Text = "TempText";
            // 
            // ChatMessageBox
            // 
            this.ChatMessageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChatMessageBox.Location = new System.Drawing.Point(22, 590);
            this.ChatMessageBox.Name = "ChatMessageBox";
            this.ChatMessageBox.Size = new System.Drawing.Size(400, 26);
            this.ChatMessageBox.TabIndex = 4;
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 661);
            this.Controls.Add(this.ChatMessageBox);
            this.Controls.Add(this.ChatNameLabel);
            this.Controls.Add(this.ChatReturnButton);
            this.Controls.Add(this.ChatSendButton);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(550, 700);
            this.MinimumSize = new System.Drawing.Size(550, 700);
            this.Name = "Chat";
            this.Text = "Chat";
            this.Load += new System.EventHandler(this.Chat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ChatSendButton;
        private System.Windows.Forms.Button ChatReturnButton;
        private System.Windows.Forms.Label ChatNameLabel;
        private System.Windows.Forms.TextBox ChatMessageBox;
    }
}