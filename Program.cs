using ConsoleApp9.List;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.IO;
using System.ComponentModel.Design;



namespace CommandLine_CLI_
{
    internal class Program
    {


        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(">> ");
                var input = Console.ReadLine().Trim();//mohamed 
                var whitespace = input.IndexOf(' ');
                var command = input.Substring(0, whitespace).ToLower();
                var path = input.Substring(whitespace + 1).Trim();
                if (command=="list")
                {
                    commands.list(path);
                }
                else if (command=="info")
                {
                    commands.info(path);
                }
                else if(command=="mkdir")
                {
                    commands.mkdir(path);                 
                }
                else if (command=="remove")
                {
                   commands.remove(path);
                 
                }
                else if (command=="read")
                {
                    commands.read(path);
                
                } else if (command=="type")
                {
                    commands.type(path);
                
                }
                
            }

           
        }
        

    }
}
