using EFCoreLesson2Task1.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EFCoreLesson2Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (EFCoreLesson2Task1.Context.AppContext db = new EFCoreLesson2Task1.Context.AppContext())
            {
                User u1 = new User { Name = "Alex", PassNo = "asdqwe123", UserInfo = new UserInfo { Address = "Ad1", City = "City1", Phone = "Phone1" } };
                User u2 = new User { Name = "Bob", PassNo = "dawafgtt23", UserInfo = new UserInfo { Address = "Ad2", City = "City2", Phone = "Phone2" } };
                User u3 = new User { Name = "Alice", PassNo = "sgt3455", UserInfo = new UserInfo { Address = "Ad3", City = "City3", Phone = "Phone3" } };

                db.Users.AddRange(u1, u2, u3);
                db.SaveChanges();

                List<User> users = db.Users.Include(u => u.UserInfo).ToList();

                foreach (User u in users)
                {
                    Console.WriteLine($"ID: {u.UserID}, Name: {u.Name}, Pass: {u.PassNo}, Address: {u.UserInfo.Address}, City: {u.UserInfo.City}");
                }

            }
        }
    }
}
