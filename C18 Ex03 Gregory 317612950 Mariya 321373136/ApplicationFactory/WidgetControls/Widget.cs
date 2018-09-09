using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C18_Ex03_Gregory_317612950_Mariya_321373136
{
    public abstract partial class Widget : UserControl
    {
        public List<ICommand> WidgetCommands { get; set; }

        public string WidgetName{ get; set; }
        public string WidgetTitle
        {
            get
            {
                return Title.Text;
            }
            set
            {
                Title.Text = value;
            }
        }

        public Widget()
        {
            InitializeComponent();
            WidgetCommands = new List<ICommand>();
        }

        public abstract void Update(params object[] str);

        protected virtual void ClearWidgetContainer<T>(List<T> i_Controlls = null)
        {
            if (i_Controlls != null)
            {
                foreach (T item in i_Controlls)
                {
                    Control control = item as Control;
                    WidgetContainer.Controls.Remove(control);
                    control.Dispose();
                }
            }

        }

        public virtual void ClearWidgetContainer()
        {
            WidgetContainer.Controls.Clear();
        }

    }
}
