using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.API;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        InformationsService informationsService = new InformationsService();
        TagsService tagsService = new TagsService();

        public Form1()
        {
            InitializeComponent();
            tagsService.getTags().ForEach(delegate (String tag) { comboBoxTags.Items.Add(tag); });
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddTag_Click(object sender, EventArgs e)
        {
            String text = Interaction.InputBox("Tag name", "", "", -1, -1);
            if (text != null && text != "")
            {
                tagsService.saveTag(text);
                comboBoxTags.Items.Clear();
                tagsService.getTags().ForEach(delegate (String tag) { comboBoxTags.Items.Add(tag); });
            }

        }

        private void buttonSubmitPath_Click(object sender, EventArgs e)
        {
            if (textBoxPath.Text != null)
            {
                pictureBox.ImageLocation = textBoxPath.Text;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void textBoxPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxPath.Text != null && textBoxTagValue.Text != "" && comboBoxTags.SelectedIndex > -1)
            {
                informationsService.saveInformations(textBoxPath.Text, comboBoxTags.Text, textBoxTagValue.Text);
                System.Windows.Forms.MessageBox.Show("Picture was saved");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSearchPhotos_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
