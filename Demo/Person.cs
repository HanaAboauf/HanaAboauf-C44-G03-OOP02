using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Person
    {
        #region attributes

        public int Id { get; set; }
        private string? name;
        public decimal salary { get; set; }



        #endregion

        #region constructor

        public Person()
        {
            Id = default;
            salary = default;
            name = default;

        }

        public Person(int id, string? name, decimal salary)
        {
            Id = id;
            this.name = name;
            this.salary = salary;
        }

        #endregion

        #region properties



        public string Name
        {
            get { return name; }
            set
            {
                if (value is not null)
                    name = value;

            }
        }
        #endregion

        #region Methods

        public override string ToString() {

            return $"Id: {Id}\n Name: {name}\n Salary: {salary}";
        }
        #endregion
    }      
}
