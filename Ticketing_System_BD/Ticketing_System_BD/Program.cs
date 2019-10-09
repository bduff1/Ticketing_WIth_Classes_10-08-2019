using System;
using System.IO;

namespace TicketingSystemFile
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string file = "ticketData.txt";
            string choice;
            do
            {
                // ask user a question
                Console.WriteLine("1) Read data from file.");
                Console.WriteLine("2) Create file from data.");
                Console.WriteLine("Enter any other key to exit.");
                // input response
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    if (File.Exists(file))
                    {

                        // read data from file
                        StreamReader sr = new StreamReader(file);
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            // convert string to array
                            string[] arr = line.Split('|');
                            // display array data
                            Console.WriteLine("Ticket ID: {0}, Summary: {1}, Status: {2}, Priority: {3}, Submitter: {4}, Assigned: {5}, Watching: {6}"
                                , arr[0], arr[1], arr[2], arr[3], arr[4], arr[5], arr[6]);


                        }

                    }
                    else
                    {
                        Console.WriteLine("File does not exist");
                    }

                }
                else if (choice == "2")
                {
                    // create file from data
                    StreamWriter sw = new StreamWriter(file);
                    for (int i = 0; i < 7; i++)
                    {
                        // ask a question
                        Console.WriteLine("Create New Ticket? (Y/N)?");
                        // input the response
                        string resp = Console.ReadLine().ToUpper();
                        // if the response is anything other than "Y", stop asking
                        if (resp != "Y") { break; }
                        // prompt for ticket id
                        Console.WriteLine("Enter Ticket ID.");
                        // save the ticket id 
                        string id = Console.ReadLine();
                        // prompt for ticket summary
                        Console.WriteLine("Enter Summary of Issue.");
                        // save the summary
                        string issue = Console.ReadLine();
                        //prompt for status
                        Console.WriteLine("Enter Status.");
                        //save status
                        string status = Console.ReadLine();
                        // prompt for priority
                        Console.WriteLine("Enter Priority.");
                        // save priority
                        string priority = Console.ReadLine();
                        //prompt for submitter
                        Console.WriteLine("Enter Submitter.");
                        // save submitter
                        string submitter = Console.ReadLine();
                        // prompt for assigned
                        Console.WriteLine("Enter Name of Personel Assigned.");
                        // save assigned 
                        string assigned = Console.ReadLine();
                        // prompt for watching
                        Console.WriteLine("Enter Name of Personel Watching.");
                        // save watching 
                        string watching = Console.ReadLine();


                        string final = Console.ReadLine();
                        sw.WriteLine("{0}|{1}|{2}|{3}|{4}|{5}|{6}", id, issue, status, priority, submitter, assigned, watching);





                    }
                    sw.Close();
                    Console.ReadLine();
                }
            } while (choice == "1" || choice == "2");

        }
    }
}
