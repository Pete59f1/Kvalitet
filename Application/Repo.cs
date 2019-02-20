using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public abstract class Repo<T>
    {
        private List<T> repoList;

        public List<T> RepoList { get { return repoList; } private set { repoList = value; } }

        public Repo()
        {
            repoList = new List<T>();
        }

        public void Add(T rep)
        {
            RepoList.Add(rep);
        }
        public void Remove(int index)
        {
            RepoList.RemoveAt(index);
        }
    }
}
