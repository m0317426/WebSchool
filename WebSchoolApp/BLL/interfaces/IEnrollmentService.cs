using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.interfaces
{
    public interface IEnrollmentService
    {
        List<Enrollment> GetEnrollments();

        Enrollment FindById(int id);

        void Update(Enrollment enrollment);

        void Add(Enrollment enrollment);

        void Remove(int id);

        void Save(Enrollment enrollment);
    }
}
