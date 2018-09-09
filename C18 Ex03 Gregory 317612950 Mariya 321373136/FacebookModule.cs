using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System;

namespace C18_Ex03_Gregory_317612950_Mariya_321373136
{
    public class FacebookModule
    {
        private ApplicationSettings m_ApplicationSettings;
        private string m_Permissions = string.Format(
@"public_profile, 
user_friends,
user_checkins");

        public User LogedInUser { get; set; }

        public FacebookModule(ApplicationSettings i_ApplicationSettings)
        {
            m_ApplicationSettings = i_ApplicationSettings;
        }

        public void autoLogin()
        {
            LoginResult result = FacebookService.Connect(m_ApplicationSettings.AccessToken);
            if (result.LoggedInUser != null)
            {
                LogedInUser = result.LoggedInUser;
            }
        }

        public void loginAndInit()
        {
            /// Use the FacebookService.Login method to display the login form to any user who wish to use this application.
            /// You can then save the result.AccessToken for future auto-connect to this user: 
            LoginResult result = FacebookService.Login(m_ApplicationSettings.FbAppId, m_Permissions);
            // The documentation regarding facebook login and permissions can be found here: 
            // https://developers.facebook.com/docs/facebook-login/permissions#reference


            if (string.IsNullOrEmpty(result.AccessToken))
            {
                throw new Exception(result.ErrorMessage);
            }


            LogedInUser = result.LoggedInUser;
            m_ApplicationSettings.AccessToken = result.AccessToken;

        }

        public void Logout(Action i_Callback)
        {
            m_ApplicationSettings.AccessToken = null;
            FacebookService.Logout(i_Callback);
        }

    }
}
