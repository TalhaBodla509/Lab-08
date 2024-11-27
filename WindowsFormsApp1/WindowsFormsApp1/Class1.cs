using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Validate
    {
        public void checkName(string n)
        {
            if (n.Length>12)
            {
                throw new Exception("Name exceeds required letters");


            }
        }
    }
}
