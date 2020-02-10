using BLL.interfaces;
using DAL.interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class StudentService : IStudentService
    {
        IStudentRepository repository;

        public StudentService(IStudentRepository _repository)
        {
            repository = _repository;
        }


        public void Add(Student student)
        {
            repository.Add(student);
        }

        public Student FindById(int id)
        {
            return repository.FindById(id);
        }

        public List<Student> GetStudents()
        {
            return repository.GetStudents();
        }

        public void Remove(int id)
        {
            repository.Remove(id);
        }

        public void Save(Student student)
        {
            repository.Save(student);
        }

        public void Update(Student student)
        {
            repository.Update(student);
        }

        public bool Exist(int id)
        {
            return repository.Exist(id);
        }
    }
}
