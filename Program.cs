using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Makarevic";
            string surname = "Maksim";
            Console.WriteLine(name + ' ' + surname);
            string bufferName;
            bufferName = name;
            name = surname;
            surname = bufferName;
            Console.WriteLine(name + ' ' + surname);           
        }
    }
}
