using CourseProject.Business.Abstract;
using CourseProject.DataAccess.Abstract;
using CourseProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Business.Concrete
{
    public class InstructorManager : IInstructorService
    {
        private readonly IInstructorDal _instructorDal;

        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }

        public void Add(Instructor t)
        {
            _instructorDal.Add(t);
        }

        public void Delete(Instructor t)
        {
            _instructorDal.Delete(t);
        }

        public List<Instructor> GetAll()
        {
            return _instructorDal.GetAll();
        }

        public void Update(Instructor t)
        {
            _instructorDal.Update(t);
        }
    }
}
