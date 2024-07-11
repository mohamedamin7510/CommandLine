using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9.List
{
    internal static class commands
    {

        /// <summary>
        /// he's return list of directories and files in the path
        /// </summary>
        /// <returns>string of files and directories</returns>
        public static void list(string path)
        {
            foreach (var items in Directory.GetDirectories(path))
            {
                Console.WriteLine("['dir']: " + items);
            }
            foreach (var items in Directory.GetFiles(path))
            {
                Console.WriteLine("['file']: " + items);
            }
            Console.WriteLine("here we go: [Salad from directory and files] ");
            foreach (var entites in Directory.GetFileSystemEntries(path))
            {
                Console.WriteLine(entites);
            }
        }
        public static void info(string path)
        {
            if (File.Exists(path))
            {
                var infofile = new FileInfo(path);
                Console.WriteLine("Type: File");
                Console.WriteLine($"Full name of file: {infofile.FullName}");
                Console.WriteLine("create time: " + infofile.CreationTime);
                Console.WriteLine("last modfied time: " + infofile.LastWriteTime);
                Console.WriteLine("Size of file: " + infofile.Length);
            }
            else if (Directory.Exists(path))
            {
                var infodir = new DirectoryInfo(path);
                Console.WriteLine("Type: dir");
                Console.WriteLine("create time: " + infodir.CreationTime);
                Console.WriteLine("last modfied time: " + infodir.LastWriteTime);
            }
            else
            {
                Console.WriteLine("type not known");
            }


        }
        public static void mkdir(string path)
        {
            Directory.CreateDirectory(path);
        }
        public static void remove(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
                Console.WriteLine("'file is deleted'");
            }
            else if (Directory.Exists(path))
            {
                try 
                { 
                    Directory.Delete(path);
                }catch (Exception err)
                {
                    Console.WriteLine(err.Message); 
                }
            }
            else { Console.WriteLine("rewrite the path"); }
        }

        public static void read(string path)
        {
            StreamReader line = new StreamReader(path);
            string Data;
            while ((Data = line.ReadLine()) != null) 
            {
                Console.WriteLine(Data);   
            }

        }public static void type(string path)
        {
            File.CreateText(path);   
            
        }



    }
}
