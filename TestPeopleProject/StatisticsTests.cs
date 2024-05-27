using PeopleProject;
using System.Linq.Expressions;

namespace TestPeopleProject
{
    public class StatisticsTests
    {

        [Test]
        public void PersonStatistics_Letrehozhato_Ervenyes_Adattagokkal()
        {
            List<Person> p = new List<Person>() { new Person(1, "Gipsz Jakab", 17, true, 56) };

            Assert.DoesNotThrow(() => { PersonStatistics pS = new PersonStatistics(p); });
        }

        [Test]
        public void PersonStatistics_Letrehozasa_Null_Adattaggal_HibatDob()
        {
            Assert.Throws<ArgumentNullException>(() => { PersonStatistics pS = new PersonStatistics(null); });
        }

        [Test]
        public void PersonStatistics_Letrehozhato_Ures_Listaval()
        {
            List<Person> p = new List<Person>();

            Assert.DoesNotThrow(() => { PersonStatistics pS = new PersonStatistics(p); });
        }

        [Test]
        public void getAverageAge_Ervenyes_Listaval()
        {
            List<Person> p = new List<Person>() { new Person(1, "Gipsz Jakab", 17, true, 56), new Person(2, "Mák Ferenc", 19, true, 54), new Person(3, "Móricka", 14, true, 42) };
            PersonStatistics pS = new PersonStatistics(p);

            Assert.That(pS.getAverageAge(), Is.EqualTo((17 + 19 + 14) / 3.0));
        }

        [Test]
        public void getAverageAge_Ures_Listaval()
        {
            List<Person> p = new List<Person>();
            PersonStatistics pS = new PersonStatistics(p);

            Assert.That(pS.getAverageAge(), Is.Zero);
        }

        [Test]
        public void getNumberOfStudents_Ervenyes_Listaval()
        {
            List<Person> p = new List<Person>() { new Person(1, "Gipsz Jakab", 17, true, 56), new Person(2, "Mák Ferenc", 19, false, 54), new Person(3, "Móricka", 14, true, 42) };
            PersonStatistics pS = new PersonStatistics(p);

            Assert.That(pS.getNumberOfStudents(), Is.EqualTo(2));
        }

        [Test]
        public void getNumberOfStudents_Ures_Listaval()
        {
            List<Person> p = new List<Person>();
            PersonStatistics pS = new PersonStatistics(p);

            Assert.That(pS.getNumberOfStudents(), Is.Zero);
        }

        [Test]
        public void getPersonWithHighestScore_Ervenyes_Listaval()
        {
            List<Person> p = new List<Person>() { new Person(1, "Gipsz Jakab", 17, true, 56), new Person(2, "Mák Ferenc", 19, false, 54), new Person(3, "Móricka", 14, true, 42) };
            PersonStatistics pS = new PersonStatistics(p);

            Assert.That(pS.getPersonWithHighestScore(), Is.EqualTo(p[0]));
        }

        [Test]
        public void getPersonWithHighestScore_Ures_Listaval()
        {
            List<Person> p = new List<Person>();
            PersonStatistics pS = new PersonStatistics(p);

            Assert.Throws<ArgumentException>(() => pS.getPersonWithHighestScore());
        }

        [Test]
        public void getPersonWithHighestScore_Utolag_Novelt_Listaval()
        {
            List<Person> p = new List<Person>();
            PersonStatistics pS = new PersonStatistics(p);

            Assert.Throws<ArgumentException>(() => pS.getPersonWithHighestScore());

            p = new List<Person>() { new Person(1, "Gipsz Jakab", 17, true, 56), new Person(2, "Mák Ferenc", 19, false, 54), new Person(3, "Móricka", 14, true, 42) };
            pS.People = p;
            Assert.That(pS.getPersonWithHighestScore(), Is.EqualTo(p[0]));
        }

        [Test]
        public void getAverageScoreOfStudents_Ervenyes_Listaval()
        {
            List<Person> p = new List<Person>() { new Person(1, "Gipsz Jakab", 17, true, 56), new Person(2, "Mák Ferenc", 19, true, 54), new Person(3, "Móricka", 14, true, 42) };
            PersonStatistics pS = new PersonStatistics(p);

            Assert.That(pS.getAverageScoreOfStudents(), Is.EqualTo((56 + 54 + 42) / 3.0));
        }

        [Test]
        public void getAverageScoreOfStudents_Ures_Listaval()
        {
            List<Person> p = new List<Person>();
            PersonStatistics pS = new PersonStatistics(p);

            Assert.That(pS.getAverageScoreOfStudents(), Is.Zero);
        }

        [Test]
        public void getOldestStudent_Ervenyes_Listaval()
        {
            List<Person> p = new List<Person>() { new Person(1, "Gipsz Jakab", 17, true, 56), new Person(2, "Mák Ferenc", 19, false, 54), new Person(3, "Móricka", 14, true, 42) };
            PersonStatistics pS = new PersonStatistics(p);

            Assert.That(pS.getOldestStudent(), Is.EqualTo(p[0]));
        }

        [Test]
        public void getOldestStudent_Ures_Listaval()
        {
            List<Person> p = new List<Person>();
            PersonStatistics pS = new PersonStatistics(p);

            Assert.Throws<ArgumentException>(() => pS.getOldestStudent());
        }

        [Test]
        public void getOldestStudent_Utolag_Novelt_Listaval()
        {
            List<Person> p = new List<Person>();
            PersonStatistics pS = new PersonStatistics(p);

            Assert.Throws<ArgumentException>(() => pS.getOldestStudent());

            p = new List<Person>() { new Person(1, "Gipsz Jakab", 17, true, 56), new Person(2, "Mák Ferenc", 19, false, 54), new Person(3, "Móricka", 14, true, 42) };
            pS.People = p;
            Assert.That(pS.getOldestStudent(), Is.EqualTo(p[0]));
        }

        [Test]
        public void isAnyoneFailing_Ervenyes_Listaval_Igaz()
        {
            List<Person> p = new List<Person>() { new Person(1, "Gipsz Jakab", 17, true, 56), new Person(2, "Mák Ferenc", 19, false, 54), new Person(3, "Móricka", 14, true, 32) };
            PersonStatistics pS = new PersonStatistics(p);

            Assert.That(pS.isAnyoneFailing(), Is.True);
        }

        [Test]
        public void isAnyoneFailing_Ervenyes_Listaval_Hamis()
        {
            List<Person> p = new List<Person>() { new Person(1, "Gipsz Jakab", 17, true, 56), new Person(2, "Mák Ferenc", 19, false, 54), new Person(3, "Móricka", 14, true, 42) };
            PersonStatistics pS = new PersonStatistics(p);

            Assert.That(pS.isAnyoneFailing(), Is.False);
        }

        [Test]
        public void isAnyoneFailing_Ures_Listaval()
        {
            List<Person> p = new List<Person>();
            PersonStatistics pS = new PersonStatistics(p);

            Assert.That(pS.isAnyoneFailing(), Is.False);
        }

    }
}