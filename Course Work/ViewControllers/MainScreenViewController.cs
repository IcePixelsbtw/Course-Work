using FireSharp.Response;
using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting;

namespace Course_Work
{
    public partial class MainScreenViewController : Form
    {


        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "y0F8Y2PZQZcrW8nyWw1B0I1n32sOLVq2zUYygd9i",
            BasePath = "https://testapp-e2de7-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        public MainScreenViewController()
        {
            InitializeComponent();
        }

        private void MainScreenViewControllerLoad(object sender, EventArgs e)
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
        private void listButtonClicked(object sender, EventArgs e)
        {
            ResultsViewController resultsViewController = new ResultsViewController();
            resultsViewController.Closed += (s, args) => Close();
            resultsViewController.Show();
        }
        private void testButtonClicked(object sender, EventArgs e)
        {
   
            Hide();

            TestViewController testViewController = new TestViewController();
            testViewController.Closed += (s, args) => Close();
            testViewController.Show();

        }
    }
}
