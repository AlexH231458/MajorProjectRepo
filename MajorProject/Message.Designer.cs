namespace MajorProject
{
    partial class Message
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
            this.MessageText = new System.Windows.Forms.Label();
            this.MessageTime = new System.Windows.Forms.Label();
            this.MessageDelete = new System.Windows.Forms.Button();
            this.MessageUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MessageText
            // 
            this.MessageText.AutoSize = true;
            this.MessageText.Location = new System.Drawing.Point(7, 33);
            this.MessageText.Name = "MessageText";
            this.MessageText.Size = new System.Drawing.Size(28, 13);
            this.MessageText.TabIndex = 0;
            this.MessageText.Text = "Text";
            this.MessageText.Click += new System.EventHandler(this.MessageText_Click);
            // 
            // MessageTime
            // 
            this.MessageTime.AutoSize = true;
            this.MessageTime.Location = new System.Drawing.Point(85, 60);
            this.MessageTime.Name = "MessageTime";
            this.MessageTime.Size = new System.Drawing.Size(30, 13);
            this.MessageTime.TabIndex = 1;
            this.MessageTime.Text = "Time";
            this.MessageTime.Click += new System.EventHandler(this.MessageTime_Click);
            // 
            // MessageDelete
            // 
            this.MessageDelete.BackColor = System.Drawing.Color.DarkRed;
            this.MessageDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MessageDelete.Location = new System.Drawing.Point(10, 56);
            this.MessageDelete.Name = "MessageDelete";
            this.MessageDelete.Size = new System.Drawing.Size(60, 21);
            this.MessageDelete.TabIndex = 2;
            this.MessageDelete.Text = "Delete";
            this.MessageDelete.UseVisualStyleBackColor = false;
            this.MessageDelete.Click += new System.EventHandler(this.MessageDelete_Click);
            // 
            // MessageUser
            // 
            this.MessageUser.AutoSize = true;
            this.MessageUser.Location = new System.Drawing.Point(7, 10);
            this.MessageUser.Name = "MessageUser";
            this.MessageUser.Size = new System.Drawing.Size(28, 13);
            this.MessageUser.TabIndex = 3;
            this.MessageUser.Text = "Text";
            this.MessageUser.Click += new System.EventHandler(this.MessageUser_Click);
            // 
            // Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MessageUser);
            this.Controls.Add(this.MessageDelete);
            this.Controls.Add(this.MessageTime);
            this.Controls.Add(this.MessageText);
            this.Name = "Message";
            this.Size = new System.Drawing.Size(500, 80);
            this.Load += new System.EventHandler(this.Message_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MessageText;
        private System.Windows.Forms.Label MessageTime;
        private System.Windows.Forms.Button MessageDelete;
        private System.Windows.Forms.Label MessageUser;
    }
}
