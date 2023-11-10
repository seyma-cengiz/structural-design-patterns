using StructuralPatterns.Adapter.Adaptees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Adapter.Targets
{
    public interface IJsonAdapter
    {
        public XMLType ConvertJsonToXML(JsonType data);
    }
}
