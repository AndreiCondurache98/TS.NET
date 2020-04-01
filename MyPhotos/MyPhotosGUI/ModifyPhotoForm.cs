using MyPhotosCore.Context;
using MyPhotosCore.Repository.LocationRepository;
using MyPhotosCore.Repository.PersonRepository;
using MyPhotosCore.Repository.PhotoRepository;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MyPhotosGUI
{
    public partial class ModifyPhotoForm : Form
    {
        static AppModelContainer context = new AppModelContainer();
        private IPhotoRepository _photoRepository = new PhotoRepository(context);
        private IPersonRepository _personRepository = new PersonRepository(context);
        private ILocationRepository _locationRepository = new LocationRepository(context);

        public ModifyPhotoForm()
        {
            InitializeComponent();
        }

        private void ModifyPhotoForm_Load(object sender, EventArgs e)
        {
            PhotoIdComboBox.Items.Clear();
            PhotoIdComboBox.Visible = false;
            photosFoundListBox.Visible = false;
            var images = _photoRepository.GetPhotos();
            var people = _personRepository.GetPeople();
            var locations = _locationRepository.GetLocations();
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
            var photoFound = _photoRepository.GetPhotoById(imageId);
            pictureBox1.ImageLocation = photoFound.FilePath;

        }
        private void AddPersonToPhotoButton_Click(object sender, EventArgs e)
        {
            Photo imageSelected = GetPhotoSelected();
            
            if (string.IsNullOrEmpty(FirstNameTextBox.Text) || string.IsNullOrEmpty(LastNameTextBox.Text) ||
                imageSelected == null)
            {
                MessageBox.Show("You didn't complete first name or last name field or you didn't select a photo");
                return;
            }
            Person personFound = _personRepository.SearchByFullName(FirstNameTextBox.Text + " " + LastNameTextBox.Text);

            if (personFound != null)
            {
                _photoRepository.AddPersonToPhoto(personFound, imageSelected);
            }
            else
            {
                Person person = new Person
                {
                    FirstName = FirstNameTextBox.Text,
                    LastName = LastNameTextBox.Text
                };
                _personRepository.AddPerson(person);
                _photoRepository.AddPersonToPhoto(person, imageSelected);
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
            Location locationFound = _locationRepository.SearchByName((string)LocationText.Text);

            if(!_locationRepository.VerifyLocationExists(locationFound))
            {
                Location location = new Location
                {
                    Name = LocationText.Text,
                };

                _locationRepository.AddLocation(location);
                _photoRepository.UpdateLocationOfPhoto(imageSelected.PhotoId, location);
                LocationComboBox.Items.Add(location.Name);
            }
            else
            {
                _photoRepository.UpdateLocationOfPhoto(imageSelected.PhotoId, locationFound);
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
            this.SetTextForComboBoxes();
            pictureBox1.Image = null;
            photosFoundListBox.Items.Clear();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            photosFoundListBox.Items.Clear();
                    
            var images = _photoRepository.GetPhotos();
            
            if (PersonComboBox.SelectedItem != null)
            {
                var personFound = _personRepository.SearchByFullName((string)PersonComboBox.SelectedItem);
                var imagesFound = _photoRepository.GetPhotosOfPerson(personFound);
                images = (images.Intersect(imagesFound)).ToList();
            }
            if (EventComboBox.SelectedItem != null)
            {
                var imagesFound = _photoRepository.SearchPhotosByEvent((string)EventComboBox.SelectedItem);
                images = (images.Intersect(imagesFound)).ToList();
            }
            if (YearComboBox.SelectedItem != null)
            {
                var imagesFound = _photoRepository.SearchPhotosByYear((int)YearComboBox.SelectedItem);
                images = (images.Intersect(imagesFound)).ToList();
            }
            if (LocationComboBox.SelectedItem != null)
            {
                var locationFound = _locationRepository.SearchByName((string)LocationComboBox.SelectedItem);
                var imagesFound = _photoRepository.GetPhotosOfLocation(locationFound);
                images = (images.Intersect(imagesFound)).ToList();
            }
            photosFoundListBox.Visible = true;
            
            foreach (var image in images)
            {
                photosFoundListBox.Items.Add(image);
            }
            this.SetTextForComboBoxes();
        }

        private void PhotosFoundListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var imageSelect = _photoRepository.GetPhotoById(((Photo)photosFoundListBox.SelectedItem).PhotoId); 
            pictureBox1.ImageLocation = imageSelect.FilePath;
        }

        private Photo GetPhotoSelected()
        {
            Photo imageSelected;

            if (PhotoIdComboBox.SelectedItem != null)
            {
                imageSelected = _photoRepository.GetPhotoById((int)PhotoIdComboBox.SelectedItem);
                return imageSelected;
                    
            }
            else if (photosFoundListBox.SelectedItem != null)
            {
                imageSelected = _photoRepository.GetPhotoById(((Photo)photosFoundListBox.SelectedItem).PhotoId);
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

        private void DeletePhotoButton_Click(object sender, EventArgs e)
        {
            Photo photoSelected = GetPhotoSelected();

            if (MessageBox.Show("Do you really want to delete this photo?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _photoRepository.DeletePhoto(photoSelected.PhotoId);
            }
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
