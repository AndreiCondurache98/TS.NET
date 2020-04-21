using System;
using System.Windows.Forms;

namespace MyPhotosClient
{
    public partial class Form1 : Form
    {
        public PhotoClient photoClient = new PhotoClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void AddPhotoButton_Click(object sender, EventArgs e)
        {
            PhotoForm photoForm = new PhotoForm();
            photoForm.Show();
        }

        private void ShowAllMyPhotosButton_Click(object sender, EventArgs e)
        {
            ShowAllPhotosForm photos = new ShowAllPhotosForm();
            photos.Show();
        }

        private void SearchAndModifyPhotoButton_Click(object sender, EventArgs e)
        {
            ModifyPhotoForm modifyPhoto = new ModifyPhotoForm();
            modifyPhoto.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
