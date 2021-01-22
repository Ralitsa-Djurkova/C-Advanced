﻿using System;
using System.Collections.Generic;

namespace DictionaryExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> users = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string userName = Console.ReadLine();

                users.Add(userName);
            }

            foreach (var name in users)
            {
                Console.WriteLine(name);
            }
        }
    }
}
