using System.Windows;
using System;
using System.Windows.Controls;
using Microsoft.Pex.Framework;

namespace System.Windows
{
    /// <summary>A factory for System.Windows.DependencyProperty instances</summary>
    public static partial class DependencyPropertyFactory
    {
        /// <summary>A factory for System.Windows.DependencyProperty instances</summary>
        [PexFactoryMethod(typeof(DependencyProperty))]
        public static object Create()
        {
            return Control.BackgroundProperty;
        }
    }
}
