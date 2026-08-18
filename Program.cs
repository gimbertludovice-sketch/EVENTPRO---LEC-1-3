using System;
using System.Threading;

class Program
{
    // ============================================================
    //  TYPEWRITER HELPERS
    //  These reproduce the auto-typing effect from the website.
    // ============================================================

    // Types text one character at a time, then moves to a new line.
    static void TypeLine(string text, int speed = 18)
    {
        Type(text, speed);
        Console.WriteLine();
    }

    // Types text one character at a time WITHOUT a line break,
    // so the cursor stays on the same line (used for input prompts).
    static void Type(string text, int speed = 18)
    {
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(speed);
        }
    }

    // Types text in a highlight colour, then restores the default.
    static void TypeLine(string text, ConsoleColor color, int speed = 18)
    {
        ConsoleColor original = Console.ForegroundColor;
        Console.ForegroundColor = color;
        Type(text, speed);
        Console.ForegroundColor = original;
        Console.WriteLine();
    }

    // Prints a prompt with the typewriter effect, then reads user input.
    static string TypePrompt(string prompt, int speed = 18)
    {
        Type(prompt, speed);
        return Console.ReadLine();
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8; // needed for "ñ" in Biñan
        bool running = true;

        while (running)
        {
            Console.Clear();
            TypeLine("=========================================", ConsoleColor.DarkYellow, 4);
            TypeLine("        C# PROGRAMMING ACTIVITIES        ", ConsoleColor.Yellow, 12);
            TypeLine("=========================================", ConsoleColor.DarkYellow, 4);
            TypeLine("[1] Activity 1 - Display Personal Info (hardcoded)", 8);
            TypeLine("[2] Activity 2 - Variables and Multiplication", 8);
            TypeLine("[3] Activity 3 - Display Personal Info (user input)", 8);
            TypeLine("[4] Exit", 8);
            TypeLine("=========================================", ConsoleColor.DarkYellow, 4);

            string choice = TypePrompt("Choose an option (1-4): ", 12);
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    Activity1();
                    break;
                case "2":
                    Activity2();
                    break;
                case "3":
                    Activity3();
                    break;
                case "4":
                    running = false;
                    TypeLine("Exiting program. Goodbye!", ConsoleColor.Cyan, 25);
                    break;
                default:
                    TypeLine("Invalid option. Please choose 1-4.", ConsoleColor.Red, 15);
                    break;
            }

            if (running)
            {
                Console.WriteLine();
                TypeLine("Press any key to return to the menu...", ConsoleColor.DarkGray, 10);
                Console.ReadKey();
            }
        }
    }

    // ============================================================
    //  ACTIVITY 1: Display hardcoded personal information
    // ============================================================
    static void Activity1()
    {
        TypeLine("--- ACTIVITY 1: Personal Information ---", ConsoleColor.Yellow, 15);
        TypeLine("Fullname: Gimbert Ludovice");
        TypeLine("Course with Specialization: Bachelor of Science in Information Technology Specialization in Mobile and Website Development");
        TypeLine("Municipality: Biñan");
        TypeLine("Province: Laguna");
        TypeLine("Date of Birth: 10/13/2006");
    }

    // ============================================================
    //  ACTIVITY 2: Declare 5 variables, multiply 2, display all
    // ============================================================
    static void Activity2()
    {
        TypeLine("--- ACTIVITY 2: Variables and Multiplication ---", ConsoleColor.Yellow, 15);

        int num1 = 8;
        int num2 = 5;
        int product = num1 * num2;
        string studentName = "Gimbert Ludovice";
        string course = "Bachelor of Science in Information Technology Specialization in Mobile and Website Development";

        TypeLine("Variable 1 (num1): " + num1);
        TypeLine("Variable 2 (num2): " + num2);
        TypeLine("Variable 3 (product of num1 * num2): " + product);
        TypeLine("Variable 4 (studentName): " + studentName);
        TypeLine("Variable 5 (course): " + course);
    }

    // ============================================================
    //  ACTIVITY 3: Get personal information via user input
    // ============================================================
    static void Activity3()
    {
        TypeLine("--- ACTIVITY 3: Personal Information (User Input) ---", ConsoleColor.Yellow, 15);

        string fullname     = TypePrompt("Enter Fullname: ");
        string course       = TypePrompt("Enter Course with Specialization: ");
        string municipality = TypePrompt("Enter Municipality: ");
        string province     = TypePrompt("Enter Province: ");
        string dob          = TypePrompt("Enter Date of Birth (MM/DD/YYYY): ");

        Console.WriteLine();
        TypeLine("--- Your Information ---", ConsoleColor.Yellow, 15);
        TypeLine("Fullname: " + fullname);
        TypeLine("Course with Specialization: " + course);
        TypeLine("Municipality: " + municipality);
        TypeLine("Province: " + province);
        TypeLine("Date of Birth: " + dob);
    }
}