using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShopAholic
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginForm : ContentPage
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        void btnnLogin(object sender, EventArgs e)
        {
            if (txtUsername.Text == null || txtPassword.Text == null )
            {
                DisplayAlert("Please fill-up all fields!", "", "OK");
            }
            else
            {
                DisplayAlert("Sucessfully Login!", "", "OK");
                txtUsername.Text = ""; txtPassword.Text = "";
                
            }
        }
    }
}
