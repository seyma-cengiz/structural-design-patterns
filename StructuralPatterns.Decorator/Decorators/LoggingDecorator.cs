using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Decorator.Decorators
{
    public class LoggingDecorator : BaseDecorator
    {
        public LoggingDecorator(IRepository repository) : base(repository)
        {
        }

        public override void Add(string item)
        {
            Console.WriteLine("New item will add.");
            base.Add(item);
        }

        public override void Delete(string item)
        {
            Console.WriteLine("The item will delete.");
            base.Delete(item);
        }

        public override string Find(string item)
        {
            Console.WriteLine("The item is searching.");
            return base.Find(item);
        }
    }
}
