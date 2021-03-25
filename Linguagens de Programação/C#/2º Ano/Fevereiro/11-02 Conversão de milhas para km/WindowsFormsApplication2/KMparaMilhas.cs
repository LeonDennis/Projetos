using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    public class ConverteKM
    {
        public double kmtemp;
        public double calculakm
        {
            set { this.kmtemp = value; }
        }
        public double kmparamilha
        {
            

            get { return (double)kmtemp / 1.60934f; }
        }
    }
}
