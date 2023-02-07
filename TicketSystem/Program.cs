using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file = "ticket.txt";
            string choice;
            List<string> watchers = new List<string>();

            do
            {
                Console.WriteLine("1) Read data from file.");
                Console.WriteLine("2) Create file from data");
                Console.WriteLine("Enter any other key to exit");
                choice = Console.ReadLine();

                if (choice == "1")
                {

                    StreamReader sr = new StreamReader(file);

                    sr.ReadLine();
                    while (!sr.EndOfStream)
                    {
                        var line = sr.ReadLine();
                        string[] arr = line.Split(',');
                    }

                    sr.Close();

                }
                else if (choice == "2")
                {

                    StreamWriter sw = new StreamWriter(file);


                    Console.WriteLine("Enter a ticket (Y/N)?");
                    string resp = Console.ReadLine().ToUpper();
                    if (resp != "Y") { break; }

                    Console.WriteLine("Enter the ticket ID");
                    int id = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the summary");
                    string summary = Console.ReadLine();

                    Console.WriteLine("Enter the priority");
                    string priority = Console.ReadLine();

                    Console.WriteLine("who submitted the ticket");
                    string sub = Console.ReadLine();

                    Console.WriteLine("who is the ticket assigned to");
                    string assigned = Console.ReadLine();

                    Console.WriteLine("Add a watcher (Y/N)?");
                    string resp2 = Console.ReadLine().ToUpper();
                    do
                    {


                        Console.WriteLine("who is watching");
                        string input = Console.ReadLine();
                        watchers.Add(input);
                        var watchersArr = watchers.ToArray();
                        break;

                    } while (resp2 == "Y" || resp2 == "N");
                }
                else
                {
                    break;
                }
            } while (choice == "1" || choice == "2");
        }
    }
}

        
    

    

