using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
        int prev = 0;
        List<String> searchResults = new List<string>();
        public Form2()
        {
            InitializeComponent();
            foreach(String tag in client.getTags())
            {
                comboBoxSearchByTag.Items.Add(tag);
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxSearchByTag_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if(textBoxSearchByDescription.Text != "" || comboBoxSearchByTag.SelectedIndex > -1)
            {
                prev = 0;
                pictureBoxResults.Image = null;
                pictureBoxResults.Update();
                searchResults = new List<string>(client.displaySearchResults(textBoxSearchByDescription.Text, comboBoxSearchByTag.Text));
                displayImage(searchResults);
            }
        }


        private void buttonNext_Click(object sender, EventArgs e)
        {
            prev++;
            if (searchResults.Count >= 1 && prev > searchResults.Count - 1)
            {
                prev = 0;
                displayImage(searchResults);
            }
            displayImage(searchResults);
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            prev--;
            if (prev < searchResults.Count && prev >= 0)
            {
                displayImage(searchResults);
            }
            else
            {
                prev = 0;
                displayImage(searchResults);
            }
        }

        private void displayImage(List<String> photos)
        {
            if (photos.Count >= 1)
            {
                pictureBoxResults.ImageLocation = photos.ElementAt(prev);
                pictureBoxResults.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            client.deletePicture(searchResults.ElementAt(prev));
            System.Windows.Forms.MessageBox.Show("Picture was deleted");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
