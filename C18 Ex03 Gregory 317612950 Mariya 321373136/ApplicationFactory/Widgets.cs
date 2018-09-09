using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C18_Ex03_Gregory_317612950_Mariya_321373136
{
    public class Widgets : List<Widget>
    {
        public void UpdateUser(User i_User)
        {
            foreach(Widget widget in this)
            {
                widget.Update(i_User);
            }
        }
    }
}
