using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SearchProgram {
    class Index {
        internal static void createIndex(string dirPath, Dictionary<string, string> dc) {
            getFilesRecursive(dirPath, dc);
        }

        private static void getFilesRecursive(string dirPath, Dictionary<string, string> dc) {
            List<string> files = new List<string>();

            try {
            foreach (string d in Directory.GetDirectories(dirPath)) {
                getFilesRecursive(d, dc);
                }
            foreach (var file in Directory.GetFiles(dirPath)) {
                    DoAction(file, dc);
                }
              } catch (System.Exception e) {
                    Console.WriteLine(e.Message);
                }
        }

        private static void DoAction(string file , Dictionary<string, string> dc)
        {
            var fileStream = new FileStream(file, FileMode.Open, FileAccess.Read);
            Console.WriteLine("\nProcessing the file name" + file);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
               string[] words = streamReader.ReadToEnd().Split(' ');
               foreach(string word in words)
                {
                    //Console.WriteLine(word);
                    if (dc.Keys.Contains(word)) {
                        string fileNames = dc.FirstOrDefault(x => x.Key == word).Value;
                        fileNames  = fileNames + file;
                        dc.Remove(word);
                        dc.Add(word, fileNames);
                    }
                    else
                        dc.Add(word, file + "| 0");
                }
            }
 	        
        }

    }
}
