using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sneakladder
{
    internal class Rolldie
    {
        public void player()
        {
 
               Random random = new Random();
               int Die = random.Next(1, 6);
               Console.WriteLine($"Roll Die is : {Die}");
            
        }
    }
}
