using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace youtube_dl_avalonia.Views
{
    public class HomeView : UserControl
    {
        public HomeView()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
