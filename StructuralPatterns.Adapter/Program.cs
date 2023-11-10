// See https://aka.ms/new-console-template for more information

using StructuralPatterns.Adapter;
using StructuralPatterns.Adapter.Adaptees;
using StructuralPatterns.Adapter.Adapters;

var xmlData1 = new XMLType("origional XML");
ShowReport(xmlData1);


var jsonData = new JsonType();
var jsonAdapter = new JsonAdapter();
var xmlData2 = jsonAdapter.ConvertJsonToXML(jsonData);
ShowReport(xmlData2);


var csvData = new CSVType();
var csvAdapter = new CSVAdapter();
var xmlData3 = csvAdapter.ConvertCSVtoXML(csvData);
ShowReport(xmlData3);

Console.ReadKey();



void ShowReport(XMLType data)
{
    //do operations with XML type data
    Console.WriteLine($"Report prepared with {data.resourceType} data source");
}
