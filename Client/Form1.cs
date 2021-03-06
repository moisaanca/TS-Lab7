﻿using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using WindowsFormsApp2.ServiceReference1;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
        public Form1()
            {
                InitializeComponent();
           
            foreach(String tag  in client.getTags()){
                comboBoxTags.Items.Add(tag);
            }
        }

            private void Form1_Load(object sender, EventArgs e)
            {

            }

            private void buttonAddTag_Click(object sender, EventArgs e)
            {
                String text = Interaction.InputBox("Tag name", "", "", -1, -1);
                if (text != null && text != "")
                {
                    client.saveTag(text);
                    comboBoxTags.Items.Clear();
                foreach (string tag in client.getTags())
                {
                    comboBoxTags.Items.Add(tag);
                }
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
                    client.saveInformations(textBoxPath.Text, comboBoxTags.Text, textBoxTagValue.Text);
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

        private void buttonSearchPhotos_Click_1(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
