using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IStudentFeatures
    {
        List<Student> GetAllStudents();
        Student GetStudentById(int studentId);
        Student AddStudent(Student student);
        Student UpdateStudent(Student student);
        bool DeleteStudent(int studentId);

        //List<Student> SearchByName(string firstName, string lastName);
        //List<Student> SearchByGrade(string grade);
        //List<Student> SearchByAge(int age);
    }
}
