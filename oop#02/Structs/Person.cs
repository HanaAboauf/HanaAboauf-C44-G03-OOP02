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
            return $"Id: {Age}, Name: {Name}";
        } 
        #endregion

    }
}
