using System;
using System.Collections.Generic;

namespace ApartmentManagementSystem
{
    public class Apartment
    {
        public int ApartmentId { get; set; }
        public string BlockInfo { get; set; }
        public bool OccupancyStatus { get; set; }
        public string Type { get; set; }
        public int FloorNumber { get; set; }
        public int ApartmentNumber { get; set; }
        public User User { get; set; }
    }

    public class User
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string TcNo { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public List<Payment> Payments { get; set; }
    }

    public class Payment
    {
        public int PaymentId { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentType { get; set; }
        public decimal Amount { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public Apartment Apartment { get; set; }
        public User User { get; set; }
    }

    public interface IRepository<T>
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetById(int id);
        IEnumerable<T> GetAll();
    }

    public class Repository<T> : IRepository<T> where T : class
    {
        void IRepository<T>.Add(T entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<T>.Delete(T entity)
        {
            throw new NotImplementedException();
        }

        IEnumerable<T> IRepository<T>.GetAll()
        {
            throw new NotImplementedException();
        }

        T IRepository<T>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        void IRepository<T>.Update(T entity)
        {
            throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Apartment Management System");

        }
    }
}
