using PeopleProject;

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
    }
}