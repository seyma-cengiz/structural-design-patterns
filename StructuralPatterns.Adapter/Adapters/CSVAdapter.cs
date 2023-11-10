using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructuralPatterns.Adapter.Adaptees;
using StructuralPatterns.Adapter.Targets;

namespace StructuralPatterns.Adapter.Adapters
{
    public class CSVAdapter : ICSVAdapter
    {
        public XMLType ConvertCSVtoXML(CSVType data)
        {
            data.DoOperation();
            //convert json to xml
            return new XMLType("XML converted from CSV");
        }
    }
}
