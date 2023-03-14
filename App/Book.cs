using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    internal class Book
    {
        public string title;
        public string author;
        public int pages;

        // Object Method
        public Book() 
        { 
            
        }
        public Book(string aTitle , string aAuthor , int aPages)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;

        }
    }
}
