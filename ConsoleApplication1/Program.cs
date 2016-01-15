using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Models;
using ConsoleApplication1.Context;
using System.Data.Entity;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Message");
            string userInput = Console.ReadLine();
            Console.WriteLine("Thank You. Your Message Has Now Been Posted.");
            Console.WriteLine("                            ..........EXITING.............");
            using (var database = new ConsoleApplicationContext())
            {
                database.Posts.Add(new Post { Message = userInput, TimeStamp = DateTime.Now.ToLongTimeString(), PostId = 1});
                database.SaveChanges();
            }
        }
    }
}


