using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeFinder
{
    interface Assessment
    {
        string Description { get; set; }
        double Score { get; set; }
    }
}
