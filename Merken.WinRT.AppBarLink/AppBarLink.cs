using Windows.UI.Xaml;

namespace Merken.WinRT.AppBarLink
{
    public class AppBarLink : DependencyObject
    {
        public FrameworkElement Element
        {
            get
            {
                return (FrameworkElement)base.GetValue(AppBarLink.ElementProperty);
            }
            set
            {
                base.SetValue(AppBarLink.ElementProperty, value);
            }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ElementProperty =
            DependencyProperty.Register("Element", typeof(FrameworkElement), typeof(AppBarLink), new PropertyMetadata(null, ElementPropertyChanged));

        private static void ElementPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var link = (AppBarLink)d;
            link.Element = (FrameworkElement)e.NewValue;
        }
    }
}
