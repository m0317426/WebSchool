using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.interfaces
{
    public interface IEnrollmentRepository
    {
        List<Enrollment> GetEnrollments();

        Enrollment FindById(int id);

        void Update(Enrollment enrollment);

        void Add(Enrollment enrollment);

        void Remove(int id);

        void Save(Enrollment enrollment);
    }
}
