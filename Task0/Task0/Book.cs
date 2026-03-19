using System;
using System.Collections.Generic;
using System.Text;

namespace Task0
{
    public class Book
    {
        private string title;
        private string author;
        private int pages;

        public Book(string title, string author, int pages)
        {
            this.author = author;
            this.title = title;
            this.pages = pages;
        }

        public string ShowInfo()
        {
            return $"{title}. {author}. {pages} сторінок.";
        }

        public bool IsLarge()
        {
            return pages > 300;
        }
    }
}
