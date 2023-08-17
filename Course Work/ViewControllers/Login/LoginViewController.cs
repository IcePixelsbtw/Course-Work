using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace Course_Work
{
    public partial class LoginViewController : Form
    {
        public static string firstName;
        public static string lastName;
   

        public LoginViewController()
        {
            InitializeComponent();
        }


        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "y0F8Y2PZQZcrW8nyWw1B0I1n32sOLVq2zUYygd9i",
            BasePath = "https://testapp-e2de7-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;


        private void LoginViewControllerLoad(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(ifc);

            }
            catch
            {
                MessageBox.Show("Connection problem occured");
            }

        }
        private void proceedButtonClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(emailTextBox.Text) ||
                !emailTextBox.Text.Contains("@") ||
                !emailTextBox.Text.Contains(".") ||
                string.IsNullOrWhiteSpace(passwordTextBox.Text) ||
                (passwordTextBox.Text.Length < 6))
            {

                MessageBox.Show("Please fill in all the fields ;d");
                return;
            }


            string safeEmail = emailTextBox.Text.Replace('.', '_');

            FirebaseResponse result = client.Get(@"Users/" + safeEmail);
            User ResultUser = result.ResultAs<User>();

            User CurrentUser = new User()
            {
                Email = emailTextBox.Text,
                Password = passwordTextBox.Text
            };

            firstName = ResultUser.FirstName;
            lastName = ResultUser.LastName;

            if (User.isEqual(ResultUser, CurrentUser))
            {
                Hide();
                MainScreenViewController msvc = new MainScreenViewController();
                msvc.Closed += (s, args) => Close();
                msvc.Show();
            }
            else 
            {
                MessageBox.Show("Ooooops... Some error occured ;d");
            }

        }

        private void registerViewButtonClicked(object sender, EventArgs e)
        {
            Hide();
            RegisterViewController registerViewController = new RegisterViewController();
            registerViewController.Closed += (s, args) => Close();
            registerViewController.Show();
        }
    }
}