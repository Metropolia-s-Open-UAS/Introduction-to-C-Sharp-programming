using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static List<String> MySplit(string text, char seperator)
    {
        List<String> list = new List<String>();
        StringBuilder temp = new StringBuilder();
        foreach (char c in text)
        {
            if (c == seperator)
            {
                list.Add(temp.ToString());
                temp = new StringBuilder();
            }
            else
            {
                temp.Append(c);
            }
        }
        list.Add(temp.ToString());
        return list;
    }
    static string MyJoin(List<string> items, char separator)
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < items.Count; i++)
        {
            if (i > 0)
            {
                sb.Append(separator);
            }
            sb.Append(items[i]);
        }

        return sb.ToString();
    }
    static void Main(string[] arg)
    {
        Console.Write("Please enter sentence: ");
        string sentence = Console.ReadLine();

        List<string> words = MySplit(sentence, ' ');

        Console.WriteLine(MyJoin(words, ','));

        foreach (string word in words)
        {
            Console.WriteLine(word);
        }

    }
}
//using System;
//using System.Collections.Generic;

//namespace myFunctions
//{
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Please enter sentence: ");
//            var Sentence = Convert.ToString(Console.ReadLine());
//            Console.WriteLine(MyJoin(MySplit(Sentence, ' '), ','));
//            Console.WriteLine(MyJoin(MySplit(Sentence, ' '), '\n'));
//        }

// Put your code here

//    }
//}
