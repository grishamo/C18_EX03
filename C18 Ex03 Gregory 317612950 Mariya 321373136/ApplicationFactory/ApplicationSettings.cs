using System;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace C18_Ex03_Gregory_317612950_Mariya_321373136
{
    public class ApplicationSettings
    {
        private static readonly string sr_FileName;

        static ApplicationSettings()
        {
            sr_FileName = Application.ExecutablePath + ".settings.xml";
        }

        /// <summary>
        ///  private CTOR as part as the singltone pattern
        /// </summary>
        private ApplicationSettings(){
            try
            {
                FromFileOrDefault();
            }
            catch(Exception e)
            {
                //handle exception
            }
        }

        /// C# 3.0 feature: Automatic Properties
        public bool AutoLogin { get; set; }
        public string FbAppId { get; set; }
        public string FbAppIdTest { get; set; }
        public FormWindowState LastWindowState { get; set; }
        public string AccessToken { get; set; }

        public void Save()
        {
            using (FileStream stream = new FileStream(sr_FileName, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ApplicationSettings));
                serializer.Serialize(stream, this);
            }
        }

        private void FromFileOrDefault()
        {
            ApplicationSettings loadedThis = null;

            if (File.Exists(sr_FileName))
            {
                using (FileStream stream = new FileStream(sr_FileName, FileMode.OpenOrCreate))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(ApplicationSettings));
                    loadedThis = (ApplicationSettings)serializer.Deserialize(stream);
                }
            }

            AutoLogin = loadedThis != null && loadedThis.AccessToken != null;
            AccessToken = null;// loadedThis != null && loadedThis.AccessToken != null ? loadedThis.AccessToken
            FbAppId = "1450160541956417";  //Desig Patter         
            FbAppIdTest = "229133017717072";  //  Gri@Mash    
        }   
    }
}
