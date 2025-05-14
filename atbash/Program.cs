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

        static string dangerousWords(string message)
        {
            int count = 0;  
            string[] messageList = message.Split(' '); // Split the message into words
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
            return message+ "       count of dangerousWords: " +count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(  dangerousWords("jhtkvyb bomb kjhg bomb"));
        }
    }
}
