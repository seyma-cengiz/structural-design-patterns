using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Decorator
{
    public interface IRepository
    {
        void Add(string item);
        void Delete(string item);
        string Find(string item);
    }
}
