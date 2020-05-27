using MyPhotosCore.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MyPhotosClient
{
    public partial class ModifyPhotoForm : Form
    {
        private readonly PhotoClient _photoClient = new PhotoClient();
        private readonly PersonClient _personClient = new PersonClient();
        private readonly LocationClient _locationClient = new LocationClient();

        public ModifyPhotoForm()
        {
            InitializeComponent();
        }

        private void ModifyPhotoForm_Load(object sender, EventArgs e)
        {
            PhotoIdComboBox.Items.Clear();
            PhotoIdComboBox.Visible = false;
            photosFoundListBox.Visible = false;
            var images = _photoClient.GetPhotos();
            var people = _personClient.GetPeople();
            var locations = _locationClient.GetLocations();
            this.SetTextForComboBoxes();

            foreach (var image in images)
            {
                PhotoIdComboBox.Items.Add(image.PhotoId);

                if (!EventComboBox.Items.Contains(image.Event))
                {
                    EventComboBox.Items.Add(image.Event);
                }
               
                if(!YearComboBox.Items.Contains(image.DateCreated.Year))
                {
                    YearComboBox.Items.Add(image.DateCreated.Year);
                }
            }
            foreach (var person in people)
            {
                string fullName = person.FirstName + " " + person.LastName;
                PersonComboBox.Items.Add(fullName);
            }
            foreach(var location in locations)
            {
                LocationComboBox.Items.Add(location.Name);
            }
        }

        private void PhotoIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int imageId = (int)PhotoIdComboBox.SelectedItem;
            var photoFound = _photoClient.GetPhotoById(imageId);
            pictureBox1.ImageLocation = photoFound.FilePath;

        }
        private void AddPersonToPhotoButton_Click(object sender, EventArgs e)
        {
            Photo imageSelected = GetPhotoSelected();

            if(imageSelected == null)
            {
                MessageBox.Show("Please select a photo first!");
                return;
            }
            
            if (string.IsNullOrEmpty(FirstNameTextBox.Text) || string.IsNullOrEmpty(LastNameTextBox.Text))
            {
                MessageBox.Show("You didn't complete first name or last name field");
                return;
            }
            var personFound = _personClient.SearchByFullName(FirstNameTextBox.Text + " " + LastNameTextBox.Text);

            if (personFound != null)
            {
                _photoClient.AddPersonToPhoto(personFound, imageSelected);
            }
            else
            {
                Person person = new Person
                {
                    FirstName = FirstNameTextBox.Text,
                    LastName = LastNameTextBox.Text
                };
                _photoClient.AddPersonToPhoto(person, imageSelected);
                PersonComboBox.Items.Add(person.FirstName + " " + person.LastName);
            }
            FirstNameTextBox.Clear();
            LastNameTextBox.Clear();
        }
        private void UpdateLocationButton_Click(object sender, EventArgs e)
        {
            Photo imageSelected = GetPhotoSelected();

            if(string.IsNullOrEmpty(LocationText.Text) || imageSelected == null)
            {
                MessageBox.Show("Please select a photo and complete the Location field");
                return;
            }
            Location locationFound = _locationClient.SearchByName((string)LocationText.Text);

            if(!_locationClient.VerifyLocationExists(locationFound))
            {
                Location location = new Location
                {
                    Name = LocationText.Text,
                };

                _locationClient.AddLocation(location);
                _photoClient.UpdateLocationOfPhoto(imageSelected.PhotoId, location);
                LocationComboBox.Items.Add(location.Name);
            }
            else
            {
                _photoClient.UpdateLocationOfPhoto(imageSelected.PhotoId, locationFound);
            }
            LocationText.Clear();
        }

        private void SelectByIdButton_Click(object sender, EventArgs e)
        {
            PhotoIdComboBox.Visible = true;
            PhotoIdComboBox.Text = "-Select Id of Image-";
            EventComboBox.Visible = false;
            YearComboBox.Visible = false;
            PersonComboBox.Visible = false;
            LocationComboBox.Visible = false;
            SearchButton.Visible = false;
            photosFoundListBox.Visible = false;
            pictureBox1.Image = null;  
        }

        private void MultipleCriteriaButton_Click(object sender, EventArgs e)
        {
            PhotoIdComboBox.Visible = false;
            EventComboBox.Visible = true;
            YearComboBox.Visible = true;
            PersonComboBox.Visible = true;
            LocationComboBox.Visible = true;
            SearchButton.Visible = true;
            this.SetDefaultValueForComboBoxes();
            this.SetTextForComboBoxes();
            pictureBox1.Image = null;
            photosFoundListBox.Items.Clear();
        } 

        private void SearchButton_Click(object sender, EventArgs e)
        {
            photosFoundListBox.Items.Clear();
            
            var images = new List<Photo>(_photoClient.GetPhotos());
            
            if (PersonComboBox.SelectedItem != null)
            {
                var personFound = _personClient.SearchByFullName((string)PersonComboBox.SelectedItem);
                var imagesFound = new List<Photo>(_photoClient.GetPhotosOfPerson(personFound));
                images = images.Intersect(imagesFound, new PhotoComparer()).ToList();
            }
            if (EventComboBox.SelectedItem != null)
            {
                var imagesFound = new List<Photo>(_photoClient.SearchPhotosByEvent((string)EventComboBox.SelectedItem));
                images = images.Intersect(imagesFound, new PhotoComparer()).ToList();
            }
            if (YearComboBox.SelectedItem != null)
            {
                var imagesFound = new List<Photo>(_photoClient.SearchPhotosByYear((int)YearComboBox.SelectedItem));
                images = images.Intersect(imagesFound, new PhotoComparer()).ToList();
            }
            if (LocationComboBox.SelectedItem != null)
            {
                var locationFound = _locationClient.SearchByName((string)LocationComboBox.SelectedItem);
                var imagesFound = new List<Photo>(_photoClient.GetPhotosOfLocation(locationFound));
                images = images.Intersect(imagesFound, new PhotoComparer()).ToList();
            }
            photosFoundListBox.Visible = true;
            
            foreach (var image in images)
            {
                photosFoundListBox.Items.Add(image);
            }
            this.SetDefaultValueForComboBoxes();
            this.SetTextForComboBoxes();
        }

        private void PhotosFoundListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var imageSelect = _photoClient.GetPhotoById(((Photo)photosFoundListBox.SelectedItem).PhotoId); 
            pictureBox1.ImageLocation = imageSelect.FilePath;
        }

        private Photo GetPhotoSelected()
        {
            Photo imageSelected;

            if (PhotoIdComboBox.SelectedItem != null)
            {
                imageSelected = _photoClient.GetPhotoById((int)PhotoIdComboBox.SelectedItem);
                return imageSelected;
                    
            }
            else if (photosFoundListBox.SelectedItem != null)
            {
                imageSelected = _photoClient.GetPhotoById(((Photo)photosFoundListBox.SelectedItem).PhotoId);
                return imageSelected;
            }
            return null;
        }
        private void SetTextForComboBoxes()
        {
            PhotoIdComboBox.Text = "-Select Image-";
            EventComboBox.Text = "-Select Event-";
            YearComboBox.Text = "-Select Year-";
            PersonComboBox.Text = "-Select Person-";
            LocationComboBox.Text = "-Select Location-";
        }
        private void SetDefaultValueForComboBoxes()
        {
            PhotoIdComboBox.SelectedItem = null;
            EventComboBox.SelectedItem = null;
            YearComboBox.SelectedItem = null;
            PersonComboBox.SelectedItem = null;
            LocationComboBox.SelectedItem = null;
        }

        private void DeletePhotoButton_Click(object sender, EventArgs e)
        {
            Photo photoSelected = GetPhotoSelected();

            if (photoSelected != null)
            {
                if (MessageBox.Show("Do you really want to delete this photo?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _photoClient.DeletePhoto(photoSelected.PhotoId);
                }
            }
            else
            {
                MessageBox.Show("Please select a photo first!");
            }
            MessageBox.Show("Photo deleted!", "Message");
        }

        private void FirstNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void LastNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void LocationText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space) ;
        }
    }
}
