using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /**
         * Event handler to load a picture form a file.
         * NOTE: There is no error handling yet!
         */
        private void showPictureButton_Click(object sender, EventArgs e)
        {
            // If the user clicks ok, load the file.  Do nothing otherwise.
            if (openFileDialog1.ShowDialog() == DialogResult.OK )
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void clearPictureButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void setBackgroundButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK )
            {
                pictureBox1.BackColor = colorDialog1.Color;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if ( checkBox1.Checked )
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            }
        }
    }
}
