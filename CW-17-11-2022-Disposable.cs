using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassWork
{
    internal class WordsCounter : IDisposable
    {
        private bool isDisposed = false;
        private Dictionary<string, int> result = new Dictionary<string, int>();
        private FileStream fs = null;
        private string path = "Test.txt";
        private string str = "Вот дом, Который построил Джек. " +
                "А это пшеница, Которая в темном чулане хранится В доме, Который построил " +
                "Джек.А это веселая птица­синица, Которая часто ворует пшеницу, Которая в темном чулане хранится В доме, " +
                "Который построил Джек";

        public WordsCounter()
        {
            CreateFile();
            Count();
            Print();
        }

        private void CreateFile()
        {
            using (FileStream newFile = new FileStream(path, FileMode.Create))
            using (StreamWriter sw = new StreamWriter(newFile))
            {
                sw.Write(str);
            }
        }

        private void Count()
        {
            try
            {
                fs = new FileStream(path, FileMode.Open);
                using (StreamReader sr = new StreamReader(fs))
                {
                    string str = sr.ReadToEnd();
                }
                List<string> words = str.Split(new char[] { ' ', '.', ',' },
                    StringSplitOptions.RemoveEmptyEntries).ToList<string>();

                foreach (string word in words)
                {
                    string key = word.ToLowerInvariant();

                    if (result.ContainsKey(key))
                        result[key]++;
                    else
                        result.Add(key, 1);
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                fs.Dispose();
            }
        }

        private void Print()
        {
            foreach (var pair in result)
                Console.WriteLine($"{pair.Key}: {pair.Value}");
        }

        public void Dispose()
        {
            Cleaning(true);
            GC.SuppressFinalize(this);
        }

        private void Cleaning(bool disposing)
        {
            if (!isDisposed)
            {
                if (disposing)
                {
                    fs.Dispose();
                }
            }
            isDisposed = true;
        }

        ~WordsCounter()
        {
            Cleaning(false);
        }
    }
}
