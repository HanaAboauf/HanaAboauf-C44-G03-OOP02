using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_02.Structs
{
    internal struct Person
    {
        #region Properties

        public string Name { set; get; }

        public int Age { set; get; }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Age: {Age}, Name: {Name}";
        } 

        public static Person GetOldestPerson(Person a, Person b, Person c)
        {
            if (a.Age >= b.Age && a.Age >= c.Age)
                return a;
            else if (b.Age >= a.Age && b.Age >= c.Age)
                return b;
            else
                return c;

        }
        #endregion

    }
}
