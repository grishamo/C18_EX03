using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace C18_Ex03_Gregory_317612950_Mariya_321373136
{
    public partial class Header : UserControl
    {
        private User FbUser { get; set; }

        public Header()
        {
            InitializeComponent();
            LogOut.Visible = false;
        }

        public event EventHandler OnLogoutClick;

        public string Username
        {
            get { return UserName.Text; }
            set { UserName.Text = value; }
        }

        public string UserPic
        {
            set { userPic.Load(value); }
        }

        public void Update(User i_LogedInUser)
        {
            LogOut.Visible = true;
            LogOut.Enabled = true;
            FbUser = i_LogedInUser;
            Username = FbUser.Name;
            UserPic = FbUser.PictureSqaureURL;
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            LogOut.Enabled = false;
            OnLogoutClick?.Invoke(sender, e);
        }
    }
}
