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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chat));
            this.ChatMessagesPanel = new System.Windows.Forms.Panel();
            this.ChatSendButton = new System.Windows.Forms.Button();
            this.ChatReturnButton = new System.Windows.Forms.Button();
            this.ChatNameLabel = new System.Windows.Forms.Label();
            this.ChatMessageBox = new System.Windows.Forms.TextBox();
            this.ChatSmile = new System.Windows.Forms.Button();
            this.ChatFrown = new System.Windows.Forms.Button();
            this.ChatSilly = new System.Windows.Forms.Button();
            this.ChatHeart = new System.Windows.Forms.Button();
            this.ChatAngry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChatMessagesPanel
            // 
            this.ChatMessagesPanel.AutoScroll = true;
            this.ChatMessagesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChatMessagesPanel.Location = new System.Drawing.Point(20, 50);
            this.ChatMessagesPanel.Name = "ChatMessagesPanel";
            this.ChatMessagesPanel.Size = new System.Drawing.Size(500, 500);
            this.ChatMessagesPanel.TabIndex = 0;
            this.ChatMessagesPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ChatMessagesPanel_Paint);
            // 
            // ChatSendButton
            // 
            this.ChatSendButton.BackColor = System.Drawing.Color.Green;
            this.ChatSendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChatSendButton.Location = new System.Drawing.Point(450, 600);
            this.ChatSendButton.Name = "ChatSendButton";
            this.ChatSendButton.Size = new System.Drawing.Size(70, 26);
            this.ChatSendButton.TabIndex = 1;
            this.ChatSendButton.Text = "Send";
            this.ChatSendButton.UseVisualStyleBackColor = false;
            this.ChatSendButton.Click += new System.EventHandler(this.ChatSendButton_Click);
            // 
            // ChatReturnButton
            // 
            this.ChatReturnButton.BackColor = System.Drawing.Color.Red;
            this.ChatReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChatReturnButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ChatReturnButton.Location = new System.Drawing.Point(20, 15);
            this.ChatReturnButton.Name = "ChatReturnButton";
            this.ChatReturnButton.Size = new System.Drawing.Size(75, 23);
            this.ChatReturnButton.TabIndex = 2;
            this.ChatReturnButton.Text = "Return";
            this.ChatReturnButton.UseVisualStyleBackColor = false;
            this.ChatReturnButton.Click += new System.EventHandler(this.ChatReturnButton_Click);
            // 
            // ChatNameLabel
            // 
            this.ChatNameLabel.AutoSize = true;
            this.ChatNameLabel.Location = new System.Drawing.Point(230, 20);
            this.ChatNameLabel.Name = "ChatNameLabel";
            this.ChatNameLabel.Size = new System.Drawing.Size(55, 13);
            this.ChatNameLabel.TabIndex = 3;
            this.ChatNameLabel.Text = "TempText";
            this.ChatNameLabel.Click += new System.EventHandler(this.ChatNameLabel_Click);
            // 
            // ChatMessageBox
            // 
            this.ChatMessageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChatMessageBox.Location = new System.Drawing.Point(20, 600);
            this.ChatMessageBox.Name = "ChatMessageBox";
            this.ChatMessageBox.Size = new System.Drawing.Size(400, 26);
            this.ChatMessageBox.TabIndex = 4;
            this.ChatMessageBox.TextChanged += new System.EventHandler(this.ChatMessageBox_TextChanged);
            // 
            // ChatSmile
            // 
            this.ChatSmile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChatSmile.Location = new System.Drawing.Point(20, 561);
            this.ChatSmile.Name = "ChatSmile";
            this.ChatSmile.Size = new System.Drawing.Size(75, 33);
            this.ChatSmile.TabIndex = 5;
            this.ChatSmile.Text = "😀";
            this.ChatSmile.UseVisualStyleBackColor = true;
            this.ChatSmile.Click += new System.EventHandler(this.ChatSmile_Click);
            // 
            // ChatFrown
            // 
            this.ChatFrown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChatFrown.Location = new System.Drawing.Point(139, 561);
            this.ChatFrown.Name = "ChatFrown";
            this.ChatFrown.Size = new System.Drawing.Size(75, 33);
            this.ChatFrown.TabIndex = 6;
            this.ChatFrown.Text = "🙁";
            this.ChatFrown.UseVisualStyleBackColor = true;
            this.ChatFrown.Click += new System.EventHandler(this.ChatFrown_Click);
            // 
            // ChatSilly
            // 
            this.ChatSilly.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChatSilly.Location = new System.Drawing.Point(244, 561);
            this.ChatSilly.Name = "ChatSilly";
            this.ChatSilly.Size = new System.Drawing.Size(75, 33);
            this.ChatSilly.TabIndex = 7;
            this.ChatSilly.Text = "😜";
            this.ChatSilly.UseVisualStyleBackColor = true;
            this.ChatSilly.Click += new System.EventHandler(this.ChatSilly_Click);
            // 
            // ChatHeart
            // 
            this.ChatHeart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChatHeart.Location = new System.Drawing.Point(345, 561);
            this.ChatHeart.Name = "ChatHeart";
            this.ChatHeart.Size = new System.Drawing.Size(75, 33);
            this.ChatHeart.TabIndex = 8;
            this.ChatHeart.Text = "😍";
            this.ChatHeart.UseVisualStyleBackColor = true;
            this.ChatHeart.Click += new System.EventHandler(this.ChatHeart_Click);
            // 
            // ChatAngry
            // 
            this.ChatAngry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChatAngry.Location = new System.Drawing.Point(445, 561);
            this.ChatAngry.Name = "ChatAngry";
            this.ChatAngry.Size = new System.Drawing.Size(75, 33);
            this.ChatAngry.TabIndex = 9;
            this.ChatAngry.Text = "😠";
            this.ChatAngry.UseVisualStyleBackColor = true;
            this.ChatAngry.Click += new System.EventHandler(this.ChatAngry_Click);
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 661);
            this.Controls.Add(this.ChatAngry);
            this.Controls.Add(this.ChatHeart);
            this.Controls.Add(this.ChatSilly);
            this.Controls.Add(this.ChatFrown);
            this.Controls.Add(this.ChatSmile);
            this.Controls.Add(this.ChatMessageBox);
            this.Controls.Add(this.ChatNameLabel);
            this.Controls.Add(this.ChatReturnButton);
            this.Controls.Add(this.ChatSendButton);
            this.Controls.Add(this.ChatMessagesPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(550, 700);
            this.MinimumSize = new System.Drawing.Size(550, 700);
            this.Name = "Chat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat";
            this.Load += new System.EventHandler(this.Chat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ChatMessagesPanel;
        private System.Windows.Forms.Button ChatSendButton;
        private System.Windows.Forms.Button ChatReturnButton;
        private System.Windows.Forms.Label ChatNameLabel;
        private System.Windows.Forms.TextBox ChatMessageBox;
        private System.Windows.Forms.Button ChatSmile;
        private System.Windows.Forms.Button ChatFrown;
        private System.Windows.Forms.Button ChatSilly;
        private System.Windows.Forms.Button ChatHeart;
        private System.Windows.Forms.Button ChatAngry;
    }
}