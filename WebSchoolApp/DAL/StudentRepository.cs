using DAL.interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class StudentRepository : IStudentRepository
    {
        DataContext context;

        public StudentRepository(DataContext _context)
        {
            context = _context;
        }


        public void Add(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
        }

        public Student FindById(int id)
        {
            return context.Students.Where(s => s.ID == id).Single();
        }

        public List<Student> GetStudents()
        {
            return context.Students.ToList();
        }

        public void Remove(int id)
        {
            var student = context.Students.SingleOrDefault(s => s.ID==id);
            context.Students.Remove(student);
            context.SaveChanges();
        }

        public void Save(Student student)
        {
            context.SaveChanges();
        }

        public void Update(Student student)
        {
            context.Students.Update(student);
            context.SaveChanges();
        }

        public bool Exist(int id)
        {
            return context.Students.Any(e => e.ID == id);
        }
    }
}
