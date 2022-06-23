using System;
using System.Collections.Generic;

namespace ListCreator
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter a number for the magic: ");
            string stringUserNum = Console.ReadLine();
            int intUserNum = int.Parse(stringUserNum);

            List<string> UserFilterList = new List<string>(0);
            for (int index = 1; index <= intUserNum; index++)
            {
                if (index % 15 == 0)
                {
                    UserFilterList.Add("Ping-Pong");
                } else if (index % 5 == 0){
                    UserFilterList.Add("Pong");
                } else if (index % 3 == 0){
                    UserFilterList.Add("Ping");
                } else {
                    UserFilterList.Add(index.ToString());
                }
            }

            foreach(string value in UserFilterList)
            {
              Console.WriteLine(value +",");
            }
        }
    }
}