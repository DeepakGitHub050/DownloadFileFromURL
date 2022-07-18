using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string link = "", FileName = "";
            XmlTextReader xtr = new XmlTextReader(@"D:\test\XMLFile1.xml");
            while(xtr.Read())
            {
                if(xtr.NodeType == XmlNodeType.Element & xtr.Name == "link") 
                {
                    string s1 = xtr.ReadElementContentAsString();
                    link = s1;
                }
                if (xtr.NodeType == XmlNodeType.Element & xtr.Name == "FileName")
                {
                    string s2 = xtr.ReadElementContentAsString();
                    FileName = s2;
                }
            }

            string rootPath = @"D:\ASP.NET Web API\ConsoleApp1\ConsoleApp1\bin\";
            string destination = @"D:\test\";
            string[] files = Directory.GetFiles(rootPath, "*", SearchOption.AllDirectories);

            using (var client = new WebClient())
            {
                client.DownloadFile(link,FileName);
            }
            File.Move(files[3], $"{destination}{Path.GetFileName(files[3])}");

            foreach (string file in files)
            {
                Console.WriteLine(Path.GetFileName(file));
            }
            Console.WriteLine(Path.GetFileName(files[3]));

            Console.ReadKey();
        }
    }
}
