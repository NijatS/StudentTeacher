using StudentTeacher.Services;


StudentService studentService = new StudentService();

TeacherService teacherService = new TeacherService();
bool status1 = true, status2 = true;
while (status1)
{
    Console.WriteLine("1.Student Login\n" +
        "2.Teacher Login\n" +
        "q Quit");
    Console.Write("Step: ");
    string step1 = Console.ReadLine();

    switch (step1)
    {
        case "1":
            while (status2)
            {
                Console.WriteLine("1.Create Student\n" +
                    "2.Show Students\n" +
                    "3.Search by ID\n" +
                    "4.Remove\n" +
                    "5.Clear Console\n" +
                    "q Quit Student Login");
                Console.Write("Step: ");
                string step2 = Console.ReadLine();
                switch (step2) {
                    case "1":
                        studentService.Create();
                        break;
                        case "2":
                        studentService.Show();
                        break;
                        case "3":
                        studentService.GetById();
                        break;
                        case "4":
                        studentService.Delete();
                        break;
                        case "5":
                        Console.Clear();
                        break;
                        case "q":
                        Console.WriteLine("Exiting...");
                        status2 = false;
                        break;
                }
               
            }
            status2 = true;
            break;
        case "2":
            while (status2)
            {
                Console.WriteLine("1.Create Teacher\n" +
                    "2.Show Teachers\n" +
                    "3.Search by ID\n" +
                    "4.Remove\n" +
                    "5.Console Clear\n" +
                    "q Quit Teacher Login");
                Console.Write("Step: ");
                string step3 = Console.ReadLine();
                switch (step3)
                {
                    case "1":
                        teacherService.Create();
                        break;
                    case "2":
                        teacherService.Show();
                        break;
                    case "3":
                        teacherService.GetById();
                        break;
                    case "4":
                        teacherService.Delete();
                        break;
                    case "5":
                        Console.Clear();
                        break;
                    case "q":
                        Console.WriteLine("Exiting...");
                        status2 = false;
                        break;
                }
            }
            status2 = true;
            break;

        case "q":
            Console.WriteLine("Exiting...");
            status1 = false;
            break;
        default:
            break;
    }
}