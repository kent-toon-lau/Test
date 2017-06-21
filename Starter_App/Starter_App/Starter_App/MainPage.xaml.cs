using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Starter_App
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void Add_Clicked(object sender, EventArgs e)
        {
            ResultLabel.Text = (Convert.ToInt32(ValueAEntry.Text) + Convert.ToInt32(ValueBEntry.Text)).ToString();
        }

        private void Multiply_Clicked(object sender, EventArgs e)
        {
            ResultLabel.Text = (Convert.ToInt32(ValueAEntry.Text) * Convert.ToInt32(ValueBEntry.Text)).ToString();
        }
    }
}
