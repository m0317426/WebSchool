using BLL.interfaces;
using DAL.interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class CourseService: ICourseService
    {
        ICourseRepository repository;

        public CourseService(ICourseRepository _repository)
        {
            repository = _repository;
        }


        public void Add(Course course)
        {
            repository.Add(course);
        }

        public Course FindById(int id)
        {
            return repository.FindById(id);
        }

        public List<Course> GetCourses()
        {
            return repository.GetCourses();
        }

        public void Remove(int id)
        {
            repository.Remove(id);
        }

        public void Save(Course course)
        {
            repository.Save(course);
        }

        public void Update(Course course)
        {
            repository.Update(course);
        }
    }
}
