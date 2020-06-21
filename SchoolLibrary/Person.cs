using System;
namespace SchoolLibrary
{
    public abstract class Person
     //Abstract means you can't instantiate this class directly
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
