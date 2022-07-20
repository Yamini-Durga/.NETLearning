using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice
{
    public class SeedData
    {
        private static List<Person> persons = new List<Person>()
          {
            new Person {
                    FirstName = "Ananda",
                    LastName = "K",
                    JoiningDate = Convert.ToDateTime("02/09/2020"),
                    YearsOfExperience = 2
                },
            new Person {
                    FirstName = "Amanda",
                    LastName = "R",
                    JoiningDate = Convert.ToDateTime("02/09/2020"),
                    YearsOfExperience = 2
                },
            new Person {
                    FirstName = "Zee",
                    LastName = "X",
                    JoiningDate = Convert.ToDateTime("09/07/2000"),
                    YearsOfExperience = 22
                },
            new Person {
                    FirstName = "Yelo",
                    LastName = "R",
                    JoiningDate = Convert.ToDateTime("05/08/2012"),
                    YearsOfExperience = 10
                },
            new Person {
                    FirstName = "Lemo",
                    LastName = "G",
                    JoiningDate = Convert.ToDateTime("04/09/2015"),
                    YearsOfExperience = 7
                },
            new Person {
                    FirstName = "Benn",
                    LastName = "J",
                    JoiningDate = Convert.ToDateTime("02/09/1999"),
                    YearsOfExperience = 23
                }
          };
        public static List<Person> GetAll()
        {
            return persons;
        }
    }
}
