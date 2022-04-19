using _20aprel_task_.Data.DAL;
using _20aprel_task_.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _20aprel_task_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    Stadion stadion = new Stadion();

            //    stadion.Name = "Test1";
            //    stadion.HourPrice = 20;
            //    stadion.Capacity = 5;

            //    AddStadion(stadion);
            //foreach (var item in GetAllStadion())
            //{
            //    Console.WriteLine(item.Name);
            //}
            //User user=new User();
            //user.FullName = "Shukran Shirinov";
            //user.Email = "sukran@mail.ru";
            //AddUser(user);

        }
        public static void AddStadion(Stadion stadion)
        {
            using(FootballDbContext dbContext= new FootballDbContext())
            {
                dbContext.Stadions.Add(stadion);
                dbContext.SaveChanges();
            }
        }
        public static List<Stadion> GetAllStadion()
        {
            using (FootballDbContext dbContext = new FootballDbContext())
            {
                return dbContext.Stadions.ToList();
            }
        }
        public static void AddUser(User user)
        {
            using (FootballDbContext dbContext = new FootballDbContext())
            {
               dbContext.Users.Add(user);
                dbContext.SaveChanges();
            }
        }
        public static List<User> GetAllUser()
        {
            using (FootballDbContext dbContext = new FootballDbContext())
            {
                return dbContext.Users.ToList();
            }
        }
        public static void AddReservation(Reservation reservation)
        {

            using (FootballDbContext dbContext = new FootballDbContext())
            {
                dbContext.Reservations.Add(reservation);
                dbContext.SaveChanges();
            }
        }
        public static List<Reservation> GetAllReservation()
        {
            using (FootballDbContext dbContext = new FootballDbContext())
            {
                return dbContext.Reservations.ToList();
            }
        }
        public static void GetByStadionId(int? id)
        {
            using (FootballDbContext dbContext = new FootballDbContext())
            {
                var result = dbContext.Reservations.Where(x => x.StadionId == id);
                foreach (var item in result)
                {

                    Console.WriteLine($"UserId:{item.UserId},Id:{item.Id},StadionId:{item.StadionId},StartDate:{item.StartDate},EndDate:{item.EndDate}");
                }
            }
        }
        public static void GetUserById(int? id)
        {
            using(FootballDbContext dbContext = new FootballDbContext())
            {
                var rslt=dbContext.Reservations.Where(x => x.UserId == id);
                foreach (var item in rslt)
                {
                    Console.WriteLine($"UserId:{item.UserId},Id:{item.Id},StadionId:{item.StadionId},StartDate:{item.StartDate},EndDate:{item.EndDate}");
                }
            }
        }
        public static void DeleteReservation(int id)
        {
            using(FootballDbContext dbContext=new FootballDbContext())
            {
                var dlt=dbContext.Reservations.FirstOrDefault(x => x.Id == id);
                if (dlt != null)
                {
                    dbContext.Reservations.Remove(dlt);
                    dbContext.SaveChanges();
                }
            }
        }
    }
}
