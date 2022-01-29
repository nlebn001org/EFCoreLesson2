using EFCoreLesson2Task2.Context;
using Microsoft.EntityFrameworkCore;
using EFCoreLesson2Task2.Entites;
using System;
using System.Linq;
using System.Collections.Generic;

namespace EFCoreLesson2Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (AppCon db = new AppCon())
            {
                Company microsoft = new Company() { Name = "Microsoft" };
                Company google = new Company() { Name = "Google" };
                Worker w1 = new Worker() { Position = "C# Developer", Company = microsoft, WorkerInfo = new WorkerInfo() { Name = "Bob", Address = "Address1" } };
                Worker w2 = new Worker() { Position = "Designer", Company = google, WorkerInfo = new WorkerInfo() { Name = "Dan", Address = "Address2" } };
                Worker w3 = new Worker() { Position = "JS Dev", Company = microsoft, WorkerInfo = new WorkerInfo() { Name = "Nik", Address = "Address3" } };
                Worker w4 = new Worker() { Position = "Designer", Company = microsoft, WorkerInfo = new WorkerInfo() { Name = "Lol", Address = "Address4" } };
                Worker w5 = new Worker() { Position = "Java Dev", Company = google, WorkerInfo = new WorkerInfo() { Name = "Sergey", Address = "Address5" } };
                Worker w6 = new Worker() { Position = "JS Dev", Company = google, WorkerInfo = new WorkerInfo() { Name = "Alice", Address = "Address6" } };

                db.AddRange(w1, w2, w3, w4, w5, w6);
                db.SaveChanges();

                IOrderedEnumerable<Worker> workers = db.Workers.Include(w => w.Company).Include(w => w.WorkerInfo).ToList().OrderBy(w=>w.CompanyID);

                foreach (Worker w in workers)
                {
                    Console.WriteLine($"Company: {w.Company.Name}, Name: {w.WorkerInfo.Name}, Position: {w.Position}, Address: {w.WorkerInfo.Address}");
                }

            }

        }
    }
}
