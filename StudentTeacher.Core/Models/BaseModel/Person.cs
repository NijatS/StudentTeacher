using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTeacher.Core.Models.BaseModel
{
    public abstract class Person
    {
        private static int _count = 0;
        public readonly int Id;
        public string Name;
        public string Surname;
        public string GroupNo;

        public Person()
        {
            _count++;
            Id = _count;
          
        }
        public override string ToString()
        {
            return "ID: " + Id + "  Name: " + Name + "  Surname:  " + Surname + "  GroupNo:  " + GroupNo;
        }
    }
}
