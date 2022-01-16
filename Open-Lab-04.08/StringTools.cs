using System;
using System.Collections.Generic;

namespace Open_Lab_04._08
{
    public class StringTools
    {
        public string[] IsFourLetters(string[] strings)
        {
            var chosenStrings = new List<string>();
            foreach (string str in strings)
            {
            if (str.Length == 4)
                {
                    chosenStrings.Add(str);
                }
            }
            return chosenStrings.ToArray();
        }
    }
}
