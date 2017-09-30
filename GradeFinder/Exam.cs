using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeFinder
{
    class Exam :Assessment 
    {
        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private double score;

        public double Score
        {
            get { return score; }
            set { score = value; }
        }

        private bool isScored;
        public bool IsScored
        {
            get { return isScored; }
            set { isScored = value; }
        }

    }
}
