using Course_Work;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Course_Work
{
    public partial class RegisterViewController : Form
    {
        public RegisterViewController()
        {
            InitializeComponent();
        }

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "y0F8Y2PZQZcrW8nyWw1B0I1n32sOLVq2zUYygd9i",
            BasePath = "https://testapp-e2de7-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        private void RegisterViewControllerLoad(object sender, EventArgs e)
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
            #region Condition
            if (string.IsNullOrWhiteSpace(firstNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(lastNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(emailTextBox.Text) ||
                !emailTextBox.Text.Contains("@") ||
                !emailTextBox.Text.Contains(".") ||
                string.IsNullOrWhiteSpace(passwordTextBox.Text) ||
                (passwordTextBox.Text.Length < 6))
            {

                MessageBox.Show("Please fill in all the fields ;d");
                return;
            }
            
            
            #endregion

            User user = new User(firstNameTextBox.Text, lastNameTextBox.Text, emailTextBox.Text, passwordTextBox.Text);
           
            string safeEmail = emailTextBox.Text.Replace('.', '_');

            SetResponse set = client.Set(@"Users/" + safeEmail, user);

            MessageBox.Show("Successfully registered!");

            Hide();
            LoginViewController loginViewController = new LoginViewController();
            loginViewController.Closed += (s, args) => Close();
            loginViewController.Show();
        }

        private void loginButtonClicked(object sender, EventArgs e)
        {
            Hide();
            LoginViewController loginViewController = new LoginViewController();
            loginViewController.Closed += (s, args) => Close();
            loginViewController.Show();
        }
    }
}


