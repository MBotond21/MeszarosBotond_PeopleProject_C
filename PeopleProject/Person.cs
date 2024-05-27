using System;
using System.Collections.Generic;
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
            this.id = id;
            this.name = name;
            this.age = age;
            this.isStudent = isStudent;
            this.score = score;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public bool IsStudent { get => isStudent; set => isStudent = value; }
        public int Score { get => score; set => score = value; }
    }
}
