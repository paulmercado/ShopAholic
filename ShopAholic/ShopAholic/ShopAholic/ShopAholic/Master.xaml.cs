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
    public partial class Master : ContentPage
    {
        public Master()
        {
            InitializeComponent();

            var menu = new List<MasterContainer>
            {
                new MasterContainer {Menu =   "Shop", Options ="shop.png"},
                new MasterContainer {Menu =  "About", Options ="library.png"},
                new MasterContainer {Menu =  "Where To Buy", Options="wtb.png"},
                new MasterContainer {Menu =  "Sign up", Options="reg.png"},
                new MasterContainer {Menu = "Sign in", Options="reg.png" }

            };
            MasterListView.ItemsSource = menu;
        }

        private void MasterListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var MenuClicked = e.Item as MasterContainer;

            if (MenuClicked.Menu == "Shop") {
                Navigation.PushModalAsync(new ShopForm());
            }
            else if (MenuClicked.Menu == "About")
            {
                Navigation.PushModalAsync(new AboutForm());
            }
            else if (MenuClicked.Menu == "Where To Buy")
            {
                Navigation.PushModalAsync(new WTBForm());
            }
            else if (MenuClicked.Menu == "Sign up")
            {
                Navigation.PushModalAsync(new RegisterForm());
            }
            else if (MenuClicked.Menu == "Sign in")
            {
                Navigation.PushModalAsync(new LoginForm());
            }
        }             
    }
}
