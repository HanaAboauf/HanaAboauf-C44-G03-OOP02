using oop_02.Structs;

namespace oop_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01

            //Person[] persons = new Person[3];
            //persons[0] = new Person { Name = "Hana", Age = 21 };
            //persons[1] = new Person { Name = "Joussef", Age = 19 };
            //persons[2] = new Person { Name = "Mohammed", Age = 74 };

            //foreach (Person person in persons)
            //{
            //    Console.WriteLine(person);
            //}

            #endregion

            #region Question02

            //Point point01 =new Point();
            //Point point02 =new Point();

            //Console.WriteLine("enter the x axis of the first point");
            //point01.X = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("enter the y axis of the first point");
            //point01.Y = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("enter the x axis of the second point");
            //point02.X = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("enter the y axis of the second point");
            //point02.Y = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($"The distance between the 2 points is: {Point.calculateDistance(point02, point01)}");

            #endregion

            #region Question03
            Person person01 = new Person();
            Console.WriteLine("ent first person name");
            person01.Name = Console.ReadLine()!;
            Console.WriteLine("ent first person age");
            person01.Age=Convert.ToInt32(Console.ReadLine());

            Person person02 = new Person();
            Console.WriteLine("ent second person name");
            person02.Name = Console.ReadLine()!;
            Console.WriteLine("ent second person age");
            person02.Age = Convert.ToInt32(Console.ReadLine());

            Person person03 = new Person();
            Console.WriteLine("ent third person name");
            person03.Name = Console.ReadLine()!;
            Console.WriteLine("ent third person age");
            person03.Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The oldest person is: \n {Person.GetOldestPerson(person01,person02,person03)}");




            #endregion
        }
    }
}
