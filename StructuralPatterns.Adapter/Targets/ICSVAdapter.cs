using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructuralPatterns.Adapter.Adaptees;

namespace StructuralPatterns.Adapter.Targets
{
    public interface ICSVAdapter
    {
        public XMLType ConvertCSVtoXML(CSVType data);

    }
}
