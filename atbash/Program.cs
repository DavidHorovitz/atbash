using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace atbash
{
    internal class Program
    {
        static string deciptedTxt(string txt)
        {
            List<char> incript = new List<char>();
            string decripted = "";
            string newtxt = txt.ToLower();
            
            foreach (char c in newtxt)
            {
                incript.Add(c);
            }
            for (int i = 0; i < incript.Count; i++) 
            {
                
                if (incript[i] >= 'a' && incript[i] <= 'z')
                {
                    string decript = char.ConvertFromUtf32(122 - (incript[i] - 97));
                    decripted += decript;

                }
                else
                {
                    decripted += incript[i];
                }

                
                    


            }
            return decripted;
                
            //{

            //if (newtxt[i] == 'a')
            //{
            //    string a = newtxt.Replace('a', 'z');
            //    decript.Add(a);
            //}
            //else if (newtxt[i] == 'b') ;
            //{
            //    string a = newtxt.Replace('b', 'y');
            //    decript.Add(a);
            //}


        }
        
        //Receives translated ciphertext, counts the number of dangerous words, returns both.   
        static (string,int) dangerousWords(string message)
        {
            int count = 0;  
            string[] messageList = message.Split(' '); 
            string[] dangerousWords = { "bomb", "nukhba", "fighter", "rocket", "secret" }; // List of dangerous words
            foreach (string word in messageList)
            {
                foreach (string dangerous in dangerousWords)
                {
                    if(word == dangerous)
                    {
                        count++;
                    }
                }
            }
            return (message,count);
        }

        //Writes a message according to the risk level and prints everything
        static void riskLevel(string message, int sumWords)
        {
            string levelOfRisk;

            if (sumWords > 0 && sumWords < 6)
            {
                levelOfRisk = "WARNING";
            }
            else if (sumWords >= 6 && sumWords < 11)
            {
                levelOfRisk = "DANGER!";
            }
            else if (sumWords >= 11 && sumWords < 16)
            {
                levelOfRisk = "ULTRA ALERT!";
            }
            else
            {
                levelOfRisk = "UNKNOWN RISK";
            }

            Console.WriteLine("The decrypted message is: " + message);
            Console.WriteLine("The warning is: " + levelOfRisk);
            Console.WriteLine("Sum of dangerous words: " + sumWords);
        }










        static void Main(string[] args)
        {
           string david= deciptedTxt("Lfi ulixvh ziv kivkzirmt uli z nzqli zggzxp lm gsv Arlmrhg vmvnb.\r\nGsv ilxpvg fmrgh ziv ivzwb zmw dzrgrmt uli gsv hrtmzo.\r\nYlnyh szev yvvm kozxvw mvzi pvb olxzgrlmh.\r\nMfpsyz urtsgvih ziv hgzmwrmt yb uli tilfmw rmurogizgrlm.\r\nGsv zggzxp droo yv hfwwvm zmw hgilmt -- gsvb dlm’g hvv rg xlnrmt.\r\nDv nfhg hgzb srwwvm zmw pvvk gsv kozm hvxivg fmgro gsv ozhg nlnvmg.\r\nErxglib rh mvzi. Hgzb ivzwb.");
            var  (message, count) = dangerousWords(david);
            riskLevel(message, count);
        }
    }
}
