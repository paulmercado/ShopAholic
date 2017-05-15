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
    public partial class RegisterForm : ContentPage
    {
        public RegisterForm()
        {
            InitializeComponent();

            Picker.Items.Add("Female");
            Picker.Items.Add("Male");
        }

        async void btnSignUp(object sender, EventArgs e)
        {
            if (txtUsername.Text == null || txtPassword.Text == null || txtRePassword.Text == null ||
                txtFname.Text == null || Picker.Items == null || txtAddress.Text == null ||
                txtContact.Text == null || txtEmail.Text == null)
                 {
                    await DisplayAlert("Please fill-up all fields!", "", "OK");
                 }
            else if (txtPassword.Text != txtRePassword.Text)
            {
                await DisplayAlert("Password not match!", "", "OK");
            }
            else
                 {
                     await DisplayAlert("Sucessfully Registered!", "", "OK");
                     txtUsername.Text = ""; txtPassword.Text = ""; txtRePassword.Text = "";
                     txtFname.Text = ""; Picker.Items.Clear();
                     txtAddress.Text = ""; txtContact.Text = ""; txtEmail.Text = "";

                await Navigation.PushAsync(new LoginForm());
                                           
                 }
        }

        void txtPasswordRestrict(object sender, EventArgs e)
        {
            String pass = txtPassword.Text;

            if (pass.Length > 8)
            {
                txtPassword.Text = "";
                DisplayAlert("Password is too long!", "", "OK");
            }         
        }

        void txtPasswordRestrict1(object sender, EventArgs e)
        {
            String repass = txtRePassword.Text;

            if (repass.Length > 8)
            {
                txtRePassword.Text = "";
                DisplayAlert("Password is too long!", "", "OK");
            }
        }

        private void txtRePassword_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
