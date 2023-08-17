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
    public partial class ResultsViewController : Form
    {
        ResultsList[] resultArray = null;


        public ResultsViewController()
        {
            InitializeComponent();
        }

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "y0F8Y2PZQZcrW8nyWw1B0I1n32sOLVq2zUYygd9i",
            BasePath = "https://testapp-e2de7-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        private void ResultsViewControllerLoad(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(ifc);

            }
            catch
            {
                MessageBox.Show("Connection problem occured");
            }
           
            FirebaseResponse response = client.Get("Results/");
            Dictionary<string, ResultsList> results = response.ResultAs<Dictionary<string, ResultsList>>();

            ResultsList[] rs = results.Values.ToArray();

            resultArray = rs;

            PopulateTable();
        }
        private void backButtonClicked(object sender, EventArgs e)
        {
            Hide();
            MainScreenViewController msvc = new MainScreenViewController();
            msvc.Closed += (s, args) => Close();
            msvc.Show();
        }


        private void PopulateTable()
        {
            // Create a DataTable object
            DataTable table = new DataTable();

            // Define the columns
            table.Columns.Add("First Name", typeof(string));
            table.Columns.Add("Last Name", typeof(string));
            table.Columns.Add("Result", typeof(int));

            for (int i = 0; i < resultArray.Count(); i++) {
                table.Rows.Add(resultArray[i].userFirstName, resultArray[i].userLastName, resultArray[i].userScore);
            }
            // Bind the DataTable to the DataGridView control
            resultsDataGrid.DataSource = table;
        }
    }
}

