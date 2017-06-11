using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchProgram {
    class Search {

        internal static void searchText(string searchText, Dictionary<string, string> dc) {
            if (dc.Keys.Contains(searchText)) {
                string fileNames = dc.FirstOrDefault(x => x.Key == searchText).Value;
                string rank = fileNames.Substring(fileNames.LastIndexOf('|') + 1);
                int rankNumber = Int32.Parse(rank);
                rankNumber =  rankNumber + 1;
                dc.Remove(searchText);
                dc.Add(searchText, fileNames + "|" +  rankNumber);

                string newValues = fileNames.Substring(0, fileNames.LastIndexOf('|'));
                Console.WriteLine("The word is present in" + newValues + " with rank " +rankNumber);
            }
        }
    }
}
