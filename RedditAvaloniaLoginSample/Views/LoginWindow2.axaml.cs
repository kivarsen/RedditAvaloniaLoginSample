using Avalonia.Controls;
using RedditAvaloniaLoginSample.ViewModels;

namespace RedditAvaloniaLoginSample.Views
{
    public partial class LoginWindow2 : Window
    {
        public LoginWindow2()
        {
            InitializeComponent();

            // Set the DataContext to the object that contains properties/methods
            // we want to bind to within XAML
            DataContext = new LoginWindow2ViewModel();
        }
    }
}
