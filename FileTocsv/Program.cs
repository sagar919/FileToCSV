
using System;
using CsvHelper;
using System.IO;
using System.Globalization;

namespace FileTocsv
{
    class Program
    {
        static void Main(string[] args)
        {
            var csvPath = Path.Combine(Environment.CurrentDirectory, @"C:\Users\slad\source\repos\FileTocsv\FileTocsv\Utility\Address.csv");
            using (var streamWriter = new StreamWriter(csvPath))
            {
                using (var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture))
                {
                    var rockets = AddressInfo.GetAddress();
                    csvWriter.Context.RegisterClassMap<AddressInfoClassMap>();
                    csvWriter.WriteRecords(rockets);
                }
            }
        }
    }
}
