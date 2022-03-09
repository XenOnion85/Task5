using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    class Book
    {
        private string author;
        private string title;
        private string publisher;
        private int pages;
        private int year;
        private static double price = 9;
        //public void SetBook (string author, string title, string publisher, int pages, int year)
        //{
        //    this.author = author;
        //    this.title = title;
        //    this.publisher = publisher;
        //    this.pages = pages;
        //    this.year = year;
        //}
        //public static void SetPrice(double price)
        //{
        //    Book.price = price;
        //}
       
        //public double PriceBook(int s)
        //{
        //    double cust = s * price;
        //    return cust;
        //}

        public Book(string author, string title, string publisher, int pages, int year)
        {
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;
        }

        public Book()
        {

        }
        static Book()
        {
            price = 10;
        }

        public Book(string author, string title)
        {
            this.author = author;
            this.title = title;
        }
        public void Show()
        {
            Console.WriteLine("\nКнига:\n Автор: {0}\n Название: {1}\n Год издания: {2}\n Кол-во страниц: {3} стр.\n Стоимость аренды: {4} р.", author, title, year, pages, Book.price);
        }
    }
}
