namespace MauiAppWithoutShell
{
    public partial class MainPage : FlyoutPage
    {

        //--------------------------------------------------------------------------------------------------------------------------------

        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();

        //--------------------------------------------------------------------------------------------------------------------------------

        public MainPage()
        {

            InitializeComponent();

            FlyoutLayoutBehavior = FlyoutLayoutBehavior.Popover;

            MenuPages.Add((int)MenuItemType.Page1, (NavigationPage)Detail);

        }

        //--------------------------------------------------------------------------------------------------------------------------------

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Page1:
                        MenuPages.Add(id, new NavigationPage(new Page1()));
                        break;
                    case (int)MenuItemType.Page2:
                        MenuPages.Add(id, new NavigationPage(new Page2()));
                        break;
                    
                }
            }

            //--------------------------------------------------------------------------------------------------------------------------------

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (DeviceInfo.Current.Platform == DevicePlatform.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }

            //--------------------------------------------------------------------------------------------------------------------------------

        }
    }
}
