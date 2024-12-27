using Week13_Pratik.Services;

public class Program
{
    public static void Main()
    {

        // 1. Öğretmen oluştur

        ITeacher teacher = new Teacher("Mustafa", "Asrlan");

        // 2. Sınıf oluştur ve öğretmeni bağla

        ClassRoom classRoom = new ClassRoom(teacher);

        // 3. Öğretmenin bilgilerini yazdır

        Console.WriteLine(classRoom.GetTeacherInfo());
        Console.ReadKey();
    }
}