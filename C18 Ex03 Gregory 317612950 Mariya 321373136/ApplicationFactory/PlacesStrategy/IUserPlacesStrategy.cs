using FacebookWrapper.ObjectModel;
using System.Windows.Forms;

namespace C18_Ex03_Gregory_317612950_Mariya_321373136
{
    public interface IUserPlacesStrategy
    {
        User User { get; set; }
        void SetContainerSettings(Widget i_container);
        string Title { get; }
        void Build();
        void Display(Control i_Container);
    }
}
