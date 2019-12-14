using System;
using System.Collections.Generic;

namespace SimpleTextEditor
{
    class StartUp
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            string text = "";

            Stack<string> textContainer = new Stack<string>();

            //textContainer.Push(text);

            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();

                switch (command[0])
                {
                    case '1':
                        textContainer.Push(text);
                        text = text + command.Substring(2);
                        break;

                    case '2':
                        textContainer.Push(text);
                        text=text.Remove(text.Length - int.Parse(command.Substring(2)));
                        break;
                    case '3':
                        Console.WriteLine(text[int.Parse(command.Substring(2))-1]);
                        break;
                    case '4':
                        text = textContainer.Pop();
                        break;
                }
            }

        }
    }
}
