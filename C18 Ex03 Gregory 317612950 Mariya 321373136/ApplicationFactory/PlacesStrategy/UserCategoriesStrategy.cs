using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C18_Ex03_Gregory_317612950_Mariya_321373136
{
    class UserCategoriesStrategy : IUserPlacesStrategy
    {
        private List<PlaceCategory> m_allCategories = new List<PlaceCategory>();

        private PlaceCategory FindByName(String i_CategoryName)
        {
            PlaceCategory foundCategory = null;

            foreach (PlaceCategory category in m_allCategories)
            {
                if (category.CategoryName == i_CategoryName)
                {
                    foundCategory = category;
                    break;
                }
            }

            return foundCategory;
        }

        public string Title
        {
            get
            {
                return User.FirstName + "'s Places";
            }
        }

        public User User { get; set; }

        public void SetContainerSettings(Widget i_container)
        {
            i_container.WidgetName = "UserPlaces";
            i_container.WidgetTitle = "Your Places";
            i_container.AutoSize = true;
            i_container.MaximumSize = new Size(0, 390);
            i_container.WidgetContainer.AutoScroll = true;
            i_container.WidgetContainer.MaximumSize = new Size(1000, 0);
        }

        public void Build()
        {
            FacebookObjectCollection<Checkin> FbUserCheckins = User.Checkins;
            List<PlaceCategory> allCategories = new List<PlaceCategory>();

            foreach (Checkin checkin in FbUserCheckins)
            {
                Page currentPlace = checkin.Place;
                PlaceCategory currentCategory;
                bool isCategoryExist = allCategories.Exists(Category => Category.CategoryName == currentPlace.Category);

                if (!isCategoryExist)
                {
                    currentCategory = new PlaceCategory(currentPlace.Category);
                    allCategories.Add(currentCategory);
                }
                else
                {
                    currentCategory = FindByName(currentPlace.Category);
                }

                currentCategory.AddFbPage(currentPlace);

            };

            // Mock Data
            // TODO: remove after debugging
            m_allCategories = mockData();

            //m_allCategories = allCategories;
        }

        public void Display(Control i_Container)
        {
            foreach (PlaceCategory category in m_allCategories)
            {
                i_Container.Controls.Add(category);
            }

        }

        private List<PlaceCategory> mockData()
        {
            List<PlaceCategory> allCategories = new List<PlaceCategory>();

            PlaceCategory mockCategory = new PlaceCategory("Bars");
            for (int i = 0; i < 10; i++)
            {
                Place mockPage = new Place(
                "https://scontent.fsdv2-1.fna.fbcdn.net/v/t1.0-1/p200x200/10526090_1500996420186296_4590947557162620097_n.png?_nc_cat=0&oh=a8eb815a522407ac3b176068ab31d283&oe=5BD0BB9F",
                "FREEDOM",
                "https://www.facebook.com/freedombarjerusalem/");

                mockCategory.AddPlace(mockPage);
                allCategories.Add(mockCategory);
            }

            PlaceCategory mockCategory2 = new PlaceCategory("Restorans");
            for (int i = 0; i < 10; i++)
            {
                Place mockPage = new Place(
                "https://scontent.fsdv2-1.fna.fbcdn.net/v/t1.0-1/564764_420623054627489_1533284902_n.jpg?_nc_cat=0&oh=9d9f67fcda93d4636ae35864461d2e4b&oe=5C107377",
                "Shaker",
                "https://www.facebook.com/Shaker-239039062785890/");

                mockCategory2.AddPlace(mockPage);
                allCategories.Add(mockCategory2);
            }

            return allCategories;
        }
    }
}
