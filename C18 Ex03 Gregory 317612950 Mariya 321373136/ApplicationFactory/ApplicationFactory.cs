using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace C18_Ex03_Gregory_317612950_Mariya_321373136
{
    public class ApplicationFactory
    {
        private List<ApplicationBase> m_AllApplications = new List<ApplicationBase>();

        private ApplicationFactory() { }

        public ApplicationBase Create<T>(ApplicationSettings i_appSettings)
            where T : ApplicationBase, new()
        {
            ApplicationBase concreteApplication = new T();
            concreteApplication.Settings = i_appSettings;
            concreteApplication.Build();

            m_AllApplications.Add(concreteApplication);

            return concreteApplication;
        }
    }
}
