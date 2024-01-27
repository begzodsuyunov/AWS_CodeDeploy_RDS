using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _00010358.DAL
{
    public interface IStudentRepository
    {
        //IStudent Repository describes the below given operations performed against the database

        void Insert(Student stu);
        Student GetById(int id);
        void Update(Student stu);

        void Delete(int id);

        List<Student> GetStudents();
    }
}
