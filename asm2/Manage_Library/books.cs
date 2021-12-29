﻿using System;

namespace asm2.NewDirectory1
{
    public class books
    {
        public string Name {get; set;}
        public string Author {get; set;}
        public string Producer {get; set;}
        public string YearPublish {get; set;}
        public double Price {get; set;}

        public books()
        {
        }

        public books(string name, string author, string producer, string yearPublish,
            float price)
        {
            this.Name = name;
            this.Author = author;
            this.Producer = producer;
            this.YearPublish = yearPublish;
            this.Price = price;
        }

        public virtual void Input()
        {
            {
                Console.WriteLine("Name of book: ");
                Name = Console.ReadLine();

                Console.WriteLine("Name of Author: ");
                Author = Console.ReadLine();

                Console.WriteLine("Manufacturers Name: ");
                Producer = Console.ReadLine();

                Console.WriteLine("Publishing year: ");
                YearPublish = Console.ReadLine();

                Console.WriteLine("Price book: ");
                var priceInput = Console.ReadLine();
                
                double vaLue = 0;
                Price = vaLue;
                while (!double.TryParse(priceInput, out vaLue))
                {
                    Console.Write("This is not valid input. Please re-enter:");
                    priceInput= Console.ReadLine();
                }
            }
        }

        public virtual void Display()
        {
            Console.WriteLine("------------Information of book------------");
            Console.WriteLine("Name of book: " + Name);
            Console.WriteLine("Author of book: " + Author);
            Console.WriteLine("Manuafacturers Name: " + Producer);
            Console.WriteLine("Publishing Year: " + YearPublish);
            Console.WriteLine("Price book: " + Price);
            
        }
    }
}


