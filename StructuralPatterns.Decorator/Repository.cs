using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Decorator
{
    public class Repository : IRepository
    {
        public void Add(string item)
        {
            Console.WriteLine($"{item} added.");
        }

        public void Delete(string item)
        {
            Console.WriteLine($"{item} deleted.");
        }

        public string Find(string item)
        {
            return $"{item} found";
        }
    }
}
