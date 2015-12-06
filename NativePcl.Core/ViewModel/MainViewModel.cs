using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace NativePcl.Core.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private readonly IOsVersionService _osVersionService;

        public MainViewModel(IOsVersionService osVersionService)
        {
            if (osVersionService == null) throw new ArgumentNullException(nameof(osVersionService));
            _osVersionService = osVersionService;
        }

        public string OSVersion => _osVersionService.GetVersion();
    }
}
