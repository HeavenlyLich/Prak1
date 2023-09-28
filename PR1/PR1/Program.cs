using System;
using System.Text.RegularExpressions;

public class TextProcessor
{
    
    public string CheckLogin(string login)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        if (Regex.IsMatch(login, @"^[a-zA-Zа-яА-ЯіІїЇєЄ][a-zA-Z0-9а-яА-ЯіІїЇєЄ]{1,9}$"))
        {
            return "Допустимий логін";
        }
        else
        {
            return "Недопустимий логін";
        }
    }

    public string FilterWords(string text)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        text = Regex.Replace(text, "Коля", "Ігор", RegexOptions.IgnoreCase);
        text = Regex.Replace(text, "Колі", "Ігорю", RegexOptions.IgnoreCase);
        text = Regex.Replace(text, "Колю", "Ігоре", RegexOptions.IgnoreCase);
        text = Regex.Replace(text, "Колею", "Ігорем", RegexOptions.IgnoreCase);

        return text;
    }
}

public class Program
{

    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        TextProcessor processor = new TextProcessor();

        string login;
        do
        {
            Console.Write("Введіть логін або 'q' для виходу: ");
            login = Console.ReadLine();

            if (login.ToLower() != "q")
            {
                Console.WriteLine(processor.CheckLogin(login));
                Console.WriteLine(processor.FilterWords(login));
            }

        } while (login.ToLower() != "q");
    }
}
