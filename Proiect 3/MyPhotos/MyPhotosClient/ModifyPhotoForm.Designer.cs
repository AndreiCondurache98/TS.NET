namespace MyPhotosClient
{
    partial class ModifyPhotoForm
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
            this.PhotoIdComboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.AddPersonToPhotoButton = new System.Windows.Forms.Button();
            this.SelectByIdButton = new System.Windows.Forms.Button();
            this.MultipleCriteriaButton = new System.Windows.Forms.Button();
            this.PersonComboBox = new System.Windows.Forms.ComboBox();
            this.EventComboBox = new System.Windows.Forms.ComboBox();
            this.YearComboBox = new System.Windows.Forms.ComboBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.photosFoundListBox = new System.Windows.Forms.ListBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LocationComboBox = new System.Windows.Forms.ComboBox();
            this.LocationText = new System.Windows.Forms.TextBox();
            this.UpdateLocationButton = new System.Windows.Forms.Button();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.DeletePhotoButton = new System.Windows.Forms.Button();
            this.PhotoSelectedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PhotoIdComboBox
            // 
            this.PhotoIdComboBox.FormattingEnabled = true;
            this.PhotoIdComboBox.Location = new System.Drawing.Point(42, 68);
            this.PhotoIdComboBox.Name = "PhotoIdComboBox";
            this.PhotoIdComboBox.Size = new System.Drawing.Size(170, 24);
            this.PhotoIdComboBox.TabIndex = 0;
            this.PhotoIdComboBox.SelectedIndexChanged += new System.EventHandler(this.PhotoIdComboBox_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(404, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(809, 19);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(166, 22);
            this.FirstNameTextBox.TabIndex = 2;
            this.FirstNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FirstNameTextBox_KeyPress);
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(809, 56);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(166, 22);
            this.LastNameTextBox.TabIndex = 3;
            this.LastNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LastNameTextBox_KeyPress);
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(727, 56);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(76, 17);
            this.LastNameLabel.TabIndex = 5;
            this.LastNameLabel.Text = "Last Name";
            // 
            // AddPersonToPhotoButton
            // 
            this.AddPersonToPhotoButton.Location = new System.Drawing.Point(995, 30);
            this.AddPersonToPhotoButton.Name = "AddPersonToPhotoButton";
            this.AddPersonToPhotoButton.Size = new System.Drawing.Size(96, 43);
            this.AddPersonToPhotoButton.TabIndex = 6;
            this.AddPersonToPhotoButton.Text = "Add Person to Photo";
            this.AddPersonToPhotoButton.UseVisualStyleBackColor = true;
            this.AddPersonToPhotoButton.Click += new System.EventHandler(this.AddPersonToPhotoButton_Click);
            // 
            // SelectByIdButton
            // 
            this.SelectByIdButton.Location = new System.Drawing.Point(42, 16);
            this.SelectByIdButton.Name = "SelectByIdButton";
            this.SelectByIdButton.Size = new System.Drawing.Size(122, 42);
            this.SelectByIdButton.TabIndex = 7;
            this.SelectByIdButton.Text = "Select One Photo By Id";
            this.SelectByIdButton.UseVisualStyleBackColor = true;
            this.SelectByIdButton.Click += new System.EventHandler(this.SelectByIdButton_Click);
            // 
            // MultipleCriteriaButton
            // 
            this.MultipleCriteriaButton.Location = new System.Drawing.Point(42, 138);
            this.MultipleCriteriaButton.Name = "MultipleCriteriaButton";
            this.MultipleCriteriaButton.Size = new System.Drawing.Size(122, 45);
            this.MultipleCriteriaButton.TabIndex = 8;
            this.MultipleCriteriaButton.Text = "Search By Multiple Criteria";
            this.MultipleCriteriaButton.UseVisualStyleBackColor = true;
            this.MultipleCriteriaButton.Click += new System.EventHandler(this.MultipleCriteriaButton_Click);
            // 
            // PersonComboBox
            // 
            this.PersonComboBox.FormattingEnabled = true;
            this.PersonComboBox.Location = new System.Drawing.Point(42, 201);
            this.PersonComboBox.Name = "PersonComboBox";
            this.PersonComboBox.Size = new System.Drawing.Size(170, 24);
            this.PersonComboBox.TabIndex = 9;
            // 
            // EventComboBox
            // 
            this.EventComboBox.FormattingEnabled = true;
            this.EventComboBox.Location = new System.Drawing.Point(42, 247);
            this.EventComboBox.Name = "EventComboBox";
            this.EventComboBox.Size = new System.Drawing.Size(170, 24);
            this.EventComboBox.TabIndex = 10;
            // 
            // YearComboBox
            // 
            this.YearComboBox.FormattingEnabled = true;
            this.YearComboBox.Location = new System.Drawing.Point(42, 297);
            this.YearComboBox.Name = "YearComboBox";
            this.YearComboBox.Size = new System.Drawing.Size(170, 24);
            this.YearComboBox.TabIndex = 11;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(237, 339);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(103, 41);
            this.SearchButton.TabIndex = 12;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // photosFoundListBox
            // 
            this.photosFoundListBox.FormattingEnabled = true;
            this.photosFoundListBox.ItemHeight = 16;
            this.photosFoundListBox.Location = new System.Drawing.Point(42, 407);
            this.photosFoundListBox.Name = "photosFoundListBox";
            this.photosFoundListBox.Size = new System.Drawing.Size(429, 132);
            this.photosFoundListBox.TabIndex = 13;
            this.photosFoundListBox.SelectedIndexChanged += new System.EventHandler(this.PhotosFoundListBox_SelectedIndexChanged);
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(727, 22);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(76, 17);
            this.FirstNameLabel.TabIndex = 14;
            this.FirstNameLabel.Text = "First Name";
            // 
            // LocationComboBox
            // 
            this.LocationComboBox.FormattingEnabled = true;
            this.LocationComboBox.Location = new System.Drawing.Point(42, 348);
            this.LocationComboBox.Name = "LocationComboBox";
            this.LocationComboBox.Size = new System.Drawing.Size(170, 24);
            this.LocationComboBox.TabIndex = 15;
            // 
            // LocationText
            // 
            this.LocationText.Location = new System.Drawing.Point(809, 175);
            this.LocationText.Name = "LocationText";
            this.LocationText.Size = new System.Drawing.Size(166, 22);
            this.LocationText.TabIndex = 16;
            this.LocationText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LocationText_KeyPress);
            // 
            // UpdateLocationButton
            // 
            this.UpdateLocationButton.Location = new System.Drawing.Point(995, 164);
            this.UpdateLocationButton.Name = "UpdateLocationButton";
            this.UpdateLocationButton.Size = new System.Drawing.Size(96, 45);
            this.UpdateLocationButton.TabIndex = 17;
            this.UpdateLocationButton.Text = "Update Location";
            this.UpdateLocationButton.UseVisualStyleBackColor = true;
            this.UpdateLocationButton.Click += new System.EventHandler(this.UpdateLocationButton_Click);
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Location = new System.Drawing.Point(736, 175);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(62, 17);
            this.LocationLabel.TabIndex = 18;
            this.LocationLabel.Text = "Location";
            // 
            // DeletePhotoButton
            // 
            this.DeletePhotoButton.Location = new System.Drawing.Point(995, 367);
            this.DeletePhotoButton.Name = "DeletePhotoButton";
            this.DeletePhotoButton.Size = new System.Drawing.Size(96, 48);
            this.DeletePhotoButton.TabIndex = 19;
            this.DeletePhotoButton.Text = "Delete Photo";
            this.DeletePhotoButton.UseVisualStyleBackColor = true;
            this.DeletePhotoButton.Click += new System.EventHandler(this.DeletePhotoButton_Click);
            // 
            // PhotoSelectedLabel
            // 
            this.PhotoSelectedLabel.AutoSize = true;
            this.PhotoSelectedLabel.Location = new System.Drawing.Point(401, 98);
            this.PhotoSelectedLabel.Name = "PhotoSelectedLabel";
            this.PhotoSelectedLabel.Size = new System.Drawing.Size(104, 17);
            this.PhotoSelectedLabel.TabIndex = 20;
            this.PhotoSelectedLabel.Text = "Photo Selected";
            // 
            // ModifyPhotoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 569);
            this.Controls.Add(this.PhotoSelectedLabel);
            this.Controls.Add(this.DeletePhotoButton);
            this.Controls.Add(this.LocationLabel);
            this.Controls.Add(this.UpdateLocationButton);
            this.Controls.Add(this.LocationText);
            this.Controls.Add(this.LocationComboBox);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.photosFoundListBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.YearComboBox);
            this.Controls.Add(this.EventComboBox);
            this.Controls.Add(this.PersonComboBox);
            this.Controls.Add(this.MultipleCriteriaButton);
            this.Controls.Add(this.SelectByIdButton);
            this.Controls.Add(this.AddPersonToPhotoButton);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PhotoIdComboBox);
            this.Name = "ModifyPhotoForm";
            this.Text = "ModifyPhotoForm";
            this.Load += new System.EventHandler(this.ModifyPhotoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PhotoIdComboBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Button AddPersonToPhotoButton;
        private System.Windows.Forms.Button SelectByIdButton;
        private System.Windows.Forms.Button MultipleCriteriaButton;
        private System.Windows.Forms.ComboBox PersonComboBox;
        private System.Windows.Forms.ComboBox EventComboBox;
        private System.Windows.Forms.ComboBox YearComboBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ListBox photosFoundListBox;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.ComboBox LocationComboBox;
        private System.Windows.Forms.TextBox LocationText;
        private System.Windows.Forms.Button UpdateLocationButton;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.Button DeletePhotoButton;
        private System.Windows.Forms.Label PhotoSelectedLabel;
    }
}