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
                ShowMinButton = false,
                ShowMaxRestoreButton = false,
                ShowCloseButton = false,
                TitlebarHeight = 0,
                WindowStartupLocation = WindowStartupLocation ?? System.Windows.WindowStartupLocation.CenterScreen,
                BorderThickness = new Thickness(0),
                GlowBrush = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0)),
                WindowTransitionsEnabled = false,
                ShowInTaskbar = false,
                ResizeMode = ResizeMode.NoResize
            };
        }
    }
}
