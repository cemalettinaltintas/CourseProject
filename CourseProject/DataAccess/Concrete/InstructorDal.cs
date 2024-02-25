using CourseProject.DataAccess.Abstract;
using CourseProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.DataAccess.Concrete
{
    public class InstructorDal : IInstructorDal
    {
        List<Instructor> _instructors;

        public InstructorDal()
        {

            _instructors = new List<Instructor>
            {
                new Instructor{Id=1,FirstName="Adil",LastName="Altıntaş"},
                new Instructor{Id=2,FirstName="Oğuz",LastName="Altıntaş"}
            };
        }

        public void Add(Instructor t)
        {
            _instructors.Add(t);
        }

        public void Delete(Instructor t)
        {
            _instructors.Remove(t);
        }

        public List<Instructor> GetAll()
        {
            return _instructors;
        }

        public void Update(Instructor t)
        {
            Instructor instructor = _instructors.SingleOrDefault(p => p.Id == t.Id);
            if (instructor != null) {
                instructor.Id = t.Id;
                instructor.FirstName = t.FirstName;
                instructor.LastName = t.LastName;
                Console.WriteLine("Eğitmen güncellendi.");
            }
            else
            {
                Console.WriteLine("Eğitmen güncellenemedi.");
            }
        }
    }
}
