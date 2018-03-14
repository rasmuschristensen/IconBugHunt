using System;
using Xamarin.Forms;

namespace XamFontAwesome
{
    public partial class XamFontAwesomePage : ContentPage
    {
        public XamFontAwesomePage()
        {
            InitializeComponent();

            //this.iconButton.Text = "\uf007";
            //this.iconButton2.Text = "\uf024";
        }

        private void Handle_Clicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new FooPage());
        }
    }
}
