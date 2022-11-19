using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    //  Задание 2. Программа «Анализатор кода»
    //  Прочитать текст C#-программы (выбрать самостоятельно)
    //  и все слова public в объявлении полей классов заменить на слово private. 
    //  В исходном коде в каждом слове длиннее двух символов все строчные символы заменить прописными. 
    //  Также в коде программы удалить все «лишние» пробелы и табуляции, оставив только необходимые для разделения операторов. 
    //  Записать символы каждой строки программы в другой файл в обратном порядке.

    // Все методы класса проверил - работают правильно
    internal class ClassThatMessesUpCode
    {
        private string code = null;

        public ClassThatMessesUpCode()
        {
            try
            {
                LoadCode();
                MessUp();
                WriteCode();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void LoadCode()
        {
            using (FileStream fs = new FileStream("CW-18-11-2022-Stream-1.cs", FileMode.Open, FileAccess.Read))
            using (StreamReader sr = new StreamReader(fs))
            {
                code = sr.ReadToEnd();
            }
        }

        private void WriteCode()
        {
            using (FileStream fs = new FileStream("CW-18-11-2022-Stream-Messed-up.cs", FileMode.Create))
            using (StreamWriter sr = new StreamWriter(fs))
            {
                sr.Write(code);
            }
        }

        private void MessUp()
        {
            code = code.Replace("public", "private");
            ChangeRegisterAlternative();
            RemoveSpacesAndTabs();
            ReverseLines();
        }

        private void ChangeRegister()
        {
            string str = ";:.,? \t\n+=-*/$%<>()[]{}";
            for (int i = 0; i < code.Length; i++)
            {
                if (!str.Contains(code[i]))
                {
                    int j = code.IndexOfAny(str.ToCharArray(), i + 1);
                    if (j != -1 && j - i > 2)
                    {
                        code = code.Replace(code.Substring(i, j - i), code.Substring(i, j - i).ToUpper());
                        i = j;
                    }
                }
            }
        }

        private void ChangeRegisterAlternative()
        {
            List<char> list = new List<char>(code);
            for (int i = 0; i < code.Length; i++)
            {
                if (Char.IsLetter(code[i]))
                {
                    int j = list.FindIndex(i + 1, (char ch) => !Char.IsLetter(ch));
                    if (j != -1 && j - i > 2)
                    {
                        code = code.Replace(code.Substring(i, j - i), code.Substring(i, j - i).ToUpper());
                        i = j;
                    }
                }
            }
        }

        private void RemoveSpacesAndTabs()
        {
            StringBuilder sb = new StringBuilder();
            bool isRow = false;
            for (int i = 0; i < code.Length; i++)
            {
                if (code[i] == ' ' || code[i] == '\t')
                {
                    if (!isRow)
                    {
                        sb.Append(code[i] == ' ' ? ' ' : '\t');
                        isRow = true;
                    }
                    continue;
                }
                isRow = false;
                sb.Append(code[i]);
            }
            code = sb.ToString();
        }

        private void ReverseLines()
        {
            StringBuilder sb = new StringBuilder();
            string[] lines = code.Split('\n');
            foreach(string line in lines)
            {
                sb.Append(new string(line.Reverse().ToArray()));
            }
            code = sb.ToString();
        }
    }
}