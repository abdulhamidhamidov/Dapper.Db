using Infrostructure.Models;
using Infrostructure.Services;

StudentServices studentServices = new StudentServices();

Student student = new Student
{
    Fullname = "Farhod Chimaev",
    Age = 32,
    Score =99
};
Console.WriteLine(studentServices.CreateStudent(student));
Console.WriteLine(studentServices.GetStudents());
Console.WriteLine(studentServices.GetStudentById(2));
student.Id = 5;
Console.WriteLine(studentServices.Update(student));
Console.WriteLine(studentServices.Delete(1));