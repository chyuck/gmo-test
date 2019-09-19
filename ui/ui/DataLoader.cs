using System.Collections.Generic;
using System.IO;
using System.Linq;
using CsvHelper;

namespace ui
{
    public static class DataLoader
    {
        public static IList<ProductDescription> LoadProductsFromFile()
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "ProductsDescriptions.csv");

            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader))
            {
                return csv.GetRecords<ProductDescription>().ToList();
            }
        }
    }
}
