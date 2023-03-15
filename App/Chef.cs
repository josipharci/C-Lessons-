using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{   
     //Inheritance
     //SuperClass
     class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("The Chef makes chicken");
        }

        public void MakeSalad()
        {
            Console.WriteLine("The Chef makes Salad");
        }

        public virtual void MakeSpacialDish()
        {
            Console.WriteLine("The Chef makes bbq ribs");
        }
    }
}
