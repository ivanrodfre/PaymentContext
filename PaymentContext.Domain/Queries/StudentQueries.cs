using PaymentContext.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace PaymentContext.Domain.Queries
{
    public static class StudentQueries
    {
        public static Expression<Func<Student, bool>> GetStudentInfo(string document)
        {
            return x => x.Document.Number == document;
        }


        //+/- Exemplo de uso da query no repositório

        //public List<Student> GetStudentInfo()
        //{
        //    return _contex.Student.Where(StudentQueries.GetStudentInfo()).ToList();
        //}
    }
}
