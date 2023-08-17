using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Work
{
    internal class ResultsList
    {
        public ResultsList(string userFirstName, string userLastName, int userScore) 
        {
        this.userLastName = userLastName;
        this.userFirstName = userFirstName;
        this.userScore = userScore;
        }

        public string userFirstName { get; set; }
        public string userLastName { get; set; }
        public int userScore { get; set; }

    }
}
