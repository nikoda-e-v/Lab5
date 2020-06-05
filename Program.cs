using System;
using System.IO;

namespace lab5
{
    public class Program
    {


        public static string encrypt(string adress)
        {
            string text = File.ReadAllText(adress);
            string newText = "";

            for(int i = 0; i < text.Length; i++)
            {
                int code = (int)text[i];
                code += 5;
                newText += (char)code;
            }
            return newText;
        }

        public static string decrypt(string text)
        {
            string newText = "";
            for (int i = 0; i < text.Length; i++)
            {
                int code = (int)text[i];
                code -= 5;
                newText += (char)code;
            }

            return newText;
        }

        static void Main(string[] args)
        {
          
        }
    }
}
