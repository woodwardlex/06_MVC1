using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Review
{
    class Program
    {
        static void Main(string[] args)
        {
            NewBorn n1 = new NewBorn(121, "Alice", "Johnson", new DateTime(1989,12,01), 'F');
            NewBorn n2 = new NewBorn(132, "Jack", "Reagan", new DateTime(1989,01,12), 'M');
            NewBorn n3 = new NewBorn(135, "Jason", "Kellog", new DateTime(1990,03,05), 'M');
            NewBorn n4 = new NewBorn(152, "Rachel", "Jackson", new DateTime(1990,04,20), 'F');
            NewBorn n5 = new NewBorn(156, "Tasha", "Robinson", new DateTime(1990,08,06), 'F');

            List<NewBorn> newBorns = new List<NewBorn>()
            {
                n1, n2, n3, n4, n5
            };//shorthand initialization syntax- makes adding items into a list more organized and easier to read.

            //newBorns.Add(n1);
            //newBorns.Add(n2);
            //newBorns.Add(n3);
            //newBorns.Add(n4);
            //newBorns.Add(n5);

            Console.WriteLine("~~~ New Born Data ~~~");
            foreach (NewBorn newBorn in newBorns)
            {
                Console.WriteLine(newBorn);
            }
        }//end main
    }

    /*Can also write C# classes under the Main()*/
    //public class NewBorn
    //{
    //    public int ID { get; /*set;*/ }//comment out setter for readonly
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public DateTime DateOfBirth { get; set; }
    //    public char Gender { get; set; }

    //    //ctor
    //    public NewBorn(int id, string firstName, string lastName, DateTime dateOfBirth, char gender)
    //    {
    //        ID = id;
    //        FirstName = firstName;
    //        LastName = lastName;
    //        DateOfBirth = dateOfBirth;
    //        Gender = gender;
    //    }

    //    //methods
    //    public override string ToString()
    //    {
    //        return string.Format("ID: {0}\n" +
    //            "Name: {1} {2}\n" +
    //            "Gender: {3}\n" +
    //            "Date of Birth: {4}\n",
    //            ID, FirstName, LastName, Gender, DateOfBirth);
    //    }
    //}
}
