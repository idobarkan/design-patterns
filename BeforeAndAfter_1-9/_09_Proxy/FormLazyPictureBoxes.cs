using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _09_Proxy
{
    public partial class FormLazyPictureBoxes : Form
    {
        int m_CountLoaded = 0;

        public FormLazyPictureBoxes()
        {
            InitializeComponent();
            
            foreach (PictureBoxLazy pictureBox in panel1.Controls)
            {
                pictureBox.ImageLocation = "http://static4.pookebook.com/wp-content/uploads/2011/10/c-30-design-patterns.jpg";
                pictureBox.LoadCompleted += new AsyncCompletedEventHandler(lazyPictureBox_LoadCompleted);
            }
        }

        private void lazyPictureBox_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            m_CountLoaded++;
            this.Text = string.Format("Pictures loaded: {0}", m_CountLoaded);
        }
    }

    /// <summary>
    ///  Class Proxy
    /// </summary>
    public class PictureBoxLazy : PictureBox
    {
        public new void Load(string i_Url)
        {
            ImageLocation = i_Url;
        }

        public new string ImageLocation { get; set; }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            if (Image == null && ImageLocation != null)
            {
                LoadAsync(ImageLocation);
            }
        }
    }
}
