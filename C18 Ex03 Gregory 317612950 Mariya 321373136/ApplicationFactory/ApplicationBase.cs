using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C18_Ex03_Gregory_317612950_Mariya_321373136
{
    public abstract class ApplicationBase
    {
        public ApplicationSettings Settings { get; set; }
        public Header Header { get; set; }
        public Widgets Widgets { get; set; }
        public Grid Grid { get; set; }

        public bool Display
        {
            set
            {
                foreach (Control gridPart in Grid)
                {
                    gridPart.Visible = value;
                }
            }
        }

        public abstract void Build(params object[] i_ObjList);

        protected abstract void BuildHeader(params object[] i_ObjList);

        protected abstract void BuildWidgets(params object[] i_ObjList);

        public abstract void OnLogOutClick(EventHandler fbLogout_Click);

        protected virtual void BuildGrid(string i_Main, string i_Header)
        {
            //Grid = new Dictionary<string, Control>();
            Grid = new Grid();
            Panel headerContainer = new Panel();
            Panel mainConatainer = new Panel();

            headerContainer.AutoSize = true;
            headerContainer.Dock = DockStyle.Top;
            headerContainer.Visible = false;

            mainConatainer.AutoSize = true;
            mainConatainer.Dock = DockStyle.Fill;
            mainConatainer.Visible = false;
            mainConatainer.Padding = new Padding(0, 20, 0, 0);

            Grid.Add(i_Main, mainConatainer)
                .Add(i_Header, headerContainer);

        }

        public virtual void LogOut()
        {
            ClearWidgetsContainer();
        }

        public virtual void UpdateUser(User i_LogedInUser)
        {
            Header.Update(i_LogedInUser);
            Widgets.UpdateUser(i_LogedInUser);
        }

        public virtual void AddAppToForm(Control.ControlCollection i_Controls)
        {
            foreach(Control gridPart in Grid)
            {
                i_Controls.Add(gridPart);
            }
        }

        protected virtual void ClearWidgetsContainer()
        {
            foreach (Widget widget in Widgets)
            {
                widget.ClearWidgetContainer();
            }
        }

    }
}
