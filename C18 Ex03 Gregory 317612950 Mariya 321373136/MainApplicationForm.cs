using System;
using System.Windows.Forms;
using System.ComponentModel;

namespace C18_Ex03_Gregory_317612950_Mariya_321373136
{
    public partial class MainApplicationForm : Form
    {
        private static ApplicationSettings m_ApplicationSettings = Singelton<ApplicationSettings>.Instance;
        private static ApplicationFactory m_ApplicationFactory = Singelton<ApplicationFactory>.Instance;
        private FacebookModule m_FacebookModule = new FacebookModule(m_ApplicationSettings);
        private ApplicationBase m_ApplicationInstance;


        public MainApplicationForm()
        {
            InitializeComponent();
            m_ApplicationInstance = m_ApplicationFactory.Create<CommonPlacesApplication>(m_ApplicationSettings);

            //Add Facebook AppIds to ComnboBox - for debuging
            AppIdComboBox.Items.Add(m_ApplicationSettings.FbAppId);
            AppIdComboBox.Items.Add(m_ApplicationSettings.FbAppIdTest);

            // Add application grid to the main form
            m_ApplicationInstance.AddAppToForm(Controls);
            m_ApplicationInstance.OnLogOutClick(FbLogout_Click);

            //Main Text
            MainText.Text = "Find Your Next Place To Visit";
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            m_ApplicationSettings.Save();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (m_ApplicationSettings.AutoLogin)
            {
                try
                {
                    m_FacebookModule.autoLogin();
                    StartApplication();
                }
                catch(Exception exception)
                {
                    MessageBox.Show(exception.Message);
                    //FbLogin_Click(null, null);
                }
            }
        }

        private void FbLogin_Click(object sender, EventArgs e)
        {
            try
            {
                m_FacebookModule.loginAndInit();
                StartApplication();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void StartApplication()
        {
            SignIn.Visible = false;
            m_ApplicationInstance.Display = true;
            m_ApplicationInstance.UpdateUser(m_FacebookModule.LogedInUser);
        }

        // TODO: move logout to Header
        public void FbLogout_Click(object sender, EventArgs e)
        {
            m_FacebookModule.Logout(null);
            m_ApplicationInstance.LogOut();
            SignIn.Visible = true;
        }

        private void AppIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            object selectedItem = AppIdComboBox.SelectedItem;
            m_ApplicationSettings.FbAppId = selectedItem.ToString();
        }
    }
    

}
