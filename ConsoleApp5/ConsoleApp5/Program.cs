using System;
using System.IO;
using System.Runtime.Remoting;
using struct_lab_student;

namespace Lab5
{
    class Program
    {
        static Student[] ReadData(string fileName)
        {
            // TODO   implement this method.
            // It should read the file whose fileName has been passed and fill 

            string location = "C:\\Users\\Moysha\\Desktop\\"; 
            string newLocation = location.Insert(location.Length, fileName);
            int count = System.IO.File.ReadAllLines(newLocation).Length;
            Student[] students = new Student[count];
            var stream = File.Open(newLocation, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(stream, System.Text.Encoding.Default);
            for (int i = 0; i < count; i++)
            {
                var str = sr.ReadLine();
                Student student = new Student(str);
                students[i] = student;
            }

            return students;

        }
       
        static void runMenu(Student[] studs)
        {




            for (int i = 0; i < studs.Length; i++)
            {
                string scholarship = Convert.ToString(studs[i].scholarship);
                int scolar = Convert.ToInt32(scholarship);


                
             
                if (scolar == 0)
                {
                    if (studs[i].mathematicsMark == '-')
                    {
                        studs[i].mathematicsMark = '2';
                    }

                    if (studs[i].physicsMark == '-')
                    {
                        studs[i].physicsMark = '2';

                    }
                    if (studs[i].informaticsMark == '-')
                    {
                        studs[i].informaticsMark = '2';

                    }
                    string SeredniMath = Convert.ToString(studs[i].mathematicsMark);
                    string SeredniInf = Convert.ToString(studs[i].informaticsMark);
                    string SeredniPhys = Convert.ToString(studs[i].physicsMark);
                    double avarage = (Convert.ToDouble(SeredniMath) + Convert.ToDouble(SeredniInf) + Convert.ToDouble(SeredniPhys)) / 3;


                    Console.WriteLine(studs[i].surName + " " + studs[i].firstName + " " + studs[i].patronymic + "  " + "  Середнiй бал = " + Math.Round(avarage, 1));
            
                    Console.WriteLine();
                }
            }
        }

        static void Main(string[] args)
        {
            Student[] studs = ReadData("Input.txt");
            runMenu(studs);
            Console.ReadKey();
        }

    }
}
