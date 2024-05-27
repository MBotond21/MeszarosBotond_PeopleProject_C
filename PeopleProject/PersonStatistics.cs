using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleProject
{
    public class PersonStatistics
    {
        private List<Person> people;

        public PersonStatistics(List<Person> people)
        {
            this.People = people;
        }

        public List<Person> People
        {
            private get { return people; }
            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException(nameof(people));
                }
                else
                {
                    people = value;
                }
            }
        }

        public double getAverageAge()
        {
            if(people.Count == 0)
            {
                return 0;
            }
            else
            {
                return people.Average(p => p.Age);
            }
        }

        public int getNumberOfStudents()
        {
            return people.Where(p => p.IsStudent).Count();
        }

        public Person getPersonWithHighestScore()
        {
            if(people.Count == 0)
            {
                throw new ArgumentException("Üres listával ez a művelet nem hajtható végre!");
            }
            else
            {
                return people.Where(p => p.Score == people.Max(p => p.Score)).First();
            }
        }

        public double getAverageScoreOfStudents()
        {
            if (people.Count == 0)
            {
                return 0;
            }
            else
            {
                return people.Average(p => p.Score);
            }
        }

        public Person getOldestStudent()
        {
            if (people.Count == 0)
            {
                throw new ArgumentException("Üres listával ez a művelet nem hajtható végre!");
            }
            else
            {
                return people.Where(p => p.Age == people.Where(p => p.IsStudent).Max(p => p.Age) && p.IsStudent).First();
            }
        }

        public bool isAnyoneFailing()
        {
            return people.Where(p => p.Score < 40).Count() > 0;
        }
    }
}
