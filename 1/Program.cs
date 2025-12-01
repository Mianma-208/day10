using _Education;
using _Exam;
using _Person;
using _Student;

Student student = new Student();
Console.WriteLine(student.ToShortString());
Console.WriteLine();

Console.WriteLine($"Education.Specialist: {student[Education.Specialist]}");
Console.WriteLine($"Education.Bachelor: {student[Education.Bachelor]}");
Console.WriteLine($"Education.SecondEducation: {student[Education.SecondEduction]}");
Console.WriteLine();

student.Pers = new Person("Иван", "Иванов", new DateTime(2000, 5, 15));
student.Educ = Education.Bachelor;
student.Group = 101;
student.Exams = new Exam[]
{
    new Exam("Математика", 4, new DateTime(2024, 1, 10))
};
Console.WriteLine(student.ToString());
Console.WriteLine();

student.AddExams(
    new Exam("Физика", 5, new DateTime(2024, 1, 15)),
    new Exam("Программирование", 4, new DateTime(2024, 1, 20))
);
Console.WriteLine(student.ToString());
Console.WriteLine();


