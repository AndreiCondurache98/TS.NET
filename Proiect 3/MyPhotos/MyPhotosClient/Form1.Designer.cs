namespace MyPhotosClient
{
    partial class Form1
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
            this.AddPhotoButton = new System.Windows.Forms.Button();
            this.ShowAllMyPhotosButton = new System.Windows.Forms.Button();
            this.SearchAndModifyPhotoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddPhotoButton
            // 
            this.AddPhotoButton.Location = new System.Drawing.Point(264, 35);
            this.AddPhotoButton.Name = "AddPhotoButton";
            this.AddPhotoButton.Size = new System.Drawing.Size(116, 62);
            this.AddPhotoButton.TabIndex = 0;
            this.AddPhotoButton.Text = "Add Photo";
            this.AddPhotoButton.UseVisualStyleBackColor = true;
            this.AddPhotoButton.Click += new System.EventHandler(this.AddPhotoButton_Click);
            // 
            // ShowAllMyPhotosButton
            // 
            this.ShowAllMyPhotosButton.Location = new System.Drawing.Point(264, 129);
            this.ShowAllMyPhotosButton.Name = "ShowAllMyPhotosButton";
            this.ShowAllMyPhotosButton.Size = new System.Drawing.Size(116, 60);
            this.ShowAllMyPhotosButton.TabIndex = 1;
            this.ShowAllMyPhotosButton.Text = "Show All My Photos";
            this.ShowAllMyPhotosButton.UseVisualStyleBackColor = true;
            this.ShowAllMyPhotosButton.Click += new System.EventHandler(this.ShowAllMyPhotosButton_Click);
            // 
            // SearchAndModifyPhotoButton
            // 
            this.SearchAndModifyPhotoButton.Location = new System.Drawing.Point(264, 214);
            this.SearchAndModifyPhotoButton.Name = "SearchAndModifyPhotoButton";
            this.SearchAndModifyPhotoButton.Size = new System.Drawing.Size(116, 62);
            this.SearchAndModifyPhotoButton.TabIndex = 2;
            this.SearchAndModifyPhotoButton.Text = "Search and Modify Photo";
            this.SearchAndModifyPhotoButton.UseVisualStyleBackColor = true;
            this.SearchAndModifyPhotoButton.Click += new System.EventHandler(this.SearchAndModifyPhotoButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 340);
            this.Controls.Add(this.SearchAndModifyPhotoButton);
            this.Controls.Add(this.ShowAllMyPhotosButton);
            this.Controls.Add(this.AddPhotoButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddPhotoButton;
        private System.Windows.Forms.Button ShowAllMyPhotosButton;
        private System.Windows.Forms.Button SearchAndModifyPhotoButton;
    }
}

