using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TranslationXYRepro
{
	// Learn more about making custom code visible in the Xamarin.Forms previewer
	// by visiting https://aka.ms/xamarinforms-previewer
	[DesignTimeVisible(false)]
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
		private void Button_Clicked(object sender, EventArgs e)
		{
			translatedBox.TranslationX = translatedBox.TranslationY = 0;
		}

		private void Button2_Clicked(object sender, EventArgs e)
		{
			translatedBox.TranslationX = translatedBox.TranslationY = new Random().Next(10, 100);
		}
	}
}
