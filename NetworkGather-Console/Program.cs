using System;
using System.Net;
using Console = Colorful.Console;
using System.Drawing;

namespace NetworkGather_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Title = "Network Gather || root-404#2770";
            Console.WriteLine(@"
 ███╗   ██╗███████╗████████╗ ██████╗ ██╗    ██╗██████╗ ██╗  ██╗     ██████╗  █████╗ ████████╗██╗  ██╗███████╗██████╗ 
 ████╗  ██║██╔════╝╚══██╔══╝██╔═══██╗██║    ██║██╔══██╗██║ ██╔╝    ██╔════╝ ██╔══██╗╚══██╔══╝██║  ██║██╔════╝██╔══██╗
 ██╔██╗ ██║█████╗     ██║   ██║   ██║██║ █╗ ██║██████╔╝█████╔╝     ██║  ███╗███████║   ██║   ███████║█████╗  ██████╔╝
 ██║╚██╗██║██╔══╝     ██║   ██║   ██║██║███╗██║██╔══██╗██╔═██╗     ██║   ██║██╔══██║   ██║   ██╔══██║██╔══╝  ██╔══██╗
 ██║ ╚████║███████╗   ██║   ╚██████╔╝╚███╔███╔╝██║  ██║██║  ██╗    ╚██████╔╝██║  ██║   ██║   ██║  ██║███████╗██║  ██║
 ╚═╝  ╚═══╝╚══════╝   ╚═╝    ╚═════╝  ╚══╝╚══╝ ╚═╝  ╚═╝╚═╝  ╚═╝     ╚═════╝ ╚═╝  ╚═╝   ╚═╝   ╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝
                                                                                                                    ", Color.White);



            _Network();
        }

        static void _Network()
        {


            string[] Net = new string[4];

            Net[0] = new WebClient().DownloadString("http://ipinfo.io/ip");
            Net[2] = new WebClient().DownloadString("http://ipinfo.io/country");
            Net[1] = new WebClient().DownloadString("http://ipinfo.io/city");
            Net[3] = new WebClient().DownloadString("http://ipinfo.io/region");


            Console.WriteLine("_____________________________", Color.Yellow);
            Console.WriteLine("");
            Console.WriteLine("IP: " + Net[0], Color.GhostWhite);
            Console.WriteLine("City: " + Net[3], Color.GhostWhite);
            Console.WriteLine("");
            Console.WriteLine("Region: " + Net[1], Color.GhostWhite);
            Console.WriteLine("");
            Console.WriteLine("Country: " + Net[2], Color.GhostWhite);
            Console.WriteLine("_____________________________", Color.Yellow);

            Console.ReadKey();

        }
    }
}
