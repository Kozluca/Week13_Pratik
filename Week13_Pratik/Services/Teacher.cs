using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week13_Pratik.Services
{
    public class Teacher : ITeacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Constructor: Öğretmenin adını ve soyadını dışarıdan alır.
        public Teacher(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        // Öğretmenin adını ve soyadını döndüren metot
        public string GetInfo()
        {
            return $"Öğretmen: {FirstName} {LastName}";
        }
    }
}