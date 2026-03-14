using _1291387.Factories;
using _1291387.Models;
using _1291387.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1291387.DITest
{
    public class TestClass
    {
        IRepoFactory factory;
        public TestClass(IRepoFactory factory)
        {
            this.factory = factory;
        }

        public void Run()
        {
            IRepo<Library> repoC = factory.CreateRepo<Library>();
            repoC.AddRange(new Library[]
            {
                new Library{Id = 1, Name = "Quran"},
                new Library{Id = 2, Name = "Hadith"},
                new Library{Id = 3, Name = "Bangla Litterateur"},
                new Library{Id = 4, Name = "Historical Book"},
                new Library{Id = 5, Name = "Uponnas"},
            });

            //Get All
            Console.WriteLine("------------------------- Get All ----------------------------");
            repoC.GetAll().ToList()
                .ForEach(l => Console.WriteLine($"Id : {l.Id}, Name : {l.Name}"));
            Console.WriteLine();

            Console.WriteLine("----------------------- Get ------------------------");
            var bk = repoC.Get(3);
            Console.WriteLine($"Id : {bk.Id}, Name : {bk.Name}");
            Console.WriteLine();


            //Update
            Console.WriteLine("===============|| Update ||==============");
            Console.WriteLine("-----------------------------------------");
            bk.Name = "Islamic History";
            repoC.Update(bk);
            repoC.GetAll().ToList()
                .ForEach(x => Console.WriteLine($"| ID : {x.Id}\t|| Name : {x.Name}\t"));
            Console.WriteLine("=========================================");
            Console.WriteLine();
            Console.WriteLine();


            //Delete
            Console.WriteLine("===============|| Delete ||==============");
            Console.WriteLine("-----------------------------------------");
            repoC.Delete(4);
            repoC.GetAll().ToList()
               .ForEach(x => Console.WriteLine($"| ID : {x.Id}\t|| Name : {x.Name}\t\t"));
            Console.WriteLine("=========================================");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("-------------------------------- Book ---------------------------------");
            IRepo<Book> repob = factory.CreateRepo<Book>();
            repob.AddRange(new Book[]
            {
                new Book{Id=1, Name="Nurani Quranul Karim", Price=350.50M, Stock=10, BooKId=1},
                new Book{Id=2, Name="Rahe Amal", Price=550.00M, Stock=5, BooKId=2},
                new Book{Id=3, Name="Gitangalee", Price=200.00M, Stock=30, BooKId=3},
                new Book{Id=4, Name="Ar Kotodin", Price=100.00M, Stock=50, BooKId=4},
            });
            Console.WriteLine();

            //Get All
            Console.WriteLine("------------------------ Get All ---------------------------");
            repob.GetAll().ToList()
                .ForEach(b => Console.WriteLine($"Id : {b.Id}, Name :{b.Name}, Price :{b.Price}, Stock : {b.Stock}, BookId : {b.BooKId}"));
            Console.WriteLine();

            //Get
            Console.WriteLine("------------------------------ Get ---------------------------------------");
            var book = repob.Get(3);
            Console.WriteLine($"Id : {book.Id}, Name : {book.Name}, Price : {book.Price}, Stock : {book.Stock}, BookId : {book.BooKId}");
            Console.WriteLine();


            //Update
            Console.WriteLine("==================================================|| Update ||==============================================");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
            book.Name = "Rahela";
            repob.Update(book);
            repob.GetAll().ToList()
               .ForEach(t => Console.WriteLine($"| ID : {t.Id}\t|| Name : {t.Name}\t\t|| Price : {t.Price}\t\t|| Stock : {t.Stock}\t|| BookId : {t.BooKId}|"));
            Console.WriteLine("=============================================================================================================");
            Console.WriteLine();
            Console.WriteLine();


            //Delete
            Console.WriteLine("------------------- Delete --------------------");
            repob.Delete(3);
            repob.GetAll().ToList()
                .ForEach(bK => Console.WriteLine($"Id : {book.Id}, Name : {book.Name}, Price : {book.Price}, Stock : {book.Stock}, BookId : {book.BooKId}"));
        }
    }
}
