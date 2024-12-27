using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week13_Pratik.Services
{
    public interface ITeacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string GetInfo();
    }
}