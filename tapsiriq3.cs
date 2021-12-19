using System;

namespace ConsoleApp11
{
    class GFG
    {


        static bool isWordPresent(String sentence, String word)
        {

            String[] s = sentence.Split(' ');


            foreach (String temp in s)
            {


                if (temp.CompareTo(word) == 0)
                {
                    return true;
                }
            }
            return false;
        }


        public static void Main(String[] args)
        {
            String s = "Geeks for Geeks";
            String word = "Geeks";

            if 

                (!isWordPresent(s, word))
                Console.Write("No"); 
            else
                Console.Write("Yes");
        }
    }


    
}
