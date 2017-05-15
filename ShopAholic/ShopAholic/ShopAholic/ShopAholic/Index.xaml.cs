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
    public partial class Detail : TabbedPage
    {
        public Detail()
        {
            InitializeComponent();

            var womenform = new TapGestureRecognizer();
            womenform.Tapped += (s, e) =>
            {
                Navigation.PushModalAsync(new WomenForm());
            };
            wom.GestureRecognizers.Add(womenform);

            var menform = new TapGestureRecognizer();
            menform.Tapped += (s, e) =>
            {
                Navigation.PushModalAsync(new MenForm());
            };
            men.GestureRecognizers.Add(menform);

            var kidsform = new TapGestureRecognizer();
            kidsform.Tapped += (s, e) =>
            {
                Navigation.PushModalAsync(new KidsForm());
            };
            kids.GestureRecognizers.Add(kidsform);

            var addtocart = new TapGestureRecognizer();
            addtocart.Tapped += (s, e) =>
            {
                Navigation.PushModalAsync(new CartForm());
            };
            cart.GestureRecognizers.Add(addtocart);

            var addtocart2 = new TapGestureRecognizer();
            addtocart2.Tapped += (s, e) =>
            {
                Navigation.PushModalAsync(new CartForm());
            };
            cart2.GestureRecognizers.Add(addtocart2);

        }

        async void btnFP(object sender, EventArgs e)
        {         
                await Navigation.PushAsync(new FProducts());          
        }

        async void btnBSP(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BestSellerProdForm());
        }

        async void btnOSP(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OnSaleProductForm());
        }
    } 
}
