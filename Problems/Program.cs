using System;

namespace Problems
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        
        string Prefix(string input)
        {
            if (input == "")
            {
                return ("0,0:");
            }
            else
            {
                int iLength = input.Length;
                int iWords = 0;
                int count = 0;
                while (count < iLength)
                {
                    if (input[0] == ' ')
                    {
                        while (input[count + 1] == ' ')
                        {
                            count++;
                        }
                        count++;
                    }
                    if (input[count] ==' ')
                    {
                        iWords++;
                        while (input[count + 1] == ' ')
                        {
                            count++;
                        }
                    }
                    count++;
                }
                if (input[iLength - 1] != ' ')
                {
                    iWords++;
                }
                return (iLength.ToString() + "," + iWords.ToString() + ":" + input);
            }
            
        }
    }
}
