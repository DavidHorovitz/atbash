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
        //Receives translated ciphertext, counts the number of dangerous words, returns both.   
        static string dangerousWords(string message)
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
            return message+ "       count of dangerous words: " +count;
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
            Console.WriteLine(dangerousWords("jhtkvyb bomb kjhg bomb"));
        }
    }
}
