using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace C18_Ex03_Gregory_317612950_Mariya_321373136
{
    public partial class FriendListItem : UserControl
    {
        public List<ICommand> ClickCommands { get; set; }

        public User FriendInfo { get; set; }

        public FriendListItem(User i_Friend)
        {
            InitializeComponent();

            FriendInfo = i_Friend;
            UserName = i_Friend.Name;
            CountPlaces = i_Friend.Checkins.Count;
            Image = i_Friend.PictureSqaureURL;
        }

        public string UserName
        {
            get { return Username.Text; }
            set { Username.Text = value; }
        }

        public int CountPlaces
        {
            get { return int.Parse(PlacesCount.Text.Split(' ')[0]); }
            set { PlacesCount.Text = value.ToString() + " Places"; }
        }

        public string Image
        {
            get { return Userpic.ImageLocation; }
            set { Userpic.Load(value); }
        }

        private void FriendItem_Click(object sender, EventArgs e)
        {
            foreach (ICommand command in ClickCommands)
            {
                command.SetParams(FriendInfo);
                command.Execute();
            }
        }

        private void FriendListItem_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(238, 245, 253);
        }

        private void FriendListItem_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }

    }
}
