using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace C18_Ex03_Gregory_317612950_Mariya_321373136
{
    public partial class PlaceCategory : UserControl
    {
        private List<Place> m_CategoryPlaces = new List<Place>();

        public string CategoryName {
            get { return Title.Text; }
            set { Title.Text = value; }
        }

        public PlaceCategory(string i_CategoryName = "")
        {
            InitializeComponent();
            CategoryName = i_CategoryName;
            Dock = DockStyle.Top;
        }

        public void AddFbPage(Page i_Page)
        {
            Place newPlace = new Place(i_Page);
            AddPlace(newPlace);
        }

        public void AddPlace(Place i_Place)
        {
            m_CategoryPlaces.Add(i_Place);
            PlacesContainer.Controls.Add(i_Place);
        }
    }
}
