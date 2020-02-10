using DAL.interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class EnrollmentRepository: IEnrollmentRepository
    {
        DataContext context;

        public EnrollmentRepository(DataContext _context)
        {
            context = _context;
        }


        public void Add(Enrollment enrollment)
        {
            context.Enrollments.Add(enrollment);
            context.SaveChanges();
        }

        public Enrollment FindById(int id)
        {
            return context.Enrollments.Where(s => s.EnrollmentID == id).Single();
        }

        public List<Enrollment> GetEnrollments()
        {
            return context.Enrollments.ToList();
        }

        public void Remove(int id)
        {
            var enrollment = context.Enrollments.SingleOrDefault(s => s.EnrollmentID == id);
            context.Enrollments.Remove(enrollment);
            context.SaveChanges();
        }

        public void Save(Enrollment enrollment)
        {
            context.SaveChanges();
        }

        public void Update(Enrollment enrollment)
        {
            context.Enrollments.Update(enrollment);
            context.SaveChanges();
        }
    }
}
