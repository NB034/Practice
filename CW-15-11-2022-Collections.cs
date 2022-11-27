using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    //1.Подсчитать, сколько раз каждое слово встречается в заданном тексте.Результат записать в коллекцию
    //Dictionary<TKey, TValue>. Результат вывести на экран
    //Текст:
    //"Вот дом, Который построил Джек. А это пшеница, Которая в темном чулане хранится В доме, Который построил
    //Джек.А это веселая птица­синица, Которая часто ворует пшеницу, Которая в темном чулане хранится В доме,
    //Который построил Джек".

    //2.Создать примитивный англо-русский и русско-английский словарь, содержащий пары слов — названий
    //стран на русском и английском языках
    //Пользователь должен иметь возможность выбирать направление перевода и запрашивать перевод
    internal class WordsCounter
    {
        Dictionary<string, int> result = new Dictionary<string, int>();
        string str = "Вот дом, Который построил Джек. " +
            "А это пшеница, Которая в темном чулане хранится В доме, Который построил " +
            "Джек.А это веселая птица­синица, Которая часто ворует пшеницу, Которая в темном чулане хранится В доме, " +
            "Который построил Джек";
        public Dictionary<string, int> Count()
        {
            List<string> words = str.Split(new char[] { ' ', '.', ',' },
                StringSplitOptions.RemoveEmptyEntries).ToList<string>();
            foreach (string word in words)
            {
                string key = word.ToLowerInvariant();
                if (result.ContainsKey(key))
                    result[key] = ++result[key];
                else
                    result.Add(key, 1);
            }
            return result;
        }

        public void Print()
        {
            foreach (var pair in result)
                Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }

    internal class CountriesDictinary
    {
        Dictionary<string, string> dict = new Dictionary<string, string>();
        public void Load()
        {
            dict.Add("россия", "russia");
            dict.Add("казахстан", "kazakhstan");
            dict.Add("германия", "german");
            dict.Add("сша", "usa");
            dict.Add("япония", "japan");
        }
        public void RequestTranslationToConsole()
        {
            char ch;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1 - На английский\n2 - To russian");
                ch = Console.ReadKey().KeyChar;
                Console.Clear();
                if (ch == '1' || ch == '2')
                    break;
            }
            Console.Clear();
            Console.Write("Enter the word: ");
            string str = Console.ReadLine();
            Console.Clear();
            switch (ch)
            {
                case '1':
                    if (dict.ContainsKey(str.ToLowerInvariant()))
                        Console.WriteLine($"{str} - {dict[str]}");
                    else
                        Console.WriteLine("Translation was not found.");
                    break;
                case '2':
                    if (dict.ContainsValue(str.ToLowerInvariant()))
                        Console.WriteLine($"{str} - {dict.FirstOrDefault(val => val.Value == str.ToLowerInvariant()).Key}");
                    else
                        Console.WriteLine("Перевод не был найден.");
                    break;
            }
        }
    }
}