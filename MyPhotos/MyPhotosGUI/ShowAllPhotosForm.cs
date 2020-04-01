using MyPhotosCore.Context;
using MyPhotosCore.Repository.PhotoRepository;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyPhotosGUI
{
    public partial class ShowAllPhotosForm : Form
    {
        static AppModelContainer context = new AppModelContainer();
        private IPhotoRepository _photoRepository = new PhotoRepository(context);
        public ShowAllPhotosForm()
        {
            InitializeComponent();
        }

        private void ShowAllPhotosForm_Load(object sender, EventArgs e)
        {

            var images = _photoRepository.GetPhotos();
            int x = 20;
            int y = 20;
            int maxHeight = -1;

            foreach (var image in images)
            {
                PictureBox pb = new PictureBox();
                pb.Size = new Size(220, 150);
                pb.Location = new Point(x, y);
                pb.ImageLocation = image.FilePath;
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                x += pb.Width + 20;
                maxHeight = Math.Max(pb.Height, maxHeight);
                if (x > this.ClientSize.Width - 40) 
                {
                    x = 20;
                    y += maxHeight + 10;
                }
                this.Controls.Add(pb);
            }
        }
        
    }
}
