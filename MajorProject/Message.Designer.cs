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
            this.SuspendLayout();
            // 
            // MessageText
            // 
            this.MessageText.AutoSize = true;
            this.MessageText.Location = new System.Drawing.Point(10, 10);
            this.MessageText.Name = "MessageText";
            this.MessageText.Size = new System.Drawing.Size(28, 13);
            this.MessageText.TabIndex = 0;
            this.MessageText.Text = "Text";
            // 
            // MessageTime
            // 
            this.MessageTime.AutoSize = true;
            this.MessageTime.Location = new System.Drawing.Point(250, 125);
            this.MessageTime.Name = "MessageTime";
            this.MessageTime.Size = new System.Drawing.Size(30, 13);
            this.MessageTime.TabIndex = 1;
            this.MessageTime.Text = "Time";
            // 
            // MessageDelete
            // 
            this.MessageDelete.BackColor = System.Drawing.Color.DarkRed;
            this.MessageDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MessageDelete.Location = new System.Drawing.Point(10, 120);
            this.MessageDelete.Name = "MessageDelete";
            this.MessageDelete.Size = new System.Drawing.Size(60, 25);
            this.MessageDelete.TabIndex = 2;
            this.MessageDelete.Text = "Delete";
            this.MessageDelete.UseVisualStyleBackColor = false;
            // 
            // Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MessageDelete);
            this.Controls.Add(this.MessageTime);
            this.Controls.Add(this.MessageText);
            this.Name = "Message";
            this.Size = new System.Drawing.Size(300, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MessageText;
        private System.Windows.Forms.Label MessageTime;
        private System.Windows.Forms.Button MessageDelete;
    }
}
