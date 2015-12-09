using System;
using NativePcl.Core.ViewModel;

using UIKit;
using GalaSoft.MvvmLight.Helpers;

namespace NativePcl.iOS
{
	public partial class ViewController : UIViewController
	{
		Binding<string, string> _osVersionBinding;

		public ViewController (IntPtr handle) : base (handle)
		{
		}

		private MainViewModel Vm => Application.Locator.Main;

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
			_osVersionBinding = this.SetBinding(() => Vm.OSVersion, () => OSVersion.Text);
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

