using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    public class Aluno
    {
        public int mediaa, mediab, mediac, mediad;
        public int media_a
        {
            set { this.mediaa = value; }
        }
        public int media_b
        {
            set { this.mediab = value; }
        }
        public int media_c
        {
            set { this.mediac = value; }
        }
        public int media_d
        {
            set { this.mediad = value; }
        }
        public int calculamedia
        {
            get { return (mediaa + mediab + mediac + mediad) / 4; }
        }
    }
}
