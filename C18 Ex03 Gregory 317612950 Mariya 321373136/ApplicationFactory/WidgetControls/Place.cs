using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace C18_Ex03_Gregory_317612950_Mariya_321373136
{
    public partial class Place : UserControl
    {
        private string m_Url;
        private Page m_FbPage;

        public string Image
        {
            get { return PlaceImage.ImageLocation; }
            set { PlaceImage.Load(value); }
        }

        public string PlaceTitle
        {
            get { return PlaceName.Text; }
            set { PlaceName.Text = value;  }
        }

        public Place(Page i_FbPage)
            : this(i_FbPage.PictureNormalURL, i_FbPage.Name, i_FbPage.URL)
        {
            m_FbPage = i_FbPage;
        }

        public Place(string i_PictureUrl = "", string i_Name = "", string i_Url = "")
        {
            InitializeComponent();

            Image = i_PictureUrl;
            PlaceTitle = i_Name;
            m_Url = i_Url;
        }

        private void PlaceImage_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(m_Url);
        }

    }
}
