using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C18_Ex03_Gregory_317612950_Mariya_321373136
{
    public class FriendsList : Widget
    {
        private User m_FbUser;
        private FacebookObjectCollection<User> m_UserFriends;

        public FriendsList(User i_FbUser = null)
        {
            WidgetName = "FriendsList";
            m_FbUser = i_FbUser;
            init();
        }

        private void init()
        {
            Title.Text = "Friends List";
            WidgetContainer.BackColor = Color.White;
            WidgetContainer.BorderStyle = BorderStyle.None;
            Width = 200;
        }

        public override void Update(params object[] args)
        {
            m_FbUser = Utils.GetParam<User>(args) as User;
            m_UserFriends = m_FbUser.Friends;
            updateContainer();
        }

        private void updateContainer()
        {
            if(m_UserFriends != null)
            {
                foreach(User friend in m_UserFriends)
                {
                    FriendListItem listItem = new FriendListItem(friend);
                    listItem.ClickCommands = WidgetCommands;
                    WidgetContainer.Controls.Add(listItem);
                }
            }
        }

    }
}
