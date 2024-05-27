using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleProject
{
    public class Person
    {
        private int id;
        private string name;
        private int age;
        private bool isStudent;
        private int score;

        public Person(int id, string name, int age, bool isStudent, int score)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.IsStudent = isStudent;
            this.Score = score;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set { if (value == "") { throw new ArgumentException("A név nem lehet üres!"); } else { name = value; } } }
        public int Age { get => age; set { if (value < 1) { throw new ArgumentException("Az életkor nem lehet 1-nél kisebb!"); } else { age = value; } } }
        public bool IsStudent { get => isStudent; set => isStudent = value; }
        public int Score { get => score; set { if (value < 0) { throw new ArgumentException("A pontszám nem lehet 0-nál kisebb!"); } else { score = value; } } }
    }
}
