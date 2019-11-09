/* Even though the namespace for a `List` was already imported
it needs to be brought into this new type as well.*/
using System.Collections.Generic;

namespace gradebook
{
    class Book
    {
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }
        List<double> grades;
    }
}