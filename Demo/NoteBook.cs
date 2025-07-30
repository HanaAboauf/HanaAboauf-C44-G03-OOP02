using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal struct NoteBook
    {
        #region attribute
		
        private string[]? names;
        private int[]? numbers;
        public int Size { get; }
        #endregion

        #region constructor

        public NoteBook(int size)
        {
            Size = size;
            names = new string[size];
            numbers = new int[size];
        }
        #endregion

        #region methods 

        public void AddPerson(string name, int number, int position)
        {
            if (names is not null && numbers is not null)
            
                if(position < Size || position >=0)
                {
                    names[position] = name;
                    numbers[position] = number;

                }
            
           
        }

        #endregion


        #region properties

        public int this[string name]
        {
            get
            {
                if (names is not null && numbers is not null)
                    for(int i = 0; i < names.Length; i++)
                    {
                        if (names[i] == name)
                        {
                            return i;
                        }
                    }
                return -1;

            }

            set
            {
                if (names is not null && numbers is not null)
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (names[i] == name)
                        {
                            numbers[i] = value;
                            return;
                        }
                    }
            }
        }

        public string this[int index]
        {
            get
            {
                if (names is not null && numbers is not null)
                {
                    if (index < Size && index >= 0)
                    {
                        return $"the page number: {index} :: Name={names[index]} :: Number={numbers[index]}";
                    }
                }
                return string.Empty;
            }

        }


        #endregion


    }
}
