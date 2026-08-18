using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter Fullname: ");
        string fullname = Console.ReadLine();

        Console.Write("Enter Course with Specialization: ");
        string course = Console.ReadLine();

        Console.Write("Enter Municipality: ");
        string municipality = Console.ReadLine();

        Console.Write("Enter Province: ");
        string province = Console.ReadLine();

        Console.Write("Enter Date of Birth (MM/DD/YYYY): ");
        string dob = Console.ReadLine();

        Console.WriteLine("\n--- Your Information ---");
        Console.WriteLine("Fullname: " + fullname);
        Console.WriteLine("Course with Specialization: " + course);
        Console.WriteLine("Municipality: " + municipality);
        Console.WriteLine("Province: " + province);
        Console.WriteLine("Date of Birth: " + dob);
    }
}