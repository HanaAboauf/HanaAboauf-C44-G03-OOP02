namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person person01 = new Person(1,"Hana",5000);

            Person person02 = new Person();

            person02.Id = 2;

            person02.Name = "Joussef";

            person02.salary = 3000;

            Console.WriteLine(person01.ToString());

            Console.WriteLine(person02);


            
        }
    }
}
