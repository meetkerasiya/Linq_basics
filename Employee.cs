namespace Linq_basics
{
    public class Employee
    {
        public Employee(string fname,string lname,string city)
        {
            FirstName= fname;
            LastName= lname;
            City= city;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set;}
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
    
}
