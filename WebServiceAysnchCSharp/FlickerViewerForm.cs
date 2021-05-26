using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WebServiceAsynchronously
{
    public partial class FlickerViewerForm : Form
    {
        // Your API KEY from Flickr
        private const string KEY = "b4180916ebe894b0430d10a3975afee7";

        private static HttpClient flickrClient = new HttpClient();

        Task<string> flickrTask = null;
        public FlickerViewerForm()
        {
            InitializeComponent();
        }

        private void searchTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private async void searchBtn_Click(object sender, EventArgs e)
        {
            if (flickrTask?.Status != TaskStatus.RanToCompletion)
            {
                var result = MessageBox.Show("Did you enter the right Flickr search tag?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    return;
                }
                else
                {
                    flickrClient.CancelPendingRequests();
                }
            }

            var flickrURL = "https://api.flickr.com/services/rest/?method=" +
                $"flickr.photos.search&api_key={KEY}&" +
                $"tags={searchTxtBox.Text.Replace(" ", ",")}" +
                "&tag_mode=all&per_page=500&privacy_filter=1";

            imagesListBox.DataSource = null;
            imagesListBox.Items.Clear();
            pictureBox.Image = null;
            imagesListBox.Items.Add("Loading...");

            flickrTask = flickrClient.GetStringAsync(flickrURL);

            XDocument flickrXML = XDocument.Parse(await flickrTask);

            var flickrPhotos =
                from photo in flickrXML.Descendants("photo")
                let id = photo.Attribute("id").Value
                let title = photo.Attribute("title").Value
                let secret = photo.Attribute("secret").Value
                let server = photo.Attribute("server").Value
                let farm = photo.Attribute("farm").Value
                select new FlickrResult
                {
                    Title = title,
                    URL = $"https://farm{farm}.staticflickr.com/" +
                          $"{server}/{id}_{secret}.jpg"
                };
            imagesListBox.Items.Clear();

            if (flickrPhotos.Any())
            {
                imagesListBox.DataSource = flickrPhotos.ToList();
                imagesListBox.DisplayMember = "Title";
            } 
            else
            {
                imagesListBox.Items.Add("No matches");
            }



        }

        private async void imagesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (imagesListBox.SelectedItem != null)
            {
                string selectedURL =
                    ((FlickrResult)imagesListBox.SelectedItem).URL;

                byte[] imageBytes =
                    await flickrClient.GetByteArrayAsync(selectedURL);

                MemoryStream memoryStream = new MemoryStream(imageBytes);
                pictureBox.Image = Image.FromStream(memoryStream);
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
