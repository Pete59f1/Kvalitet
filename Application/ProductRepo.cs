using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace MyApplication
{
    public class ProductRepo: Repo<Product>
    {
        public string GetName(int index)
        {
            return RepoList[index].Name;
        }
        public double GetPrice(int index)
        {
            return RepoList[index].Price;
        }

        private int count;

        public int GetCount()
        {
            SetCount();
            return count;
        }

        private void SetCount()
        {
            count = RepoList.Count;
        }
    }
}
