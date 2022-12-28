using Avalonia.Controls;

namespace RedditAvaloniaLoginSample.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.Opened += MainWindow_Opened;
        }

        private void MainWindow_Opened(object? sender, System.EventArgs e)
        {
            // TODO: Uncomment one of thse to test the behavior
            var loginWindow = new LoginWindow1();
            //var loginWindow = new LoginWindow2();
            
            loginWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            loginWindow.ShowDialog(this); // Show the window as a modal dialog on top of the main window
        }
    }
}
