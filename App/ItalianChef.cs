using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    //Subclass
    class ItalianChef : Chef
    {
        public override void MakeSpacialDish()
        {
            Console.WriteLine("The Chef makes Pizza");
        }
        public void MakePasta()
        {
            Console.WriteLine("The ItalianChef makes Pasta");
        }
    }
}
