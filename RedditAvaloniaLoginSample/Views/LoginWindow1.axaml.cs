using Avalonia.Controls;

namespace RedditAvaloniaLoginSample.Views
{
    public partial class LoginWindow1 : Window
    {
        public LoginWindow1()
        {
            InitializeComponent();
        }

        private void logInButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            logInButton.Content = usernameTextBox.Text;
        }
    }
}
