/* Even though the namespace for a `List` was already imported
it needs to be brought into this new type as well.*/
using System.Collections.Generic;

namespace gradebook
{
    class Book
    {
        /*Creation of an explicit constructor.
        By placing `string name` in parameters it has become
        mandatory data required whenever the constructor is called.
        */ 
        public Book(string name)
        {
            grades = new List<double>();
            /* The key word `this` is a referance to the object
            that is currently being operated on.
            It is a trick for allowing a field
            to have the same name as a parameter. */
            this.name = name;
        }
        /* Because the key word static is missing the method 
        `AddGrade` is an instance member of the class book. */
        public void AddGrade(double grade)
        {
            /* The keyword `this` could also be used here but is not
            needed as it is implied whenever accessing a member 
            of the class. */
            grades.Add(grade);
        }
        private List<double> grades;
        private string name;
    }
}