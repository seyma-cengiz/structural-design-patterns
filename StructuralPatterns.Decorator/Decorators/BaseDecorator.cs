using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Decorator.Decorators
{
    public abstract class BaseDecorator : IRepository
    {
        private readonly IRepository _repository;

        public BaseDecorator(IRepository repository)
        {
            _repository = repository;
        }

        public virtual void Add(string item)
        {
            _repository.Add(item);
        }

        public virtual void Delete(string item)
        {
            _repository.Delete(item);
        }

        public virtual string Find(string item)
        {
            return _repository.Find(item);
        }
    }
}
