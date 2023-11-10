using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Adapter
{
    public class XMLType
    {
        public string resourceType;
        public XMLType(string _resourceType)
        {
            resourceType = _resourceType;
        }

    }
}
