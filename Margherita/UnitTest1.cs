using NUnit.Framework;

namespace Margherita.Test
{
    public class Tests
    {
        [Test]
        public void MamaMargheritaPizza()
        {
            var expected = "Mama Margherita, 14\" Pizza with Special Mama source, Sucuk, Pitze, Käse, Special Cheese is only $10";
            var actual = Pizza.CreateByName("Mama Margherita").ToString();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MamaSpecialPizza()
        {
            var expected = "Mama Special, 18\" Pizza with Special Mama Double Source, Zwiebel, Knoblauch, Sucuk, Pitze, Petersilie, Special Cheese x2 is only $15";
            var actual = Pizza.CreateByName("Mama Special").ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestCase("Mama Margherita", 10, 14)]
        [TestCase("Mama Special", 15, 18)]
        public void CheckPizzaNameAndPriceAndSize(string name, decimal price, int size)
        {
            var pizza = Pizza.CreateByName(name);

			var expectedName = name;
			var expectedPrice = price;
            var expectedSize = size;

            var actualPrice = pizza.Price;
			var actualName = pizza.Name;
            var actualSize = pizza.Size;

            Assert.AreEqual(expectedName, actualName);
			Assert.AreEqual(expectedPrice, actualPrice);
			Assert.AreEqual(expectedSize, actualSize);
        }

        [Test]
        public void CheckPizzaIsMargheritaPizza()
		{
            var expectedPizza = new Pizza() { 
                Name = "Mama Margherita",
                Price = 10,
                Size = 14
            };

            var actualPizza = Pizza.CreateByName("Mama Margherita");

            Assert.AreEqual(expectedPizza, actualPizza);
        }

        [Test]
        public void MamaMargheritaPizzaShouldNotBeEmptyPizza()
        {
            var expectedPizza = new Pizza();

            var actualPizza = Pizza.CreateByName("Mama Margherita");

            Assert.AreNotEqual(expectedPizza, actualPizza);
        }
    }
}