using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierPasAvecLINQ
{
    class Program
    {
        static void Main(string[] args)
        {

            //creation d'un tableau d'entiers stocké dans "tab"
            var tab = new int[]
            {
                4,2,6,13,42,58,77
            };
         /////////////////////////////////////   
            //synthaxe SQL 
            /////////////////////////////
            /*var pairs = from elt in tab
                        where elt % 2 == 0
                        select elt;*/
        //////////////////////////////////////

            //ou alors 
            //methode fonctionel avec Lambda 
            var pairs = tab.Where((elt) => elt % 2 == 0);

            foreach(var elt in pairs)
            {
                Console.WriteLine(elt);
            }
            Console.ReadLine();
        }
    }
}
