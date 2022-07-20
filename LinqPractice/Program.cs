namespace LinqPractice
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = SeedData.GetAll();

            // Sort
            // persons = persons.OrderBy(x => x.LastName).ToList(); // ascending order
            // persons = persons.OrderByDescending(x => x.FirstName).ToList(); // descending order
            //persons = persons.OrderByDescending(x => x.LastName).ThenByDescending(x => x.YearsOfExperience).ToList();
            // persons = persons.OrderBy(p => p.LastName).ThenBy(p => p.YearsOfExperience).ToList();

            // Filter
            //persons = persons.Where(p => p.YearsOfExperience > 8).ToList();
            //persons = persons.Where(p => p.YearsOfExperience > 8 && p.JoiningDate.Month == 2).ToList();
            //persons = persons.Where(p => p.FirstName.StartsWith("A")).ToList();
            //foreach (var person in persons)
            //{
            //    Console.WriteLine($"{person.FullName} : {person.JoiningDate.ToShortDateString()} : {person.YearsOfExperience} ");
            //}

            // Select
            //var names = persons.Select(p => p.FirstName).ToList();
            //var plist = persons.Select(p => new { p.FirstName, p.JoiningDate }).ToList();
            //foreach (var p in plist)
            //{
            //    Console.WriteLine($"{p.FirstName} - {p.JoiningDate}");
            //}

            // Sum
            //int yoeTotal = persons.Sum(p => p.YearsOfExperience);
            //int total = persons.Where(p => p.JoiningDate.Month == 2).Sum(p => p.YearsOfExperience);
            //Console.WriteLine($"Total YOE: {total}");

            //string[] names = { "Jay Ji", "Mich Di", "Clarie", "Manny Degl", "Phil", "Cam Kli" };
            //var namesList = from name in names
            //                where name.Contains(" ")
            //                orderby name descending
            //                select name;
            //foreach(var name in namesList)
            //{
            //    Console.WriteLine(name);
            //}

            // Zip
            List<int> l1 = new List<int>(new int[] {1,2,3 });
            List<int> l2 = new List<int>(new int[] { 4, 5, 6 });
            var mult = l1.Zip(l2, (x, y) => x * y).ToList();
            foreach(var m in mult)
            {
                Console.WriteLine(m);
            }

            Console.ReadKey();
        }
    }
}