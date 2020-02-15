// using System;
// using System.Collections.Generic;
// using System.Security.Cryptography;
// using System.Text;

// namespace ExemploPrograma
// {
//     class Program{
//         void Main (string[] args) {

//             string text = "microsoft is not the answer. microsoft is the question. \"no\" is the answer. unknown";
//             string computedshaMash = ComputedshaMash(text);
//                 Console.WriteLine(computedshaMash);

//             Console.ReadLine();
//             }
//             private static string ComputedshaMash(string input) {
//                 StringBuilder stringBuilder = new StringBuilder();
//                 byte[] textBytes = Encoding.ASCII.GetBytes(input);
//                 using (MD5 md5 = MD5.Create()) {
//                     byte[] computeHash = md5.ComputeHash(textBytes);
//                     for (int i = 0; i < computeHash.Length; i++) {
//                         stringBuilder.Append(computeHash[i].ToString("x2"));
//                     }
//                 }
//                 return stringBuilder.ToString();
//             }
//         }
//     }

    

        

   
