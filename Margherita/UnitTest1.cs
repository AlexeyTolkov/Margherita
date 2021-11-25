﻿using NUnit.Framework;

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

        [Test]
        public void CheckMamaMargheritaPizzaName_Should_Be_MamaMargherita()
        {
            string expected = "Mama Margherita";
            string actual = Pizza.CreateByName("Mama Margherita").Name;
            Assert.AreEqual(expected, actual);
        }
    }
}