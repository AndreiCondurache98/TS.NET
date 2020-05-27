using MyPhotosCore.Context;
using MyPhotosCore.Repository.LocationRepository;
using MyPhotosCore.Repository.PhotoRepository;
using System;
using System.Windows.Forms;

namespace MyPhotosGUI
{
    public partial class PhotoForm : Form
    {
        static AppModelContainer context = new AppModelContainer();
        private IPhotoRepository _photoRepository = new PhotoRepository(context);
        private ILocationRepository _locationRepository = new LocationRepository(context);

        public PhotoForm()
        {
            InitializeComponent();
        }
        private void PhotoForm_Load(object sender, EventArgs e)
        {

        }

        private void AddPhotoButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EventTextBox.Text) == true || string.IsNullOrWhiteSpace(DescriptionTextBox.Text) == true
                || string.IsNullOrWhiteSpace(LocationTextBox.Text) == true)
            {
                MessageBox.Show("Please complete all fields");
                return;
            }

            var locationFound = _locationRepository.SearchByName((string)LocationTextBox.Text);

            if (!_locationRepository.VerifyLocationExists(locationFound))
            {

                Location locationToAdd = new Location
                {
                    Name = LocationTextBox.Text
                };
                _locationRepository.AddLocation(locationToAdd);


                Photo photoToAdd = new Photo
                {
                    Event = EventTextBox.Text,
                    DateCreated = (DateTime)dateCreatedPicker.Value,
                    Description = DescriptionTextBox.Text,
                    FilePath = pathText.Text,
                    LocationId = locationToAdd.LocationId,
                    Location = locationToAdd
                };
                _photoRepository.AddPhoto(photoToAdd);
            }
            else
            {
                Photo photoToAdd = new Photo
                {
                    Event = EventTextBox.Text,
                    DateCreated = (DateTime)dateCreatedPicker.Value,
                    Description = DescriptionTextBox.Text,
                    FilePath = pathText.Text,
                    LocationId = locationFound.LocationId,
                    Location = locationFound
                };
                _photoRepository.AddPhoto(photoToAdd);
            }

            MessageBox.Show("Photo Added!","Message");
            EventTextBox.Clear();
            DescriptionTextBox.Clear();
            LocationTextBox.Clear();
            pictureBox1.Image = null;
        }

        private void SearchPhotoButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog.FileName;
                string fName = openFileDialog.FileName;
                pathText.Text = fName;
            }
            EventTextBox.Clear();
            DescriptionTextBox.Clear();
            LocationTextBox.Clear();
            pictureBox1.Image = null;
        }

        private void EventTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Space);
        }

        private void LocationTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
    }
}
