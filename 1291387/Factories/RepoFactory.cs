using _1291387.Models;
using _1291387.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1291387.Factories
{
    public class RepoFactory : IRepoFactory
    {
        public IRepo<T> CreateRepo<T>() where T : BaseEntry
        {
            return new GenericRepo<T>();
        }
    }
}
