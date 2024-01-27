using _00010358.DBContext;
using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _00010358.DAL
{
    public class StudentRepository : IStudentRepository
    {
        private readonly DatabaseContext _dbContext;

        //repository will query the database using DatabaseContext
        //injected the context using constructor    
        public StudentRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Delete(int id)
        {
            //finding the student with id
            var stu = _dbContext.Student.Find(id);
            //with the help of remove method from DbSet, it can delete student from database
            _dbContext.Student.Remove(stu);
            //inserting changes into the database
            Save();
        }
        public Student GetById(int id) 
        {
            //Find method of Dbset has been implemented into to get the single student 
            var stu = _dbContext.Student.Find(id);
            return stu;
        }

        public List<Student> GetStudents()
        {
            //ToList method of DbSet will fetch all the books from the database
            return _dbContext.Student.ToList();
        }


        public void Insert(Student stu)
        {
            //using the add method of DBSet for adding a new instance student class
            _dbContext.Add(stu);
            //inserting it into the database
            Save();
        }

        public void Update(Student stu)
        {
            //changing the state of the entity
            _dbContext.Entry(stu).State = EntityState.Modified;
            //save will update the entity in the database
            Save();
        }
        public void Save()
        {
            //Save the changes into the db
            _dbContext.SaveChanges();
        }
    }
}
