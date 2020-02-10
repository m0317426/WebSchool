using BLL.interfaces;
using DAL.interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class EnrollmentService: IEnrollmentService
    {
        IEnrollmentRepository repository;

        public EnrollmentService(IEnrollmentRepository _repository)
        {
            repository = _repository;
        }


        public void Add(Enrollment enrollment)
        {
            repository.Add(enrollment);
        }

        public Enrollment FindById(int id)
        {
            return repository.FindById(id);
        }

        public List<Enrollment> GetEnrollments()
        {
            return repository.GetEnrollments();
        }

        public void Remove(int id)
        {
            repository.Remove(id);
        }

        public void Save(Enrollment enrollment)
        {
            repository.Save(enrollment);
        }

        public void Update(Enrollment enrollment)
        {
            repository.Update(enrollment);
        }
    }
}
