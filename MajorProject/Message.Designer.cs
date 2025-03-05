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
            this.MessageText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageText.Location = new System.Drawing.Point(5, 25);
            this.MessageText.Name = "MessageText";
            this.MessageText.Size = new System.Drawing.Size(60, 29);
            this.MessageText.TabIndex = 0;
            this.MessageText.Text = "Text";
            this.MessageText.Click += new System.EventHandler(this.MessageText_Click);
            // 
            // MessageTime
            // 
            this.MessageTime.AutoSize = true;
            this.MessageTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageTime.Location = new System.Drawing.Point(390, 10);
            this.MessageTime.Name = "MessageTime";
            this.MessageTime.Size = new System.Drawing.Size(49, 20);
            this.MessageTime.TabIndex = 1;
            this.MessageTime.Text = "00:00";
            this.MessageTime.Click += new System.EventHandler(this.MessageTime_Click);
            // 
            // MessageDelete
            // 
            this.MessageDelete.BackColor = System.Drawing.Color.Firebrick;
            this.MessageDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MessageDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageDelete.Location = new System.Drawing.Point(450, 5);
            this.MessageDelete.Name = "MessageDelete";
            this.MessageDelete.Size = new System.Drawing.Size(25, 30);
            this.MessageDelete.TabIndex = 2;
            this.MessageDelete.Text = "X";
            this.MessageDelete.UseVisualStyleBackColor = false;
            this.MessageDelete.Click += new System.EventHandler(this.MessageDelete_Click);
            // 
            // MessageUser
            // 
            this.MessageUser.AutoSize = true;
            this.MessageUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageUser.Location = new System.Drawing.Point(5, 5);
            this.MessageUser.Name = "MessageUser";
            this.MessageUser.Size = new System.Drawing.Size(39, 20);
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
            this.Size = new System.Drawing.Size(480, 60);
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
