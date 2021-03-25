using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    public class ConverteMilhas
    {
        public double milhastemp;
        public double calculamilha
        {
            set { this.milhastemp = value; }
        }
        public double milhaprakm
        {
            get { return (double) milhastemp * 1.60934f; }
        }
    }
}
