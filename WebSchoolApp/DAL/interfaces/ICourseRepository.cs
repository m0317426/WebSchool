using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.interfaces
{
    public interface ICourseRepository
    {
        List<Course> GetCourses();

        Course FindById(int id);

        void Update(Course course);

        void Add(Course course);

        void Remove(int id);

        void Save(Course course);
    }
}
