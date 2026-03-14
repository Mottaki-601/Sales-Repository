using _1291387.DITest;
using _1291387.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1291387
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IRepoFactory repoFactory = new RepoFactory();
            TestClass test = new TestClass(repoFactory);
            test.Run();

            Console.ReadKey();
        }
    }
}
