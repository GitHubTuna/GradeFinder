using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeFinder
{
    class AssessmentHelper
    {
        //https://images.search.yahoo.com/yhs/search;_ylt=A0LEVjO37c9Z2ywAcesnnIlQ?p=letter+grade+score+chart&fr=yhs-mozilla-002&fr2=piv-web&hspart=mozilla&hsimp=yhs-002#id=2&iurl=http%3A%2F%2F4.bp.blogspot.com%2F_nxbkpa_H8hg%2FS8zHv3meUnI%2FAAAAAAAAACc%2FFHrMKFwl9CY%2Fs1600%2FGradingChart.JPG&action=click
        public string GetLetterGrade(double percentScore)
        {
            if (percentScore < 55)
            {
                return "E";
            }
            else if (percentScore < 70)
            {
                return "D";
            }
            else if (percentScore < 73)
            {
                return "C-";
            }
            else if (percentScore < 76)
            {
                return "C";
            }
            else if (percentScore < 79)
            {
                return "C+";
            }
            else if (percentScore < 82)
            {
                return "B-";
            }
            else if (percentScore < 85)
            {
                return "B";
            }
            else if (percentScore < 88)
            {
                return "B+";
            }
            else if (percentScore < 91)
            {
                return "A-";
            }
            else if (percentScore < 94)
            {
                return "A";
            }
            else
            {
                return "A+";
            }
        }
    }
}
