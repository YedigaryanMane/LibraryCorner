using LibraryCorner.Models;

namespace LibraryCorner.LoginMenu
{
    public abstract class Menu
    {
        public DataContext _dataContext { get; set; }

        public Menu(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public abstract void Register(User user);
        public abstract string Login(string username, string password);
    }
}
