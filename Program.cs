using Linq_basics;

class MyClass
{
    static IEnumerable<string> Suits()
    {
        yield return "spades";
        yield return "clubs";
        yield return "hearts";
        yield return "diamonds";
    }
    static IEnumerable<string> Ranks()
    {
        yield return "jack";
        yield return "queen";
        yield return "king";
        yield return "ace";
        yield return "two";
        yield return "three";
        yield return "four";
        yield return "five";
        yield return "six";
        yield return "seven";
        yield return "eight";
        yield return "nine";
        yield return "ten";
        
    }
    public static void Main(string[] args)
    {
        //using query
        var CardDeck = from s in Suits()
                       from r in Ranks()
                       select new { s, r };

        //using method
       // var CardDeck = Suits().SelectMany(suit => Ranks().Select(rank => new { Suit = suit, Rank = rank }));
        foreach (var card in CardDeck)
        {
            Console.WriteLine(card);
        }

        int[] numbers = { 10, 15, 35, 8, 45, 6, 345, 78, 45 };
        var odds = from s in numbers
                   where s % 2 != 0
                   select s;

        Console.WriteLine("Odd numbers are: ");
        foreach (var num in odds)
        {
            Console.WriteLine(num);
        }

        Employee[] emps = new Employee[]
        {
            new Employee("Meet","Kerasiya","Amreli"),
            new Employee("Mitesh","Kateliya","Kodinar"),
            new Employee("Bhayo","Sisodiya","Junagadh"),
            new Employee("Krupal","Vasani","Amreli"),
            new Employee("Jay","Laheri","Amreli"),
            new Employee("Krunal","Togadiya","Amreli"),
            new Employee("Hiren","Kanet","Porbandar"),
            new Employee("Kamal","jethva","Junagadh"),

        };
        IEnumerable<Employee> amreli_emp = from e in emps
                                           where e.City is "Amreli"
                                           select e;
        Console.WriteLine("Employees from amreli");
        foreach (var item in amreli_emp)
        {
            Console.WriteLine(item);
        }
        IEnumerable<Employee> Junagadh_emp = from e in emps
                                           where e.City is "Junagadh"
                                           select e;
        Console.WriteLine("Employees from Junagadh");

        foreach (var item in Junagadh_emp)
        {
            Console.WriteLine(item);
        }
        IEnumerable<Employee> other_emp = from e in emps
                                           where e.City is not "Junagadh" && e.City is not"Amreli"
                                           select e;
        Console.WriteLine("Employees from other cities");

        foreach (var item in other_emp)
        {
            Console.WriteLine(item);
        }
    }
}

