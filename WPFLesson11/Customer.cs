using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFLesson11
{
    public class Customer
    {
        public Customer()
        {
        }

        public Customer(string name)
        {
            Name = name;
        }

        public Customer(int id, string name)
        {
            Id = id;
            Name = name;
        }


        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
