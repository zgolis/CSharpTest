using System;

namespace CSharpTest
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            string fileaddress = "";

            Console.WriteLine("Enter the file address:");
            fileaddress = Console.ReadLine();
            
            foreach (string line in System.IO.File.ReadLines(fileaddress)) {
                string[] str;
                str = line.Split(':');
                if (str[0] == "i") {
                    list.insert(str[1]);
                }else if (str[0] == "d") {
                    list.delete(str[1]);
                } else {
                    Console.WriteLine("Not either i or d, unknown command");
                }
            }
            list.PrintAll();
            Console.ReadLine();
        }
    }
}
