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
        Random rand = new Random();
        int numbers = 5;

        public StreamPractice()
        {
            WriteToBinary();
            ReadFromBinary();
        }

        private void WriteToBinary()
        {
            using (FileStream fs = new FileStream("binary.txt", FileMode.Create))
            using (BinaryWriter bw = new BinaryWriter(fs, Encoding.UTF8))
            {
                Ints(bw);
                bw.Write("Hello ");
                Ints(bw);
                bw.Write("world!\n");
            }
        }

        private void ReadFromBinary()
        {
            using (FileStream fs = new FileStream("binary.txt", FileMode.Open))
            using (BinaryReader bw = new BinaryReader(fs, Encoding.UTF8))
            {
                while (fs.Position != fs.Length)
                {
                    fs.Seek(sizeof(Int32) * numbers, SeekOrigin.Current);
                    Console.Write(bw.ReadString());
                }
            }
        }

        private void Ints(BinaryWriter bw)
        {
            for (int i = 0; i < numbers; i++)
            {
                bw.Write(rand.Next(0, 10));
            }
        }
    }
}
