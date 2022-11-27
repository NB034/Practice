using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    internal class StreamPractice
    {
        int numbersCount = 5;
        string fileName = "binary.txt";

        public StreamPractice()
        {
            WriteToBinary();
            ReadFromBinary();
        }

        private void WriteToBinary()
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            using (BinaryWriter bw = new BinaryWriter(fs, Encoding.UTF8))
            {
                WriteNumbersToFile(bw);
                bw.Write("Hello ");
                WriteNumbersToFile(bw);
                bw.Write("world!" + Environment.NewLine);
            }
        }

        private void ReadFromBinary()
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            using (BinaryReader br = new BinaryReader(fs, Encoding.UTF8))
            {
                while (fs.Position < fs.Length)
                {
                    fs.Seek(sizeof(Int32) * numbersCount, SeekOrigin.Current);
                    Console.Write(br.ReadString());
                }
            }
        }

        private void WriteNumbersToFile(BinaryWriter bw)
        {
            Random rand = new Random();
            for (int i = 0; i < numbersCount; i++)
            {
                bw.Write(rand.Next(0, 10));
            }
        }
    }
}
