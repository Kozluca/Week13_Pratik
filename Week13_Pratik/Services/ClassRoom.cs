using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week13_Pratik.Services
{
    public class ClassRoom
    {
        private readonly ITeacher _teacher; // Bağımlılık olarak öğretmen nesnesi

        // Constructor Injection: Öğretmen nesnesi dışarıdan alınır.
        public ClassRoom(ITeacher teacher)
        {
            
            _teacher = teacher;
        }

        // Öğretmenin bilgilerini döndüren metot
        public string GetTeacherInfo()
        {
            return _teacher.GetInfo();
            
        }
        
    }
    
}