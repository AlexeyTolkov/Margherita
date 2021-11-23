using NUnit.Framework;

namespace Margherita.Test
{
    public class Tests
    {
        [Test]
        void MamaMargheritaPizza()
        {
            var expected = "Mama Margherita, 14\" Pizza with Special Mama source, Sucuk, Pitze, Käse, Special Cheese is only $10";
            var actual = Pizza.CreateByName("Mama Margherita").ToString();
            Assert.Equals(expected, actual);
        }

        [Test]
        void MamaSpecialPizza()
        {
            var expected = "Mama Special, 18\" Pizza with Special Mama Double Source, Zwiebel, Knoblauch, Sucuk, Pitze, Petersilie, Special Cheese x2 is only $15";
            var actual = Pizza.CreateByName("Mama Special").ToString();
            Assert.Equals(expected, actual);
        }
    }
}