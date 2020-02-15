using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program {
    class Program {
        public static char cipher (char ch, int key) {
            if (!char.IsLetter (ch)) {

                return ch;
            }

            char d = char.IsUpper (ch) ? 'A' : 'a';
            return (char) ((((ch + key) - d) % 26) + d);

        }

        public static string Encipher (string input, int key) {
            string output = string.Empty;

            foreach (char ch in input)
                output += cipher (ch, key);

            return output;
        }

        public static string Decipher (string input, int key) {
            return Encipher (input, 26 - (2 * key));
        }

        static void Main (string[] args) {

            int key;

            System.Console.WriteLine ("Insira a mensagem");
            string UserString = Console.ReadLine ();
            System.Console.WriteLine ("Insira a chave");
            key = int.Parse (Console.ReadLine ());

            Console.WriteLine ("Mensagem criptografada");

            string cipherText = Encipher (UserString, key);
            Console.WriteLine (cipherText);
            Console.Write ("\n");

            Console.WriteLine ("Mensagem descriptografada");

            string t = Decipher (cipherText, key);
            Console.WriteLine (t);
            Console.Write ("\n");
        }

    }
}