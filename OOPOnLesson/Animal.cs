using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace OOPOnLesson
{
    public class Animal
    {
        public void ShowMe()
        {
            Console.WriteLine();


            Meva meva = new Meva();

            Console.WriteLine(meva.Name);
        }
    }
}
