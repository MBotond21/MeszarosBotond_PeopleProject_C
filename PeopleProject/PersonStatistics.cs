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
            this.people = People;
        }

        internal List<Person> People
        {
            private get { return people; }
            set
            {
                if (people != null)
                {
                    people = value;
                }
                else
                {
                    throw new ArgumentNullException(nameof(people));
                }
            }
        }

        public double getAverageAge()
        {
            return people.Average(p => p.Age);
        }

        public int getNumberOfStudents()
        {
            return people.Where(p => p.IsStudent).Count();
        }

        public Person getPersonWithHighestScore()
        {
            return people.Where(p => p.Score == people.Max(p => p.Score)).First();
        }

        public double getAverageScoreOfStudents()
        {
            return people.Average(p => p.Score);
        }

        public Person getOldestStudent()
        {
            return people.Where(p => p.Age == people.Max(p => p.Age)).First();
        }

        public bool isAnyoneFailing()
        {
            return people.Where(p => p.Score < 40).Count() > 0;
        }
    }
}
