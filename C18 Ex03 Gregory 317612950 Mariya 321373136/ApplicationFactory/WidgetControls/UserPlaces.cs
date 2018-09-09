using FacebookWrapper.ObjectModel;
using System.Drawing;


namespace C18_Ex03_Gregory_317612950_Mariya_321373136
{
    public class UserPlaces : Widget
    {
        protected User FbUser { get; set; }
        public IUserPlacesStrategy userPlacesStrategy { get; set; }

        public UserPlaces(IUserPlacesStrategy userPlacesStrategy = null)
        {
            this.userPlacesStrategy = userPlacesStrategy;
            this.userPlacesStrategy.SetContainerSettings(this);
        }

        public virtual void UpdatePlaces(object i_user) {
            Update(i_user);
        }

        public override void Update(params object[] args)
        {
            ClearWidgetContainer();
            if (args.Length > 0 && userPlacesStrategy != null)
            {
                FbUser = Utils.GetParam<User>(args) as User;

                userPlacesStrategy.User = FbUser;
                userPlacesStrategy.Build();
                WidgetTitle = userPlacesStrategy.Title;

                userPlacesStrategy.Display(WidgetContainer);
            }
        }

    }
 }
