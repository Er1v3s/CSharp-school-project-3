using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Artisan
{
    class Bed
    {
        private int width;
        private int footersHeight;
        private int mattress;

        public Bed(int getWidth, int getfootersHeight, int getMattress)
        {
            width = getWidth;
            footersHeight = getfootersHeight;
            mattress = getMattress;

        }
    }

    
}
