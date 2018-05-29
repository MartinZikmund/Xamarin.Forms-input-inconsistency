using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace InputTransparentIssue
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

	    private void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
	    {
	        Debug.WriteLine("Tap captured");
	    }
	}
}
