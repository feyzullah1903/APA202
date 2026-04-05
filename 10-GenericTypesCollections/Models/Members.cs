using _10_GenericTypesCollections.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
//Id - Üzv ID(int)
//Name - Ad(string)
//Email - Email(string)
//BorrowedBooks - Borc götürdüyü kitablar(List<Book>)
//Constructor:
//Parametrli constructor(id, name, email)
//BorrowedBooks - u boş list olaraq initialize edin
//Metodlar:
//1.BorrowBook(Book book) - Kitab götürür
//Yoxla: BorrowedBooks.Count < 3(maksimum 3 kitab)
//Əgər limit keçilibsə: Console - a yaz "Maksimum 3 kitab götürə bilərsiniz!"
//Əgər ok: List - ə əlavə et
//Console - a yaz: "Kitab götürüldü: [Title]"

namespace _10_GenericTypesCollections.Models

{
    internal class Members
    {
        public int MemberId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public List<Book> BorrowedBooks { get; set; }
        public Members(int memberId, string name, string email)
        {
            MemberId = memberId;
            Name = name;
            Email = email;
            BorrowedBooks = new List<Book>();
        }
        public void BorrowBook(Book book)
        {
            if (BorrowedBooks.Count >= 3)
            {
                Console.WriteLine( "Maksimum 3 kitab goture bilersiniz");
                
            }
            else
            {
                BorrowedBooks.Add(book);
                Console.WriteLine($"Borca Kitab verildi qaytararsan:)) ");
            }

            
        }
        public void ReturnBook(int bookId)
        {
            foreach (var item in BorrowedBooks)
            {
                if (item.BookId==bookId)
                {
                    BorrowedBooks.Remove(item);
                    Console.WriteLine("Kitab qaytairldi");
                    break;
                   
                }
               
                
                
            }



        }
        public void DisplayBorrowedBooks()
        {
            if (BorrowedBooks.Count == 0)
            {
                Console.WriteLine("Heç bir kitab borcda yoxdur.");
            }
            else
            {
                foreach (var item in BorrowedBooks)
                {
                    item.Dispayinfo();
                }
            }
        }



    }
}
