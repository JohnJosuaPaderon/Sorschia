using MahApps.Metro.Controls;
using Prism.Interactivity;
using System.Windows;
using System.Windows.Media;

namespace Sorschia
{
    public sealed class SorschiaPopupWindowAction : PopupWindowAction
    {
        protected override Window CreateWindow()
        {
            return new MetroWindow()
            {
                SizeToContent = SizeToContent.WidthAndHeight,
                ShowTitleBar = false,
                TitlebarHeight = 0,
                ShowMinButton = false,
                ShowMaxRestoreButton = false,
                ShowCloseButton = false,
                WindowStartupLocation = WindowStartupLocation ?? System.Windows.WindowStartupLocation.CenterScreen,
                BorderBrush = new SolidColorBrush(Color.FromArgb(50, 0, 0, 0)),
                BorderThickness = new Thickness(1),
                Padding = new Thickness(50)
            };
        }
    }
}
