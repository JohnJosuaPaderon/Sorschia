using System.Windows;

namespace Sorschia
{
    public sealed class NavigationInfo : FrameworkElement
    {
        public string RegionName
        {
            get { return (string)GetValue(RegionNameProperty); }
            set { SetValue(RegionNameProperty, value); }
        }

        public static readonly DependencyProperty RegionNameProperty = DependencyProperty.Register(nameof(RegionName), typeof(string), typeof(NavigationInfo), new PropertyMetadata(null));

        public string TargetViewName
        {
            get { return (string)GetValue(TargetViewNameProperty); }
            set { SetValue(TargetViewNameProperty, value); }
        }

        public static readonly DependencyProperty TargetViewNameProperty = DependencyProperty.Register(nameof(TargetViewName), typeof(string), typeof(NavigationInfo), new PropertyMetadata(null));
    }
}
