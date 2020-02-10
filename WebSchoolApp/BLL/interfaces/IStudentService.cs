using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.interfaces
{
    public interface IStudentService
    {
        List<Student> GetStudents();

        Student FindById(int id);

        void Update(Student student);

        void Add(Student student);

        void Remove(int id);

        void Save(Student student);

        bool Exist(int id);
    }
}
