using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Microsoft.Pex.Framework;

namespace HBD.WPF.Tests.Factories
{
    /// <summary>A factory for System.Windows.DependencyObject instances</summary>
    public static class DependencyObjectFactory
    {
        /// <summary>A factory for System.Windows.DependencyObject instances</summary>
        [PexFactoryMethod(typeof(DependencyObject))]
        public static DependencyObject Create()
        {
            DependencyObject dependencyObject = new Label();
            dependencyObject.SetValue(Control.BackgroundProperty, new SolidColorBrush(Colors.Transparent));
            return dependencyObject;
        }
    }
}
