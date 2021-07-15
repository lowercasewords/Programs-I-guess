using System;
using System.Collections.Generic;

namespace MusicSite {
    class Program {
        static public void Main (string[] args) {
            Console.WriteLine("It works somehow");
        }
    }
    class User {
        //properties
        public string Name { get; private set; }
        public int Id { get; private set; }
        public double Balance { get; private set; }
        public double Spent { get; private set; }
        public List<string> Library { get; private set; }
        
        //Constructor
        public User (string name, int id, double balance, double spent, List<string> library) {
            Name = name;
            Id = id;
            Balance = balance;
            Spent = spent;
            Library = library;
        }
    }
    interface Product {
        string Name { get; set; }
        double Price { get; set; }
        int Id { get; set; }
    }
    class StarboyAlbum : Product {
        //properties
        public string Name { get; set; }
        public double Price { get; set; }
        public int Id { get; set; }
       
        //constructors
        public StarboyAlbum (string name, double price, int id) {
            Name = name;
            Price = price;
            Id = id;
        }
    }
}