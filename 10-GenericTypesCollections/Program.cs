using _10_GenericTypesCollections.Models;
using System.Threading.Channels;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;
//1.Kitablar yaradın(5 kitab):
//Book 1: ID = 1, Title = "Martin Eden", Author = "Jack London", Year = 1909, PageCount = 400
//Book 2: ID = 2, Title = "1984", Author = "George Orwell", Year = 1949, PageCount = 328
//Book 3: ID = 3, Title = "Animal Farm", Author = "George Orwell", Year = 1945, PageCount = 112
//Book 4: ID = 4, Title = "Ağ Gəmi", Author = "Cingiz Aytmatov", Year = 1970, PageCount = 200
//Book 5: ID = 5, Title = "Qırıq Budaq", Author = "Elçin", Year = 1998, PageCount = 350
//Hər kitabın məlumatlarını göstərin (DisplayInfo)
//Generic Library<T> test edin:
//Library<Book> tipində obyekt yaradın (ad: "Milli Kitabxana")
//5 kitabı əlavə edin (Add method)
//Kitab sayını göstərin (Count method)
//İndeks 0-dakı kitabı tapın və göstərin
//İndeks 2-dəki kitabı tapın və göstərin
//Bütün kitabları göstərin (GetAll və foreach)



namespace _10_GenericTypesCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Book b1 = new Book(1, "Martin Eden", "Jack London", 1909, 400);
            Book b2 = new Book(2, "1984", "George Orwell", 1949, 328);
            Book b3 = new Book(3, "Animal Farm", "George Orwell", 1945, 112);

            Book b4 = new Book(4, "Ag Gemi", "Cingiz Aytmatov", 1970, 200);
            Book b5 = new Book(5, "Qiriq Budaq", "Elcin", 1998, 350);


            b1.Dispayinfo();
            b2.Dispayinfo();
            b3.Dispayinfo();
            b4.Dispayinfo();
            b5.Dispayinfo();



            Library<Book> library = new Library<Book>("Milli Kitabxana");

            library.AddItem(b1);
            library.AddItem(b2);

            library.AddItem(b3);
            library.AddItem(b4);
            library.AddItem(b5);


            Console.WriteLine("count: " + library.GetCount());

            var first = library .FinfItemindex(0);
            if (first != null)
                first.Dispayinfo();

            var third = library.FinfItemindex(2);
            if (third != null)
                third.Dispayinfo();


            foreach (var x in library.GetAllItems())
            {
                x.Dispayinfo();
            }



            List<Members> list = new List<Members>();

            list.Add(new Members(1, "Ali Memmedov", "ali@mail.com"));
            list.Add(new Members(2, "Leyla Hesenova", "leyla@mail.com"));

            list.Add(new Members(3, "Vuqar Eliyev", "vuqar@mail.com"));


            Members m = list[0];

            m.BorrowBook(b1);
            m.BorrowBook(b2);

            m.DisplayBorrowedBooks();


            m.ReturnBook(1);

            m.DisplayBorrowedBooks();


            m.BorrowBook(b3);
            m.BorrowBook(b4);

            m.BorrowBook(b5);  



            Bookmanager man = new Bookmanager();

            man.AddBook(b1);
                    man.AddBook(b2);
            man.AddBook(b3);
            man.AddBook(b4);
            man.AddBook(b5);



            var orwell = man.GetBooksByAuthor("George Orwell");

            foreach (var item in orwell)
            {
                item.Dispayinfo();
            }


            var ayt = man.GetBooksByAuthor("Cingiz Aytmatov");

            foreach (var item in ayt)
            {
                item.Dispayinfo();
            }


            var jack = man.GetBooksByAuthor("Jack London");

            foreach (var item in jack)
            {
                item.Dispayinfo();
            }


            var none = man.GetBooksByAuthor("Dostoyevski");
            Console.WriteLine("tapilan: " + none.Count);




            man.AddToWaitingQueue("Nigar");

            man.AddToWaitingQueue("Resad");
            man.AddToWaitingQueue("Sebine");


            Console.WriteLine("queue: " + man.WaitingQueue.Count);

            Console.WriteLine("xidmet: " + man.ServeNextInQueue());

            Console.WriteLine("qalan: " + man.WaitingQueue.Count);


            man.ServeNextInQueue();

            Console.WriteLine("qalan: " + man.WaitingQueue.Count);


            man.ServeNextInQueue();

            Console.WriteLine("qalan: " + man.WaitingQueue.Count);




            man.ReturnBook(b1);
            man.ReturnBook(b2);

            man.ReturnBook(b3);


            Console.WriteLine("stack: " + man.Recentlyreturned.Count);


            var last = man.GetLastReturnedBook();

            if (last != null)
                last.Dispayinfo();


            man.Recentlyreturned.Pop();

            Console.WriteLine("stack: " + man.Recentlyreturned.Count);


            var last2 = man.GetLastReturnedBook();

            if (last2 != null)
                last2.Dispayinfo();




            var f = man.SearchByTitle("1984");

            if (f != null)
                f.Dispayinfo();


            var nf = man.SearchByTitle("Harry Potter");

            if (nf == null)
                Console.WriteLine("tapilmadi");




            Console.WriteLine("books: " + man.Books.Count);
            Console.WriteLine("members: " + list.Count);

            Console.WriteLine("queue: " + man.WaitingQueue.Count);
            Console.WriteLine("stack: " + man.Recentlyreturned.Count);



            int min = man.Books[0].YearOfProse;
            int max = man.Books[0].YearOfProse;


            foreach (var i in man.Books)
            {
                if (i.YearOfProse < min)
                    min = i.YearOfProse;

                if (i.YearOfProse > max)
                    max = i.YearOfProse;
            }


            Console.WriteLine("min year: " + min);
            Console.WriteLine("max year: " + max);

        }
    }
}
    

       

