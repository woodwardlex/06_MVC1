using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Review
{
    public class NewBorn
    {

        public int ID { get; /*set;*/ }//comment out setter for readonly
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }//CONTAINMENT - the use of a complex datatype as a field/prop
          //Complex Dataypes: Classes that can store multiple values for an object
        public char Gender { get; set; }

        //ctor
        public NewBorn(int id, string firstName, string lastName, DateTime dateOfBirth, char gender)
        {
            //property    is assigned the value of    parameter
            ID                    =                     id;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Gender = gender;
        }//fully-qualified ctor

        //methods
        public override string ToString()
        {
            return string.Format("ID: {0}\n" +
                "Name: {1} {2}\n" +
                "Gender: {3}\n" +
                "Date of Birth: {4:d}\n",
                ID, FirstName, LastName, Gender, DateOfBirth);

            //return $"Newborn: {LastName}, {FirstName}\nID: {ID}\nBorn on: {DateOfBirth:d}\nGender: {Gender}";
        }
    }
}
