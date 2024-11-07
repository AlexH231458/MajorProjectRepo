namespace MajorProject
{
    partial class Requests
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
            this.RequestNameText = new System.Windows.Forms.Label();
            this.RequestAcceptButton = new System.Windows.Forms.Button();
            this.RequestRemoveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RequestNameText
            // 
            this.RequestNameText.AutoSize = true;
            this.RequestNameText.Location = new System.Drawing.Point(19, 22);
            this.RequestNameText.Name = "RequestNameText";
            this.RequestNameText.Size = new System.Drawing.Size(0, 13);
            this.RequestNameText.TabIndex = 0;
            // 
            // RequestAcceptButton
            // 
            this.RequestAcceptButton.Location = new System.Drawing.Point(121, 17);
            this.RequestAcceptButton.Name = "RequestAcceptButton";
            this.RequestAcceptButton.Size = new System.Drawing.Size(55, 23);
            this.RequestAcceptButton.TabIndex = 1;
            this.RequestAcceptButton.Text = "Accept";
            this.RequestAcceptButton.UseVisualStyleBackColor = true;
            // 
            // RequestRemoveButton
            // 
            this.RequestRemoveButton.Location = new System.Drawing.Point(182, 17);
            this.RequestRemoveButton.Name = "RequestRemoveButton";
            this.RequestRemoveButton.Size = new System.Drawing.Size(65, 23);
            this.RequestRemoveButton.TabIndex = 2;
            this.RequestRemoveButton.Text = "Remove";
            this.RequestRemoveButton.UseVisualStyleBackColor = true;
            // 
            // Requests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RequestRemoveButton);
            this.Controls.Add(this.RequestAcceptButton);
            this.Controls.Add(this.RequestNameText);
            this.Name = "Requests";
            this.Size = new System.Drawing.Size(250, 50);
            this.Load += new System.EventHandler(this.Requests_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RequestNameText;
        private System.Windows.Forms.Button RequestAcceptButton;
        private System.Windows.Forms.Button RequestRemoveButton;
    }
}
