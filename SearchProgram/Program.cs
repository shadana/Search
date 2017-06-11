using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchProgram {
    class Program {
        static void Main(string[] args) {
            String choice = String.Empty;
            String dirName = String.Empty;
            String searchText = String.Empty;
            Dictionary<string, string> dc = new Dictionary<string, string>();
             do {
                Console.WriteLine("\n\t\t\tWELCOME TO THE INDEX SEARCH !\t\t\t\n");
                Console.WriteLine("\n1.Create Index");
                Console.WriteLine("\n2.Search text");
                Console.WriteLine("\n2.Exit");
                Console.WriteLine("\nPlease choose an option\n\n");
                choice = Console.ReadLine();
                switch (Int32.Parse(choice)) {
                    case 1:
                        Console.WriteLine("Please enter the path which has to be indexed");
                        //dirName = Console.ReadLine();
                        dirName = "D:\\Program\\redis-unstable\\src";
                        Index.createIndex(dirName, dc);
                        break;
                    case 2:
                        Console.WriteLine("Please enter the text to be searched");
                        searchText = Console.ReadLine();
                        Search.searchText(searchText, dc);
                        break;
                    case 3:
                        
                        break;
                    default:
                        Console.WriteLine("\nPlease enter the correct input");
                        break;
                    }
                }while (choice != "3");
         }

    }
}

