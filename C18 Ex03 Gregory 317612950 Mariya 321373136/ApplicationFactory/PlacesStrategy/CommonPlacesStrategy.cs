using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using System.Drawing;

namespace C18_Ex03_Gregory_317612950_Mariya_321373136
{
    class CommonPlacesStrategy : IUserPlacesStrategy
    {
        private List<User> m_UsersToCompare = new List<User>();
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

        public void SetContainerSettings(Widget i_container)
        {
            i_container.WidgetName = "CommonPlaces";
            i_container.WidgetTitle = "Common Places";

            i_container.WidgetContainer.BorderStyle = BorderStyle.None;
            i_container.WidgetContainer.BackColor = Color.White;

            i_container.MinimumSize = new Size(0, 230);
            i_container.MaximumSize = new Size(0, 230);

            i_container.WidgetContainer.AutoScroll = true;
            i_container.WidgetContainer.MaximumSize = new Size(1000, 0);
        }

        public string Title {
            get {
                string title = "Common Places ";
                if (m_UsersToCompare.Count > 1)
                {

                    title += "With " + m_UsersToCompare[m_UsersToCompare.Count - 1].FirstName;
                }
                return title;
            }
        }

        public User User {
            get {
                //Loged in User
                return m_UsersToCompare[0];
            }
            set {
                if (m_UsersToCompare.IndexOf(value) == -1)
                {
                    m_UsersToCompare.Add(value);
                }
            }
        }

        private FacebookObjectCollection<Checkin> buildCommonFiendsPlaces()
        {
            FacebookObjectCollection<Checkin> FbUserCheckins = User.Checkins;
            FacebookObjectCollection<User> FbFriends = User.Friends;
            FacebookObjectCollection<Checkin> commonCheckins = new FacebookObjectCollection<Checkin>();

            foreach (Checkin userCheckin in User.Checkins)
            {
                bool isCommon = true;

                foreach (User nextUser in FbFriends)
                {
                    if (!nextUser.Checkins.Contains(userCheckin))
                    {
                        isCommon = false;
                        break;
                    }
                }

                if (isCommon)
                {
                    commonCheckins.Add(userCheckin);
                }
            }

            return commonCheckins;
        }

        private FacebookObjectCollection<Checkin> buildCommonPlaces()
        {
            User i_FirstUser = m_UsersToCompare[0];
            User i_SecondUser = m_UsersToCompare[0];
            List<PlaceCategory> commonPlaces = new List<PlaceCategory>();
            FacebookObjectCollection<Checkin> commonCheckins = new FacebookObjectCollection<Checkin>();

            foreach (Checkin checkin in i_FirstUser.Checkins)
            {
                if (!i_SecondUser.Checkins.Contains(checkin))
                {
                    commonCheckins.Add(checkin);
                }
            }

            return commonCheckins;
        }

        public void Build()
        {
            List<PlaceCategory> commonPlaces = new List<PlaceCategory>();
            FacebookObjectCollection<Checkin> commonCheckins = new FacebookObjectCollection<Checkin>();

            if(m_UsersToCompare.Count > 1)
            {
                commonCheckins = buildCommonPlaces();
            }
            else
            {
                commonCheckins = buildCommonFiendsPlaces();
            }


            // Mock Data
            // TODO: remove after debugging
            m_allCategories = mockData();

            //m_allCategories = orderByCategory(commonCheckins);
        }

        private List<PlaceCategory> orderByCategory(FacebookObjectCollection<Checkin> i_CommonCheckins)
        {
            List<PlaceCategory> allCategories = new List<PlaceCategory>();
          
            foreach (Checkin checkin in i_CommonCheckins)
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

            return allCategories;
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
