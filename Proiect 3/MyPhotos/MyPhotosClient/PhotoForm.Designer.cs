namespace MyPhotosClient
{
    partial class PhotoForm
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
            this.EventTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateCreatedPicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.AddPhotoButton = new System.Windows.Forms.Button();
            this.SearchPhotoButton = new System.Windows.Forms.Button();
            this.pathText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LocationTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // EventTextBox
            // 
            this.EventTextBox.Location = new System.Drawing.Point(249, 118);
            this.EventTextBox.Name = "EventTextBox";
            this.EventTextBox.Size = new System.Drawing.Size(199, 22);
            this.EventTextBox.TabIndex = 0;
            this.EventTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EventTextBox_KeyPress);
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(249, 319);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(200, 59);
            this.DescriptionTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date Created";
            // 
            // dateCreatedPicker
            // 
            this.dateCreatedPicker.Location = new System.Drawing.Point(249, 176);
            this.dateCreatedPicker.Name = "dateCreatedPicker";
            this.dateCreatedPicker.Size = new System.Drawing.Size(200, 22);
            this.dateCreatedPicker.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description";
            // 
            // AddPhotoButton
            // 
            this.AddPhotoButton.Location = new System.Drawing.Point(530, 385);
            this.AddPhotoButton.Name = "AddPhotoButton";
            this.AddPhotoButton.Size = new System.Drawing.Size(97, 48);
            this.AddPhotoButton.TabIndex = 6;
            this.AddPhotoButton.Text = "Add";
            this.AddPhotoButton.UseVisualStyleBackColor = true;
            this.AddPhotoButton.Click += new System.EventHandler(this.AddPhotoButton_Click);
            // 
            // SearchPhotoButton
            // 
            this.SearchPhotoButton.Location = new System.Drawing.Point(76, 34);
            this.SearchPhotoButton.Name = "SearchPhotoButton";
            this.SearchPhotoButton.Size = new System.Drawing.Size(127, 41);
            this.SearchPhotoButton.TabIndex = 7;
            this.SearchPhotoButton.Text = "Search Image";
            this.SearchPhotoButton.UseVisualStyleBackColor = true;
            this.SearchPhotoButton.Click += new System.EventHandler(this.SearchPhotoButton_Click);
            // 
            // pathText
            // 
            this.pathText.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pathText.Location = new System.Drawing.Point(250, 53);
            this.pathText.Name = "pathText";
            this.pathText.ReadOnly = true;
            this.pathText.Size = new System.Drawing.Size(377, 22);
            this.pathText.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "FilePath";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(21, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // LocationTextBox
            // 
            this.LocationTextBox.Location = new System.Drawing.Point(249, 255);
            this.LocationTextBox.Name = "LocationTextBox";
            this.LocationTextBox.Size = new System.Drawing.Size(199, 22);
            this.LocationTextBox.TabIndex = 11;
            this.LocationTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LocationTextBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Location";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Event";
            // 
            // PhotoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 462);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LocationTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pathText);
            this.Controls.Add(this.SearchPhotoButton);
            this.Controls.Add(this.AddPhotoButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateCreatedPicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.EventTextBox);
            this.Name = "PhotoForm";
            this.Text = "PhotoForm";
            this.Load += new System.EventHandler(this.PhotoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EventTextBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateCreatedPicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddPhotoButton;
        private System.Windows.Forms.Button SearchPhotoButton;
        private System.Windows.Forms.TextBox pathText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox LocationTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}