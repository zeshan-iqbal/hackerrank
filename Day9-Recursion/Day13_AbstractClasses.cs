using System;
using System.Collections.Generic;
using System.IO;
namespace Day9_Recursion
{
    //https://www.hackerrank.com/challenges/30-abstract-classes/problem

    abstract class Book
    {

        protected String title;
        protected String author;

        public Book(String t, String a)
        {
            title = t;
            author = a;
        }
        public abstract void display();


    }

    class MyBook:Book
    {
        private int price;

        public MyBook(string title, string author, int price) : base(title, author)
        {
            this.price = price;
        }

        public override void display()
        {
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"Price: {price}");
        }
    }
}