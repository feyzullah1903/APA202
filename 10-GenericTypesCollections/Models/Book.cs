using System;
using System.Collections.Generic;
using System.Text;
//using static System.Net.WebRequestMethods;
//1.Book Sinfi
//Kitabı təmsil edir.

//Xüsusiyyətlər (Properties):
//Id - Kitab ID(int)
//Title - Başlıq(string)
//Author - Müəllif(string)
//Year - Nəşr ili(int)
//PageCount - Səhifə sayı(int)
//Constructor:
//Parametrli constructor yaradın
//Bütün field - ləri təyin edin
//[ID] Başlıq - Müəllif(İl) - Səhifə sayı

namespace _10_GenericTypesCollections.Models
{
    internal class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int YearOfProse { get; set; }
        public int PageCount { get; set; }
        public Book(int bookId, string title, string author, int yearOfprose, int pageCount)
        {
            BookId = bookId;
            Title = title;
            Author = author;
            YearOfProse = yearOfprose;
            PageCount = pageCount;
            
        }
        public void Dispayinfo()
        {
            Console.WriteLine($"[ID] {Title} - {Author}({YearOfProse}) - {PageCount} sehife");
        }
    }
}
