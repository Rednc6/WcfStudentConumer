using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfStudentConumer.WcfServiceReference;

namespace WcfStudentConumer
{
    class Program
    {
        static void Main(string[] args)
        {
            IStudentService x = new StudentServiceClient();

            int funcController = 0;

            while (funcController != 6)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Welcome to the student registry. \n Press a number to access the function \n");
                Console.WriteLine(" 1. Add student");
                Console.WriteLine(" 2. Find student");
                Console.WriteLine(" 3. Remove student");
                Console.WriteLine(" 4. Edit student");
                Console.WriteLine(" 5. Get all student");
                Console.WriteLine(" 6. Exit \n");

                Console.ResetColor();

                try
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("Input : ");
                    funcController = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n Value must be a number and not empty \n");
                    Console.ResetColor();
                }

                switch (funcController)
                {
                    case 1:
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("\n Enter name of new student : ");
                        String newStudentName = Console.ReadLine();
                        x.AddStudent(newStudentName);

                        Console.WriteLine($"\n {newStudentName} has been added to the registry \n");
                        Console.ReadKey();
                        Console.ResetColor();
                        break;
                    case 2:
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("\n Enter name of student to find : ");
                        String findStudentName = Console.ReadLine();
                        Console.WriteLine($"\n {x.FindStudent(findStudentName)} \n");   

                        Console.ReadKey();
                        Console.ResetColor();
                        break;
                    case 3:
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("\n Enter name of student to remove : ");
                        String removeStudentName = Console.ReadLine();
                        x.RemoveStudent(removeStudentName);
                        Console.WriteLine($"\n {removeStudentName} has been removed from the registry \n");

                        Console.ReadKey();
                        Console.ResetColor();

                        break;
                    case 4:
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("\n Enter name of the student you want to edit : ");
                        String editStudentValue1 = Console.ReadLine();
                        Console.Write("\n Enter new name of the student : ");
                        String editStudentValue2 = Console.ReadLine();
                        x.EditStudent(editStudentValue1, editStudentValue2);

                        Console.WriteLine($"\n {editStudentValue1} has been changed to {editStudentValue2} \n");
                        Console.ReadKey();
                        Console.ResetColor();
                        break;
                    case 5:
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\n All the students in the registry ");

                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Green;
                        foreach (var obj in x.GetAllStudents())
                        {
                            
                            Console.WriteLine(" " + obj._name);
                        }
                       
                        Console.ReadKey();
                        Console.ResetColor();
                        break;
                }

            }
        }
    } 
}
