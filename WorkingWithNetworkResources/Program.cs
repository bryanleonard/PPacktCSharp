using System;
using System.Net;
using static System.Console;
using System.Net.NetworkInformation;

namespace WorkingWithNetworkResources
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Enter a valid web address: ");
            string url = ReadLine();
            if (string.IsNullOrWhiteSpace(url))
            {
                url = "http://world.episerver.com/cms/?q=pagetype";
            }

            var uri = new Uri(url);

            WriteLine($"Scheme: {uri.Scheme}");
            WriteLine($"Port: {uri.Port}");
            WriteLine($"Host: {uri.Host}");
            WriteLine($"Path: {uri.AbsolutePath}");
            WriteLine($"Query: {uri.Query}");

            WriteLine("");

            IPHostEntry entry = Dns.GetHostEntry(uri.Host);
            WriteLine($"{entry.HostName} has the following IP addresses:");
            foreach (IPAddress address in entry.AddressList)
            {
                WriteLine($" {address}");
            }

            WriteLine("");

            var ping = new Ping();
            PingReply reply = ping.Send(uri.Host);
            WriteLine($"{uri.Host} was pinged, and replied: {reply.Status}.");
            if (reply.Status == IPStatus.Success)
            {
                WriteLine($"Reply from {reply.Address} took { reply.RoundtripTime:N0} ms");
            }
        }
    }
}
