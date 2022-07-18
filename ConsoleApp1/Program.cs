using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"D:\ASP.NET Web API\ConsoleApp1\ConsoleApp1\bin\";
            string destination = @"D:\test\";
            string[] files = Directory.GetFiles(rootPath, "*", SearchOption.AllDirectories);
            /*foreach (string dirPath in dir)
            {
                Console.WriteLine(Path.GetFileName(dirPath));
            }*/
            //Console.WriteLine(Path.GetFileName(dir[3]));

            /*using (var client = new WebClient())
            {
                client.DownloadFile("https://thumbs.dreamstime.com/z/lord-ganesha-dancing-6439542.jpg", "Ganesh.jpg");
            }*/
            File.Copy(files[3], $"{destination}{Path.GetFileName(files[3])}");
            Console.ReadKey();
        }
    }
}
