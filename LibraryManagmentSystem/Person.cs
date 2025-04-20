using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem
{
    abstract class Person
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public Person()
        {
            this.Id = 0;
            this.Name = "no name yet";
        }
        public Person(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public abstract void DisplayInfo();
        public override string ToString() {
            return ($"Name: {this.Name}, ID:{this.Id}");
        }
    }
}
