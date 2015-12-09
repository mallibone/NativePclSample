using System;
using System.Threading;
using NativePcl.Core.ViewModel;

namespace NativePcl.Droid
{
    internal class Locator : ViewModelLocator
    {
        private static readonly Lazy<Locator> _locator = new Lazy<Locator>(() => new Locator(), LazyThreadSafetyMode.PublicationOnly);
        public static Locator Instance => _locator.Value;

        private Locator()
        {
        }
    }
}