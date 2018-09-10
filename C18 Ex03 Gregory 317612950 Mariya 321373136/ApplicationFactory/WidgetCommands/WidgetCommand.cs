using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C18_Ex03_Gregory_317612950_Mariya_321373136
{
    public class WidgetCommand : ICommand
    {
        private Action<object> m_ActionToInvoke;
        private object m_NewUser;

        public WidgetCommand(Action<object> i_ActionToInvoke)
        {
            m_ActionToInvoke = i_ActionToInvoke;
        }

        public void Execute()
        {
            m_ActionToInvoke.Invoke(m_NewUser);
        }

        public void SetParams(params object[] args)
        {
            m_NewUser = args[0];
        }
    }
}
