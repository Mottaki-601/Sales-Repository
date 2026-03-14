using _1291387.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1291387.Repositories
{
    public class GenericRepo<T> : IRepo<T> where T : BaseEntry
    {
        private readonly IList<T> data;
        public GenericRepo()
        {
            this.data = new List<T>();
        }
        public void Add(T entity)
        {
            this.data.Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            foreach (var item in entities)
            {
                this.data.Add(item);
            }
        }

        public void Delete(int id)
        {
            var entity = this.data.FirstOrDefault(x => x.Id == id);
            if (entity != null)
            {
                this.data.Remove(entity);
            }
        }

        public T Get(int id)
        {
            return this.data.FirstOrDefault(x => x.Id == id);
        }

        public List<T> GetAll()
        {
            return this.data.ToList();
        }

        public void Update(T entity)
        {
            int i = this.data.IndexOf(entity);
            this.data.RemoveAt(i);
            this.data.Add(entity);
        }
    }
}
