using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Customer
    {
        private int id;
        private string name;
        private string address;
        private int zip;
        private string town;
        private string telephone;

        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Address { get { return address; } set { address = value; } }
        public int ZIP { get { return zip; } set { zip = value; } }
        public string Town { get { return town; } set { town = value; } }
        public string Telephone { get { return telephone; } set { telephone = value; } }
    }
}
