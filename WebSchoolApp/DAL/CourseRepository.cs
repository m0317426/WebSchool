using DAL.interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class CourseRepository: ICourseRepository
    {
        DataContext context;

        public CourseRepository(DataContext _context)
        {
            context = _context;
        }


        public void Add(Course course)
        {
            context.Courses.Add(course);
            context.SaveChanges();
        }

        public Course FindById(int id)
        {
            return context.Courses.Where(s => s.CourseID == id).Single();
        }

        public List<Course> GetCourses()
        {
            return context.Courses.ToList();
        }

        public void Remove(int id)
        {
            var course = context.Courses.SingleOrDefault(s => s.CourseID == id);
            context.Courses.Remove(course);
            context.SaveChanges();
        }

        public void Save(Course course)
        {
            context.SaveChanges();
        }

        public void Update(Course course)
        {
            context.Courses.Update(course);
            context.SaveChanges();
        }
    }
}
