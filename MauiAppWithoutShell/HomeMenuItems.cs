namespace MauiAppWithoutShell
{
    public enum MenuItemType
    {
        Page1,
        Page2
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
